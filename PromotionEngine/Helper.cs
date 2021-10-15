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
            int LeftOutPromotionQuantity = CartQuantity - PromotionQuantity;
            CartItemTotal += PromotionPrice;

            decimal LeftOutPromotionPrice = SkuPrice * LeftOutPromotionQuantity;
            CartItemTotal += LeftOutPromotionPrice;

            return CartItemTotal;
        }
        public static void OpenDatabaseConnection(SqlConnection Connection)
        {
            Connection.Open();
        }
        public static void CloseDatabaseConnection(SqlConnection Connection)
        {
            Connection.Close();
        }

        #region SKU
        public static void InsertingNewSKU(string SKU, decimal Price)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.Sku (Sku, Price) VALUES ('" + SKU + "', " + Price + ")";
            cmd.Connection = Helper.Con;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.OpenDatabaseConnection(Helper.Con);
        }

        public static Object[] GettingSkuIdAndPrice(string SKU)
        {
            int SKU_Id = 0;
            decimal Price = 0;
            string oString = "Select * from SKU where Sku=@Sku";
            SqlCommand cmd = new SqlCommand(oString, Helper.Con);
            cmd.Parameters.AddWithValue("@Sku", SKU);
            Helper.OpenDatabaseConnection(Helper.Con);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    SKU_Id = Convert.ToInt32(oReader["Id"]);
                    Price = Convert.ToDecimal(oReader["Price"]);
                }
                Helper.CloseDatabaseConnection(Helper.Con);
            }
            Object[] ArrayOfObjects = new Object[] { SKU_Id, Price };
            return ArrayOfObjects;
        }
        #endregion

        #region Cart
        public static int GettingCartId(DateTime DateTime, decimal Total)
        {
            int Cart_Id = 0;
            string oString = "Select * from Cart where OrderDate='" + DateTime + "' And Total="
                + Total;
            SqlCommand oCmd = new SqlCommand(oString, Helper.Con);
            oCmd.Parameters.AddWithValue("@OrderDate", DateTime);
            oCmd.Parameters.AddWithValue("@Total", Total);
            Helper.OpenDatabaseConnection(Helper.Con);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    Cart_Id = Convert.ToInt32(oReader["Id"]);
                }
                Helper.CloseDatabaseConnection(Helper.Con);
            }
            return Cart_Id;
        }

        public static void InsertingNewCart(DateTime DateTime, decimal Total)
        {
            string oString = "INSERT INTO dbo.Cart (OrderDate,Total) VALUES ('" + DateTime + "'," +
             Total + ")";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(oString, Helper.Con);
            cmd.CommandType = System.Data.CommandType.Text;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.CloseDatabaseConnection(Helper.Con);
        }

        public static void InsertingNewCartItem(int Sku_Id, int Cart_Id, decimal Quantity, decimal Total)
        {
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.CartItem (Sku_Id,Cart_Id,Quantity,Total) " +
                "VALUES (" + Sku_Id + "," + Cart_Id + "," + Quantity + "," + Total + ")";
            cmd.Connection = Helper.Con;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.CloseDatabaseConnection(Helper.Con);
        }

        #endregion

        #region Promotion 
        public static void InsertingNewPromotionDetail(int PromotionId, int SkuId, decimal Quantity, decimal Price)
        {
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.PromotionDetail (Promotion_Id,Sku_Id,Quantity,Price) " +
                "VALUES (" + PromotionId + "," + SkuId + "," + Quantity + "," + Price + ")";
            cmd.Connection = Helper.Con;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.CloseDatabaseConnection(Helper.Con);
        }

        public static void InsertingNewPromotion(string PromotionName)
        {
            string oString = "INSERT INTO dbo.Promotion (PromotionName) VALUES ('" + PromotionName + "')";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(oString, Helper.Con);
            cmd.CommandType = System.Data.CommandType.Text;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.CloseDatabaseConnection(Helper.Con);
        }

        public static void UpdatingPromotionRecord(int PromotionId, decimal Total)
        {
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE Promotion SET Total = " + Total +
                " WHERE " +
                "Id='" + PromotionId + "' ";
            cmd.Connection = Helper.Con;
            Helper.OpenDatabaseConnection(Helper.Con);
            cmd.ExecuteNonQuery();
            Helper.CloseDatabaseConnection(Helper.Con);
        }

        public static int GettingPromotionId(string PromotionName)
        {
            int PromotionId = 0;
            string oString = "Select * from Promotion where PromotionName=@PromotionName";
            SqlCommand oCmd = new SqlCommand(oString, Helper.Con);
            oCmd.Parameters.AddWithValue("@PromotionName", PromotionName);
            Helper.OpenDatabaseConnection(Helper.Con);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    PromotionId = Convert.ToInt32(oReader["Id"]);
                }
                Helper.CloseDatabaseConnection(Helper.Con);
            }
            return PromotionId;
        }

        public static Object[] GettingPromotionQuantityAndPrice(int SKU_Id)
        {
            int PromotionQuantity = 0;
            decimal PromotionPrice = 0;
          string  oString = "Select * from PromotionDetail where Sku_Id='" + SKU_Id + "'";
            SqlCommand cmd = new SqlCommand(oString, Helper.Con);
            Helper.OpenDatabaseConnection(Helper.Con);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    PromotionQuantity = Convert.ToInt32(oReader["Quantity"]);
                    PromotionPrice = Convert.ToDecimal(oReader["Price"]);
                }
                Helper.CloseDatabaseConnection(Helper.Con);
            }
            Object[] ArrayOfObjects = new Object[] { PromotionQuantity, PromotionPrice };
            return ArrayOfObjects;
        }

        #endregion

    }
}
