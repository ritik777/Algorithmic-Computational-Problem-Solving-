using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2,2,2,4,5,7 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'b', 'c','a','b','c' };
            int k = 2;
            Console.WriteLine(ContainsDuplicate(arr, k));

        }

        public static int MinimumSum(int[] l2)
        {
            int sum = l2[0];

            try
            {
                int i;

                for (i = 0; i < l2.Length - 1; i++)
                {
                    
                    
                    if (l2[i + 1] == l2[i])
                    {
                        l2[i + 1] = l2[i] + 1;
                        if (i < l2.Length - 2)
                        {
                            if (l2[i + 2] < l2[i + 1])
                            {
                                int c = l2[i + 1] - l2[i + 2];
                                l2[i + 2] = c + l2[i + 2];
                            }
                        }
                    }
                    
                    sum = sum + l2[i +1];
                    
                }
                for (int j = 0; j < l2.Length; j++) {
                    Console.WriteLine(l2[j]);
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            return sum;
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                Dictionary<char, int> myDict = new Dictionary<char, int>();
               
                for (int i = 0; i < arr.Length; i++) {
                    if (!myDict.ContainsKey(arr[i]))
                    {
                        myDict.Add(arr[i], i );
                    }

                    else {
                        int v = myDict[arr[i]];
                        int new_v = i - v;
                        myDict[arr[i]] = new_v;
                        Console.WriteLine(myDict[arr[i]]);
                        if (myDict[arr[i]] <= k)
                        {
                            return true;
                        }
                        
                        
                    }
                    
                   
                }
                return false;
                //foreach (KeyValuePair<char, int> kvp in myDict)
                // {
                //     Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                //}






            }
            catch (Exception)
            {
                throw;
            }
            
        }


    }


}
