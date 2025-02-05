int sheetsOfBook = int.Parse(Console.ReadLine());
int sheetsPerHour = int.Parse(Console.ReadLine());
int daysForBook = int.Parse(Console.ReadLine());
//Общо време за четене на книгата: 212 страници / 20 страници за час = 10 часа общо
//Необходимите часове на ден: 10 часа / 2 дни = 5 часа на ден



int hoursForAllBook= sheetsOfBook/sheetsPerHour;
int hoursPerDay= hoursForAllBook / daysForBook;
Console.WriteLine(hoursPerDay);