using System;

class UseConstant
{
   static double PI = 3.14159265358979; // constant, value not reset

   static double CircleArea(double radius)
   {
      return PI*radius*radius;
   }

   static double Circumference(double radius)
   {
      return 2*PI*radius;
   }

   static void Main()
   {
      Console.WriteLine("circle area with radius 5: " + CircleArea(5));
      Console.WriteLine("circumference with radius 5:" + Circumference(5));
   }
}

