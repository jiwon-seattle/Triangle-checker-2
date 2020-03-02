using System;
using System.Collections.Generic;


class Triangle
{
  public static int FirstSide;
  public static int SecondSide;
  public static int ThirdSide;

  static void Main()
  {
    Console.WriteLine("Welcome to Triangle Tracker!");
    Console.WriteLine("Enter three numbers that consist of three sides of triangle.");
    Console.WriteLine("First Side: ");
    int.TryParse(Console.ReadLine(), out FirstSide);
    Console.WriteLine("Second Side: ");
    int.TryParse(Console.ReadLine(), out SecondSide);
    Console.WriteLine("Third side : ");
    int.TryParse(Console.ReadLine(), out ThirdSide);


    if(Check())
    {
      Console.WriteLine("This is not a triangle since all sides are not balanced.");
    }
    else if (Equilateral() == true)
    {
      Console.WriteLine("This type is Equilateral.");
    }
    else if (Isosceles() == true)
    {
      Console.WriteLine("This type is Isosceles.");
    }
    else if (Scalene())
    {
      Console.WriteLine("This tye is Scalene.");
    }
  }

  public static bool Check()
  {
    return(FirstSide + SecondSide < ThirdSide || SecondSide + ThirdSide < FirstSide || ThirdSide + FirstSide < SecondSide);
  }

  static bool Equilateral()
  {
    return (FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide);
  }

  static bool Isosceles()
  {
    if (FirstSide == SecondSide)
    {
      return true;
    }
    else if (SecondSide == FirstSide)
    {
      return true;
    }
    else if (ThirdSide == FirstSide)
    {
      return true;
    }
      return false;
  }

  static bool Scalene()
  {
    return (FirstSide != SecondSide && FirstSide != ThirdSide && SecondSide != ThirdSide);
  }

}
