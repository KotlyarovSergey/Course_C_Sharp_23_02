// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string ConvertBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
int n = int.Parse(Console.ReadLine()!);
string ResultEnd = ConvertBin(n);
Console.WriteLine(ResultEnd);