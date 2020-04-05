namespace CaixaDeMercado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBarFila = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.groupBoxCaixa1 = new System.Windows.Forms.GroupBox();
            this.lblRestanteCaixa1 = new System.Windows.Forms.Label();
            this.lblTotalCaixa1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCaixa2 = new System.Windows.Forms.GroupBox();
            this.lblRestanteCaixa2 = new System.Windows.Forms.Label();
            this.lblTotalCaixa2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCaixa3 = new System.Windows.Forms.GroupBox();
            this.lblRestanteCaixa3 = new System.Windows.Forms.Label();
            this.lblTotalCaixa3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxCaixa4 = new System.Windows.Forms.GroupBox();
            this.lblRestanteCaixa4 = new System.Windows.Forms.Label();
            this.lblTotalCaixa4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxCaixa5 = new System.Windows.Forms.GroupBox();
            this.lblRestanteCaixa5 = new System.Windows.Forms.Label();
            this.lblTotalCaixa5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFila = new System.Windows.Forms.Label();
            this.timerCaixa1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxAberto = new System.Windows.Forms.TextBox();
            this.label1Fechado = new System.Windows.Forms.Label();
            this.groupBoxCaixa1.SuspendLayout();
            this.groupBoxCaixa2.SuspendLayout();
            this.groupBoxCaixa3.SuspendLayout();
            this.groupBoxCaixa4.SuspendLayout();
            this.groupBoxCaixa5.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarFila
            // 
            this.progressBarFila.Location = new System.Drawing.Point(37, 47);
            this.progressBarFila.Maximum = 150;
            this.progressBarFila.Name = "progressBarFila";
            this.progressBarFila.Size = new System.Drawing.Size(769, 17);
            this.progressBarFila.TabIndex = 0;
            this.progressBarFila.Value = 10;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(280, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 24);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(447, 12);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(108, 24);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // groupBoxCaixa1
            // 
            this.groupBoxCaixa1.Controls.Add(this.lblRestanteCaixa1);
            this.groupBoxCaixa1.Controls.Add(this.lblTotalCaixa1);
            this.groupBoxCaixa1.Controls.Add(this.label2);
            this.groupBoxCaixa1.Controls.Add(this.label1);
            this.groupBoxCaixa1.Location = new System.Drawing.Point(37, 141);
            this.groupBoxCaixa1.Name = "groupBoxCaixa1";
            this.groupBoxCaixa1.Size = new System.Drawing.Size(149, 208);
            this.groupBoxCaixa1.TabIndex = 3;
            this.groupBoxCaixa1.TabStop = false;
            this.groupBoxCaixa1.Text = "Caixa 1";
            // 
            // lblRestanteCaixa1
            // 
            this.lblRestanteCaixa1.AutoSize = true;
            this.lblRestanteCaixa1.Location = new System.Drawing.Point(79, 182);
            this.lblRestanteCaixa1.Name = "lblRestanteCaixa1";
            this.lblRestanteCaixa1.Size = new System.Drawing.Size(0, 13);
            this.lblRestanteCaixa1.TabIndex = 3;
            // 
            // lblTotalCaixa1
            // 
            this.lblTotalCaixa1.AutoSize = true;
            this.lblTotalCaixa1.Location = new System.Drawing.Point(59, 151);
            this.lblTotalCaixa1.Name = "lblTotalCaixa1";
            this.lblTotalCaixa1.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCaixa1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restante: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: ";
            // 
            // groupBoxCaixa2
            // 
            this.groupBoxCaixa2.Controls.Add(this.lblRestanteCaixa2);
            this.groupBoxCaixa2.Controls.Add(this.lblTotalCaixa2);
            this.groupBoxCaixa2.Controls.Add(this.label3);
            this.groupBoxCaixa2.Controls.Add(this.label4);
            this.groupBoxCaixa2.Location = new System.Drawing.Point(192, 141);
            this.groupBoxCaixa2.Name = "groupBoxCaixa2";
            this.groupBoxCaixa2.Size = new System.Drawing.Size(149, 208);
            this.groupBoxCaixa2.TabIndex = 4;
            this.groupBoxCaixa2.TabStop = false;
            this.groupBoxCaixa2.Text = "Caixa 2";
            // 
            // lblRestanteCaixa2
            // 
            this.lblRestanteCaixa2.AutoSize = true;
            this.lblRestanteCaixa2.Location = new System.Drawing.Point(75, 182);
            this.lblRestanteCaixa2.Name = "lblRestanteCaixa2";
            this.lblRestanteCaixa2.Size = new System.Drawing.Size(0, 13);
            this.lblRestanteCaixa2.TabIndex = 4;
            // 
            // lblTotalCaixa2
            // 
            this.lblTotalCaixa2.AutoSize = true;
            this.lblTotalCaixa2.Location = new System.Drawing.Point(59, 151);
            this.lblTotalCaixa2.Name = "lblTotalCaixa2";
            this.lblTotalCaixa2.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCaixa2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Restante: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total: ";
            // 
            // groupBoxCaixa3
            // 
            this.groupBoxCaixa3.Controls.Add(this.lblRestanteCaixa3);
            this.groupBoxCaixa3.Controls.Add(this.lblTotalCaixa3);
            this.groupBoxCaixa3.Controls.Add(this.label5);
            this.groupBoxCaixa3.Controls.Add(this.label6);
            this.groupBoxCaixa3.Location = new System.Drawing.Point(347, 141);
            this.groupBoxCaixa3.Name = "groupBoxCaixa3";
            this.groupBoxCaixa3.Size = new System.Drawing.Size(149, 208);
            this.groupBoxCaixa3.TabIndex = 4;
            this.groupBoxCaixa3.TabStop = false;
            this.groupBoxCaixa3.Text = "Caixa 3";
            // 
            // lblRestanteCaixa3
            // 
            this.lblRestanteCaixa3.AutoSize = true;
            this.lblRestanteCaixa3.Location = new System.Drawing.Point(75, 182);
            this.lblRestanteCaixa3.Name = "lblRestanteCaixa3";
            this.lblRestanteCaixa3.Size = new System.Drawing.Size(0, 13);
            this.lblRestanteCaixa3.TabIndex = 5;
            // 
            // lblTotalCaixa3
            // 
            this.lblTotalCaixa3.AutoSize = true;
            this.lblTotalCaixa3.Location = new System.Drawing.Point(59, 151);
            this.lblTotalCaixa3.Name = "lblTotalCaixa3";
            this.lblTotalCaixa3.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCaixa3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Restante: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total: ";
            // 
            // groupBoxCaixa4
            // 
            this.groupBoxCaixa4.Controls.Add(this.lblRestanteCaixa4);
            this.groupBoxCaixa4.Controls.Add(this.lblTotalCaixa4);
            this.groupBoxCaixa4.Controls.Add(this.label7);
            this.groupBoxCaixa4.Controls.Add(this.label8);
            this.groupBoxCaixa4.Location = new System.Drawing.Point(502, 141);
            this.groupBoxCaixa4.Name = "groupBoxCaixa4";
            this.groupBoxCaixa4.Size = new System.Drawing.Size(149, 208);
            this.groupBoxCaixa4.TabIndex = 4;
            this.groupBoxCaixa4.TabStop = false;
            this.groupBoxCaixa4.Text = "Caixa 4";
            // 
            // lblRestanteCaixa4
            // 
            this.lblRestanteCaixa4.AutoSize = true;
            this.lblRestanteCaixa4.Location = new System.Drawing.Point(74, 181);
            this.lblRestanteCaixa4.Name = "lblRestanteCaixa4";
            this.lblRestanteCaixa4.Size = new System.Drawing.Size(0, 13);
            this.lblRestanteCaixa4.TabIndex = 6;
            // 
            // lblTotalCaixa4
            // 
            this.lblTotalCaixa4.AutoSize = true;
            this.lblTotalCaixa4.Location = new System.Drawing.Point(59, 151);
            this.lblTotalCaixa4.Name = "lblTotalCaixa4";
            this.lblTotalCaixa4.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCaixa4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Restante: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total: ";
            // 
            // groupBoxCaixa5
            // 
            this.groupBoxCaixa5.Controls.Add(this.lblRestanteCaixa5);
            this.groupBoxCaixa5.Controls.Add(this.lblTotalCaixa5);
            this.groupBoxCaixa5.Controls.Add(this.label9);
            this.groupBoxCaixa5.Controls.Add(this.label10);
            this.groupBoxCaixa5.Location = new System.Drawing.Point(657, 141);
            this.groupBoxCaixa5.Name = "groupBoxCaixa5";
            this.groupBoxCaixa5.Size = new System.Drawing.Size(149, 208);
            this.groupBoxCaixa5.TabIndex = 4;
            this.groupBoxCaixa5.TabStop = false;
            this.groupBoxCaixa5.Text = "Caixa 5";
            // 
            // lblRestanteCaixa5
            // 
            this.lblRestanteCaixa5.AutoSize = true;
            this.lblRestanteCaixa5.Location = new System.Drawing.Point(75, 181);
            this.lblRestanteCaixa5.Name = "lblRestanteCaixa5";
            this.lblRestanteCaixa5.Size = new System.Drawing.Size(0, 13);
            this.lblRestanteCaixa5.TabIndex = 7;
            // 
            // lblTotalCaixa5
            // 
            this.lblTotalCaixa5.AutoSize = true;
            this.lblTotalCaixa5.Location = new System.Drawing.Point(59, 151);
            this.lblTotalCaixa5.Name = "lblTotalCaixa5";
            this.lblTotalCaixa5.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCaixa5.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Restante: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total: ";
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFila.Location = new System.Drawing.Point(321, 77);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(184, 20);
            this.lblFila.TabIndex = 5;
            this.lblFila.Text = "Tem 0 pessoas na fila";
            // 
            // textBoxAberto
            // 
            this.textBoxAberto.BackColor = System.Drawing.Color.Red;
            this.textBoxAberto.Enabled = false;
            this.textBoxAberto.Location = new System.Drawing.Point(784, 368);
            this.textBoxAberto.Name = "textBoxAberto";
            this.textBoxAberto.Size = new System.Drawing.Size(22, 20);
            this.textBoxAberto.TabIndex = 6;
            // 
            // label1Fechado
            // 
            this.label1Fechado.AutoSize = true;
            this.label1Fechado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Fechado.Location = new System.Drawing.Point(618, 372);
            this.label1Fechado.Name = "label1Fechado";
            this.label1Fechado.Size = new System.Drawing.Size(149, 16);
            this.label1Fechado.TabIndex = 7;
            this.label1Fechado.Text = "Mercado fechado =>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 473);
            this.Controls.Add(this.label1Fechado);
            this.Controls.Add(this.textBoxAberto);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.groupBoxCaixa5);
            this.Controls.Add(this.groupBoxCaixa4);
            this.Controls.Add(this.groupBoxCaixa3);
            this.Controls.Add(this.groupBoxCaixa2);
            this.Controls.Add(this.groupBoxCaixa1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.progressBarFila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxCaixa1.ResumeLayout(false);
            this.groupBoxCaixa1.PerformLayout();
            this.groupBoxCaixa2.ResumeLayout(false);
            this.groupBoxCaixa2.PerformLayout();
            this.groupBoxCaixa3.ResumeLayout(false);
            this.groupBoxCaixa3.PerformLayout();
            this.groupBoxCaixa4.ResumeLayout(false);
            this.groupBoxCaixa4.PerformLayout();
            this.groupBoxCaixa5.ResumeLayout(false);
            this.groupBoxCaixa5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarFila;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.GroupBox groupBoxCaixa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCaixa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCaixa3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxCaixa4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxCaixa5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRestanteCaixa1;
        private System.Windows.Forms.Label lblTotalCaixa1;
        private System.Windows.Forms.Label lblRestanteCaixa2;
        private System.Windows.Forms.Label lblTotalCaixa2;
        private System.Windows.Forms.Label lblRestanteCaixa3;
        private System.Windows.Forms.Label lblTotalCaixa3;
        private System.Windows.Forms.Label lblRestanteCaixa4;
        private System.Windows.Forms.Label lblTotalCaixa4;
        private System.Windows.Forms.Label lblRestanteCaixa5;
        private System.Windows.Forms.Label lblTotalCaixa5;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Timer timerCaixa1;
        private System.Windows.Forms.TextBox textBoxAberto;
        private System.Windows.Forms.Label label1Fechado;
    }
}

