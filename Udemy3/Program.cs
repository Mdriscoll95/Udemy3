﻿namespace Udemy3;

class Program
{
    static void Main(string[] args)
    {
        string myString = "15";
        string mySecondString = "13";
        string result = myString + mySecondString;
        int num1 = Int32.Parse(myString);
        int num2 = Int32.Parse(mySecondString);
        int resultInt = num1 + num2;
        Console.WriteLine(resultInt);
        Console.Read();
    }
}

