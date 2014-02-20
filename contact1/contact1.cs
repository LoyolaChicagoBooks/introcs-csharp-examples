using System;
namespace IntroCS
{
   /// A simple class / object example:
   class Contact // nothing in here is marked static
   {
      private string name, phone, email;

      // a constructor - no return type
      public Contact(string fullName, string phoneNumber, string emailAddress) 
      {
         name = fullName;
         phone = phoneNumber;
         email = emailAddress;
      }

      // getter methods                         
      public string GetName() 
      {
         return name;
      }

      public string GetPhone() 
      {
         return phone;
      }
                             
      public string GetEmail() 
      {
         return email;
      }

      ///print with labels
      public void Print()
      {
         Console.WriteLine (@"Name:  {0}
Phone: {1}
Email: {2}", name, phone, email);
      } 
   }               // end Print chunk
}
