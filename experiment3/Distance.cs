
namespace experiment3
{
    public class Distance
    {
        private readonly decimal meter;
        private const decimal meterInAMile =  0.000621371192M;


        public Distance():this(0)
        { 
        }

        private Distance(decimal meter)
        {
            this.meter = meter;
        }

        public static Distance FromMeter(decimal meter)
        {
            return new Distance(meter);
        } 

        public static Distance FromMile(decimal mile)
        {
            return new Distance();
        }

        public decimal AsMeter()
        {
            return meter;
        }

        public decimal AsMile()
        {
            return meter * meterInAMile;
        }

        public static Distance operator+ (Distance left, Distance right)
        {
            return new Distance(left.meter + right.meter);
        }

        



    }

}
