using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace css3
{
    public class Buyer
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public long CreditCardNumber { get; set; }
        public long AccountNumber { get; set; }

        public static List<Buyer> buyers = new List<Buyer>();

        public Buyer(string Name, string SurName, string Patronymic, long CreditCardNumber, long AccountNumber)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Patronymic = Patronymic;
            this.CreditCardNumber = CreditCardNumber;
            this.AccountNumber = AccountNumber;
            buyers.Add(this);
        }

        public void ShowAllBuyers()
        {
            Console.Write($"\nName: {Name}\n" +
                          $"Surname: {SurName}\n" +
                          $"Patronymic: {Patronymic}\n" +
                          $"Credit card number: {CreditCardNumber}\n" +
                          $"Account number: {AccountNumber}\n\n");

        }

        public static void SortedAllBuyers(List<Buyer> buyers)
        {
            var sortedBooksOnNameBuyer = buyers.OrderBy(name => name.Name);
            foreach (var buyer in sortedBooksOnNameBuyer)
            {
                Console.Write($"\nName: {buyer.Name}\n" +
                              $"Surname: {buyer.SurName}\n" +
                              $"Patronymic: {buyer.Patronymic}\n" +
                              $"Credit card number: {buyer.CreditCardNumber}\n" +
                              $"Account number: {buyer.AccountNumber}\n\n");
            }
        }

        public void CreditCardOnDiapason()
        {
            Console.Write("\nEnter min diapazon credit card: ");
            long minDiapazonCreditCard = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter max diapazon credit card: ");
            long maxDiapazonCreditCard = Convert.ToInt32(Console.ReadLine());


            var checkDiapazon = from b in buyers
                                where b.CreditCardNumber >= minDiapazonCreditCard
                                   && b.CreditCardNumber <= maxDiapazonCreditCard
                                select b;

            if (checkDiapazon.Any())
                foreach (var buyer in checkDiapazon)
                    buyer.ShowAllBuyers();
            else Console.WriteLine("\nThe credit card is not in the range!\n");

        }
    }
}
