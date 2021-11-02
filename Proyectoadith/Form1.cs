using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoadith
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            porcentaje.Text = f;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void porcentaje_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radio, altura, manguera;
            double porciento, txagua;
            double xa, xb;
            manguera = Convert.ToDouble(mangueras.Text);
            radio = Convert.ToDouble(txtdiametro.Text);
           altura = Convert.ToDouble(txtlongitud.Text);

            Clase obj = new Clase(radio, altura, manguera);
            xa = obj.volumen();

            textBox5.Text = xa.ToString();

            porciento = Convert.ToDouble(textBox5.Text);
            txagua = Convert.ToDouble(porcentaje.Text);
            Resultado obj1 = new Resultado(porciento, txagua);
            xb = obj1.volumen2();
            totalrestante.Text = xb.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
