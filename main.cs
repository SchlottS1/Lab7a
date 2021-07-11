using System;

class MainClass {

  public static double CalculateCharges(double Hours)
  {
    double Charges = 0.00;
    //get hours parked for the customer
    double TotalHours = Hours;
    double HourlyCharge = 0.50;
    double MaxCharge = 10.0;
    double MinCharge = 2.0;
    if (TotalHours <= 3)
    {
      Charges = MinCharge;
    } else if (TotalHours > 3 && TotalHours <= 19)
    {
      Charges = MinCharge + ((TotalHours - 3) * HourlyCharge);
    } else
    {
      Charges = MaxCharge;
    }
    
    Console.WriteLine("Your total parking charge is " + Charges + " dollars.");
    return Charges;
    
  }



  public static void Main (string[] args) {

    //Ask for number of customers
    Console.WriteLine("How many customers are there?");
    int nbrOfCustomers = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < nbrOfCustomers + 1; i++)
    {
    Console.WriteLine("How many hours did customer " + i + " park?");
    double HoursParked = Convert.ToDouble(Console.ReadLine());

    CalculateCharges(HoursParked);
    }
    while (true)
    {
      Console.WriteLine("Are there any other customers?");
      string response = Console.ReadLine();
      if (response == "No")
      {
      Console.WriteLine("Thank you, have a nice day.");
      break;
      } else {
        Console.WriteLine("How many hours did the customer park?");
        double HoursParked = Convert.ToDouble(Console.ReadLine());

        CalculateCharges(HoursParked);
      }
    }

    
  }
}