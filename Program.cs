using System;

namespace hw14Plus
{
    class Program
    {
        //Public
        public void Places() {

            Console.WriteLine("I've been to Paris and Germany.");
            Console.ReadKey();

        }
        //Private
        private void States()
        {
            Console.WriteLine("I've Lived in Colorado, and Texas.");
            Console.ReadKey();
        }
        //Public int
        public int RetMuliInt()
        {
            int RetMultiInt = 25 * 25;
            return RetMultiInt;
         }
        //Public with Parameters
        public void home(String bedrooms, String bathrooms)
        {
            Console.WriteLine("I have two {0} and two {1}.", bedrooms, bathrooms);
        }

    }
    }


