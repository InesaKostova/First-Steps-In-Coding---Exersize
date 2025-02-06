int priceForYear = int.Parse(Console.ReadLine());

double shoes =0.6 * priceForYear ;
double basketSet =0.8 *  shoes;
double ball = basketSet * 0.25;
double acsessories = ball * 0.2;

double fullPriceForAll = shoes + basketSet + ball + acsessories + priceForYear;
Console.WriteLine(fullPriceForAll);

