namespace Objects_Conway_David
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // creates A new coputer object with the brand apple and the type all in one set to on 
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer; // creates Ibootup varible and set it equal to the computer
            Console.WriteLine(myComputer.Equals(myBootUp)); // cheaks if there equal and prints to console
            //creates another computer object with the same vaules as the first prints to console if equal
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

           
            // strings store the text of the computers description 
            string myString = myComputer.ToString();
            string myOtherString = myString; //creates a new string and assains it to the first
            //reassins the first strings vaule to hi 
            myString = "hi";
            //prints both string to compare them
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);
            //compares strings to computer objects 
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());
            // compares mycomputer to the computer data type 
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());
            // sets mycomputer to power on off
            myOtherComputer.PowerOnOff();
            //campares the strings to the computer
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            //
            Console.WriteLine(myString.Contains('i')) ;
            Console.WriteLine(myString.ToUpper());
        }
    }
}