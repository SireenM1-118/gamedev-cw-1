using System;

namespace ConsoleApp1
{
    class Program

    {
       
        static double playerspeed = 40;
        static void Main(string[] args)
        {
            string charectername = "zac";
            string superpower1 = "steel armor";
            string superpower2 = "night vision";

            int age = 18;
            float speed = 22.55f;

            Console.WriteLine("Hello my name is " + charectername + " and my age is " + age + ". I have super powers : " + superpower1 + " and " + superpower2 + ". My speed is {0}", speed);

            string HeroName = "Jack";
            string herosuperpower1 = "flying";
            string herosuperpower2 = "invisibility";

            double heroheight = 177;
            int heroage = 33;

            double age_differance = heroage - age;
            Console.WriteLine(" The age difference between the two characters is {0}", age_differance);

            setspeed(2.5);
            Console.WriteLine("the player current speed is " + getspeed());


            checkpower();


        }

        static void setspeed(double newspeed)
        {

            playerspeed = newspeed;

        }

        static double getspeed()
        {
            return playerspeed;
        }
        
        static void checkpower() {
            int[] characterpower = { 88, 99, 60, 55 };
            if (characterpower[0] < characterpower[2]) {
                Console.WriteLine("power three is greater than power one"); }

               

            else if (characterpower[0] > characterpower[2]) {
                Console.WriteLine("power one is greater than power three");
            }



            else
            {
                Console.WriteLine("neither one is greater");
            }

        }


    }
       
    }

