namespace Practice.Wage
{
    public class FullTimeEmployee: Employee
    {
        int annulIncome;

        public int AnnulIncome
        {
            get{return annulIncome;}
        }

        public FullTimeEmployee(string empID, string empName,int annulIncome):base(empID,empName)
        {
           this.annulIncome = annulIncome; 
        }

        public override double empIncome()
        {
            return annulIncome / 12; // MONTHLY INCOME
        }
       
        public override string ToString()
        {
            return base.ToString() + $"  AnnulIncome : {annulIncome}";
        }
    }
}