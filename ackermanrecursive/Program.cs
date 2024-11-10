using System;

class Program
{
    // Burada ana fonksiyon olan Maini tanımlıyoruz
    static void Main()
    {
        // Ackerman fonksiyonunu çalıştırmak için kullanıcıdan m ve n adında iki değer alıyoruz
        Console.Write("İlk değeri giriniz: ");
        int m= Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci değeri giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());


        // Ackerman fonksiyonunun sonucunu hesaplayıp ekrana yazdırıyoruz
        Console.WriteLine("Ackerman({0}, {1}) = {2}", m, n, Ackerman(m, n));
    }

    // Burada Ackerman fonksiyonunu tanımlıyoruz
    static int Ackerman(int m, int n)
    {
        // m 0 ise n + 1 döndürüyoruz
        if (m == 0)
            return n + 1;

        // m > 0 ve n 0 ise Ackerman(m - 1, 1) hesaplayıp döndürüyoruz
        else if (m > 0 && n == 0)
            return Ackerman(m - 1, 1);

        // m > 0 ve n > 0 ise Ackerman(m - 1, Ackerman(m, n - 1)) hesaplayıp döndürüyoruz
        else
            return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

