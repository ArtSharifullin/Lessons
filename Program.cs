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

double eps = 0.0001; 
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

//21/09/2023
/*
int s = 0;
int count = 0;
int k = int.Parse(Console.ReadLine());

for (int a = 1; a <= 9;a++)
{
    for (int b = 0; b <= 9;b++)
    {
        for (int c = 0; c <= 9;c++)
        {
            s = a + b + c;
            if (s == k)
            {
                count++;
            }
        }
    }
}


Console.WriteLine(count);


int s1 = 0;
int s2 = 0;
int s3 = 0;
for(int a = 0; a<=9;a++)
{
    for (int b = 0; b<=9;b++)
    {
        for (int c = 0; c<=9;c++)
        {
            for(int d = 0; d<=9;d++)
            {
                for (int e = 0; e<=9;e++) 
                {
                    for (int f = 0; f<=9;f++)
                    {
                        if (a + b + c == d+ e + f)
                        {
                            s1++;
                        }
                        if (a + c + e == b+d+f)
                        {
                            s2++;
                        }
                        if ((a + b + c == d + e + f) && (a + c + e == b + d + f))
                        {
                            s3++;
                        }
                    }
                }
            }
        }
    }
}


Console.WriteLine($"Счастливый билет по 1-ому способу - {s1}\nСчастливый билет по 2-ому способу - {s2}\nСчастливый билет по 3-eму способу - {s3}");


*/
//Задание пятиминутки
double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
if ((x>=0 && x <=1) && (y >=x-1 && y <= -x +1))
{
    Console.WriteLine("Точка попала в область");
}
else if ((x <=0 && x >= -1) && (y >=-1 && y <= 1) && (Math.Pow(x,2) + Math.Pow(y,2) >= 1))
{
    Console.WriteLine("Точка попала в область");
}
else
{
    Console.WriteLine("Точка не попала в область");
}
























































































































