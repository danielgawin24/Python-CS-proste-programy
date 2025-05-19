using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen");
            Console.WriteLine("0. Wyjście");

            Console.Write("Wybierz opcję: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    Konwerter();
                    break;
                case "3":
                    Srednia();
                    break;
                case "0":
                    Console.WriteLine("Koniec programu.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }

    static void Kalkulator()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        double wynik;

        switch (op)
        {
            case "+":
                wynik = a + b;
                break;
            case "-":
                wynik = a - b;
                break;
            case "*":
                wynik = a * b;
                break;
            case "/":
                if (b != 0)
                    wynik = a / b;
                else
                {
                    Console.WriteLine("Błąd: dzielenie przez zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieznana operacja.");
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }

    static void Konwerter()
    {
        Console.Write("Wybierz kierunek konwersji (C -> F lub F -> C): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik}°C");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór.");
        }
    }

    static void Srednia()
    {
        Console.Write("Ile ocen chcesz podać? ");
        int n = Convert.ToInt32(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Podaj ocenę {i}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}
