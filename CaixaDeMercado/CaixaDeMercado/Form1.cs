using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaDeMercado
{
    public partial class Form1 : Form
    {
        /*Declaração de variáveis*/
        List<Thread> threadLista = new List<Thread>();
        /* Classe feita na mão */
        Fila<Caixa> FilaDeCaixas = new Fila<Caixa>(); //Declaração da Fila
        Label[] listaLbTotal = new Label[5];
        Label[] listaLbRestante = new Label[5];
        /* Array de boolean par ter um controle das thread */
        Boolean[] estadoThread = {true, true, true, true, true};
        /* Thread do mercado em si para poder inciiar em uma thread diferente */
        Thread proIniciar;
        public Form1()
        {
            InitializeComponent();
            progressBarFila.Value = 0;
        }

        private void proPassarMercadorias(Label lblTotal, Label lblRestante, int processo) {
            /* Cria uma variavel para gerar os números randômicos */
            Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            /* Pega o primeiro da fila e guarda em uma variavel local */
            Caixa caixa = FilaDeCaixas.Peek();
            /* remove o caixa da fila */
            FilaDeCaixas.Dequeue();
            /* Cria um método invoker para chamar um item da thread principal */
            MethodInvoker m4 = new MethodInvoker(() => proUpdateLabelPessoasFila());
            /* Chama o lbl atraves do método invoke para colocar o tottal no label */
            lblFila.Invoke(m4);
            MethodInvoker m3 = new MethodInvoker(() => proUpdateProgressBar(true));
            /* Chama o método do Progress bar para retirar um da fila pois irá começar passar os produtos */
            progressBarFila.Invoke(m3);
            MethodInvoker m = new MethodInvoker(() => proUpdateTotal(lblTotal, caixa.getRestante()));
            lblTotal.Invoke(m);
            /* Ele fica retirando os itens do carrinho de acordo com um número aleatório */
            while (caixa.getRestante() > 0) {
                caixa.setRestante(caixa.getRestante() - 1);
                MethodInvoker m2 = new MethodInvoker(() => proUpdateLblRestante(lblRestante, caixa.getRestante()));
                /* Chama o método apenas para regredir um número do label restante */
                lblRestante.Invoke(m2);
                Thread.Sleep(r.Next(1000, r.Next(1500,11000)));
            }
            lblTotal.Invoke(m);
            /*  se ainda existe pessoas na fila ele carrega o próximoo carrinho */
            if (FilaDeCaixas.Count > 0) 
                proPassarMercadorias(lblTotal, lblRestante, processo);
            /* Após finalizado o processo ele torna acessível a thread novamente*/
            estadoThread[processo] = true;
        }

        private void proUpdateTotal(Label lblTotal, int total) {
            /* Seta os valores do label total */
            if (total == 0)
                lblTotal.Text = "";
            else
                lblTotal.Text = total.ToString();
        }

        private void proUpdateLabelPessoasFila() {
            /* Seta os valores de pessoas na fila */
            lblFila.Text = "Tem " + FilaDeCaixas.Count.ToString() + " pessoas na fila.";
        }

        private void proUpdateProgressBar(Boolean retirar) {
            /* regride ou aumenta um na fila no progress bar */
            if (retirar)
                progressBarFila.Value = progressBarFila.Value - 10;
            else
                progressBarFila.Value = progressBarFila.Value + 10;
        }

        private void proUpdateLblRestante(Label lblRestante, int restante) {
            /* Seta o label com o valor restante passado como parâmetro */
            if (restante == 0)
               lblRestante.Text = "";
            else
                lblRestante.Text = restante.ToString();
        }

        private void proIniciarMercado() {
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            /* Inicia um random para os valores randômicos que serão gerados */
            while (true)
            {   /* Ele aceita apenas 15 pessoas na fila */
                if (progressBarFila.Value != 150)
                {
                    /* Ele acrescenta um cliente na fila com chance de 25% */
                    if (random.Next(0, 4) == 1)
                    {   
                        /* Chama o método para acrescentar no progress bar */
                        MethodInvoker m3 = new MethodInvoker(() => proUpdateProgressBar(false));
                        progressBarFila.Invoke(m3);
                        FilaDeCaixas.Enqueue(new Caixa(random.Next(1, (random.Next(20, 250)))));
                        /* Adiciona na fila o cliente */
                        MethodInvoker m4 = new MethodInvoker(() => proUpdateLabelPessoasFila());
                        lblFila.Invoke(m4);
                    }
                    for (int i = random.Next(0, 5); i <= 4; i++)
                    {
                        /* Se existir pessoas na fila, ele ve se tem alguma thread disponivel
                              e se tiver ele inicia a thread para pegar o cliente da fila */
                        if (FilaDeCaixas.Count > 0)
                            if (estadoThread[i])
                            {
                                estadoThread[i] = false;
                                threadLista[i] = new Thread(() => proPassarMercadorias(listaLbTotal[i], listaLbRestante[i], i));
                                threadLista[i].Start();
                                Thread.Sleep(50);
                            }
                    }
                }
                /*Tem um timer menor para ficar visível a chegada de pessoas.*/
                Thread.Sleep(random.Next(1000, random.Next(1001,5000)));
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (threadLista.Count > 0)
                return;
            /*Inicia e adiciona os label em um array */
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            listaLbTotal[0] = lblTotalCaixa1;
            listaLbTotal[1] = lblTotalCaixa2;
            listaLbTotal[2] = lblTotalCaixa3;
            listaLbTotal[3] = lblTotalCaixa4;
            listaLbTotal[4] = lblTotalCaixa5;
            listaLbRestante[0] = lblRestanteCaixa1;
            listaLbRestante[1] = lblRestanteCaixa2;
            listaLbRestante[2] = lblRestanteCaixa3;
            listaLbRestante[3] = lblRestanteCaixa4;
            listaLbRestante[4] = lblRestanteCaixa5;
            FilaDeCaixas.Enqueue(new Caixa(random.Next(1, 20)));
            /* Adiociona as threads na Lista */
            threadLista.Add(new Thread(() => proPassarMercadorias(lblTotalCaixa1, lblRestanteCaixa1, 0)));
            threadLista.Add(new Thread(() => proPassarMercadorias(lblTotalCaixa2, lblRestanteCaixa2, 1)));
            threadLista.Add(new Thread(() => proPassarMercadorias(lblTotalCaixa3, lblRestanteCaixa3, 2)));
            threadLista.Add(new Thread(() => proPassarMercadorias(lblTotalCaixa4, lblRestanteCaixa4, 3)));
            threadLista.Add(new Thread(() => proPassarMercadorias(lblTotalCaixa5, lblRestanteCaixa5, 4)));
            FilaDeCaixas.Dequeue();
            /* Muda o status do mercado para aberto */
            label1Fechado.Text = "Mercado Aberto =>";
            textBoxAberto.BackColor = Color.Green;
            /*  Inicia a thread para dar inicio do cliclo do mercado de entrada de cliente */
            proIniciar = new Thread(() => proIniciarMercado());
            proIniciar.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Ao parar o mercado ele irá fechar deseja continuar?", "Parar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            /* Pede a confirmação e se confirmado ele mata as thread e finaliza a aplicação */
            if (confirm.ToString().ToUpper() == "YES")
            {
                if (threadLista.Count > 0)
                {
                    foreach (Thread percorre in threadLista)
                    {
                        percorre.Abort();
                    }
                    proIniciar.Abort();
                }
                Environment.Exit(0);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Mata as thread caso exista alguma viva */
            if (threadLista.Count > 0)
            {
                foreach (Thread percorre in threadLista)
                {
                    percorre.Abort();
                }
                proIniciar.Abort();
            }
        }
    }
}
