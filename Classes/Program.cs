namespace Classes
{
    public class Program
    {   //step1-- Create a public class called Car
        public class Car
        { 
            
          //step2-- inside of the class, create Make,Model,year
            public  string Make { get; set; } 

            public string Model { get; set; }

            public int Year { get; set; }

            static void Main(string[] args)
            {   //Step3-- In main Create a new instance of car Class
                Car myCar = new Car(); 
                //Step4-- Set values to the properties for the object
                myCar.Make = "Toyota";
                myCar.Model = "Corolla";
                myCar.Year = 2001;

                //Step4--Print to the console.
                Console.WriteLine(myCar.Make); 
                Console.WriteLine(myCar.Model);
                Console.WriteLine(myCar.Year);


            }
          

        }
    }
}
