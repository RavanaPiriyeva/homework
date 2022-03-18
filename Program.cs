using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task 1
            //Console.WriteLine("Reqemlerin sayini daxil et :");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[size];

            //Console.WriteLine("Reqemleri daxil et :");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Yeni ededi daxil et :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yeni siyahi :");


            //NewArray(  ref nums, num);

            //foreach (var item in nums)
            //{

            //    Console.WriteLine(item);
            //}
            #endregion


            #region task 2
            //Console.WriteLine("Cumleni daxil et :");
            //string word = Console.ReadLine();
            //Delete(ref word);
            //Console.WriteLine("Alinan soz:");
            //Console.WriteLine(word);

            #endregion


            #region task 3

            //Console.WriteLine("ededi daxil et:");
            //string numstr = Console.ReadLine();
            //int number = Convert.ToInt32(numstr);
            //Console.WriteLine("en yaxin kok altisi :");
            //FindSquareRoot(ref number);
            //Console.WriteLine(number);

            #endregion


            #region task 4
            //Console.WriteLine("Ededi daxil et:");
            //string numstr = Console.ReadLine();
            //int number = Convert.ToInt32(numstr);
            //Console.WriteLine("Yeni eded :");

            //int newnum = newNum(number);
            //Console.WriteLine(newnum);
            #endregion

        }
        static void NewArray(  ref int  []nums ,  int num)
        {
            int i;
            int[] newarr = new int[nums.Length +1];
            for (i = 0; i < newarr.Length; i++)
            {
                if(i<nums.Length)
                newarr[i] = nums[i];
                else
                {
                    newarr[i] = num;    
                }
            }
            nums = newarr;
        }
        static void Delete(ref string word)
        {
            string newWord ="";
            int i = 0;
            foreach (var item in word)
               
            {
                 if(item != ' ')
                {
                   newWord += word[i];
                 
                }
                   i++;
            }
            word = newWord;    
        }
        static void FindSquareRoot(ref int num)
        {
            int result = 0;
            for (int i = 0; i * i <= num; i++)
            {
                result = i;
            }
            num = result;
        }

        static int newNum(int num)
        {
            int y = num;
            int count = 0;
            int x = num % 10;
            int m = 1;
            while (y > 0)
            {
                y /= 10;
                count++;
            }
            while(count > 1)
            {
                m*=10;
                count--;
            }
           
                int r = (num-x) / 10;

            int result = x * m + r;
            return result;
        }
    }
}
