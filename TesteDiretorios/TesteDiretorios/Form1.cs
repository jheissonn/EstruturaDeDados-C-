using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDiretorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Model item1 = new Model("oi", "asdasd");
            ListViewItem item = new ListViewItem("Abacaxi");
            item.SubItems.Add("10");
            item.SubItems.Add("10");
            item.SubItems.Add("10");
            listView1.Items.Add(item); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo teste;

            
             // folder.GetFiles;
            //folder.Exists;
            //MessageBox.Show( folder.MoveToGetDirectories().GetLongLength().ToString());
        }

        public void GetDirStructure(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine(fi.FullName.ToString());
                }

                if (subDirs != null)
                {
                    foreach (DirectoryInfo sd in subDirs)
                    {
                        GetDirStructure( @"\\" + sd.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static bool listararquivos(string nomPasta,string extensao) {
            DirectoryInfo folder = new DirectoryInfo(nomPasta);


            try {

                foreach (FileInfo file in folder.GetFiles()) {
                    if (file.Extension.ToLower() == extensao.ToLower())
                        ;//LÓGICA
                }

                foreach (DirectoryInfo subfolder in folder.GetDirectories()) {

                    if (!listararquivos(subfolder.FullName, extensao)) return false;

                }
                return true;

            }
            catch { return false; }

            
        }

        


        public void PegarPastas(string path)
        {
            try
            {w
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine(fi.FullName.ToString());
                }

                if (subDirs != null)
                {
                    foreach (DirectoryInfo sd in subDirs)
                    {
                        PegarPastas(@"\\" + sd.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
