namespace Practice.Wage
{
    public abstract class Employee
    {
         string empID;
         string empName;

        //property
        public string EmpID
        {
            get{return empID;}
        }

        public string EmpName
        {
            get{return empName;}
        }

        //constructor
        public Employee(string empID,string empName)
        {
            this.empID = empID;
            this.empName = empName;
        }

        public abstract double empIncome();
        public override string ToString()
        {
            return $"Emplyee: {empName} with employee ID: {empID}";
        }
    }
}