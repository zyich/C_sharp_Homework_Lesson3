
int GetFirstNum (int num)
{
    int result = (num- num%10000) / 10000;
    return result;
}
int GetSecondNum (int num)
{
    int result = (num%10000 - num%1000) /1000 ;
    return result;
}
int GetFourthNum (int num)
{
    int result = (num%100 - num%10) / 10;
    return result;
}
int GetFifthNum (int num)
{
    int result = num%10;
    return result;
}

Console.WriteLine("inpun 5 digit number :");
int num = Convert.ToInt32(Console.ReadLine());

bool CheckPalindrom = GetFirstNum(num) == GetFifthNum(num) & GetSecondNum(num) == GetFourthNum(num); 
    if (CheckPalindrom)
    {
        Console.WriteLine($"{num}  = palindrom");
    }
    else
    {
        Console.WriteLine($"{num}  ne palindrom");
    }
  

  /* Верхнее сделал сам , а нижнее мне сгенерила нейросеть, 
    хотя можно было и самому догадаться ,
    было бы побольше свободного времени ... 
    прикрепил себе на будущее.   
*/

  using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input a string:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}