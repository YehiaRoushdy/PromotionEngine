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


        public static void InsertingNewSKU(string SKU, decimal Price)
        {
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.Sku (Sku, Price) VALUES ('" + SKU + "', " + Price + ")";
            cmd.Connection = SQLConnection;
            SQLConnection.Open();
            cmd.ExecuteNonQuery();
            SQLConnection.Close();
        }
    }
}
