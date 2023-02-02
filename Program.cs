/* ДЗ к Семинару 3
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*void Digit ( int number)
{
    int dig =0;
    int des=0;
    int num= number;
    while ( number>= 1)
    {
          des = number%10;
          dig= dig *10 + des;
          number=number/10;
    }
    if (dig==num)
    {
       Console.WriteLine ("да");
    }
    else
    {
        Console.WriteLine ("нет");
    }
}
 Console.WriteLine("Input  number:"); 
int user_number = Convert.ToInt32 (Console.ReadLine());
    if (user_number>9999 && user_number<100000)
{
    Digit (user_number);

}
else
{
   Console.WriteLine ($"Impissible value");
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*double DistanceAB (int xa, int ya, int za, int xb, int yb, int zb)
{
    
    double destaAB = Math.Round( Math.Sqrt(Math.Pow (xb-xa,2)+Math.Pow (yb-ya,2)+Math.Pow (zb-za,2)),2);
    return destaAB;
}
Console.WriteLine("Input  x coordinat of A:"); 
int xAcoord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  y coordinat of A:"); 
int yAcoord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  z coordinat of A:"); 
int zAcoord = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input  x coordinat of B:"); 
int xBcoord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  y coordinat of B:"); 
int yBcoord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  z coordinat of B:"); 
int zBcoord = Convert.ToInt32 (Console.ReadLine());

double distanceAB = DistanceAB (xAcoord,yAcoord,zAcoord,xBcoord,yBcoord,zBcoord);
Console.WriteLine ($"Distance between A & B is {distanceAB}");
/*

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*void Digit (int number)
{
     int current=1;
     while (current <= number)
     {
        int res=current*current*current;
        Console.Write ($"{res}, ");
        current++;
     }
     Console.WriteLine ("\b\b.");
}
Console.WriteLine("Input  number:"); 
int user_number = Convert.ToInt32 (Console.ReadLine());
if (user_number>= 1)
{
    Console.WriteLine ($"{user_number} ->");
    Digit (user_number);
}
else
{
   Console.WriteLine ($"Impissible value");
}



Задачи на Семинаре

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/*void Digit (int number)
{
    if ( number>0 && number<2)
        Console.WriteLine ("x>0; y>0");
    else
        if (number>1 && number<3)
            Console.WriteLine ("x<0;y>0 "); 
        else
        if (number>2 && number<4)
            Console.WriteLine ("x<0;y<0"); 
            else 
            if (number>3 && number<5)
                Console.WriteLine ("x>0;y<0"); 
                if (number<1 && number >4 )
                        Console.WriteLine ("not a quarter");    
}
Console.WriteLine("Input  number:"); 
int user_number = Convert.ToInt32 (Console.ReadLine());
Digit (user_number);*/
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
