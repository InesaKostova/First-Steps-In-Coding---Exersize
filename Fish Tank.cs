int duljinaSm = int.Parse(Console.ReadLine());
int shirinaSm = int.Parse(Console.ReadLine());
int visochinaSm = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());

double obemAkva = duljinaSm * shirinaSm * visochinaSm;
double obemAkvaLitri = obemAkva / 1000;
double nujnaVodaZapulvane = obemAkvaLitri * (1- (procent / 100));

Console.WriteLine(nujnaVodaZapulvane);


