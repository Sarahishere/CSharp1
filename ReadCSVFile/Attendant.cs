namespace ReadCSV
{
    public class Attendants
    {
         private string id;
         private string name;
         private string phone;

         public string ID
         {
             get => id;
             set => id = value;
         }  
         public string Name
         {
             get => name;
             set => name = value;
         } 
         public string Phone{
             get => phone;
             set => phone = value;
         }     

         public Attendants(string id, string name, string phone)
         {
             this.id = id;
             this.name = name;
             this.phone = phone;
         }
    }
}