using System.Text;

Console.WriteLine("İlk sayıyı giriniz:");
string sayi1 = Console.ReadLine();

Console.WriteLine("İkinci sayıyı giriniz:");
string sayi2 = Console.ReadLine();

char[] buyuksayi;
char[] kucuksayi;
int eldevar = 0;
int loop = 0;


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
Array.Reverse(buyuksayi);
Array.Reverse(kucuksayi);

StringBuilder toplam = new StringBuilder("", buyuksayi.Length + 1);

foreach (char rakam in buyuksayi)
{
    if(loop > kucuksayi.Length - 1)
    {
        int rakamlartoplami = (rakam - '0') + eldevar;
        if (rakamlartoplami > 9 && loop != buyuksayi.Length-1)
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
        toplam.Insert(0, rakamlartoplami);
    }
    loop++;
}
Console.WriteLine(toplam);
