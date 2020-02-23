using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 2, 2, 2, 2, 2 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            int k = 4;
            Console.WriteLine(ContainsDuplicate(arr, k));

            solvePuzzle();

        }

        public static void solvePuzzle() {
            // Input Strings
            Console.WriteLine("Enter the first String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter the second String");
            String s2 = Console.ReadLine();

            //Output Strings
            Console.WriteLine("Enter the Output String");
            String s3 = Console.ReadLine();

            uniqueCharacters(s1, s2, s3);

            void uniqueCharacters(String str1, String str2, String str3)
            {
                char[] s1 = str1.ToCharArray();
                char[] s2 = str2.ToCharArray();
                char[] s11 = new char[(str3.Length)];
                char[] s22 = new char[(str3.Length)];
                char[] temp4 = str3.ToCharArray();


                int j = str1.Length - 1;
                for (int i = str3.Length - 1; i >= 0; i--)
                {
                    if (j >= 0)
                    {
                        s11[i] = s1[j];
                        j--;
                    }
                    
                    else {
                    s11[i] = '0';
                    }
                }

                int k = str2.Length - 1;
                for (int i = str3.Length - 1; i >= 0; i--)
                {
                    if (k >= 0)
                    {
                        s22[i] = s2[k];
                        k--;
                    }

                    else
                    {
                        s22[i] = '0';
                    }
                }
                int q = 0; int v = 0;int index = 0;
                String str_duplicate = str1 + str2 + str3;
                char[] concat = str_duplicate.ToCharArray();
                char[] no_duplicate = new char[(concat.Length)];
                for (q = 0; q < concat.Length - 1; q++) {
                    for (v = 0; v < q; v++) {
                        if (concat[q] == concat[v]) {
                            break;
                        
                        }
                    }
                    if (q == v)
                    {
                        no_duplicate[index] = concat[q];
                        index++;
                    }
                

                }
                foreach (char c in no_duplicate) {
                    Console.WriteLine(c);
                }
                //Console.WriteLine(s11.Length);
            }

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
                            ///if duplicates are in range like 2,2,2,2,2
                            if (l2[i + 2] < l2[i + 1])
                            {
                                int c = l2[i + 1] - l2[i + 2];
                                l2[i + 2] = c + l2[i + 2];
                            }
                        }
                    }
                    
                    sum = sum + l2[i +1];
                    
                }
                /*for (int j = 0; j < l2.Length; j++) {
                    Console.WriteLine(l2[j]);
                }*/
                
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
                        //Console.WriteLine(myDict[arr[i]]);
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
