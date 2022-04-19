namespace Practice.Wage
{
    public class CasualEmployee : Employee
    {
        double incomePerHour;
        double hoursWorked;

        public double IncomePerHour
        {
            get{return incomePerHour;}
        }
        public  double HoursWorked
        {
            get{return hoursWorked;}
        }

        public CasualEmployee(string empID, string empName,double incomePerHour,double hoursWorked): base(empID,empName)
        {
            this.incomePerHour = incomePerHour;
            this.hoursWorked = hoursWorked;

        }

        public override double empIncome()
        {
           return incomePerHour * hoursWorked;
        }
        public override string ToString()
        {
            return base.ToString() + $"  2worked for: {hoursWorked} hour(s) at: {incomePerHour} hourly rate";
        }
    }
}