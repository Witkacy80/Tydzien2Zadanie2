// ex1 Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.

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

// ex2 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.

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

// ex3 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.

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

// ex4 Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.

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

// ex5 Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.

double yearOfBirth;
Console.WriteLine("Podaj rok urodzenia");

double.TryParse(Console.ReadLine(), out yearOfBirth);

double age = 2023 - yearOfBirth;

if (age >= 21 && age <30)
{
    Console.WriteLine("Możesz zostać posłem");
}

else if (age >= 30 && age < 35)
{
    Console.WriteLine("Możesz zostać premierem");
}

else if (age >=35 && age < 40)
{
    Console.WriteLine("Możesz zostać senatorem");
}
else if (age <= 40)
{
    Console.WriteLine("Możesz zostać prezydentem");
}
else
{
    Console.WriteLine("Musisz jeszcze podrosnąć");
}

// ex6 Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.

double height;
Console.WriteLine("Podaj swój wzrost w cm");

double.TryParse(Console.ReadLine(), out height);
if (height > 0)
{
    if (height >= 200)
    {
        Console.WriteLine("Jesteś gigantem");
    }
    else if (height >= 180)
    {
        Console.WriteLine("Jesteś drzewcem");
    }
    else if (height >= 160)
    {
        Console.WriteLine("Jesteś człowiekiem");
    }
    else if (height >= 140)
    {
        Console.WriteLine("Jesteś krasnoludem");
    }
    else if (height >= 120)
    {
        Console.WriteLine("Jesteś niziołkiem");
    }
    else if (height >= 100)
    {
        Console.WriteLine("Jesteś dzieckiem");
    }
}
else
{
    Console.WriteLine("Podaj wartość większą od 0");
}

// ex7 Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa


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

// ex8 Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów: 
//Wynik z Matury z matematyki powyżej 70 
//Wynik z fizyki powyżej 55 
//Wynik z chemii powyżej 45 
//Łączny wynik z 3 przedmiotów powyżej 180 
//Albo 
//Wynik z matematyki i jednego przedmiotu powyżej 150

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


// ex9 Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach

double temp;

Console.WriteLine("Podaj aktualną temperaturę");
double.TryParse(Console.ReadLine(), out temp);



 if (temp >= 40)
{
    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
}

else if (temp >= 30)
{
    Console.WriteLine("Zaczyna być słabo, bo gorąco");
}

else if (temp >= 20)
{
    Console.WriteLine("W sam raz");
}

else if (temp >= 10 )
{
    Console.WriteLine("Chłodno");
}

else if (temp >= 0)
{
    Console.WriteLine("Zimno");
}

else
{
    Console.WriteLine("CHolernie piździ");
}

// ex10 Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt

double side1;
double side2;
double side3;

Console.WriteLine("Podaj długość pierwszego boku trójkąta");
double.TryParse(Console.ReadLine(), out side1);

Console.WriteLine("Podaj długość drugiego boku trójkąta");
double.TryParse(Console.ReadLine(), out side2);

Console.WriteLine("Podaj długość trzeciego boku trójkąta");
double.TryParse(Console.ReadLine(), out side3);

if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
{
    Console.WriteLine("Mozna zbudowac trójkąt");
}
else
{
    Console.WriteLine("Nie można zbudować trójkąta");
}
    

// ex11 Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:

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

// ex12 Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę

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

// ex13 Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem


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
        if (b != 0)
        {
            double dzielenie = a / b;
            Console.WriteLine($"Twój wynik to {dzielenie}");
        }
        else
        {
            Console.WriteLine("Nie można dzielić przez 0");
        }
        break;

    default:
        Console.WriteLine("Wybrano niepoprawny numer akcji");
        break;
}

