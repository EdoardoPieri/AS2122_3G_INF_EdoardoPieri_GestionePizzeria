
namespace AS2122_3G_INF_EdoardoPieri_GestionePizzeria
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPizze = new System.Windows.Forms.ComboBox();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.lstPizze = new System.Windows.Forms.ListBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.lbl4Stagioni = new System.Windows.Forms.Label();
            this.lblVerdure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di pizza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantita:";
            // 
            // cmbPizze
            // 
            this.cmbPizze.FormattingEnabled = true;
            this.cmbPizze.Items.AddRange(new object[] {
            "margherita",
            "4 stagioni",
            "verdure"});
            this.cmbPizze.Location = new System.Drawing.Point(154, 88);
            this.cmbPizze.Name = "cmbPizze";
            this.cmbPizze.Size = new System.Drawing.Size(121, 23);
            this.cmbPizze.TabIndex = 2;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(154, 127);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(100, 23);
            this.txtQuantita.TabIndex = 3;
            // 
            // lstPizze
            // 
            this.lstPizze.FormattingEnabled = true;
            this.lstPizze.ItemHeight = 15;
            this.lstPizze.Location = new System.Drawing.Point(436, 88);
            this.lstPizze.Name = "lstPizze";
            this.lstPizze.Size = new System.Drawing.Size(120, 154);
            this.lstPizze.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(300, 87);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(436, 264);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(100, 15);
            this.lblMargherita.TabIndex = 6;
            this.lblMargherita.Text = "Pizze Margherite: ";
            // 
            // lbl4Stagioni
            // 
            this.lbl4Stagioni.AutoSize = true;
            this.lbl4Stagioni.Location = new System.Drawing.Point(436, 299);
            this.lbl4Stagioni.Name = "lbl4Stagioni";
            this.lbl4Stagioni.Size = new System.Drawing.Size(90, 15);
            this.lbl4Stagioni.TabIndex = 7;
            this.lbl4Stagioni.Text = "Pizze 4 stagioni:";
            // 
            // lblVerdure
            // 
            this.lblVerdure.AutoSize = true;
            this.lblVerdure.Location = new System.Drawing.Point(436, 335);
            this.lblVerdure.Name = "lblVerdure";
            this.lblVerdure.Size = new System.Drawing.Size(79, 15);
            this.lblVerdure.TabIndex = 8;
            this.lblVerdure.Text = "Pizze verdure:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 426);
            this.Controls.Add(this.lblVerdure);
            this.Controls.Add(this.lbl4Stagioni);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lstPizze);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.cmbPizze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Edoardo Pieri 3G 15/3/22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPizze;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.ListBox lstPizze;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblMargherita;
        private System.Windows.Forms.Label lbl4Stagioni;
        private System.Windows.Forms.Label lblVerdure;
    }
}

