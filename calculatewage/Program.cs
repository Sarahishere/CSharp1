using System;
using static System.Console;

namespace Practice.Wage
{
    class Program
    {
        static void Main(string[] args)
        {  int employeeType;
           int annulWage;
           
           
          employeeType = getEmployeeType();
          var nameAndID = getNameID();
          switch(employeeType){
              case 1:
               var rateAndHours = getRateAndHours();
               getCasualEmpWage(nameAndID.name,nameAndID.id,rateAndHours.rate,rateAndHours.hours); break;
             
              case 2: 
              annulWage = getAnnulWage();
              getFullTimeEmpWage(nameAndID.name,nameAndID.id,annulWage); break;
             
              default: break;
          }
          
        }

        
        
        public static void  getFullTimeEmpWage(string name, string id, int annulWage)
        {
            var employee = new FullTimeEmployee(id,name,annulWage);
            WriteLine(employee.ToString() + $"   Monthly wage: {employee.empIncome()}");

        }

        public static void  getCasualEmpWage(string name, string id,double rate, double hours)
        {
            var employee = new CasualEmployee(id,name,rate,hours);
            WriteLine(employee.ToString() + $"  Total Wage: {employee.empIncome()}");

        }
        
        public static int getAnnulWage(){
            int annulWage = 0;
            WriteLine("Enter your Annul wage");
            if(int.TryParse(ReadLine(),out int input)){
              annulWage = input;
            }else{ WriteLine("Invalid input!");}

            return annulWage;
        }
        public static (double rate, double hours) getRateAndHours()
        {   double dRate = 0;
            double dHours = 0;

            WriteLine("Enter the hourly rate:");
            if(double.TryParse(ReadLine(),out double input1)){
                dRate = input1;
            }else{WriteLine("Invalid input!");}
            
            WriteLine("Enter the hours worked:");
            if(double.TryParse(ReadLine(),out double input2)){
                dHours = input2;
            }else{WriteLine("Invalid input!");}

            return(rate:dRate,hours:dHours);

        }
        public static (string name, string id) getNameID()
        {
            WriteLine("Enter the Employee name");
            string nameStr = ReadLine();
            WriteLine("Enter the Emplyee ID");
            string idStr = ReadLine();

            return (name: nameStr,idStr);

        }
       
        
        public static int getEmployeeType()
        {
            int employeeType = 0;
            while(employeeType != 1 && employeeType != 2){
                 WriteLine("\nPlesase select Employee type:"
                 + "\n1.Casual" + "\n2.Full Time");
                 if(int.TryParse(ReadLine(),out int input)){
                     employeeType = input;
                 }
                 
                if(employeeType != 1 && employeeType != 2){
                     WriteLine("Invalid input for Employee type, Try Again!");
                }
               
            }
            return employeeType;
        }
    }
}
