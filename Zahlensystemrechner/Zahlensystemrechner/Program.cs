using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hier Können sie Zahlen in andere Zahlensysteme Umwandeln\n");
        Console.Write("Bitte geben Sie das Ausgangszahlensystem ein (Binär (2), Oktal (8), Dezimal (10), Hexadezimal (16): ");
        int ausgangsZahlensystem = int.Parse(Console.ReadLine());
        Console.Write("Bitte geben Sie das Zielzahlensystem ein (Binär (2), Oktal (8), Dezimal (10), Hexadezimal (16): ");
        int zielZahlensystem = int.Parse(Console.ReadLine());
        Console.Write("Bitte geben Sie die Zahl ein, welche Sie umwandeln möchten: ");
        string zahl = Console.ReadLine();
        string ergebnis = Umwandeln(ausgangsZahlensystem, zielZahlensystem, zahl);
        Console.WriteLine("\nDie Zahl lautet im Zielzahlensystem: " + ergebnis);
    }
    

    public static string Umwandeln(int ausgangsZahlensystem, int zielZahlensystem, string zahl)
    {
        int dezimal = 0;
        if (ausgangsZahlensystem == 2)
        {
            dezimal = BinärZuDezimal(zahl); 
        }
        else if (ausgangsZahlensystem == 8)
        {
            dezimal = OktalZuDezimal(zahl);
        }
        else if (ausgangsZahlensystem == 10)
        {
            dezimal = int.Parse(zahl);
        }
        else if (ausgangsZahlensystem == 16)
        {
            dezimal = HexadezimalZuDezimal(zahl);
        }

        string ergebnis = "";
        if (zielZahlensystem == 2)
        {
            ergebnis = DezimalZuBinär(dezimal);
        }
        else if (zielZahlensystem == 8)
        {
            ergebnis = DezimalZuOktal(dezimal);
        }
        else if (zielZahlensystem == 10)
        {
            ergebnis = dezimal.ToString();
        }
        else if (zielZahlensystem == 16)
        {
            ergebnis = DezimalZuHexadezimal(dezimal);
        }

        return ergebnis;
    }
   

    public static int BinärZuDezimal(string binär)
    {
        int dezimal = 0;
        int zahl = 1;

        for (int i = binär.Length - 1; i >= 0; i--)
        {
            if (binär[i] == '1')
            {
                dezimal += zahl;
            }
            zahl *= 2;
        }

        return dezimal;
    }


    public static int OktalZuDezimal(string oktal)
    {
        int dezimal = 0;
        int zahl = 1;

        for (int i = oktal.Length - 1; i >= 0; i--)
        {
            dezimal += int.Parse(oktal[i].ToString()) * zahl;
            zahl *= 8;
        }

        return dezimal;
    }


    public static int HexadezimalZuDezimal(string hexadezimal)
    {
        int dezimal = 0;
        int zahl = 1;

        for (int i = hexadezimal.Length - 1; i >= 0; i--)
        {
            string hexZahl = hexadezimal[i].ToString();
            if (hexZahl == "A")
            {
                dezimal += 10 * zahl;
            }
            else if (hexZahl == "B")
            {
                dezimal += 11 * zahl;
            }
            else if (hexZahl == "C")
            {
                dezimal += 12 * zahl;
            }
            else if (hexZahl == "D")
            {
                dezimal += 13 * zahl;
            }
            else if (hexZahl == "E")
            {
                dezimal += 14 * zahl;
            }
            else if (hexZahl == "F")
            {
                dezimal += 15 * zahl;
            }
            else
            {
                dezimal += int.Parse(hexZahl) * zahl;
            }
            zahl *= 16;
        }

        return dezimal;
    }


    public static string DezimalZuBinär(int dezimal)
    {
        string binär = "";
        int rest = 0;

        while (dezimal > 0)
        {
            rest = dezimal % 2;
            dezimal /= 2;
            binär = rest + binär;
        }

        return binär;
    }


    public static string DezimalZuOktal(int dezimal)
    {
        string oktal = "";
        int rest = 0;

        while (dezimal > 0)
        {
            rest = dezimal % 8;
            dezimal /= 8;
            oktal = rest + oktal;
        }

        return oktal;
    }


    public static string DezimalZuHexadezimal(int dezimal)
    {
        string hexadezimal = "";
        int rest = 0;

        while (dezimal > 0)
        {
            rest = dezimal % 16;
            dezimal /= 16;
            if (rest == 10)
            {
                hexadezimal = "A" + hexadezimal;
            }
            else if (rest == 11)
            {
                hexadezimal = "B" + hexadezimal;
            }
            else if (rest == 12)
            {
                hexadezimal = "C" + hexadezimal;
            }
            else if (rest == 13)
            {
                hexadezimal = "D" + hexadezimal;
            }
            else if (rest == 14)
            {
                hexadezimal = "E" + hexadezimal;
            }
            else if (rest == 15)
            {
                hexadezimal = "F" + hexadezimal;
            }
            else
            {
                hexadezimal = rest + hexadezimal;
            }
        }

        return hexadezimal;
    }
}
