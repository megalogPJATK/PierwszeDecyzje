// zadanie 1

/*

Console.WriteLine("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine()!);

if (liczba % 2 == 0)
{
    Console.WriteLine("Liczba jest parzysta.");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta.");   
}

// zadanie 2

Console.WriteLine("Wybierz kierunek podróży (północ, południe, wschód, zachód): ");
string kierunek = Console.ReadLine()!;

switch (kierunek)
{
    case "północ":
        Console.WriteLine("Wyruszasz w stronę gór.");
    break;

    case "południe":
        Console.WriteLine("Wyruszasz w stronę pustyni.");
    break;

    case "wschód":
        Console.WriteLine("Wyruszasz w stronę lasu.");
    break;

    case "zachód":
        Console.WriteLine("Wyruszasz w stronę morza.");
    break;

    default:
        Console.WriteLine("Nieprawidłowy kierunek");
    break;
}

*/

// zadanie 3

/*

Console.WriteLine("Ile masz lat?: ");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek < 0)
{
    Console.WriteLine("Nieprawidłowy wiek");
}
else if(wiek > 0 && wiek <= 12)
{
    Console.WriteLine("Jesteś dzieckiem.");
}
else if(wiek > 12 && wiek <= 17)
{
    Console.WriteLine("Jesteś osobą nastoletnią.");
}
else if(wiek > 17 && wiek <= 64)
{
    Console.WriteLine("Jesteś osobą dorosłą.");
}
else
{
    Console.WriteLine("Jesteś seniorem.");
}

// zadanie 4

Console.WriteLine("Ile masz punktów życia?: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy posiadasz klucz? (true albo false): ");
bool klucz = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Czy znasz hasło? (true albo false): ");

bool haslo = bool.Parse(Console.ReadLine()!);

bool gotowy = (zycie > 0) && (klucz || haslo);

Console.WriteLine($"Punkty życia: {zycie}");
Console.WriteLine($"Ma klucz: {klucz}");
Console.WriteLine($"Zna hasło: {haslo}");

if(zycie > 0 && gotowy)
{
    Console.WriteLine("Bohater może wejść do lochu.");
}
else if(zycie > 0 && !gotowy)
{
    Console.WriteLine("Bohater nie może wejść do lochu - nie posiada klucza i nie zna hasła.");
}
else if(zycie <= 0)
{
    Console.WriteLine("Bohater nie może wejść do lochu - nie żyje.");
}

*/

//krótkie ćwiczenie 

/*

Console.WriteLine("Ile masz punktów życia?: ");
int zycie = int.Parse(Console.ReadLine()!);

string stan = zycie > 0 ? "żyje" : "nie żyje";

Console.WriteLine(stan);

Console.WriteLine("Ile posiadasz złota?: ");
int zloto = int.Parse(Console.ReadLine()!);

string informacja = zloto >= 30 ? "Możesz kupić miksture" : "Brakuje złota";

Console.WriteLine(informacja);

*/

//zadanie 5

/*

Console.WriteLine("Ile masz punktów życia?: ");
int zycie = int.Parse(Console.ReadLine()!);

if (zycie > 0){

Console.WriteLine("Ile twoja broń zadaje obrażeń?: ");
int obrazenia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy posiadasz miksture leczenia? (true albo false): ");
bool mikstura = bool.Parse(Console.ReadLine()!);

if (zycie < 20)
    {
        Console.WriteLine("Niskie punkty zdrowia.");
    }

Console.WriteLine("Wybierz akcję (1, 2, 3): ");
int opcja = int.Parse(Console.ReadLine()!);


switch (opcja)
{
    case 1:
        Console.WriteLine($"Zadane obrażenia: {obrazenia}");
    break;

    case 2:
        if (mikstura) {
            Console.WriteLine($"Mikstura uleczyła cię 15 punktów zdrowia. Twoje aktualne zdrowie: {zycie += 15}");
        }
        else
        {
            Console.WriteLine("Nie posiadasz mikstury.");
        }
    break;

    case 3:
        Console.WriteLine("Ucieczka skończyła się powodzeniem.");
    break;

    default:
        Console.WriteLine("Nieznana akcja");
    break;
}

}

else
{
    Console.WriteLine("Przegrana.");
}

*/

//zadanie 6

using System.Reflection.Metadata;

Console.WriteLine("Jak się nazywasz? ");
string imie = Console.ReadLine()!;


Console.WriteLine("Ile posiadasz mikstur? ");
int mikstury = int.Parse(Console.ReadLine()!);

Console.WriteLine("Twoje maksymalne punkty życia? ");
double maxZycie = double.Parse(Console.ReadLine()!);

Console.WriteLine("Twoje aktualne punkty zdrowia? ");
int aktualneZycie = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile posiadasz złota? ");
int ileZlota = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy masz mape? (true albo false): ");
bool czyMapa = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Wybierz akcję: ");
Console.WriteLine("1 - Sprawdź stan");
Console.WriteLine("2 - Rozpocznij wyprawę");
Console.WriteLine("3 - przygotuj miksturę");
Console.WriteLine("4 - odpocznij");
int akcja = int.Parse(Console.ReadLine()!);

double procentZycia = (aktualneZycie / maxZycie) * 100;

bool zyje = aktualneZycie > 0;

string gotowa = zyje && czyMapa ? "tak" : "nie";

bool bogata = ileZlota > 100;

bool walka = zyje && mikstury > 0;

bool niskiPoziomZ = zyje && aktualneZycie < 25;

string wybranaAkcja = "";

string stanzycia = "";

if (aktualneZycie > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    stanzycia = "Nie żyje.";
    Console.ResetColor();
}
else if (aktualneZycie < 25)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    stanzycia = "Bohater jest ranny";
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    stanzycia = "Bohater jest w dobrej formie";
    Console.ResetColor();
}

switch (akcja)
{
    case 1:
        wybranaAkcja = $"Stan bohatera: {stanzycia}";
    break;

    case 2:
        wybranaAkcja = "Wyprawa rozpoczęta.";
    break;

    case 3:
        wybranaAkcja = "Mikstura została przygotowana";
        mikstury ++;
        Console.WriteLine($"Posiadane mikstury: {mikstury}");
    break;
    
    case 4:
        wybranaAkcja = "Bohater odpoczywa.";
    break;
    
    default:
        wybranaAkcja = "Nie poprawna akcja";
    break;
}
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.ResetColor();
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {aktualneZycie}/{maxZycie} ({procentZycia:F2}%)");
Console.WriteLine($"Mikstury: {mikstury}");
Console.WriteLine($"Złoto: {ileZlota}");
Console.WriteLine($"Ma mape: {czyMapa}");
Console.WriteLine("+==========================================+");
Console.WriteLine($"Czy żyje: {zyje}");
Console.WriteLine($"Niski poziom zdrowia: {niskiPoziomZ}");
Console.WriteLine($"Może wyruszyć: {gotowa}");
Console.WriteLine($"Jest bogata: {bogata}");
Console.WriteLine($"Gotowa do walki: {walka}");
Console.WriteLine("+==========================================+");
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\n{wybranaAkcja}");
Console.ResetColor();
