using System;

namespace ChainOfResponsibility
{
    internal abstract class Manager
    {
        protected readonly string ManagerName;
        protected Manager superior;
        protected Manager(string name) => ManagerName = name;

        public Manager Superior
        {
            set{superior = value;}
        }
        public abstract void RequestApplications(Request request);
    }

    internal class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == "Leave" && request.RequestNum <= 2)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}  Granted");
            }
            else
            {
                superior.RequestApplications(request);
            }
        }
    }

    internal class SeniorManager : Manager
    {
        public SeniorManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == "Leave" && request.RequestNum <= 5)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum} Granted");
            }
            else
            {
                superior.RequestApplications(request);
            }
        }
    }

    internal class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == "Leave")
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum} Granted");
                return;
            }
            if(request.RequestType == "PayIncrease" && request.RequestNum < 500)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum} Granted");
                return;
            }
            if(request.RequestType == "PayIncrease" && request.RequestNum > 500)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum} To Be Further Discussed");
                
                return;
            }
        }
    }

}