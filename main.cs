using System;

class Program {
  public static void Main (string[] args) {
  double value = 250;

  if(value == .01)
  {
    Console.WriteLine($"No person is found in Php {value}");
  } 
    else if (value == 0.05)
  {
    Console.WriteLine($"No person is found in Php {value}");
  }
    else if (value == 0.25)
  {
    Console.WriteLine($"No person is found in Php {value}");
  }
    else if (value == 1)
  {
    Console.WriteLine($"Jose Rizal is found in Php {value}");
  }
    else if (value == 5)
  {
    Console.WriteLine($"Emilio Aguinaldo is found in Php {value}");
  }
    else if (value == 10)
  {
    Console.WriteLine($"Andres Bonifacio and Apolinario Mabini are found in Php {value}");
  }
    else if (value == 20)
  {
    Console.WriteLine($"Manuel L. Quezon is found in Php {value}");
  }
    else if (value == 50)
    {
      Console.WriteLine($"Sergio Osmena is found in Php {value}");
    }
    else if (value == 100)
    {
      Console.WriteLine($"Manuel Roxas is found in Php {value}");
    }
    else if (value == 200)
    {
      Console.WriteLine($"Diosdado Macapagal is found in Php {value}");
    }
    else if (value == 500)
    {
      Console.WriteLine($"Benigno Sr. and Corazon Aquino are found in Php {value}");
    }
    else if (value == 1000)
    {
      Console.WriteLine($"Jose Abad Santos, Vicente Lim and Josefa Llanes Escoda are found in Php {value}");
    }
    else {
      Console.WriteLine($"Invalid Denomination: {value}");
    }
  }
}