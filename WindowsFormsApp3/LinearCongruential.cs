using System;

namespace WindowsFormsApp3
{
    class LinearCongruential
    {
        public LinearCongruential()
        { }
        public LinearCongruential(int rand ,int count)
        {
            RandomNum = rand;
            Counter = count;
        }
        public int RandomNum { get; set; }
        public int Counter { get; set; }
    }
}
