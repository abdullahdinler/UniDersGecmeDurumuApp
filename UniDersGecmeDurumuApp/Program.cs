using System;

namespace UniDersGecmeDurumuApp
{
    class Program
    {
        static void Main()
        {
            float vize, final, VizeNot, but, ButNot, FinalNot, durum;
            int butDurum;
            Console.WriteLine("*********** Ders gecme durumu hesaplama ***********");
            Console.Write("Fize notunuzu giriniz: "); vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunuzu giriniz: "); final = Convert.ToInt32(Console.ReadLine());
            VizeNot = ((vize / 100) * 40);
            FinalNot = ((final / 100) * 60);
            durum = VizeNot + FinalNot;

            if (durum >= 60)
            {
                Console.WriteLine("Dersi gectiniz not ortalamaniz: {0}", durum);
            }
            else
            {
                Console.WriteLine("Dersten kaldiniz. Butunlemeye girmeye hak kazandiniz.");
                Console.Write("Butunleme sinavina girdiniz mi (evet: 1)/ (hayir: 2): "); butDurum = Convert.ToInt32(Console.ReadLine());

                switch (butDurum)
                {
                    case 1:
                        Console.Write("Butunleme notunuzu giriniz: "); but = Convert.ToInt32(Console.ReadLine());
                        ButNot = ((but / 100) * 60);
                        durum = ButNot + VizeNot;
                        if (durum >= 60)
                        {
                            Console.WriteLine("Dersi gectiniz not ortalamaniz: {0}", durum);
                        }
                        else
                        {
                            Console.WriteLine("Dersten kaldiniz not ortalamaniz: {0}", durum);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Dersten kaldiniz not ortalamaniz: {0}", durum);

                        break;

                    default:
                        Console.WriteLine("Hatali deger girdiniz.");
                        break;
                }
            }

            Console.Read();
        }
    }
}