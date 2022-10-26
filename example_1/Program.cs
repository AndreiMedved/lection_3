// Виды методов

// 1 (ничего не принимает и ничего не возвращает)
void ExampleFirst()
{
Console.WriteLine("Hello, World!");
}
ExampleFirst(); // вызов 1 вида методов 

// 2 (Принимаеет переменные, но ничего не возвращает)
void ExampleSecond(string print)
{
    Console.WriteLine(print);
}
ExampleSecond("check it"); // вызов 2 вида методов 

// 3 (Ничего не принимает, но возвращает результат)
int ExampleThird()
{
return DateTime.Now.Year;
}
Console.WriteLine(ExampleThird()); // вызов 3 вида методов 

// 4 (Принимает аргументы и возвращает результат)
string ExampleFour(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + " " + text;
        i++;
    }
    return result;
}
Console.WriteLine(ExampleFour(3, "hoy"));