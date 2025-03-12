using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NDP_PROJE_DENEME_1
{
    class SqlBaglanti
    {
        public SqlConnection sqlBaglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMK0LLN;Initial Catalog=MagazaVeriTabani;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
