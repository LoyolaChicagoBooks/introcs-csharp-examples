using System;
namespace IntroCS
{
   /// Elaborated class / object example with setters and ToString, use this
   class Contact 
   {
      private string name, phone, email;

      // a constructor - no return type
      public Contact(string name, string phone, string email) 
      {
         this.name = name;
         this.phone = phone;
         this.email = email;
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

                          // setter methods                         
      public void SetPhone(string newPhone) 
      {
         phone = newPhone;
      }
                         // SetEmail chunk
      public void SetEmail(string email) 
      {
         this.email = email;
      }
                         // ToString chunk
      public override string ToString()
      {
         return string.Format (@"Name:  {0}
Phone: {1}
Email: {2}", name, phone, email);
      } 
                         // new Print chunk
      ///print with labels
      public void Print()  // use ToString
      {
         Console.WriteLine(ToString()); 
      }
   }
}
