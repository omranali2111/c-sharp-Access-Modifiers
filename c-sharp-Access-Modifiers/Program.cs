using c_sharp_Access_Modifiers;
using ClassLibrary1;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //Class1 anynumber = new Class1(5);
        //Console.WriteLine(Class1.somenumber);
        //Console.WriteLine(anynumber.getNumberofWeels());

        //Console.WriteLine("&&&&&&&&&&&&&&&");

        //Class1 anyvalue = new Class1(6);
        //Console.WriteLine(Class1.somenumber);
        //anyvalue.getNumberofWeels();

        //Console.WriteLine(anyvalue.getNumberofWeels());

        //Class1 anyvalue2 = new Class1(7);
        //Console.WriteLine(Class1.somenumber);

        //Console.WriteLine(anyvalue2.getNumberofstaticweels()); 
        
        SportCar newcar=new SportCar( "engine2J", 4, 4, "Automatic", "red", "double nitres", "specialBelt");
        newcar.printData();

    }
}