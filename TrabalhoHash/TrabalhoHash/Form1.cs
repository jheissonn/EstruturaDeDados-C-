using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabalhoHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Este é um trabalho acadêmico. \n E serve apenas para demonstração da utilização de HASH");
        }

        private static Dictionary<String, Carro> uListaDeCarros = new Dictionary<string, Carro>();

        internal static Dictionary<String, Carro> UuListaDeCarros { get => uListaDeCarros; set => uListaDeCarros = value; }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroDeCarro _r = new CadastroDeCarro();
            _r.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscaCarro _r = new BuscaCarro();
            _r.ShowDialog();
        }
    }
}
