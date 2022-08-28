/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* Сделала универсальную, чтобы обрабатывала любое число */



string MaybePalindrome(string number)
{
    string palindrome = String.Empty;
    int i = 0;
    while (i <= number.Length - i)
    {
        if (number[i] == number[number.Length - i - 1])
        {
            if (i >= number.Length - i - 1)
            {
                palindrome = $"{number} is a palindrome";
            }
            ++i;
        }
        else
        {
            palindrome = $"{number} is not a palindrome";
            break;
        }
    }
    return palindrome;
}

Console.WriteLine("Enter number: ");
string num = Console.ReadLine();
while (num == String.Empty)
{
    Console.WriteLine("Please, enter number: ");
    num = Console.ReadLine();
}

Console.WriteLine(MaybePalindrome(num));
