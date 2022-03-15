using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_EdoardoPieri_GestionePizzeria
{
    public partial class frmMain : Form
    {
        int tipoPizza;
        int[] nPizze = new int[3];
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if(txtQuantita.Text != "")
            {
                switch(cmbPizze.Text)
                {
                    case "margherita":
                        tipoPizza = 0;
                        break;
                    case "4 stagioni":
                        tipoPizza = 1;
                        break;
                    case "verdure":
                        tipoPizza = 2;
                        break;
                }
                nPizze[tipoPizza] = nPizze[tipoPizza] + Convert.ToInt32(txtQuantita.Text);
                lblMargherita.Text = $"Pizze Margherite: {Convert.ToString(nPizze[0])}";
                lbl4Stagioni.Text = $"Pizze 4 stagioni: {Convert.ToString(nPizze[1])}";
                lblVerdure.Text = $"Pizze verdure: {Convert.ToString(nPizze[2])}";
                lstPizze.Items.Add($"{cmbPizze.Text} {nPizze[tipoPizza]}");

            }
        }
    }
}
