using System;
using System.Text;
using Helper;

namespace Evtapsirigi_5
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title="Kontakt Home Panel";
           int len;
          
          len = Helpers.ReadInteger("Neçə Telefon: ");

            Phone[] phones = new Phone[len];

            for(int i=0; i < phones.Length; i++)
            {
                Phone phone = new Phone();
                Console.WriteLine($"{i+1} Nömrəli Telefonun məlumatları");
                phone.producer = Helpers.ReadString(" Istehsalçı adı: ");
                phone.model = Helpers.ReadString(" Model: ");
                phone.mainCamera = Helpers.ReadInteger(" Ön Kamera Mpx: ");
                phone.cores = Helpers.ReadInteger(" Nüvə sayı: ");
                phone.memory = Helpers.ReadInteger("Yaddaş Gb: ");
                phone.prodYear = Helpers.ReadInteger("İstehsal ili: ");
                phone.price = Helpers.ReadDouble("Qiymet: ");

                phones[i] = phone;
                Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");

            }
            Console.WriteLine("List of Phones");

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("**************************");
            }


         


            
            
          

            










            
            


        }

    }
}
