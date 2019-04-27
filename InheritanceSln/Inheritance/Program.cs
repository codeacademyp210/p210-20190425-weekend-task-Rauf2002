using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Classes;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secim edin :");
            Console.WriteLine("I-ishci yaratmaq");
            Console.WriteLine("M-Musteri yaratmaq");
            Console.WriteLine("P-Mehsul yaratmaq");
            Console.WriteLine("O-Sifaris yaratmaq");
            string option = Console.ReadLine();
            if(option == "i" || option == "I")
            {
                Employee e1 = new Employee();
                Console.WriteLine("Isci yaratmaq ucun suallari cavablandirin :");
                Console.WriteLine("Adiniz :");
                e1.Name = Console.ReadLine();
                Console.WriteLine("Soyadiniz :");
                e1.Surname = Console.ReadLine();
                Console.WriteLine("Kart ID-iz :");
                e1.Card_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vezifeniz :");
                e1.Position = Console.ReadLine();
                Console.WriteLine("Maasiniz : ");
                e1.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Isci yaradildi - {1} {2}",Employee.Id, e1.Name, e1.Surname);
                Console.ReadLine();

            }
            if (option == "m" || option == "M")
            {
                Client c1 = new Client();
                Console.WriteLine("Musteri yaratmaq ucun suallari cavablandirin :");
                Console.WriteLine("Adiniz :");
                c1.Name = Console.ReadLine();
                Console.WriteLine("Soyadiniz :");
                c1.Surname = Console.ReadLine();
                Console.WriteLine("Kart ID-iz :");
                c1.Card_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Musteri ID-iz :");
                c1.Client_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adresiniz :");
                c1.Address = Console.ReadLine();
                Console.WriteLine("Telefon nomreniz :");
                c1.Phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Musteri yaradildi - {1} {2}",Client.Id, c1.Name, c1.Surname);
                Console.ReadLine();

            }
            if (option == "p" || option == "P")
            {
                Product p1 = new Product();
                Console.WriteLine("Mehsul yaratmaq ucun suallari cavablandirin :");
                Console.WriteLine("Adi :");
                p1.Name = Console.ReadLine();
                Console.WriteLine("Qiymeti :");
                p1.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rengi");
                p1.Color = Console.ReadLine();
                Console.WriteLine("{0} - Mehsul yaradildi : {1} {2} {3}$",Product.Id,p1.Name,p1.Color,p1.Price);
                Console.ReadLine();
            }
            if(option == "o" || option == "O")
            {
                Order o1 = new Order();
                Console.WriteLine("Sifaris yaratmaq ucun suallari cavablandirin :");
                Console.WriteLine("Sayi :");
                o1.Count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Sayi:{1}. Umumi odenecek mebleg :{2} ",Order.Id,o1.Count,o1.TotalPrice(o1.Count,20));
                Console.ReadLine();
            }
        }
    }
}
