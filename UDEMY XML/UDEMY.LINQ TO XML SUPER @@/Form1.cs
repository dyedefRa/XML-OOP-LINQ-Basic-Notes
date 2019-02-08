using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çalışmam6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> listem = new List<Personel>();
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p1 = new Personel();
            p1.ID = Convert.ToInt32(textBox1.Text);
            p1.Adi = textBox2.Text;
            listem.Add(p1);
            listBox1.Items.Add(p1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var deger = from sa in listem where sa.ID > 5 orderby sa.ID select new { sa.Adi };
            //foreach (var item in deger)
            //{
            //    listBox2.Items.Add(item);
            //}




            //List<Personel> k = new List<Personel>() { new Personel() { ID = 4, Adi = "saf" }, new Personel() { ID = 3, Adi = "saf" } };
            //listem.AddRange(k);




            //bool k = listem.All(new Func<Personel, bool>(I => I.Adi == "m" ? true : false));
            //MessageBox.Show(k.ToString());

            listem.ForEach(I => MessageBox.Show("sfa"));
        }
    }
}
