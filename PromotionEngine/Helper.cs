using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public static class Helper
    {
        public static string str = "server=(local);database=PromotionEngineDB;persist security info=True;" +
                    "Integrated Security = SSPI";
        public static SqlConnection Con;


        public static decimal CalculateSKUTotal(int PromotionQuantity, int CartQuantity, decimal SkuPrice, decimal PromotionPrice)
        {
            decimal CartItemTotal = 0;

            //Getting In Promotion and Left Out Quantity
            int InPromotionQuantity = CartQuantity / PromotionQuantity;
            int LeftOutPromotionQuantity =  CartQuantity - (InPromotionQuantity * PromotionQuantity);
            CartItemTotal += (PromotionPrice * InPromotionQuantity);

            decimal LeftOutPromotionPrice = SkuPrice * LeftOutPromotionQuantity;
            CartItemTotal += LeftOutPromotionPrice;

            return CartItemTotal;
        }


        #region SKU
        public static void InsertingNewSKU(string SKU, decimal Price)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.Sku (Sku, Price) VALUES ('" + SKU + "', " + Price + ")";
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static Object[] GettingSkuIdAndPrice(string SKU)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                int SKU_Id = 0;
                decimal Price = 0;
                string oString = "Select * from SKU where Sku=@Sku";
                SqlCommand cmd = new SqlCommand(oString, Helper.Con);
                cmd.Parameters.AddWithValue("@Sku", SKU);
                cmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        SKU_Id = Convert.ToInt32(oReader["Id"]);
                        Price = Convert.ToDecimal(oReader["Price"]);
                    }
                    connection.Close();
                }
                Object[] ArrayOfObjects = new Object[] { SKU_Id, Price };
                return ArrayOfObjects;
            }
        }
        #endregion

        #region Cart
        public static int GettingCartId(DateTime DateTime, decimal Total)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                int Cart_Id = 0;
                string oString = "Select * from Cart where OrderDate='" + DateTime + "' And Total="
                    + Total;
                SqlCommand oCmd = new SqlCommand(oString, Helper.Con);
                oCmd.Parameters.AddWithValue("@OrderDate", DateTime);
                oCmd.Parameters.AddWithValue("@Total", Total);
                oCmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Cart_Id = Convert.ToInt32(oReader["Id"]);
                    }
                    connection.Close();
                }
                return Cart_Id;
            }
        }

        public static void InsertingNewCart(DateTime DateTime, decimal Total)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                string oString = "INSERT INTO dbo.Cart (OrderDate,Total) VALUES ('" + DateTime + "'," +
             Total + ")";
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand(oString, Helper.Con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void InsertingNewCartItem(int Sku_Id, int Cart_Id, decimal Quantity, decimal Total)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.CartItem (Sku_Id,Cart_Id,Quantity,Total) " +
                    "VALUES (" + Sku_Id + "," + Cart_Id + "," + Quantity + "," + Total + ")";
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        #endregion

        #region Promotion 
        public static void InsertingNewPromotionDetail(int PromotionId, int SkuId, decimal Quantity, decimal Price)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.PromotionDetail (Promotion_Id,Sku_Id,Quantity,Price) " +
                    "VALUES (" + PromotionId + "," + SkuId + "," + Quantity + "," + Price + ")";
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void InsertingNewPromotion(string PromotionName)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                string oString = "INSERT INTO dbo.Promotion (PromotionName) VALUES ('" + PromotionName + "')";
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand(oString, Helper.Con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void UpdatingPromotionRecord(int PromotionId, decimal Total)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Promotion SET Total = " + Total +
                    " WHERE " +
                    "Id='" + PromotionId + "' ";
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static int GettingPromotionId(string PromotionName)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                int PromotionId = 0;
                string oString = "Select * from Promotion where PromotionName=@PromotionName";
                SqlCommand oCmd = new SqlCommand(oString, Helper.Con);
                oCmd.Parameters.AddWithValue("@PromotionName", PromotionName);
                oCmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        PromotionId = Convert.ToInt32(oReader["Id"]);
                    }
                    connection.Close();
                }
                return PromotionId;
            }
        }

        public static Object[] GettingPromotionQuantityAndPrice(int SKU_Id)
        {
            using (SqlConnection connection = new SqlConnection(Helper.str))
            {
                int PromotionQuantity = 0;
                decimal PromotionPrice = 0;
                string oString = "Select * from PromotionDetail where Sku_Id='" + SKU_Id + "'";
                SqlCommand cmd = new SqlCommand(oString, Helper.Con);
                cmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        PromotionQuantity = Convert.ToInt32(oReader["Quantity"]);
                        PromotionPrice = Convert.ToDecimal(oReader["Price"]);
                    }
                    connection.Close();
                }
                Object[] ArrayOfObjects = new Object[] { PromotionQuantity, PromotionPrice };
                return ArrayOfObjects;
            }
        }

        #endregion

    }
}
