double deposit = double.Parse(Console.ReadLine());
int mounth = int.Parse(Console.ReadLine());
double percentPerYear = double.Parse(Console.ReadLine());

double sum = deposit + mounth * ((deposit * percentPerYear/100) /12);
Console.WriteLine(sum);


