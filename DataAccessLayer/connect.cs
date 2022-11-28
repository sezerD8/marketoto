using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;


namespace DataAccessLayer
{
    internal class connect
    {
        public static SqlConnection db = new SqlConnection("Data Source=DESKTOP-B7SPO6J;Initial Catalog=marketOtomasyon;User ID=sa;Password=1234;MultipleActiveResultSets=True");
    }
}
