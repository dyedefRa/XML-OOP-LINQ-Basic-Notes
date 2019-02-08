using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace XML_VERI_OKUYAK_KENDIM_YAZIM
{
    class DATA
    {
        public SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=Kullanıcı;Integrated Security=True");
    }
}
