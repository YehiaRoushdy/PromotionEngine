using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;

namespace PromotionEngineDBTesting
{
    [TestClass]
    public class PromotionEngineTesting
    {
        [TestMethod]
        public void MainTestingMethod()
        {
            Helper.InsertingNewSKU("A", 10);
            var SKU_A_Details = Helper.GettingSkuIdAndPrice("A");
            int Sku_Id_A = Convert.ToInt32(SKU_A_Details[0]);
            decimal SKU_A_Price = Convert.ToDecimal(SKU_A_Details[1]);
            Helper.InsertingNewSKU("B", 20);
            var SKU_B_Details = Helper.GettingSkuIdAndPrice("B");
            int Sku_Id_B = Convert.ToInt32(SKU_B_Details[0]);
            decimal SKU_B_Price = Convert.ToDecimal(SKU_B_Details[1]);
            Helper.InsertingNewSKU("C", 30);
            var SKU_C_Details = Helper.GettingSkuIdAndPrice("C");
            int Sku_Id_C = Convert.ToInt32(SKU_C_Details[0]);
            decimal SKU_C_Price = Convert.ToDecimal(SKU_C_Details[1]);


            //Inserting Promotion
            Helper.InsertingNewPromotion("New Promotion");
            int Promotion_Id = Helper.GettingPromotionId("New Promotion");
            Helper.InsertingNewPromotionDetail(Promotion_Id, Sku_Id_A, 3, 15);
            Helper.InsertingNewPromotionDetail(Promotion_Id, Sku_Id_B, 3, 30);


            //Preparing Order Details
            int Quantity_A = 5;
            int Quantity_B = 6;
            var Prommotion_Details_A = Helper.GettingPromotionQuantityAndPrice(Sku_Id_A);
            var Prommotion_Details_B = Helper.GettingPromotionQuantityAndPrice(Sku_Id_B);

            int PromotionQuantity_A = Convert.ToInt32(Prommotion_Details_A[0]);
            int PromotionQuantity_B = Convert.ToInt32(Prommotion_Details_B[0]);
            decimal PromotionPrice_A = Convert.ToDecimal(Prommotion_Details_A[1]);
            decimal PromotionPrice_B = Convert.ToDecimal(Prommotion_Details_B[1]);


            decimal RowTotal_A = Helper.CalculateSKUTotal(PromotionQuantity_A, Quantity_A, SKU_A_Price, PromotionPrice_A);
            decimal RowTotal_B = Helper.CalculateSKUTotal(PromotionQuantity_B, Quantity_B, SKU_B_Price, PromotionPrice_B);

            decimal RowTotal_A_Expected = 35;
            decimal RowTotal_B_Expected = 90;

            Assert.AreEqual(RowTotal_A, RowTotal_A_Expected);
            Assert.AreEqual(RowTotal_B, RowTotal_B_Expected);

        }
    }
}
