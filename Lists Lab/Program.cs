using System.Security.Cryptography.X509Certificates;

namespace Lists_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<string> programs = new List<string>()
         { 
           "C#", 
           "JavaScript",
           "Python", 
           "Java", 
           "ASP.NET", 
           "React" 
         };

         List<string> instructors = new List<string>() 
         { 
           "Mike", 
           "Nevin", 
           "Jake", 
           "Dan", 
           "Megan"
         };

            instructors.Add("Dan");
            instructors.Add("Amy");
            instructors.Add("Ted");
            instructors[3] = "Danimal";

            //foreach(string instructor in instructors)
            //   {
            //       Console.WriteLine(instructor);
            //   }
            instructors.Remove("Ted");
            instructors.RemoveAt(0);

            for (int i = 0; i < instructors.Count; i++)
            {
                Console.WriteLine(instructors[i]);
            }
            
            Console.WriteLine(instructors.Count);

            List<string> names = new List<string>()
            {
                "John",
                "Thomp",
                "Sander",
                "Robin"
            };

             string ending = "son";

            foreach (string name in names)
            {
                Console.WriteLine(name + ending);
            }

            List<string> items = new List<string>()
            {
                "fan",
                "bulls",
                "high-",
                "barrel-o-",
                "slap"
            };

            List<string> objects = new List<string>()
            {
                "fare",
                "eye",
                "horse",
                "monkeys",
                "stick"
            };

           
        }
    }
}