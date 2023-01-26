﻿// ex1

int var1 = 5;
int var2 = 5;

if (var1 == var2)
{
    Console.WriteLine($"{var1} i {var2} są równe");
}
else
{
    Console.WriteLine($"{var1} i {var2} nie są równe");
}

// ex2

double var3;
Console.WriteLine("Podaj jakąś liczbę");

double.TryParse(Console.ReadLine(), out var3);

if ((var3 % 2) == 0)
{
    Console.WriteLine($"Liczba {var3} jest parzysta");
}
else
{
    Console.WriteLine($"Liczba {var3} jest nie parzysta");
}

// ex3

double var4;
Console.WriteLine("Podaj jakąś liczbę");

double.TryParse(Console.ReadLine(), out var4);

switch (var4)
{
    case >= 0:
        Console.WriteLine($"Liczba {var4} jest dodatnia");
        break;

    case < 0:
        Console.WriteLine($"Liczba {var4} jest ujemna");
        break;
}

// ex4

double year;

Console.WriteLine("Podaj dowolny rok");
double.TryParse(Console.ReadLine(), out year);

if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine($"Rok {year} jest rokiem przestępnym");
}

else
{
    Console.WriteLine($"Rok {year} nie jest rokiem przestępnym");
}

// ex5
double yearOfBirth;
Console.WriteLine("Podaj rok urodzenia");

double.TryParse(Console.ReadLine(), out yearOfBirth);

if (2023 - yearOfBirth >= 21)
{
    Console.WriteLine("Możesz zostać posłem");
}
else
{
    Console.WriteLine("Nie możesz zostać posłem");
}

// ex6
double height;
Console.WriteLine("Podaj swój wzrost w cm");

double.TryParse(Console.ReadLine(), out height);
if (height > 0)
{

    if (height > 0 && height < 140)
    {
        Console.WriteLine("Jesteś niziołkiem");
    }
    else if (height >= 140 && height < 160)
    {
        Console.WriteLine("Jesteś krasnoludem");
    }
    else if (height >= 160 && height < 180)
    {
        Console.WriteLine("Jesteś człowiekiem");
    }
    else if (height >= 160 && height < 180)
    {
        Console.WriteLine("Jesteś człowiekiem");
    }
    else if (height >= 180 && height < 200)
    {
        Console.WriteLine("Jesteś drzewcem");
    }
    else if (height >= 200)
    {
        Console.WriteLine("Jesteś gigantem");
    }
}
else
{
    Console.WriteLine("Podaj wartość większą od 0");
}

// ex7


double var5;
double var6;
double var7;

Console.WriteLine("Podaj pierwszą liczbę");
double.TryParse(Console.ReadLine(), out var5);

Console.WriteLine("Podaj drugą liczbę");
double.TryParse(Console.ReadLine(), out var6);

Console.WriteLine("Podaj trzecią liczbę");
double.TryParse(Console.ReadLine(), out var7);



if (var5 > var6 && var5 > var7)
{
    Console.WriteLine($"Liczba {var5} jest największa z podanych liczb");
}
else if (var6 > var5 && var6 > var7)
{
    Console.WriteLine($"Liczba {var6} jest największa z podanych liczb");
}
else if (var7 > var6 && var7 > var5)
{
    Console.WriteLine($"Liczba {var7} jest największa z podanych liczb");
}

// ex8

double math;
double phisics;
double chemistry;

Console.WriteLine("Podaj wynik z matematyki");
double.TryParse(Console.ReadLine(), out math);

Console.WriteLine("Podaj wynik z fizyki");
double.TryParse(Console.ReadLine(), out phisics);

Console.WriteLine("Podaj wynik z chemii");
double.TryParse(Console.ReadLine(), out chemistry);

if ((math >70 && phisics > 55 && chemistry > 45) && (math + phisics + chemistry) > 180)
{
    Console.WriteLine("Kandydat dopuszczony do studiów");
}
else if (math + phisics > 150 || math + chemistry > 150)
{
    Console.WriteLine("Kandydat dopuszczony do studiów");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do studiów");
}


// ex9

double temp;

Console.WriteLine("Podaj aktualną temperaturę");
double.TryParse(Console.ReadLine(), out temp);

if (temp < 0)
{
    Console.WriteLine("CHolernie piździ");
}
else if (temp >= 0 && temp <=10)
{
    Console.WriteLine("Zimno");
}
else if (temp > 10 && temp <= 20)
{
    Console.WriteLine("Chłodno");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("W sam raz");
}
else if (temp > 30 && temp < 40)
{
    Console.WriteLine("Zaczyna być słabo, bo gorąco");
}
else if (temp >= 40)
{
    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
}


// ex10
double side1;
double side2;
double side3;

Console.WriteLine("Podaj długość pierwszego boku trójkąta");
double.TryParse(Console.ReadLine(), out side1);

Console.WriteLine("Podaj długość drugiego boku trójkąta");
double.TryParse(Console.ReadLine(), out side2);

Console.WriteLine("Podaj długość trzeciego boku trójkąta");
double.TryParse(Console.ReadLine(), out side3);

if ((side1 + side2)>side3 || (side2 + side3)> side1 || (side1 + side3)> side2)
{
    Console.WriteLine("Z podanych boków można zbudować trójkąt");
}
else
{
    Console.WriteLine("Z podanych boków nie można zbudować trójkąt");
}

// ex11

double grade;

Console.WriteLine("Podaj swoją ocenę");
double.TryParse(Console.ReadLine(), out grade);

switch (grade)
{
    case 1:
        Console.WriteLine("Niedostateczny");
        break;

    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;

    default:
        Console.WriteLine("Podano niepoprawną ocenę");
        break;

}

// ex12

double dayOfWeek;

Console.WriteLine("Podaj numer dnia tygodnia");
double.TryParse(Console.ReadLine(), out dayOfWeek);

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;

    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;

    case 7:
        Console.WriteLine("Niedziela");
        break;

    default:
        Console.WriteLine("Podano niepoprawny numer");
        break;

}

// ex13


double a;
double b;
double chosenOption;

Console.WriteLine("Podaj pierwszą liczbę");
double.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Podaj drugą liczbę");
double.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Podaj numer akcji do wykonania:");
Console.WriteLine(" 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");

double.TryParse(Console.ReadLine(), out chosenOption);

switch (chosenOption)
{
    case 1:
        double dodawanie = a + b;
        Console.WriteLine($"Twój wynik to {dodawanie}");
        break;

    case 2:
        double odejmowanie = a - b;
        Console.WriteLine($"Twój wynik to {odejmowanie}");
        break;

    case 3:
        double mnozenie = a * b;
        Console.WriteLine($"Twój wynik to {mnozenie}");
        break;

    case 4:
        double dzielenie = a / b;
        Console.WriteLine($"Twój wynik to {dzielenie}");
        break;

    default:
        Console.WriteLine("Wybrano niepoprawny numer akcji");
        break;

}
