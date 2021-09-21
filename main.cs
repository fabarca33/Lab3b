using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");

    var name = Console.ReadLine();
    
    Console.WriteLine("Enter sales amount");

    var amount = Console.ReadLine();
    double sales = Convert.ToDouble(amount);

    double commission = 200 + (0.09*sales);
    
    Console.WriteLine("Sales commission for " +name +" is $" +commission);

    if (sales >= 0 && sales <= 2999)
    {
      Console.WriteLine("Performance is poor");
    }
    else if (sales >= 3000 && sales <= 4999)
    {
      Console.WriteLine("Performance is average");
    }
    else if (sales >= 5000 && sales <= 9999)
    {
      Console.WriteLine("Performance is good");
    }
    else if (sales >= 10000 && sales <= 14999)
    {
      Console.WriteLine("Performance is excellent");
    }
    else
    {
      Console.WriteLine("Performance is outstanding");
    }
  }
}