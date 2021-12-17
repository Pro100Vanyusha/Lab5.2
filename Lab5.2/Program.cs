using System;

namespace Lab5._2
{
         interface ITool
        {
            string KEY { set { KEY = "До мажор"; } }
           
            void play();
        }
        class Guitar : ITool
        {
            public int quantity { get; set; }
            
            public Guitar(int quantity)
            {
                this.quantity = quantity;
            }
            public void play()
            {
                Console.WriteLine($"Грає гiтара з такою кiлькiстю струн - {quantity}");
            }
        }
        class Drum : ITool
        {
            public double size { get; set; }
           
             public Drum(double size)
            {
                this.size = size;
            }
            public void play()
            {
                Console.WriteLine($"Грає барабан з таким розмiром - {size} см");
            }
        }
        class Trumpet : ITool
        {
            public double diameter { get; set; }
            public Trumpet(double diameter)
            {
                this.diameter = diameter;
            }
            
        public void play()
            {
                Console.WriteLine($"Грає труба з таким дiаметром - {diameter}");
            }
        }
        
    class Program
        {
            static void Main(string[] args)
            {
                ITool[] tools = { new Guitar(6), new Drum(45.5), new Trumpet(5) };
                
                 foreach (ITool t in tools)
                {
                    t.play();
                }
            }
        }
    
}
