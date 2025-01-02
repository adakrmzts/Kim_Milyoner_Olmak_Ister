

int score = 0;
Console.WriteLine("Kızınca Tüküren Hayvan Hangisidir?");
Console.WriteLine("A)Lama_____B)Deve_____");
string cevap = Console.ReadLine().ToUpper();

    if (cevap == "A")

    score++;
else
Console.WriteLine("Tek şansınız kaldı.Eğer bir sonraki soruya da yanlış cevap verirseniz eleneceksiniz.");
Console.WriteLine("Dünya'ya en yakın gezegen hangisidir?");
Console.WriteLine("A)Venüs_____B)Mars_____");
string cevap2 = Console.ReadLine().ToUpper();

if (cevap2 == "A")
    score++;

if (score >= 1)
{
    Console.WriteLine("Sonraki soruya geçebiliriz.");
}
else
{
    Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
    return;
}



    Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
    Console.WriteLine("A)7_____B)12_____");
string cevap3 = Console.ReadLine().ToUpper();

if (cevap3 == "A")
    Console.WriteLine("Yanlış cevap verdiniz.");

else

    Console.WriteLine("3. soruya doğru cevap verdiniz. 1 MİLYON KAZANDINIZ! ");
    




