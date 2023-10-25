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
/*
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
*/
/*
long f, f1, f2;
f = f1 = f2 = 1;
int k = int.Parse(Console.ReadLine());
for (int i = 2; i < k; i++)
{
    f = f1 + f2;
    f1 = f2;
    f2 = f;
}
Console.WriteLine(f);
*/
/*
static int F(int k)
{
    if (k == 1 || k == 2)
    {
        return 1;
    } 
    else
    {
        return F(k - 1) + F(k - 2);
    }
}
Console.WriteLine(F(20));

*/
/*
double x = double.Parse(Console.ReadLine());
double y,yo;

y = Math.Pow(x, 1 / 3);
if (x >= 1)
{
    y = x / 3; 
}
else
{
    y = x;
}
do
{
    yo = y;
    y = yo - (1 / 3) * (yo - x / (yo * yo));
} while (Math.Abs(yo - y) > 0.01);
Console.WriteLine(y);
*/

//28.09.2023
/*
Random r = new Random();
int n = 10;
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(-100,100);
    Console.WriteLine(arr[i]);
}
*/
/*
Random r = new Random();
int[] arr = new int[10];
int max = int.MinValue;
int b = int.MinValue;
//int c = false;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(-100,100);
    if (arr[i] > max)
    {
        max = arr[i];
 //       c = true;
 //       if c

    }
}
int count = 0;
for (int i = 0;i < arr.Length;i++)
{
    if (arr[i] == max)
    {
        count += 1;
    }
    if (arr[i] >b && arr[i] != max) { b = arr[i]; }
}
Console.WriteLine($"max = {max} count = {count} предпоследнее макс= {b}");

*/



//#4
/*
Random r = new Random();
int rep_c = 0;
bool exist_repeat = false;
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = r.Next(10);
    for(int j  = 0; j < arr.Length; j++)
    {
        if (arr[j] == arr[i])
        {
            rep_c++;
        }
    }
    if (rep_c > 1) 
    { 
        exist_repeat = true;
    }

    Console.WriteLine(arr[i]);
    rep_c = 0;
}
if (exist_repeat)
{
    Console.WriteLine("Есть повторяющиеся числа");
}
*/

//#5-6

/*
Random r = new Random();
int[] arr = new int[10];
int unic_count = 0,rep_count = 0, c = 0;

//Заполняю массив рандомными значениями
for (int i = 0; i < 10; i++)
{
    arr[i] = r.Next(10);
    Console.WriteLine(arr[i]);
}

//Перебираю числа и счетчиком вычисляю кол-во различных и повторов
for (int i = 0; i < 10; i++)
{
    bool fl = false;
    for (int j = 0; j < i; j++)
    {
        if (arr[i] == arr[j])
        {
            c++;
            fl = true;
            break;
        }
    }
   
    if (!fl)
    {
        unic_count++;
    }
    if(c > 1) { rep_count++; }
    c = 0;
}

Console.WriteLine("Количество различных элементов: " + unic_count);
Console.WriteLine("Количество повторов: " + rep_count);
*/

//04.10.2023

// 1
/*
int[] arr = {5,4,3,2,1};
int count = 0;
for (int i = 2; i < arr.Length; i++)
{
    if (arr[i - 1] < arr[i]) { count++; }
    else if (arr[i - 1] > arr[i]) { count--; }
}
if (count == (arr.Length-1))
{
    Console.WriteLine("Массив упорядочен по возрастающей");
}
else if (count == -(arr.Length-1))
{
    Console.WriteLine("Массив упорядочен по убыванию");
}
else
{
    Console.WriteLine("Массив не упорядочен");
}
*/

//2
/*
Random r = new Random();
int[] arr = new int[10];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(10);
    Console.WriteLine(arr[i]);
}

for (int i = 2;i < arr.Length; i++)
{
    if ((arr[i-2] < arr[i-1]) && (arr[i-1] > arr[i])) {  count++; }
}

Console.WriteLine($"count : {count}");
*/

// 3 
/*
int[] arr = new int[10];
int a = 0, size = 10;
Random r = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = r.Next(10);
    Console.Write(arr[i]  + " ");
}
for (int i = 0; i < size/2; i++)
{
    a = arr[i];
    arr[i] = arr[size - (i+1)];
    arr[size - (i + 1)] = a;
}
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    Console.Write(arr[i] + " ");
}
*/


// 05.10.2023

// 1
/*
Console.WriteLine("--------------------------------------------------");
int N1 = 10;
int[,] matr1 = new int[N1, N1];
Random r = new Random();
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (i == j)
        {
            matr1[i, j] = 1;
        }
        Console.Write($"{matr1[i, j],3} ");
    }
    Console.WriteLine();
}


// 2 

Console.WriteLine("--------------------------------------------------");
int[,] matr2 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (j < i)
        {
            matr2[i, j] = 0;
        }
        else
        {
            matr2[i, j] = j - i + 1;
        }
        Console.Write($"{matr2[i, j]}  ");
    }
    Console.WriteLine();
}


// 3
Console.WriteLine("--------------------------------------------------");

int[,] matr3 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (i < j)
        {
            matr3[i, j] = 0;
        }
        else
        {
            matr3[i, j] = j + 1;
        }
        Console.Write($"{matr3[i, j]}  ");
    }
    Console.WriteLine();
}


// 4
Console.WriteLine("--------------------------------------------------");

int[,] matr4 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        matr4[i, j] = N1 - (i + j);


        Console.Write($"{matr4[i, j],3}  ");
    }
    Console.WriteLine();
}


//5


int[,] matr5 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (i == 0 || j == 0 || i == N1 - 1 || j == N1 - 1)
        {
            matr2[i, j] = 1;
        }
        else
        {
            matr2[i, j] = 0;
        }
        Console.Write($"{matr2[i, j]}  ");
    }
    Console.WriteLine();
}
int summ = 0;
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (i == 0 || j == 0 || i == N1 - 1 || j == N1 - 1)
        {
            summ += matr2[i, j];
        }
    }
}

Console.WriteLine(summ);


// 6

Console.WriteLine("-------------------------------------------------");
int[,] matr6 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if ((i == j) || (i == N1 - j - 1))
        {
            matr3[i, j] = 1;
        }
        else
        {
            matr3[i, j] = 0;
        }
        Console.Write($"{matr3[i, j]}  ");
    }
    Console.WriteLine();
}
int summ2 = 0;
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if ((i == j) || (i == N1 - j - 1))
        {
            summ2 += matr3[i, j];
        }
    }
}
Console.WriteLine(summ2);


// 7
Console.WriteLine("----------------------------------");
int[,] matr7 = new int[N1, N1];
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (((i <= j) && (i <= N1 - j - 1)) || ((i >= j) && (i >= N1 - j - 1)))
        {
            matr4[i, j] = 1;
        }
        else
        {
            matr4[i, j] = 0;
        }
        Console.Write($"{matr4[i, j]}  ");
    }
    Console.WriteLine();
}
int summ3 = 0;
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < N1; j++)
    {
        if (((i <= j) && (i <= N1 - j - 1)) || ((i >= j) && (i >= N1 - j - 1)))
        {
            summ3 += matr4[i, j];
        }
    }
}
Console.WriteLine(summ3);
*/



// 18.10.2023

// Task 1

/*int[] arr = { 1,2,3,4,5 };

static bool Mas(int[] arr)
{
    int count = 0;
    int c = 0;
    for (int i = 2; i < arr.Length; i++)
    {
        if (arr[i - 1] < arr[i]) { count++; }
        else if (arr[i - 1] > arr[i]) { count--; }
        else { c++; }
    }
    if (count + c != (arr.Length - 2) || count + c != -(arr.Length - 2))
    {
        return false;
    }
    else { return true; }
}

Console.WriteLine(Mas(arr));
*/

// 2 
/*
using System.Security.Cryptography;

double[] a = { 2, 2 };
double[] b = { 4, 3 };

static double Scal(double[] a, double[] b)
{
    double res = 0;
    for (int i = 0; i < a.Length; i++)
    {
        res+= a[i] * b[i];
    }
    return res;
}
Console.WriteLine(Scal(a,b));

static double MasAbs(double[] a)
{
    double res = 0;
    for (int i = 0;i < a.Length;i++)
    {
        res += Math.Pow(a[i], 2); 
    }
    return Math.Sqrt(res); 
}
static double Cos(double[] a, double[] b)
{

    double res = Math.Abs(Scal(a,b)) / (MasAbs(a) * MasAbs(b));
    return res;
}

Console.WriteLine(Cos(a,b));

*/

//25.10.2023

//List<> - просто массив

//LinkedList<> - ссылки в разных местах памяти, ссылающиеся друг на друга

List<int> lst = new List<int> ();
Console.WriteLine (lst);












































