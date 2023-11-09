// 25.10.2023

/*List<int> lst = new List<int>();
lst.Add(0);
lst.Add(1);
lst.Add(2);
lst.Add(3);
lst.Add(4);
lst.Add(5);
lst.Remove(6); // Удаление по значению
lst.RemoveAt(0); // Удаление по индексу
Console.WriteLine($"Count = {lst.Count} Cap = {lst.Capacity}");
// Count - кол-во элементов, Capacity - вместимомть

foreach (var i in lst)
{
    Console.WriteLine(i );
}*/

/*List<int> lst = new List<int>();
lst.Add(0);
lst.Add(1);
lst.Add(2);
lst.Add(3);
lst.Add(4);
lst.Add(5);
bool IsOrdered(List<int> lst)
{
    for (int i = 0; i < lst.Count; i++)
    {
        if (lst[i] < lst[i+1]) 
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(IsOrdered(lst));*/

//------------------------------------------------------------------------
/*
List<int> lst1 = new List<int> { 1, 3, 3, 5, 6 };
List<int> lst2 = new List<int> { 1, 5, 14, 16 };
static bool IsDistinct(List<int> list) //проверка на уникальность значений списка
{
    if (list != null)
    {
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i - 1] > list[i]) { return false; }
        }
    }
    return true;
}

static bool IsOrdered(List<int> list) // проверка на упорядоченность списка
{
    for (int i = 1; i < list.Count; i++)
    {
        if (list[i - 1] > list[i])
        {
            return false;
        }
    }
    return true;
}

static List<int> U(List<int> l1, List<int> l2) // Метод объединения с сортировкой
{
    int k = 0, l = 0;
    List<int> answer = new List<int>();

    while ((k + l) < (l1.Count + l2.Count))
    {
        if (k != l1.Count && l != l2.Count)
        {
            if (l1[k] < l2[l]) { answer.Add(l1[k]); k++; }
            else { answer.Add(l2[l]); l++; }
        }

        if (k == l1.Count && l != l2.Count) { answer.Add(l2[l++]); }

        if (k != l1.Count && l == l2.Count) { answer.Add(l1[k++]); }

    }
    return answer;
}

static List<int> Intersection(List<int> l1, List<int> l2) //
{
    int k = 0, l = 0;
    List<int> answer = new List<int>();

    while (k  < l1.Count && l < l2.Count)
    {
        if (l1[k] < l2[l])
        {
            k++;
        }

        else if (l1[k] > l2[l])
        {
            l++;
        }   

        else { answer.Add(l1[k]); k++; l++; }
    }

    return answer;
}

static List<int> Substarction(List<int> l1, List<int> l2) // Метод Вычитания
{
    List<int> answer = new List<int>();
    for (int i = 0; i < l1.Count; i++)  // Заполняем новый список значениями первого
    {
        bool flag = true;
        for (int j = 0; j < l2.Count; j++)
        {
            if (l1[i] == l2[j]) { flag = false; break; }
        }

        if (flag) { answer.Add(l1[i]); }
    }

    return answer;
}





// Вызываем метод объединения:
Console.WriteLine("-------------------------------\nОбъединение:");
foreach (var i in U(lst1, lst2)) { Console.WriteLine(i); }

// Вызываем метод пересечения
Console.WriteLine("-------------------------------\nПересечение:");
foreach (var i in Intersection(lst1, lst2)) { Console.WriteLine(i); }


// Вызывыем метод вычитания
Console.WriteLine("-------------------------------\nA/B:");
foreach (var i in Substarction(lst1, lst2)) { Console.WriteLine(i); }

// Вызываем метод обратного вычитания (тот же метод, только меняем местами списки)
Console.WriteLine("-------------------------------\nB/A:");
foreach (var i in Substarction(lst2, lst1)) { Console.WriteLine(i); }

Console.WriteLine($"----------------------\n" +
    $"IsOrdered(lst1) : {IsOrdered(lst1)}\nIsDistinct(lst2) : {IsDistinct(lst2)}\n");
*/


//26.10.2023
/*
string path = "C:\\Users\\Moibaty\\source\\repos\\Task_1\\Lessons\\content.txt"; // Путь к файлу
Dictionary<char, int> freq = new Dictionary<char, int>();

foreach (var str in File.ReadAllLines(path))
{
    var words = str.ToLower().Split(" ");
    foreach (var word in words)
    {
        if (word.Length > 0)
        {
            var ch = word[0];
            if (Char.IsLetter(ch))
            {
                if (freq.Keys.Contains(ch)) { freq[ch]++; }
                else { freq[ch] = 1; }
            }
        }
    }
}
foreach (var i in freq.Keys.Order())
{
    Console.WriteLine($"{i} - {freq[i]}");
}*/

/*
string path = "C:\\Users\\Moibaty\\source\\repos\\Task_1\\Lessons\\content.txt"; // Путь к файлу
Dictionary<string, int> freq = new Dictionary<string, int>();

foreach (var str in File.ReadAllLines(path))
{
    var words = str.ToLower().Split(new char[] { ' ', '.', ',', ':', '-' });
    foreach (var word in words)
    {
        if (word.Length > 0)
        {
            var w = word;
            if (freq.Keys.Contains(w)) { freq[w]++; }
            else { freq[w] = 1; }
            
        }
    }
}
foreach (var i in freq.Keys.Order())
{
    Console.WriteLine($"{i} - {freq[i]}");
}
*/





/*

string path = "C:\\Users\\Moibaty\\source\\repos\\Task_1\\Lessons\\content.txt"; 
static string DecodeMessage(string[] lines)
{
    List<string> answer = new List<string>();

    for (int i = lines.Length - 1; i >= 0; i--)
    {
        string[] words = lines[i].Split(' ');

        for (int k = words.Length - 1; k >= 0; k--)
        {
            if (words[k].Length != 0 && char.IsUpper(words[k][0])) { answer.Add(words[k]); }
        }
    }
    return string.Join(" ", answer);
}
Console.WriteLine(DecodeMessage(File.ReadAllLines(path)));

*/

/*
Console.WriteLine(GetBenfordStatistics("1"));
Console.WriteLine(GetBenfordStatistics("abc"));
Console.WriteLine(GetBenfordStatistics("123 456 789"));
Console.WriteLine(GetBenfordStatistics("abc 123 def 456 gf 789 i"));

static int[] GetBenfordStatistics(string text)
{
    int[] statistics = new int[10];
    string[] input = text.Split(" ");
    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsDigit(input[i][0]))
        {
            int index = (int)input[i][0] - '0';
            statistics[index] += 1;
        }
    }
    return statistics;
}

*/


/*
Random r = new Random();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во отрезков (кол-во пар словаря): ");
int n = int.Parse(Console.ReadLine());
var dict = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    dict[i] = 0;
}

for (int k = 0; k < 10000; k++)
{
    int x = r.Next(a, b);

    for (int i = 0; i < n; i++)
    {
        if (x < (i + 1) * ((b - a) / n) && x >= (i) * ((b - a) / n)) { dict[i]++; }
    }
}

foreach (var i in dict) { Console.WriteLine(i.Key + "\t" + i.Value); }*/



/*long Fibb(int k )
{
    if ( k < 3 ) { return 1; }
    return Fibb(k-2) + Fibb(k-1);
}

void PrintMas(int[] arr, int k)
{
    if (k >= arr.Length) { return; }
    Console.WriteLine(arr[k]);
    PrintMas(arr, k+1);
}

int[] a = new int[] {1,2,3,4,5,6,7};

PrintMas(a, 0);
Console.WriteLine(Fibb(4));*/




/*
static bool IsArrSym(int[] arr, int a, int b)
{
    if (a >= b) { return true; }

    if (arr[a] != arr[b]) { return false; }

    return IsArrSym(arr, a + 1, b - 1);
}

int[] arr = { 1, 2, 3, 2, 1 };


if (IsArrSym(arr, 0, arr.Length - 1))
    Console.WriteLine($"Массив симметричен\n");
else
    Console.WriteLine("Массив несимметричен\n");


static bool IsPalindrom(string str)
{
    str = str.Replace(" ", "").ToUpper();

    return Check(str, 0, str.Length - 1);
}

static bool Check(string str, int a, int b)
{
    if (a >= b) { return true; }

    if (str[a] != str[b]) { return false; }

    return Check(str, a + 1, b - 1);
}


string str = "Казак";

if (IsPalindrom(str))
    Console.WriteLine($"Строка является палиндромом\n");
else
    Console.WriteLine($"Строка не является палиндромом\n");
*/


//08.11.2023 
/*int[,] GenerateMatr(int size)
{
    Random r = new Random();
    int[,] matr = new int[size, size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            matr[i, j] = r.Next(3);
    return matr;
}

void ShowMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3} ");
        Console.WriteLine();
    }
}

int[,] MultMatrix(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) != m2.GetLength(0))
        throw new ArgumentException("Размеры матриц не подходят!");

    var rows = m1.GetLength(0);
    var cols = m2.GetLength(1);
    var l = m1.GetLength(1);
    var res = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            for (int k = 0; k < l; k++)
                res[i, j] += m1[i, k] * m2[k, j];

    return res;
}

int N = 2;
var a = GenerateMatr(N);
var b = GenerateMatr(N);

ShowMatrix(a);
Console.WriteLine("**********************************");
ShowMatrix(b);
Console.WriteLine("**********************************");
ShowMatrix(MultMatrix(a, b));

*/

/*int[] arr = { 661, 662, 663, 664, 665, 666,667,668 };
int F(int[] arr, int x)
{
    int start = 0, end = arr.Length - 1;
    int i;
    while (start <= end)
    {
        i = (start + end) / 2;
        if (arr[i] < x) { start = i + 1; }
        else if (arr[i] > x) { end = i - 1; }
        else return i;
    }
    return -1;
}

Console.WriteLine($"Инндекс искомого элемента = {F(arr,666)}");*/

List<int> list = new List<int> {};

void InsertX(List<int> list, int x)
{
    for (int i = 0; i < list.Count; i++)
    {
        if ((list[i] > x)) { list.Insert(i,x); return; }
    }
    if (list.Count == 0 || list[list.Count-1] < x) { list.Add(x); }
}
Random r = new Random();
for (int i = 0; i < 20; i++) { InsertX(list, r.Next(100)); }
foreach (int x in list) { Console.Write($" {x} "); }

































































































































































