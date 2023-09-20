/*
int n, i = 1;
n = int.Parse(Console.ReadLine());

while (i < n)
{
    i *= 3;
}

if (i == n)
{
    Console.WriteLine("Это степень тройки");
}

else
{
    Console.WriteLine("Это не является степенью тройки");
}
*/

//20.09.2023
//#1
/*
int k,f = 1, s = 0;
k = int.Parse(Console.ReadLine());
for (int i = 1;i <= k;i+=1)
{
    f *= i;
    s += f;
}

Console.WriteLine(s);
*/

//#2
/*
double x = double.Parse(Console.ReadLine());
double s = 0;
double m = 1;//x^
double l = 1;
for ( int k = 1; k < 10; k++)
{
    s += m / l;
    m *= x;
    l *= k;
}
Console.WriteLine(s);
Console.WriteLine(Math.Exp(x));
*/











































































































































