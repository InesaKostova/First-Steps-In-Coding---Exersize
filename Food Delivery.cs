int chikenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int veganMenu = int.Parse(Console.ReadLine());

double priceChikenMenu = chikenMenu * 10.35;
double priceFishMenu = fishMenu * 12.40;
double priceVeganMenu = veganMenu * 8.15;

double fullPriceMenus = priceChikenMenu + priceFishMenu + priceVeganMenu;
double priceDesert = fullPriceMenus * 0.2;
Console.WriteLine(fullPriceMenus + priceDesert + 2.50);