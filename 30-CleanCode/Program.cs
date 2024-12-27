// Clean Code

#region Isimlendirme
// 1- isimlendirme
// degisken ve metot isimleri kısa ve anlamli olmalidir

int a = 10; // kotu
int ogrenciSayisi = 10; // iyi
#endregion

#region MetotUzunlugu

// 2- Metot Uzunlugu 

// Metotlari olabildigince kisa tut. Birinci sorumluluk uzerine odaklanin. Bir metodun bir seyi yapmasi her zaman iyi olandir.

#endregion

#region Yorumlar

// 3- Yorumlar

// Kodun hedefine odalanan yorumlar yazin.

#endregion

#region Bosluk Kullanimi

// Kotu

for (int k = 0; k < 10; k++)
{
    Console.WriteLine(k);
}

// Iyi
for (int k = 0; k < 10; k++)
{
    Console.WriteLine(k);
}
#endregion

#region Hata Yonetimi

// Kotu

try
{
    // istisna firlatilacak kodlarimiz
}
catch (Exception)
{
    // Ozel bir islem olmadan tum istisnalari yakalamak.
}

// Iyi

try
{
    // Sadece hata olabilme ihtimali olan kodlar,
}
catch (OverflowException ex)
{
    // Belirli durumlarda hata firlat
}
catch (DivideByZeroException ex)
{
    // Belirli durumlarda hata firlat
}
#endregion

#region Best Practies
int sayi, sayac = 0, maksimumSayi = 0, ciftMaksimumSayi = 0;

bool sayiMi = KullanicidanSayiAl(out sayi);

bool KullanicidanSayiAl(out int sayi)
{
    Console.WriteLine("Lutfen pozitif bir sayi giriniz : ");
    return int.TryParse(Console.ReadLine(), out sayi);

    if (sayiMi && sayi >= 0 && sayi != 1)
    {
        DegerleriBul(out ciftMaksimumSayi, out maksimumSayi, sayi, out sayac);
        DegerleriEkranaYaz(maksimumSayi, ciftMaksimumSayi, sayac);
    }
    else if (sayiMi == false)
        Console.WriteLine("Girilen deger bir sayi degildir.");
    else if (sayi < 0)
        Console.WriteLine("Sayi Negatif");
    else if (sayi == 1)
        Console.WriteLine("Sayiyi 1 girdiniz");
}
void DegerleriEkranaYaz(int maksimumSayi, int ciftMaksimumSayi, int sayac)
{
    Console.WriteLine("Bu islem sirasinda ulasilan maksimum sayi : {0}", maksimumSayi);
    // sonrada ss alinan kodu buraya yaz.

}
void DegerleriBul(out int ciftMaksimumSayi, out int maksimumSayi, int sayi, out int sayac)
{
    ciftMaksimumSayi = maksimumSayi = sayac = 0;

    while (sayi >= 2)
    {
        sayac++;

        if (sayi % 2 == 0)
        {
            sayi = (sayi * 3) + 1;
            sayac++;
            ciftMaksimumSayi = 0;
        }

        // kosul dogrultusunda atama operasyonu yapicaksaniz TernaryIf kullanin.

        ciftMaksimumSayi = ciftMaksimumSayi < sayi ? sayi : ciftMaksimumSayi;
        sayi /= 2;
    }
}
#endregion






