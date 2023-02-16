//prints out how many times the number can be divided by 2 evenly
using System;



namespace Program;

class RecursionTask{
public static int DividedBy2(double num){

int count = 0;

if (num >0 && num%2 == 0){
    count++;
    num/=2;

    return count += DividedBy2(num);
}
return count;
}

public static void Main (string[] args){

Console.WriteLine("Entrez un entier");
double number = Convert.ToDouble (Console.ReadLine());

int result = DividedBy2(number);

Console.WriteLine($"Le nombre {number} peut etre divisé {result} fois par  2  " );

}

}