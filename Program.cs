using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSolutions
{
  class Program
  {
    static void Main(string[] args)
    {
      //Exercise 1
        SumOfBiggestNeighbor();

      //Exercise 2
        UserClass();

      //Exercise 3
        Exercise();

      //Exercise 4
        Alexa();


      //Exercise 5
      // var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10L, 0L == 10L);

      //Exercise 6
      Contruction();

      Console.ReadLine();
    }

    // Exercise 1
    static private void SumOfBiggestNeighbor()
    {
      int[] input = { 1, 6, 1, 2, 6, 1, 6, 6 };

      var sumList = new List<int>();

      var data = from numbers in input
              group numbers by numbers into grouped
              select new { Number = grouped.Key, Freq = grouped.Count() };

      //maximum no of occurence 
      var m = data.Max(a => a.Freq);

      //filtered array 
      var newList = data.Where(a => a.Freq == m - 1 || a.Freq == m).Select(n =>n.Number).ToArray();
      newList = input.Where(s => newList.Contains(s)).ToArray();

      //sum the neighbors
      for (int i = 0; i < newList.Count(); i++)
      {
        if (i == newList.Count() - 1)
        {
          break;
        }
        else
        { 
          var sum = newList[i] + newList[i + 1];
          sumList.Add(sum);
        }     
      }
      //biggest neighbor 
      var biggestNeighbor = sumList.Max();
      Console.WriteLine("Biggest nieghbor is: " + biggestNeighbor);
    }

    // Exercise 2
    static private void UserClass()
    {
      while (true)
      {
        var user = new User();
        Console.WriteLine("please enter the username, or q to exit");
        var userName = Console.ReadLine();

        if (userName == "q")
        {
          break;
        }

        user.Add(userName);
        Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
      }

    }

    //Exercise 3
    static private void Exercise()
    {
      var john = new Humanoid(new Dancing());
      Console.WriteLine(john.ShowSkill()); //print dancing

      var alex = new Humanoid(new Cooking());
      Console.WriteLine(alex.ShowSkill());//print cooking

      var bob = new Humanoid();
      Console.WriteLine(bob.ShowSkill());//print no skill is defined
    }

    //Exercise 4
    static private void Alexa()
    {
      var alexa = new Alexa();
      Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

      alexa.Configure(x =>
      {
        x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
        x.OwnerName = "Bob Marley";
      });

      Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

      Console.WriteLine("press any key to exit ...");
      Console.ReadKey();

    }

    //Exercise 5
    //static async Tuple<int, int> SomeCalculation(long i, long j, bool result)
    //{
    //  return await Tuple.Create(1, 2);
    //}


    //Exercise 6
    static private void Contruction()
    {
      var myHouse = new Building()
        .AddKitchen()
        .AddBedroom("master")
        .AddBedroom("guest")
        .AddBalcony();

      myHouse.Build();

      //kitchen, master room, guest room, balcony
      Console.WriteLine(myHouse.Describe());

      myHouse.AddKitchen().AddBedroom("another");

      //before build the house description still is as before
      //kitchen, master room, guest room, balcony
      Console.WriteLine(myHouse.Describe());
      myHouse.Build();

      //it only shows the kitchen after build
      //kitchen, master room, guest room, balcony, kitchen, another room
      Console.WriteLine(myHouse.Describe());

    }
  }
}
