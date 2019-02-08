using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XML_VERI_OKUYAK_KENDIM_YAZIM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=silebilirsin;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from bu", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ds.WriteXml("kg.xml");

        }
    }
}
