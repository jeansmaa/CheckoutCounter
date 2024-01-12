// See https://aka.ms/new-console-template for more information

using CheckoutCounter.Models;
using System.Runtime.CompilerServices;

CheckoutCounter.Services.CC_PromotionService promotionService =
    new CheckoutCounter.Services.CC_PromotionService();

CheckoutCounter.Services.CC_CheckOutService cC =
    new CheckoutCounter.Services.CC_CheckOutService(promotionService);

  
///////////////////////////

/////////////////
CheckoutCounter.Models.CC_Product p1=new CheckoutCounter.Models.CC_Product();
p1.Name = "Talco AAA";
p1.UnitPrice = 100;
p1.MeasurementUnit = "U";
p1.Code = "21A";


CheckoutCounter.Models.CC_Product p2 = new CheckoutCounter.Models.CC_Product();
p2.Name = "Harina";
p2.UnitPrice = 60;
p2.Code = "55QW";
p2.MeasurementUnit = "KG";
p2.Weight = 10;
p2.SoldBy = SoldBy.Bybulk;


CheckoutCounter.Models.CC_Product p3 = new CheckoutCounter.Models.CC_Product();
p3.Name = "Pasta NMV";
p3.UnitPrice = 500;
p3.MeasurementUnit = "U";
p3.Code = "Y5A";

////////////////////////
CC_Promotion promotion1 = new CC_Promotion(p1,PromotionType.BuyOneGetOne);
CC_Promotion promotion2 = new CC_Promotion(p3, PromotionType.BuyTwoGetOne);
promotionService.AddPromotion(promotion1);
promotionService.AddPromotion(promotion2);
///////////////////////
//for (int i = 0; i < 4; i++)
//{
//    cC.Scan(p2);
//}
for (int i = 0; i < 2; i++)
{
    cC.Scan(p1);
}
for (int i = 0; i < 3; i++)
{
    cC.Scan(p3);
}
for (int i = 0; i < 4; i++)
{
    cC.Scan(p1);
}
cC.sale.PrintReceipt();
Console.Read();

