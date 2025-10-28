namespace aaroncocabancomat
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.pnlOperazioni = new System.Windows.Forms.Panel();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.txtImporto = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnAccedi = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.Iabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pnlOperazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.Location = new System.Drawing.Point(360, 256);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(44, 16);
            this.lblMessaggio.TabIndex = 9;
            this.lblMessaggio.Text = "label1";
            this.lblMessaggio.Click += new System.EventHandler(this.lblMessaggio_Click);
            // 
            // pnlOperazioni
            // 
            this.pnlOperazioni.Controls.Add(this.btnEsci);
            this.pnlOperazioni.Controls.Add(this.btnDeposita);
            this.pnlOperazioni.Controls.Add(this.btnPreleva);
            this.pnlOperazioni.Controls.Add(this.txtImporto);
            this.pnlOperazioni.Controls.Add(this.lblSaldo);
            this.pnlOperazioni.Location = new System.Drawing.Point(268, 284);
            this.pnlOperazioni.Name = "pnlOperazioni";
            this.pnlOperazioni.Size = new System.Drawing.Size(238, 182);
            this.pnlOperazioni.TabIndex = 8;
            this.pnlOperazioni.Visible = false;
            this.pnlOperazioni.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOperazioni_Paint);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(80, 124);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 4;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(138, 85);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(100, 23);
            this.btnDeposita.TabIndex = 3;
            this.btnDeposita.Text = "DEPOSITA";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(3, 85);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(110, 23);
            this.btnPreleva.TabIndex = 2;
            this.btnPreleva.Text = "PRELEVA";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // txtImporto
            // 
            this.txtImporto.Location = new System.Drawing.Point(95, 43);
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(56, 22);
            this.txtImporto.TabIndex = 1;
            this.txtImporto.Text = "Importo:";
            this.txtImporto.TextChanged += new System.EventHandler(this.txtImporto_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(77, 10);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(84, 16);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo €1000 ";
            // 
            // btnAccedi
            // 
            this.btnAccedi.Location = new System.Drawing.Point(348, 230);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(75, 23);
            this.btnAccedi.TabIndex = 7;
            this.btnAccedi.Text = "ACCEDI";
            this.btnAccedi.UseVisualStyleBackColor = true;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(316, 74);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(130, 22);
            this.txtPIN.TabIndex = 6;
            this.txtPIN.UseSystemPasswordChar = true;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // Iabel1
            // 
            this.Iabel1.AutoSize = true;
            this.Iabel1.Location = new System.Drawing.Point(337, 55);
            this.Iabel1.Name = "Iabel1";
            this.Iabel1.Size = new System.Drawing.Size(81, 16);
            this.Iabel1.TabIndex = 5;
            this.Iabel1.Text = "Inserisci PIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(428, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(265, 160);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(345, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(428, 160);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(346, 189);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(426, 189);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "CANC";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 634);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.pnlOperazioni);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.Iabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperazioni.ResumeLayout(false);
            this.pnlOperazioni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.Panel pnlOperazioni;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.TextBox txtImporto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnAccedi;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label Iabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

