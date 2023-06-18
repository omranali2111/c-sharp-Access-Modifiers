namespace ClassLibrary1
{
    public class Class1
    {
        int numberofweel;
        public static int somenumber = 2;

        public Class1(int parameter)
        {
            numberofweel = parameter;
        }

        public int getNumberofWeels() {

            somenumber = somenumber * 10;
            return numberofweel*2;
        
        
        }

        public int  getNumberofstaticweels()

        {
            somenumber = somenumber * 2;
            return numberofweel * 4;

        }
    }
}