int nylonForMeter = int.Parse(Console.ReadLine());
double paintForLitres = double.Parse(Console.ReadLine());
int thinnerForLitres = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());


double priceNylon = (nylonForMeter + 2) * 1.50;
double priceLitres = (paintForLitres * 1.1) * 14.50;
double priceThinner = thinnerForLitres * 5.00;


double allSumForMaterials = priceNylon + priceLitres + priceThinner + 0.40;
double priceForWork = (allSumForMaterials * 0.3)* workHours;

Console.WriteLine(allSumForMaterials + priceForWork);
