// Цикл в цикле
/*
for(int a = 2; a <= 10; a++)
{
    for(int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{a} x {b} = {a*b}");
    }
    Console.WriteLine();
}
*/

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string a = "Да, были люди в наше время, Не то, что нынешнее племя: Богатыри — не вы! Плохая им досталась доля: Немногие вернулись с поля… Не будь на то господня воля, Не отдали б Москвы!";
string newText = Replace(a, ' ', '|');
Console.WriteLine(newText);

