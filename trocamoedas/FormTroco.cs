using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trocamoedas
{
    public partial class FormTroco : Form
    {
        public FormTroco()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lbl_calcular_Click(object sender, EventArgs e)
        {
                
            if (textBox_Compra.Text == string.Empty && textBox_Pago.Text == string.Empty)
            {
                
                textBox_Compra.Text = "0";
                textBox_Pago.Text = "0";
            }

            decimal valorCompra;
            decimal valorpagoDinheiro;
            decimal valorTroco;
            

            valorCompra = Convert.ToDecimal(textBox_Compra.Text);
            valorpagoDinheiro = Convert.ToDecimal(textBox_Pago.Text);
            valorTroco = valorpagoDinheiro - valorCompra;

            textBox_Troco.Text = valorTroco.ToString();

            int moeda1 = (int) (valorTroco / 1);
            lbl_troco1.Text = moeda1.ToString();
            valorTroco = valorTroco % 1;

            int moeda50 = (int)(valorTroco / 0.50m);
            lbl_troco50.Text = moeda50.ToString();
            valorTroco = valorTroco % 0.50m;

            int moeda25 = (int)(valorTroco / 0.25m);
            lbl_troco25.Text = moeda25.ToString();
            valorTroco = valorTroco % 0.25m;

            int moeda10 = (int)(valorTroco / 0.10m);
            lbl_troco10.Text= moeda10.ToString();
            valorTroco = valorTroco % 0.10m;

            int moeda05 = (int)(valorTroco / 0.05m);
            lbl_troco05.Text = moeda05.ToString();
            valorTroco = valorTroco % 0.05m;

            int moeda01 = (int)(valorTroco / 0.01m);
            lbl_troco01.Text = moeda01.ToString();
            valorTroco = valorTroco % 0.01m;

        }
    }
}
