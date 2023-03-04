 // Проверяет на "палиндромность" любое! целое число
 
 
 // считает количество цифр в числе
int DigitCount(long number)
{
    int digitCount = 0;
    while(number > 0) 
    {
        number /= 10;
        digitCount++;
    }
    return digitCount;
}

// выдает 10 в степени pow
long PowerOfTen(int pow)
{
    long rezult = 1;
    int i = 0;
    while (i < pow)
    {
        rezult *= 10;
        i++;
    }
    return rezult;
}
 
 
 bool IsPalindrom(long number)
 {
    int digitQuantity = DigitCount(number); // количество цифр в числе
    int i = 0;              // счетчик
    int leftDigit = 0;      // левая цифра
    int rightDigit = 0;     // праввая цифра
    
    // перебираем попарно поочередно до середины числа
    while(i < digitQuantity / 2)
    {
        leftDigit = (int)(number / PowerOfTen(digitQuantity - i - 1) % 10);     // левая цифра
        rightDigit = (int)(number / PowerOfTen(i) % 10);        // првая цифра
        // сравниваем их
        if (leftDigit != rightDigit)
            return false;
        i++;
    }
    // если не вышлли по несовпадению, выдаем полжительный результат
    return true;
 }



//int n = 123456;
//int n = 2147483647;     //int.MaxValue
//long n = (long)int.MaxValue * 2 + 630000000;
//long n = 121;
//long n = 12459813731895421;
long n = 12409813731890421;

if (IsPalindrom(n))
    Console.WriteLine($"{n} это палиндром");
else
    Console.WriteLine($"{n} не палиндром");

n = 12459813731695421;
if (IsPalindrom(n))
    Console.WriteLine($"{n} это палиндром");
else
    Console.WriteLine($"{n} не палиндром");

n = 121;

if (IsPalindrom(n))
    Console.WriteLine($"{n} это палиндром");
else
    Console.WriteLine($"{n} не палиндром");

n = 44;
if (IsPalindrom(n))
    Console.WriteLine($"{n} это палиндром");
else
    Console.WriteLine($"{n} не палиндром");


n = 45;
if (IsPalindrom(n))
    Console.WriteLine($"{n} это палиндром");
else
    Console.WriteLine($"{n} не палиндром");
