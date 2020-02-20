using System;

namespace oobcsClass
{
    class Fruit
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Console.WriteLine("");
            
            Citrus myCitrus = new Citrus();
            myCitrus.bite();
            myCitrus.tasteSour();
            Console.WriteLine("The color of the outside of the " + myCitrus.citrusType[1] +  " is " + myCitrus.color[3] + " and the size of the fruit is " + myCitrus.sizeS + ".");

            Console.WriteLine("");

            Melon myMelon = new Melon();
            myMelon.bite();
            myMelon.tasteSweet();
            Console.WriteLine("The color of the inside of the " + myMelon.melonType[0] +  " is " + myMelon.color[0] + " and the size of the fruit is " + myMelon.sizeL + ".");
        }
    }
}
