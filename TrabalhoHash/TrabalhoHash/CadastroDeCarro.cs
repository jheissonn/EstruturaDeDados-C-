using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabalhoHash
{

    public partial class CadastroDeCarro : Form
    {
        private List<Carro> _uCarros = new List<Carro>();
        private String _uAcaoCrud = string.Empty;
        public CadastroDeCarro()
        {
            InitializeComponent();
            iniciarComponentes();
            listarCarros();
            groupBoxCadastro.Enabled = false;
        }

        private void iniciarComponentes() {
            comboBoxPortas.SelectedIndex = 0;
            comboBoxModelos.SelectedIndex = 0;
            comboBoxRodas.SelectedIndex = 0;
            comboBoxSom.SelectedIndex = 0;
            comboBoxArCond.SelectedIndex = 0;
            comboBoxAirBag.SelectedIndex = 0;
            comboBoxModelos.SelectedIndex = 0;
            if (Form1.UuListaDeCarros.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                return;
            }
            else {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnSalvar.Enabled = false;

            }


        }
        private void listarCarros()
        {
            if (Form1.UuListaDeCarros.Count > 0) {
                foreach (String xis in Form1.UuListaDeCarros.Keys)
                {
                    Carro _rTemp = Form1.UuListaDeCarros[xis];
                    comboBoxModelos.SelectedIndex = _rTemp.Modelo;
                    comboBoxPesquisa.Items.Add(comboBoxModelos.SelectedItem.ToString() + " placa:" + _rTemp.Placa);
                }
                comboBoxPesquisa.SelectedIndex = 0;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _uAcaoCrud = "N";
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            groupBoxPesquisa.Enabled = false;
            btnSalvar.Enabled = true;
            textBoxPlaca.Text = string.Empty;
            comboBoxPortas.SelectedIndex = 0;
            comboBoxModelos.SelectedIndex = 0;
            comboBoxRodas.SelectedIndex = 0;
            comboBoxSom.SelectedIndex = 0;
            comboBoxArCond.SelectedIndex = 0;
            comboBoxAirBag.SelectedIndex = 0;
            comboBoxModelos.SelectedIndex = 0;
            textBoxPlaca.Enabled = true;
            groupBoxCadastro.Enabled = true;
        }

        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_uAcaoCrud == string.Empty)
                return;
            if(textBoxPlaca.Text == "")
            {
                MessageBox.Show("Preencher Placa do carro.");
                return;
            }
            if (_uAcaoCrud == "N")
                Form1.UuListaDeCarros.Add((textBoxPlaca.Text), new Carro(comboBoxModelos.SelectedIndex, comboBoxRodas.SelectedIndex, comboBoxRodas.SelectedIndex,
                    comboBoxSom.SelectedIndex, comboBoxArCond.SelectedIndex, comboBoxAirBag.SelectedIndex, textBoxPlaca.Text));
            else {
                String _rchave = comboBoxPesquisa.SelectedItem.ToString().Replace("Placa:", "");
                Form1.UuListaDeCarros[_rchave].Som = 0;
                Form1.UuListaDeCarros[_rchave].Modelo = comboBoxModelos.SelectedIndex;
                Form1.UuListaDeCarros[_rchave].Portas = comboBoxPortas.SelectedIndex;
                Form1.UuListaDeCarros[_rchave].Rodas = comboBoxRodas.SelectedIndex;
                Form1.UuListaDeCarros[_rchave].Som = comboBoxSom.SelectedIndex;
                Form1.UuListaDeCarros[_rchave].ArCondicionado = comboBoxArCond.SelectedIndex;
                Form1.UuListaDeCarros[_rchave].ArCondicionado = comboBoxAirBag.SelectedIndex;
            }

            comboBoxPesquisa.Items.Clear();
            foreach (String xis in Form1.UuListaDeCarros.Keys) {
                Carro _rTemp = Form1.UuListaDeCarros[xis];
                comboBoxModelos.SelectedIndex = _rTemp.Modelo;
                comboBoxPesquisa.Items.Add("Placa:" + _rTemp.Placa);
            }
            comboBoxPesquisa.SelectedIndex = 0;
            if (_uAcaoCrud == "N")
                MessageBox.Show("Registro salvo com sucesso.");
            else
                MessageBox.Show("Registro alterado com sucesso.");
            btnEditar.Enabled = true;
            groupBoxPesquisa.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            _uAcaoCrud = string.Empty;
            groupBoxCadastro.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(comboBoxPesquisa.Items.Count > 0) { 
              _uAcaoCrud = "E";
              textBoxPlaca.Enabled = false;
              btnNovo.Enabled = false;
              btnEditar.Enabled = false;
              btnExcluir.Enabled = false;
              groupBoxCadastro.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _uAcaoCrud = string.Empty;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            groupBoxCadastro.Enabled = false;
        }

        private void comboBoxPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Form1.UuListaDeCarros.Count > 0) {
                Carro _rTemp = Form1.UuListaDeCarros[comboBoxPesquisa.SelectedItem.ToString().Replace("Placa:", "")];
                comboBoxModelos.SelectedIndex = _rTemp.Modelo;
                textBoxPlaca.Text             = _rTemp.Placa;
                comboBoxPortas.SelectedIndex  = _rTemp.Portas;
                comboBoxRodas.SelectedIndex   = _rTemp.Rodas;
                comboBoxSom.SelectedIndex     = _rTemp.Som;
                comboBoxArCond.SelectedIndex  = _rTemp.ArCondicionado;
                comboBoxAirBag.SelectedIndex  = _rTemp.AirBag;
                textBoxPlaca.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form1.UuListaDeCarros.Remove(comboBoxPesquisa.SelectedItem.ToString().Replace("Placa:", ""));
            MessageBox.Show("Registro excluído com sucesso.");
            comboBoxPesquisa.Items.Clear();
            if (Form1.UuListaDeCarros.Count > 0)
                foreach (String xis in Form1.UuListaDeCarros.Keys)
                {
                    Carro _rTemp = Form1.UuListaDeCarros[xis];
                    comboBoxModelos.SelectedIndex = _rTemp.Modelo;
                    comboBoxPesquisa.Items.Add("Placa:" + _rTemp.Placa);
                }
            else {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
}
