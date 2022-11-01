using LibAnimales.Animales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(8, 1.34, 70);
            MessageBox.Show("Leon creado");
            MessageBox.Show(leon.Imprimir());
            MessageBox.Show(leon.ImprimirComida());
        }

        private void btnAgregarConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(2, 0.4, 3);
            MessageBox.Show("Conejo creado");
            MessageBox.Show(conejo.Imprimir());
            MessageBox.Show(conejo.ImprimirComida());
        }

        private void btnAgregarLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(5, 0.25, 1);
            MessageBox.Show("Loro creado");
            MessageBox.Show(loro.Imprimir());
            MessageBox.Show(loro.ImprimirComida());
        }
    }
}
