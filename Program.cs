using System;

public class Napovednik
{
    public static void Main(string[] args)
    {
        // toto jsou základní používané datové typy v C# (tedy proměnné)
        // int ukládá celá čísla
        int CeleCislo = 1;
        // double ukládá reálná čísla
        double RealneCislo = 1.5;
        // char ukládá jednotlivé znaky, musí být mezi jednoduchými uvozovkami
        char Pismeno = 'A';
        // string ukládá textové řetězce (tedy text) musí být mezi dvojitými uvozovkami
        string Text = "Toto je ukázkový text v C#.";
        // bool (také boolean) ukládá logické hodnoty, tedy true nebo false
        bool TrueStatement = true;
        bool FalseStatement = false;
        // matematické operace prostě používají normální symboly, jako všude +, -, *, /
        double Vysledek = CeleCislo + RealneCislo; // sčítání
        // dělení se zbytek, kdy je zobrazen zbytek se nazývá modulo a používá se symbol %
        int Zbytek = 10 % 3; // výsledek je 1
        // incrementace a dekrementace, tedy přičtení nebo odečtení jedničky
        int CisloProIncrementaci = 5;
        CisloProIncrementaci++; // nyní je CisloProIncrementaci 6
        int CisloProDekrementaci = 5;
        CisloProDekrementaci--; // nyní je CisloProDekrementaci 4

        // exstuje pre a post inkrementace a dekrementace
        // pre inkrementace/dekrementace znamená, že se hodnota změní před použitím
        // post inkrementace/dekrementace znamená, že se hodnota změní až po použití

        // artimetické zkratky aka složený operátory
        // +=, -=, *=, /=, %=
        // zapisováno:
        // int zkratka = 4;
        // zkratka += 3; // proměnná "zkratka" je nyní 7 (4 + 3)

        //komparační operátory
        // ==, !=, <, >, <=, >=
        // taky jako v normání matice

        // logické operátory
        // && - and, || - or, ! - not (negace)

        // else && if
        // existuje i else if

        // switch statement funguje jako více větví if-else if-else
        int month = 37;
        string season = "jestli tohle vidíš, tak se něco posralo.";
        switch (month)
            {
                case 12: 
                case 1:
                case 2:
                    season = "Winter";
                break; // důležitý, jinak to bude pokračovat dál

                case 3:
                case 4:
                case 5:
                    season = "Spring";
                break;

                case 6:
                case 7:
                case 8:
                    season = "Summer";
                break;

                case 9:
                case 10:
                case 11:
                    season = "Fall";
                break;

                default: // pokud nepadne žádný case, provede se default
                    season = "Debile, blbá hodnta";
                break;
            }
        // ternary conditional operator
        // zkrácená verze if-else pro přiřazení hodnoty
        // syntaxe: (podmínka) ? hodnota pokud true : hodnota pokud false
        int age = 20;
        string eligibility = (age >= 18) ? "Můžeš hlasovat." : "Nemůžeš hlasovat.";
        // lze je i nestovat
        int score = 67;
        string grade = (score >= 90) ? "A" :
                       (score >= 80) ? "B" :
                       (score >= 70) ? "C" :
                       (score >= 60) ? "D" : "F";

        /*
        Výpis hodnot na obrazovku pomocí Console.WriteLine (do konzole)
        S tím, že pokud vložíme text do uvozovek, vypíše se přesně ten text.
        Pokud chceme vypsat hodnotu nějaké proměnné, musíme ji zapsat mimo uvozovky.
        */
        Console.WriteLine("Ahoj!");
        Console.WriteLine("Tohle je ukázka pro variable INT: " + CeleCislo);
        Console.WriteLine("Tohle je ukázka pro variable DOUBLE: " + RealneCislo);
        Console.WriteLine("Tohle je ukázka pro variable CHAR: " + Pismeno);
        Console.WriteLine("Tohle je ukázka pro variable STRING: " + Text);
        Console.WriteLine("Tohle je ukázka pro variable BOOL (true): " + TrueStatement);
        Console.WriteLine("Tohle je ukázka pro variable BOOL (false): " + FalseStatement);
        Console.WriteLine("Výsledek sčítání INT + DOUBLE je: " + Vysledek);
        Console.WriteLine("Zbytek po dělení 10 % 3 je: " + Zbytek);
        Console.WriteLine("Hodnota po incrementaci je: " + CisloProIncrementaci);
        Console.WriteLine("Hodnota po dekrementaci je: " + CisloProDekrementaci);
        Console.WriteLine("Aktuální měsíc je: " + month + ", roční období je: " + season);
       
       // interpolace řetězců pomocí $ což znamená, že můžeme v řetězci používat {} do kterých můžeme vložit proměnné nebo výrazy
        Console.WriteLine($"Věk: {age}, Oprávnění: {eligibility}");
        Console.WriteLine($"Skóre: {score}, Známka: {grade}"); // ještě kombinováno s ternárním operátorem

        // čtení inputu od uživatele, fungje to pomocí Console.ReadLine(), ale je to vždy string, takže je potřeba převést na jiný datový typ pokud chceme něco jiného
        Console.WriteLine("Zadej své jméno:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Ahoj, {userName}!");

        // Parsování inputu na int (lze i s double. string, char a ostatními datovými typy)
        Console.WriteLine("Zadej své oblíbené číslo:");
        string favoriteNumberInput = Console.ReadLine();
        int favoriteNumber = int.Parse(favoriteNumberInput);
        Console.WriteLine($"Tvé oblíbené číslo je: {favoriteNumber}");

        // String.Format metoda pro formátování řetězců
        // například chci, aby to zobrazovalo číslo s dvěma desetinnými místy
        double pi = 3.14159265359;
        string formattedPi = String.Format("Hodnota π na dvě desetinná místa je: {0:F2}", pi);
        Console.WriteLine(formattedPi);
        //nebo!
        Console.WriteLine($"Hodnota π na dvě desetinná místa je: {pi:F2} jen je to v kódu napsáno přímo :)");

        // for loop
        // syntaxe: for (počáteční hodnota; podmínka; inkrementace/dekrementace) { kód k vykonání }
        for (int i = 0; i < 3; i ++)
        {
            Console.WriteLine($"Toto je řádek číslo {i} z for loop.");
        }

        // while loop
        // syntaxe: while (podmínka) { kód k vykonání }
        // kód, kde se jedno číslo dělí, dokud není menší neno rovno 3
        double xy = 67;
        while (xy >= 3)
        {
            xy /= 2;
        }
        Console.WriteLine($"Hodnota xy po while loop je: {xy}");

        // do while loop
        // syntaxe: do { kód k vykonání } while (podmínka);
        // nejdříve se vykoná kód a pak se zkontroluje podmínka
        int sum = 0;
        int num = 1;
        do
        {
            sum += num;
            num += 2;
            Console.WriteLine(sum);
            Console.WriteLine(num);
        } while (sum <= 20);

        // break
        // používá se k přerušení smyčky nebo switch statementu
        for (int j = 0; j < 10; j++)
        {
            if (j == 5)
            {
                Console.WriteLine("Přerušení smyčky na j = 5");
                break;
            }
            Console.WriteLine($"Hodnota j je: {j}");
        }

        // continue
        // používá se k přeskočení aktuální iterace smyčky a pokračování
        for (int k = 0; k < 10; k++)
        {
            if (k % 2 != 0)
            {
                continue; // přeskočí lichá čísla
            }
            Console.WriteLine($"Sudé číslo: {k}");
        }
    }
}