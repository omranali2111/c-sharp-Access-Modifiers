using ClassLibrary1;
internal class Program
{
    private static void Main(string[] args)
    {
        Class1 anynumber = new Class1(5);
        Console.WriteLine(Class1.somenumber);
        Console.WriteLine(anynumber.getNumberofWeels());

        Console.WriteLine("&&&&&&&&&&&&&&&");

        Class1 anyvalue = new Class1(6);
        Console.WriteLine(Class1.somenumber);
        anyvalue.getNumberofWeels();

        Console.WriteLine(anyvalue.getNumberofWeels());

        Class1 anyvalue2 = new Class1(7);
        Console.WriteLine(Class1.somenumber);




    }
}