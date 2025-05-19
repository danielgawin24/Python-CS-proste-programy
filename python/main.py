def kalkulator():
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Wybierz operację (+, -, *, /): ")

    if op == '+':
        wynik = a + b
    elif op == '-':
        wynik = a - b
    elif op == '*':
        wynik = a * b
    elif op == '/':
        if b != 0:
            wynik = a / b
        else:
            print("Błąd: dzielenie przez zero")
            return
    else:
        print("Nieznana operacja.")
        return

    print("Wynik:", wynik)


def konwerter_temperatur():
    kierunek = input("Wybierz kierunek konwersji (C -> F lub F -> C): ").upper()
    temp = float(input("Podaj temperaturę: "))

    if kierunek == 'C':
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik}°F")
    elif kierunek == 'F':
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik}°C")
    else:
        print("Nieprawidłowy wybór.")


def srednia_ocen():
    n = int(input("Ile ocen chcesz podać? "))
    suma = 0

    for i in range(n):
        ocena = float(input(f"Podaj ocenę {i + 1}: "))
        suma += ocena

    srednia = suma / n
    print(f"Średnia: {srednia:.2f}")
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def main():
    while True:
        print("\nMENU:")
        print("1. Kalkulator")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen")
        print("0. Wyjście")

        wybor = input("Wybierz opcję: ")

        if wybor == '1':
            kalkulator()
        elif wybor == '2':
            konwerter_temperatur()
        elif wybor == '3':
            srednia_ocen()
        elif wybor == '0':
            print("Koniec programu.")
            break
        else:
            print("Nieprawidłowa opcja.")


if __name__ == "__main__":
    main()
