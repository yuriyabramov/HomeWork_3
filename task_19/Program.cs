//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Например: 14212 -> нет; 12821 -> да.

int num = new Random(). Next (10000, 99999);
string number = num.ToString();



if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
else 
    {
        
        Console.WriteLine($"{number} - НЕ палиндром");
    }





