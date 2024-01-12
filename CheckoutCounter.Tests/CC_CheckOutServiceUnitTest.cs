using CheckoutCounter.Models;
using CheckoutCounter.Services;
namespace CheckoutCounter.Tests
{
    public class CC_CheckOutServiceUnitTest
    {
        [Fact]
        public void CalculateTotalPriceWithoutPromoTest()
        {
            //Arrange
            decimal expected = 100;
            //Act
            decimal actual = 0;
            CC_PromotionService promotionService = new CC_PromotionService();
            CC_CheckOutService checkOutService=new CC_CheckOutService(promotionService);
            List<CC_Product> products = new List<CC_Product>();
            products = this.GetProducts();
            foreach (var product in products) 
            {
                checkOutService.Scan(product);
            }
            actual = checkOutService.Sale.TotalPrice;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculateTotalPriceWithPromoTest()
        {
            //Arrange
            decimal expected = 80;
            //Act
            decimal actual = 0;
            CC_PromotionService promotionService = new CC_PromotionService();
            CC_Product p1 = new CC_Product();
            p1.Code = "21A";
            CC_Product p3 = new CC_Product();
            p3.Code = "Y5A";
            CC_Promotion promotion1 = new CC_PromotionB1G1(p1);
            CC_Promotion promotion2 = new CC_PromotionB2G1(p3);
            promotionService.AddPromotion(promotion1);
            promotionService.AddPromotion(promotion2);
            CC_CheckOutService checkOutService = new CC_CheckOutService(promotionService);
            List<CC_Product> products = new List<CC_Product>();
            products = this.GetProducts();
            foreach (var product in products)
            {
                checkOutService.Scan(product);
            }
            actual = checkOutService.Sale.TotalPrice;
            //Assert
            Assert.Equal(expected, actual);
        }
        private List<CC_Product> GetProducts()
        {
            CheckoutCounter.Models.CC_Product p1 = new CheckoutCounter.Models.CC_Product();
            p1.Name = "Talco AAA";
            p1.UnitPrice = 10;
            p1.MeasurementUnit = "U";
            p1.Code = "21A";

            CheckoutCounter.Models.CC_Product p2 = new CheckoutCounter.Models.CC_Product();
            p2.Name = "Harina";
            p2.UnitPrice = 10;
            p2.Code = "55QW";
            p2.MeasurementUnit = "KG";
            p2.Weight = 5;
            p2.SoldBy = SoldBy.Bybulk;

            CheckoutCounter.Models.CC_Product p3 = new CheckoutCounter.Models.CC_Product();
            p3.Name = "Pasta NMV";
            p3.UnitPrice = 10;
            p3.MeasurementUnit = "U";
            p3.Code = "Y5A";

            List<CC_Product> products = new List<CC_Product>();
            products.Add(p1);
            products.Add(p2);            
            products.Add(p3);
            products.Add(p3);            
            products.Add(p1);
            products.Add(p3);
            return products;
        }
    }
}