using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace css3
{
    public class Program
    {
        public static void Main()
        {
            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer("Gleb", "Gnomich", "kaarlikovic", 532, 7547643636565883),
                new Buyer("Kolba", "Dron", "Faridovich", 654, 52347845295883),
                new Buyer("Egor", "Uzbek", "Karlovick", 1, 85478675295883),
                new Buyer("Volodymer", "Putin", "Putinovich", 854, 9465478475295883),
                new Buyer("Soul", "Goodman", "Djonovich", 123, 97475475295883),
            };

            while (true)
            {
                Console.Write("Enter action: \n" +
                              "1. Show all buyer collection.\n" +
                              "2. Show all buyer in the sorted collection.\n" +
                              "3. Show number of credit card on diapason.\n" +
                              "4. Exit.\n" +
                              "Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var buyer in buyers)
                            buyer.ShowAllBuyers();
                        break;

                    case 2:
                        Buyer.SortedAllBuyers(buyers);
                        break;

                    case 3:
                        foreach (var buyer in buyers)
                        {
                            buyer.CreditCardOnDiapason();
                            break;
                        }
                        break;

                    case 4:
                        return;
                        break;
                }
            }
        }
    }
}