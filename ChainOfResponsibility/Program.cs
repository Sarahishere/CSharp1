using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager commonM = new CommonManager("Lid");
            Manager seniorM = new SeniorManager("Sarah");
            Manager gM = new GeneralManager("Pisa");

            commonM.Superior = seniorM;
            seniorM.Superior = gM;

            Request request1 = new Request()
            {
                RequestContent = "Sally ask for Leave",
                RequestType = "Leave",
                RequestNum = 1
            };
            

            Request request2 = new Request()
            {
                RequestContent = "Nora ask for Leave",
                RequestType = "Leave",
                RequestNum = 4
            };

            Request request3 = new Request()
            {
                RequestContent = "Tom ask for PayIncrease",
                RequestType = "PayIncrease",
                RequestNum = 300
            };

            Request request4 = new Request()
            {
                RequestContent = "Billy ask for PayIncrease",
                RequestType = "PayIncrease",
                RequestNum = 600
            };

            commonM.RequestApplications(request1);
            commonM.RequestApplications(request2);
            commonM.RequestApplications(request3);
            commonM.RequestApplications(request4);
        }
    }
}
