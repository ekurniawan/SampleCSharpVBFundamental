using System.Data.SqlClient;

namespace SampleCSharp
{
    public class CustomerDAL
    {
        const string strConn = "Server=ACTUAL;Database=BobsShoes;Trusted_Connection=True;";

        public IEnumerable<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"SELECT * FROM Orders.Customers order by CustName";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustID = Convert.ToInt32(dr["CustID"]),
                            CustName = dr["CustName"].ToString(),
                            CustStreet = dr["CustStreet"].ToString(),
                            CustCity = dr["CustCity"].ToString(),
                            CustStateProv = dr["CustStateProv"].ToString(),
                            CustCountry = dr["CustCountry"].ToString(),
                            CustPostalCode = dr["CustPostalCode"].ToString(),
                            SalutationID = Convert.ToInt32(dr["SalutationID"])
                        });
                    }
                }

                dr.Close();
                cmd.Dispose();
                conn.Close();

                return customers;
            }
        }
    }
}
