namespace Classes
{

    //public class Car
    //{

    //    //step2-- Create a new class, create properties of Make,Model,year
    //    public string Make { get; set; }

    //    public string Model { get; set; }

    //    public int Year { get; set; }




    //}
    public class Program
    {


        static void Main(string[] args)

        {   //Step3-- In main Create a new instance of car Class


            Car myCar = new Car();

            ////---create instance and set values in one
            //Car myCar = new Car() { Make = "Toyota", Model ="Corolla", Year= 2001};
            ///


            //Step4-- Set values to the properties for the object
            //----THIS is DOT NOTATION

            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2001;
            

            //Step4--Print to the console, to see the properties
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);



        }


    }
    
}