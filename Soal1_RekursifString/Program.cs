using System;

class RekursifString
{
static void Main()
    {
        Console.WriteLine("tes soal 1");
        Console.Write("Masukkan string: ");
        string input = Console.ReadLine();


        string hasil = ReverseString(input);
        Console.WriteLine("Hasil: " + hasil);
    }


    static string ReverseString(string text)
    {
        if (text.Length == 0)
            return "";

        return ReverseString(text.Substring(1)) +"_"+ text[0];
    }
}