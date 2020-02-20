using System;

namespace oobcsClass
{
    public class Taste
    {
        public string[] color = {"red", "orange", "yellow", "green", "blue", "purple"};

        public void bite()
        {
            Console.WriteLine("*bite*");
        }

        public void tasteSour()
            {
                Console.WriteLine("I don't know. The fruit is a little sour.");
            }
        public void tasteSweet()
            {
                Console.WriteLine("Yay, the fruit is sweet!");
            }
        public void tasteBitter()
            {
                Console.WriteLine("Oh no, the fruit is bitter!");
            }
    }
}