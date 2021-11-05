using System;

namespace P1_3_1204039
{
    class Program
    {
        static void Main(string[] args)
        {
            // tampilkan judul program
            Console.Write("ANAK AYAM TURUN ");
            
            // get value jmlAyam dari inputan user ke Integer
            int jmlAyam = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            // validasi inputan agar > 0
            if (jmlAyam > 0 && jmlAyam <= 10)
            {
                // looping generate lirik
                int jmlAyamOut = jmlAyam;
                for (int i = 0;i < jmlAyam;i++)
                {
                    if (jmlAyamOut == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah " + Convert.ToString(jmlAyamOut) + ", mati satu tinggallah induknya");
                        continue;
                    }
                    Console.WriteLine("Anak ayam turunlah " + Convert.ToString(jmlAyamOut) + ", mati satu tinggallah " + Convert.ToString(jmlAyamOut - 1));
                    jmlAyamOut -= 1;
                }
                
            } else if (jmlAyam == 0)
            {
                Console.WriteLine("Angka tidak boleh nol. Nanti mau ngitung ayamnya gimana dong? :(");
            } else if (jmlAyam < 0)
            {
                Console.WriteLine("Angka tidak boleh negatif. Anak ayamnya ngutang dong :v");
            } else if (jmlAyam > 10)
            {
                Console.WriteLine("Angka jangan lebih dari sepuluh. Kebanyakan anak ayam pusing ntar induknya wkwk");
            }
        }
    }
}
