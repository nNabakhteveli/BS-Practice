namespace ClassesAndObjectsTask
{
   public class Employee
   {
      private string surname;
      private int age;

      public Employee() 
      {
      }

      public Employee(string s, int a)
      {
         this.surname = s;
         this.age = a;
      }

      public void SetSurname(string newSurname) => this.surname = newSurname;
      
      public string GetEmployeeInfo() => $"Surname: {this.surname}, Age: {this.age}";

      private string AgeToString() => this.age.ToString();
   }
}