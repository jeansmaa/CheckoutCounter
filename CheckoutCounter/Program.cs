// See https://aka.ms/new-console-template for more information

using CheckoutCounter.Models;

CheckoutCounter.Services.CC_CheckOutService cC =
    new CheckoutCounter.Services.CC_CheckOutService();
/////////////////
CheckoutCounter.Models.CC_Product p1=new CheckoutCounter.Models.CC_Product();
p1.Name = "Talco AAA";
p1.UnitPrice = 25.54m;
p1.Code = "21A";
cC.Scan(p1);

CheckoutCounter.Models.CC_Product p5 = new CheckoutCounter.Models.CC_Product();
p5.Name = "Harina";
p5.UnitPrice = 60;
p5.Code = "55QW";
p5.Weight = 10;
p5.SoldBy = SoldBy.Bybulk;
cC.Scan(p5);

CheckoutCounter.Models.CC_Product p3 = new CheckoutCounter.Models.CC_Product();
p3.Name = "Pasta NMV";
p3.UnitPrice = 33;
p3.Code = "Y5A";
cC.Scan(p3);
CheckoutCounter.Models.CC_Product p2 = new CheckoutCounter.Models.CC_Product();
p2.Name = "Talco AAA";
p2.UnitPrice = 25.54m;
p2.Code = "21A";
cC.Scan(p2);
CheckoutCounter.Models.CC_Product p4 = new CheckoutCounter.Models.CC_Product();
p4.Name = "Harina";
p4.UnitPrice = 60;
p4.Code = "55QW";
p4.Weight = 10;
p4.SoldBy = SoldBy.Bybulk;
cC.Scan(p4);

cC.sale.PrintReceipt();
//Console.WriteLine("Hello, World!");
