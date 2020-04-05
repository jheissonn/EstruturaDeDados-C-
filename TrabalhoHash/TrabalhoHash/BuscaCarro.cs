using System;
using System.Windows.Forms;

namespace TrabalhoHash
{
    public partial class BuscaCarro : Form
    {
        public BuscaCarro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxPlaca.Text == "")
                return;
            try {
                Carro _rTemp = Form1.UuListaDeCarros[textBoxPlaca.Text];
                MessageBox.Show("O carro com a placa: " + _rTemp.Placa + " existe na base de dados \n Busca serve apenas para aprendizado acadêmico.");

            }
            catch {
                MessageBox.Show("O carro com a placa: " + textBoxPlaca.Text +
                    " não existe na base de dados \n Busca serve apenas para aprendizado acadêmico.");
            }

            
        }
    }
}
