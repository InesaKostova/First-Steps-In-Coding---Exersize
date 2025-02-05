int packetsOfPens = int.Parse(Console.ReadLine());
int packetsOfMarkers = int.Parse(Console.ReadLine());
int litres = int.Parse(Console.ReadLine());
int percentOfDiscount = int.Parse(Console.ReadLine());

double priceOfPens = packetsOfPens * 5.80;
double priceOfMarkers = packetsOfMarkers * 7.20;
double priceForLitres = litres * 1.20;

double priceForAll = priceOfPens + priceOfMarkers + priceForLitres;

double finalPrice = priceForAll - ((priceForAll * percentOfDiscount)/100);
Console.WriteLine(finalPrice);