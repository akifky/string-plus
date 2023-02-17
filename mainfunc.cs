using System.Text;
StringBuilder toplama(string sayi1, string sayi2)
{
    //Değişkenler
    char[] buyuksayi;
    char[] kucuksayi;
    int eldevar = 0;
    int loop = 0;

    //Hangi sayının daha büyük olduğunu ayırt etme
    if (sayi1.Length > sayi2.Length)
    {
        buyuksayi = sayi1.ToCharArray();
        kucuksayi = sayi2.ToCharArray();
    }
    else
    {
        buyuksayi = sayi2.ToCharArray();
        kucuksayi = sayi1.ToCharArray();
    }
    // Toplama işlemine sağdan başlanacağı için Array'leri ters çevirme
    Array.Reverse(buyuksayi);
    Array.Reverse(kucuksayi);

    // Sonuç değişkeni
    StringBuilder toplam = new StringBuilder("", buyuksayi.Length + 1);

    //Büyük olan sayının son rakamından başlayıp küçük olanın rakamıyla toplama işlemi
    foreach (char rakam in buyuksayi)
    {
        //Eğer küçük sayıdaki tüm karakterler işleme tabii tutulduysa, büyük sayıdaki kalan sayıları aynen yaz
        if (loop > kucuksayi.Length - 1)
        {
            //Daha öncedeki rakamların toplamını 10'u geçmiş ise eldevar'ı da ekle
            int rakamlartoplami = (rakam - '0') + eldevar;
            //Rakamlar toplamı 10 ve daha fazlasıysa rakamın son hanesini yaz. Sayının son rakamı istisna, 10'u geçse de direkt yazılır.
            if (rakamlartoplami > 9 && loop != buyuksayi.Length - 1)
            {
                eldevar = rakamlartoplami / 10;
                rakamlartoplami = rakamlartoplami % 10;

            }
            toplam.Insert(0, rakamlartoplami);
        }
        else
        {
            int rakamlartoplami = (rakam - '0') + (kucuksayi[loop] - '0' + eldevar);
            if (rakamlartoplami > 9)
            {
                eldevar = rakamlartoplami / 10;
                rakamlartoplami = rakamlartoplami % 10;

            }
            //Sonuç stringinin başına rakamın toplamını ekle
            toplam.Insert(0, rakamlartoplami);
        }
        loop++;
        
    }
    return (toplam);
}
Console.WriteLine(toplama("999", "1"));
