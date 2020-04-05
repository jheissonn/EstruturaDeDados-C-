using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;


namespace TrabalhoMediaPlayer
{
    public partial class Form1 : Form
    {
        ListaEncadeada<CaminhoMusica> listaMusicas = new ListaEncadeada<CaminhoMusica>();
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        private BlockAlignReductionStream stream = null;
        private DirectSoundOut output = null;
        // WaveOut waveOut = new WaveOut();
        private Node<CaminhoMusica> _rMusicaAtual;
        private Boolean _rPodeEntrarTrocaMusic = true;
        private Boolean _rAleatorio = false;
        ListaEncadeada<FileInfo> _uListaArquivos = new ListaEncadeada<FileInfo>();




        public Form1()

        {
            InitializeComponent();
            output = new DirectSoundOut();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        void player_PlaybackStopped(object sender, StoppedEventArgs e)
        {

            if (_rPodeEntrarTrocaMusic)
            {
                if (_rAleatorio)
                {
                    Node<CaminhoMusica> _rTemp = listaMusicas.head;
                    Random randNum = new Random();
                    int count = 0;
                    while (count < randNum.Next(listaMusicas.count))
                    {
                        _rTemp = _rTemp.Proximo;
                        count++;
                    }
                    _rMusicaAtual = _rTemp;
                    proPlayMusic(_rMusicaAtual.Item.caminho);
                }
                else
                {

                    if (_rMusicaAtual.Proximo == null)
                    {
                        _rMusicaAtual = listaMusicas.head;
                        proPlayMusic(_rMusicaAtual.Item.caminho);

                    }
                    else
                    {
                        proPlayMusic(_rMusicaAtual.Proximo.Item.caminho);
                        _rMusicaAtual = _rMusicaAtual.Proximo;

                    }
                }
            }
        }


        private void buttonbusca_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath == null || folderBrowserDialog1.SelectedPath == "")
                return;
            DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            ListarFiles(folder.GetFiles(), folder.GetFiles().Length - 1);
            Listarpastas(folder.GetDirectories(), folder.GetDirectories().Length - 1);
        }
        private void proPlayMusic(string musica)
        {

            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(musica));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            _rPodeEntrarTrocaMusic = true;
            output.Init(stream);
            output.PlaybackStopped += player_PlaybackStopped;
            output.Play();

        }
        public Boolean ListarFiles(FileInfo[] arquivos, int comprimento)
        {

            if (comprimento < 0)
                return true;
            if (arquivos[comprimento].Extension.Equals(".mp3"))
            {
                try
                {
                    treeViewMusic.SelectedImageIndex = 0;
                    listaMusicas.InsertLast(new CaminhoMusica(arquivos[comprimento].FullName, listaMusicas.count + 1));
                    treeViewMusic.Nodes.Add(arquivos[comprimento].ToString());
                    Mp3FileReader reader = new Mp3FileReader(arquivos[comprimento].FullName);

                    double bitrate = (reader.Mp3WaveFormat.AverageBytesPerSecond * 8) / 1000;
                    treeViewMusic.Nodes[listaMusicas.count - 1].Nodes.Add("Arquivo: " + arquivos[comprimento].FullName);
                    String duracao = reader.TotalTime.Duration().ToString().Substring(3, 5);
                    treeViewMusic.Nodes[listaMusicas.count - 1].Nodes.Add("Duração: " + duracao);
                    treeViewMusic.Nodes[listaMusicas.count - 1].Nodes.Add("BitRate: " + bitrate.ToString() + " Kbps");
                    treeViewMusic.Nodes[listaMusicas.count - 1].SelectedImageIndex = 1;
                    treeViewMusic.Nodes[listaMusicas.count - 1].SelectedImageIndex = 2;
                    treeViewMusic.Nodes[listaMusicas.count - 1].SelectedImageIndex = 3;
                }
                catch { }
            }
            ListarFiles(arquivos, comprimento - 1);
            return true;


        }

        public Boolean Listarpastas(DirectoryInfo[] pastas, int comprimento)
        {
            if (comprimento < 0)
            {
                return true;
            }

            ListarFiles(pastas[comprimento].GetFiles(), pastas[comprimento].GetFiles().Length - 1);
            Listarpastas(pastas[comprimento].GetDirectories(), pastas[comprimento].GetDirectories().Length - 1);
            Listarpastas(pastas, comprimento - 1);
            return true;
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {


            if (output.PlaybackState.ToString() == "Playing")
                return;
            if (output.PlaybackState.ToString() == "Paused")
            {
                output.Play();
                return;
            }
            if (treeViewMusic.Nodes.Count == 0)
                return;
            string _rMusicaSelecionada = string.Empty;

            if (treeViewMusic.SelectedNode == null)
                _rMusicaSelecionada = treeViewMusic.Nodes[0].Nodes[0].Text.ToString().Replace("Arquivo: ", "");
            else
                _rMusicaSelecionada = treeViewMusic.SelectedNode.Nodes[0].Text.ToString().Replace("Arquivo: ", "");

            _rMusicaAtual = proDevolverAtual(_rMusicaSelecionada);
            proPlayMusic(_rMusicaAtual.Item.caminho);
        }

        private void buttonpause_Click(object sender, EventArgs e)
        {

            if (output.PlaybackState.ToString() == "Playing")
                output.Pause();
        }

        private void trackBarminplus_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBarminplus.Value.ToString());
            output.Volume = 0.5f;
            //  float teste = 0;
            //output.Volume = teste;
        }


        public class VerticalProgressBar : ProgressBar
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.Style |= 0x04;
                    return cp;
                }
            }
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

                var device = (MMDevice)comboBox1.SelectedItem;

                progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 100));
                progressBar2.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 80));
                progressBar3.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 70));
                progressBar4.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 60));
                progressBar5.Value = (int)(Math.Round(device.AudioMeterInformation.PeakValues[0] * 50));
            }
        }

        private Node<CaminhoMusica> proDevolverAtual(String caminho)
        {
            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            while (_rTemp.Proximo != null)
            {
                if (_rTemp.Item.caminho == caminho)
                    return _rTemp;
                _rTemp = _rTemp.Proximo;
            }
            return _rTemp;
        }

        private String proDevolverAnterior(String caminho)
        {
            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            while (_rTemp.Proximo != null)
            {
                if (_rTemp.Proximo.Item.caminho == caminho)
                    return _rTemp.Item.caminho;
                _rTemp = _rTemp.Proximo;
            }
            return listaMusicas.end.Item.caminho;


        }

        private void buttonfoward_Click_1(object sender, EventArgs e)
        {
            if (_rMusicaAtual == null)
                return;


            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();
            if (_rMusicaAtual.Proximo == null)
            {
                _rMusicaAtual = listaMusicas.head;
                proPlayMusic(_rMusicaAtual.Item.caminho);
            }
            else
            {
                proPlayMusic(_rMusicaAtual.Proximo.Item.caminho);
                _rMusicaAtual = _rMusicaAtual.Proximo;
            }
        }

        private void buttonback_Click_1(object sender, EventArgs e)
        {
            if (_rMusicaAtual == null)
                return;

            _rPodeEntrarTrocaMusic = false;
            output.Stop();
            output = new NAudio.Wave.DirectSoundOut();

            String musi = proDevolverAnterior(_rMusicaAtual.Item.caminho);
            proPlayMusic(musi);
            _rMusicaAtual = proDevolverAtual(musi);
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {

            Node<CaminhoMusica> _rTemp = listaMusicas.head;
            string caminho = treeViewMusic.SelectedNode.Nodes[0].Text.ToString().Replace("Arquivo: ", "");
            while (_rTemp.Proximo != null)
            {
                if (_rTemp.Item.caminho == caminho)
                {
                    listaMusicas.DeleteNode(_rTemp.Item.caminho);
                    treeViewMusic.SelectedNode.Remove();
                    _rTemp = _rTemp.Proximo;
                }
                break;

            }





            /*
            _rPodeEntrarTrocaMusic = false;
            output.Stop();*/
        }

        private void buttonAleatorio_Click(object sender, EventArgs e)
        {
            if (_rAleatorio)
                _rAleatorio = false;
            else
                _rAleatorio = true;
            MessageBox.Show("pronto");
        }
    }
}
