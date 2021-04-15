using System.Collections.Generic;
using System.Linq;
using System;

namespace Titanic
{
   public class Program
   {
      static void Main(string[] args)
      {
         List<Passenger> passengers = Titanic.GetPassengers("Titanic.Tsv");

            // Intro: The line of code above reads in a file that contains all of
            //        the passengers who were on the Titanic. Feel free to look at
            //        the Passenger class to see which fields each Passenger
            //        contains. The file is read into a List of Passengers.

            // ToDo: Write code using LInQ in order to find the answers to the
            //       following questions.

            // 1) Find out whether a "Miss. Alice Cleaver" survived the accident.
            var aliceCleaver = passengers.Find(x => x.Name.Contains("Alice") && x.Name.Contains("Cleaver"));
            bool survived = aliceCleaver.Survived;
            Console.WriteLine(survived);

            // 2) There were six 52-year-olds on board, however, only one embarked
            //    from Cherbourg (C). What was his or her name? Did he or she
            //    survive?
            Passenger fiftyTwoYearOld = passengers.Find(x => x.Age == 52 && x.Embarked == 'C');
            Console.WriteLine(fiftyTwoYearOld.Name);
            bool MarthaEustisSurvived = fiftyTwoYearOld.Survived;
            Console.WriteLine(MarthaEustisSurvived);

            // 3a) How many men were on board?
            var allMen = passengers.FindAll(x => x.Gender == 'M' && x.Age >= 18);
            double totalNumOfMen = allMen.Count();
            // 3b) How many men survived?
            double numOfMenSurvived = allMen.FindAll(x => x.Survived == true).Count();
            // 3c) What was the survival rate of men?
            double survivalRateMen = (numOfMenSurvived / totalNumOfMen) * 100;
            // ToDo (Hint): Implement the getSurvivalRate method below.
            Console.WriteLine(survivalRateMen);

            //3Method) Men
            var allMenList = passengers.FindAll(x => x.Gender == 'M' && x.Age >= 18);
            Console.WriteLine(getSurvivalRate(allMenList));

            // 4a) How many women were on board?
            var allWomen = passengers.FindAll(x => x.Gender == 'F' && x.Age >= 18);
            double totalNumOfWomen = allWomen.Count();
            // 4b) How many women survived?
            double numOfWomenSurvived = allWomen.FindAll(x => x.Survived == true).Count();
            // 4c) What was the survival rate of women?
            double survivalRateWomen = (numOfWomenSurvived / totalNumOfWomen) * 100;
            Console.WriteLine(survivalRateWomen);

            //4Method) Women
            var allWomenList = passengers.FindAll(x => x.Gender == 'F' && x.Age >= 18);
            Console.WriteLine(getSurvivalRate(allWomenList));

            // 5a) How many children were on board?
            var allChildren = passengers.FindAll(x => x.Age < 18);
            double totalNumOfChildren = allChildren.Count();
            // 5b) How many children survived?
            double childrenSurvived = allChildren.FindAll(x => x.Survived == true).Count();
            // 5c) What was the survival rate of children?
            double survivalRateChildren = (childrenSurvived / totalNumOfChildren) * 100;
            Console.WriteLine(survivalRateChildren);

            //5Method) Children
            var allChildrenList = passengers.FindAll(x => x.Age < 18);
            Console.WriteLine(getSurvivalRate(allChildrenList));

            // 6a) Who was the youngest survivor? (name)
            var lowestAge = passengers.Min(x => x.Age);
            var youngestSurvivor = passengers.First(x => x.Age == lowestAge && x.Survived == true);
            Console.WriteLine(youngestSurvivor.Name); //Elizabeth Gladys "Millvina"
            // 6b) Who was the oldest casualty? (name)
            var highestAge = passengers.Max(x => x.Age);
            var oldestSurvivor = passengers.Find(x => x.Age <= highestAge && x.Survived == false);
            Console.WriteLine(oldestSurvivor.Name); //Anthony Abbing

            // 7a) Who had the cheapest ticket? (name) Did they survive?
            var cheapestTicket = passengers.Min(x => x.Fare);
            var personWithCheapestTicket = passengers.Find(x => x.Fare == cheapestTicket);
            Console.WriteLine(personWithCheapestTicket.Name); //Artur Karl Olsen
            Console.WriteLine(personWithCheapestTicket.Survived); //True
            // 7b) Who had the most expensive ticket? (name) Did they survive?
            var expensiveTicket = passengers.Max(x => x.Fare);
            var personWithExpensiveTicket = passengers.Find(x => x.Fare == expensiveTicket);
            Console.WriteLine(personWithExpensiveTicket.Name); //Thomas Drake Martinez Cardeza
            Console.WriteLine(personWithExpensiveTicket.Survived); //True

            // 8a) What was the survival rate for all first class passengers?
            var firstClassPassengers = passengers.FindAll(x => x.Class == 1);
            Console.WriteLine(getSurvivalRate(firstClassPassengers));
            // 8b) What was the survival rate for all second class passengers?
            var secondClassPassengers = passengers.FindAll(x => x.Class == 2);
            Console.WriteLine(getSurvivalRate(secondClassPassengers));
            // 8c) What was the survival rate for all third class passengers?
            var thirdClassPassengers = passengers.FindAll(x => x.Class == 3);
            Console.WriteLine(getSurvivalRate(thirdClassPassengers));

            //9) What was the survival rate of girls in first class with 2 or
            //   more of any relative?
            var girlsFirstClassTwoOrMoreRel = passengers.Where(x => x.Gender == 'F' && x.Class == 1 && (x.ParentsChildren + x.SiblingsSpouse) > 2);
            Console.WriteLine(getSurvivalRate(girlsFirstClassTwoOrMoreRel));

            // 10) What was the survival rate of men in third class with no
            //     relatives onboard?
            var menThirdClassNoRel = passengers.Where(x => x.Gender == 'M' && x.Class == 3 && (x.ParentsChildren + x.SiblingsSpouse) == 0);
            Console.WriteLine(getSurvivalRate(menThirdClassNoRel));

            // 11) What was the survival rate of passengers who embarked from
            //     Southampton (S) and whose fare was over 10 pounds?
            var southHampton10Pounds = passengers.Where(x => x.Embarked == 'S' && x.Fare > 10);
            Console.WriteLine(getSurvivalRate(southHampton10Pounds));

            // 12) What was the survival rate of passengers with the word "sink"
            //     in their name? (case insensitive)
            var nameWithSink = passengers.Where(x => x.Name.ToLower().Contains("sink"));
            Console.WriteLine(getSurvivalRate(nameWithSink));

            // 13) What was the survival rate of passengers whose ticket number
            //     included the substring "13"?
            var ticketWith13 = passengers.Where(x => x.Ticket.Contains("13"));
            Console.WriteLine(getSurvivalRate(ticketWith13));

        } // end Main( )

      private static double getSurvivalRate(IEnumerable<Passenger> passengers)
      {
            double survivalRate = 0.0;
            double totalPassengerCount = passengers.Count();
            double survivingPassengers = passengers.Where(x => x.Survived == true).Count();
            survivalRate = (survivingPassengers / totalPassengerCount) * 100;

            return survivalRate;
      } // end getSurvivalRate( )
   }
}
