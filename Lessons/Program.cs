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














































































































































































































































