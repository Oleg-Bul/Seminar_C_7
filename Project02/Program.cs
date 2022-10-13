// Напишите программу, которая на вход 
// принимает два числа A и B,
//  и возводит число А в целую степень B 
//  с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

int ReadData(string msg)
{
    Console.Write(msg);
     int number = int.Parse(System.Console.ReadLine()??"0");
    return number;
}
int a = ReadData("Ввведите размер число А ");
int b = ReadData("Введите размер число Б ");
int PowAtoB(int a, int b)
{   
    int sum = a;
    for ( int i = 1; i < b;i++)
    {
       sum = a*a;
       b++;
    }return sum;
    
    
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg+value);
}

PrintData(" Число A в степени B равно : ", PowAtoB(a,b));


//https://t.me/VladVin2314
