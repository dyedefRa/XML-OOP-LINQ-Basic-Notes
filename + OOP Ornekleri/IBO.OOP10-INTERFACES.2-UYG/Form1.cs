using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBO.OOP10_INTERFACES._2_UYG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Muslera sa = new Muslera();
            sa.Adi = "muslera";
            sa.BacakKasIndexi = 13;
            sa.Soyadi = "fasf";
            sa.FormaNumamrasi = 2;
           

            sa.EldivenNumarasi = 7;

            MessageBox.Show(sa.SutGucu().ToString());
            MessageBox.Show(sa.ToString());
        }
    }
}
