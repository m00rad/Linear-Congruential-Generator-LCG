using System;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    class Generator
    {
        //input 
        public int multiplier { get; set; }
        public int seed { get; set; }
        public int increment { get; set; }
        public int modulus { get; set; }
        public int NumOfIterations { get; set; }
        //output
        public int CycleLength { get; set; }
        public bool LongestLengthIsFound { get; set; }
        public List<LinearCongruential> linearCongruentials;
        //---------------------------------------------------
        public HashSet<int> RandNums; // Hashset is used because it doesn't contain any repeated  variables
        // Constructors
        public Generator()
        {
            linearCongruentials = new List<LinearCongruential>();
            RandNums = new HashSet<int>();
        }
        public Generator(int multiplier, int seed, int increment, int modulus,int NumOfIterations)
        {
            linearCongruentials = new List<LinearCongruential>();
            RandNums = new HashSet<int>();
            this.multiplier = multiplier;
            this.seed = seed;
            this.increment = increment;
            this.modulus = modulus;
            this.NumOfIterations = NumOfIterations;
        }
        public void RunLCG()
        {
            /// <summary>
            /// ---------------------- used variables -------------------------
            /// index            : used as an iterator 
            /// Rand             : used to save the generated random num (for reusability perpose only)
            /// </summary>
            int index = 0, Rand;
            LongestLengthIsFound = LongestCycleIsFound();        // Get Cycle Length And flag Used to declear which
            for (index = 0; index < NumOfIterations; index++)
            {
                if (index == 0)                                 // If it the first Random number
                    //Rand =seed;                               // use the seed  
                    Rand = GenetateRN(seed);
                else                                            // else generate random number
                    Rand = GenetateRN(linearCongruentials[index - 1].RandomNum);
                linearCongruentials.Add(new LinearCongruential(Rand, index));
                
            }
        }
        
        public int GenetateRN(int PrevRandNum)
        {
            int RandNum;
            RandNum = ((multiplier * PrevRandNum) + increment) % modulus;
            return RandNum;
        }
        public bool LongestCycleIsFound()
        {
            /// ---------------------- used variables -------------------------
            /// RandNums         : It's a hashSet contains the generated rundom numbers 
            int k = modulus - 1;
            CycleLength = -1;
            //Scenarios
            
            if (IsPowerOf2(modulus))
            {
                //-----------------------> 1 <-----------------------
                if (increment != 0 )
                {
                    if (IsRelativePrime(increment, modulus) && multiplier == ((4 * k) + 1))
                    {
                        CycleLength = modulus;
                        return true;
                    }
                }
                //-----------------------> 2 <-----------------------
                else // increment == 0 
                {
                    if (seed % 2 == 1 && (multiplier == (5 + (8 * k)) || multiplier == (3 + (8 * k))))
                    {
                        CycleLength = modulus / 4;
                        return true;
                    }
                }
            }
            //-----------------------> 3 <-----------------------
            else if (increment == 0 && IsPrime(modulus))
            {
                double TestVal = Math.Pow((double)multiplier, (double)k);
                if (IsDivisableBy((int)(TestVal - 1), modulus))
                {
                    CycleLength = k;
                    return true;
                }
            }
            //-----------------------> 4 <-----------------------
            if (CycleLength == -1)
            {
                int LastRandNum = -1;
                int RandomNumber=-1;
                for(int index=0; ;index++)                           // get Random numbers until the cycle ended
                {
                    if (index == 0)                                 // If it the first Random number
                        RandomNumber = GenetateRN(seed);            // use the seed  
                    else                                            // generate random number
                        RandomNumber = GenetateRN(LastRandNum);
                    
                    if (RandNums.Contains(RandomNumber))
                    {
                        CycleLength = RandNums.Count;
                        return false;
                    }
                    else
                    {
                        RandNums.Add(RandomNumber);
                        LastRandNum = RandomNumber;   
                    }
                }
            }
            return false;
        }
        public bool IsRelativePrime(int FirstNum, int SecondNum)
        {
            if (FirstNum == SecondNum || FirstNum % SecondNum == 0 || SecondNum % FirstNum == 0)
            {
                return false;
            }
            else if (FirstNum > SecondNum)
            {
                for (int i = 2; i <= SecondNum / 2; i++)
                {
                    if (FirstNum % i == 0 && SecondNum % i == 0)
                        return false;
                }
                return true;
            }
            else
            {
                for (int i = 2; i <= FirstNum / 2; i++)
                {
                    if (FirstNum % i == 0 && SecondNum % i == 0)
                        return false;
                }
                return true;
            }
        }
        public bool IsPrime(int Number)
        {
            if (Number == 2)
                return true;
            for (int i = 2; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsDivisableBy(int Num , int Divisor)
        {
            if (Num % Divisor == 0)
                return true;
            return false;
        }
        public bool IsPowerOf2(int Num)
        {
            double Number = (double)Num;
            double log2 ;
            log2 = Math.Log(Number,2);
            if (log2 % 1 == 0)
                return true;
            return false;
        }
    }
}
 
