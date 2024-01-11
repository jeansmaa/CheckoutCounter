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
p1.Code = "21A";


CheckoutCounter.Models.CC_Product p2 = new CheckoutCounter.Models.CC_Product();
p2.Name = "Harina";
p2.UnitPrice = 60;
p2.Code = "55QW";
p2.Weight = 10;
p2.SoldBy = SoldBy.Bybulk;


CheckoutCounter.Models.CC_Product p3 = new CheckoutCounter.Models.CC_Product();
p3.Name = "Pasta NMV";
p3.UnitPrice = 33;
p3.Code = "Y5A";

////////////////////////
CC_Promotion promotion = new CC_Promotion(p1,PromotionType.BuyOneGetOne);
promotionService.AddPromotion(promotion);
///////////////////////
for (int i = 0; i < 102; i++)
{
    cC.Scan(p1);
}

//cC.Scan(p4);
cC.Scan(p2);
cC.Scan(p2);
cC.Scan(p3);
cC.Scan(p3);
//cC.Scan(p5);
//cC.Scan(p6);
//cC.Scan(p7);
cC.sale.PrintReceipt();

