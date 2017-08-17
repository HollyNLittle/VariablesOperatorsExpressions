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

            int studentsAttendedFieldTrip = 331;
            int studentsInCars = 7;
            int studentsTravellingBybus = studentsAttendedFieldTrip - studentsInCars;
            int numOfBusses = 6;
            int studentsPerBus = studentsTravellingBybus / numOfBusses;
            Console.WriteLine("The number of students in each bus: {0}", studentsPerBus);

            float pencilBudget = 24;
            float numPencils = 7;
            float moneyAfterPencilPurchase = 10;
            float totalSpentOnPencils = pencilBudget - moneyAfterPencilPurchase;
            float costPerPencil = totalSpentOnPencils / numPencils;
            Console.WriteLine("The cost per pencil: {0}", costPerPencil);

            int boxesBought = 7;
            int boxesDestroyed = 2;
            int boxesRemaining = 22;
            int originalBoxTotal = boxesRemaining * boxesDestroyed;
            int boxesAtBeginning = originalBoxTotal - boxesBought;
            Console.WriteLine("The number of boxes Maria had before the fire: {0}",
                originalBoxTotal);
            Console.WriteLine("The number of boxes Maria had before purchasing the 7 additional pencils: {0}", 
                boxesAtBeginning);

            int number1 = 23;
            int number2 = 24;
            int number3 = 25;
            int sumOfNumbers = 72;
            int numOfNumbers = 3;
            int numberAverage = sumOfNumbers / numOfNumbers;
            int amountToDecrease = -1;
            int numberA = numberAverage - 1;
            int x = numberAverage;
            int numberC = numberAverage + 1;
            Console.WriteLine("The smallest number is: {0}",
                numberA);

            int sum = 48;
            int numOfNums = 3;
            int average = sum / numOfNums;
            int largestNum = average + 2;
            int smallestNum = average - 2;
            Console.WriteLine("The smallest number is; {0}", smallestNum);

            int total = 48;
            int min1 = (total - 6)/3;
            Console.WriteLine(min1);

            int sumOfEvenNumbers = 48;
            int evenOne = sumOfEvenNumbers / 3;
            int evenTwo = evenOne - 2;
            Console.WriteLine(evenTwo);

            int totalNum = 72;
            int middleNum = totalNum / 3;
            int largeNum = middleNum + 1;
            int smallNum = middleNum - 1;
            Console.WriteLine("The smallest number: {0}", smallNum );

            int boughtBoxes = 7;
            int boxesLeft = 22;
            int boxesBeforeFire = boxesLeft * 2;
            Console.WriteLine(boxesBeforeFire);















        }
    }
}
