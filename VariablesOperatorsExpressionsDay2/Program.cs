using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressionsDay2
{
    class Program
    {
        static void Main(string[] args)
        {
     
 
            int amountPaidEach = 13;
            int numberOfFriends = 4;
            int totalBill = amountPaidEach * numberOfFriends;
            Console.WriteLine("The total bill was: {0}", totalBill);

            int totalSugar = 7;
            int amtSugarAdded = 2;
            int remainingSugarNeeded = totalSugar - amtSugarAdded;
            Console.WriteLine("The remaining sugar needed is: {0}", remainingSugarNeeded);

            int costOfDiapers = 8;
            int availableDiaperMoney = 40;
            int numDiapersCanBuy = availableDiaperMoney/costOfDiapers;
            Console.WriteLine("Number of diapers can buy: {0}", numDiapersCanBuy);

            int moneyLastWeek = 29;
            int totalMoneyCurrent = 41;
            int moneyReceived = totalMoneyCurrent - moneyLastWeek;
            Console.WriteLine("Trevon received: {0}", moneyReceived);

            int juliasMiles = 47;
            int previousMiles = 30;
            int pranavsMiles = juliasMiles - previousMiles;
            Console.WriteLine("Pranav ran: {0}", pranavsMiles);

            int envelopeCostPerBox = 3;
            int budgetForEnvelopes = 12;
            int numEnvelopeBoxesCanBuy = budgetForEnvelopes / envelopeCostPerBox;
            Console.WriteLine("Number of boxes of envelopes can purchase: {0}", numEnvelopeBoxesCanBuy);

            decimal moneyPaidForSalad = 5.12m;
            decimal norachaisTotalMoney = 27.10m;
            decimal norachaisMoneyBeforePurchase = norachaisTotalMoney + moneyPaidForSalad;
            Console.WriteLine("Amount of money Norachai had prior to purchase: {0}", norachaisMoneyBeforePurchase);










        }
    }
}
