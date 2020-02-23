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
            //String of unique characters
            int l1 = s1.Length;
            int l2 = s2.Length;
            int l3 = s3.Length;
            int l4 = 0;
            int[] values = new int[(10)];
            char[] letters = new char[(10)];
            Random random = new Random();
            add(s1.ToCharArray());
            add(s2.ToCharArray());
            add(s3.ToCharArray());

            for (int y = 0; y < letters.Length; y++) {
                Console.Write(letters[y]);
            }

            //values array
            for (int v = 0; v < letters.Length; v++) {
                values[v] = 0;
            }
            int iteration = 10000000;
            for (int i = 1; i < iteration; i++)
            {
                findvalues();
                for (int q = 0; q < l4; q++)
                {
                    for (int p = q + 1; p < l4; p++)
                    {
                        if (values[q] == values[p])
                        {
                            findvalues();
                            q = -1;
                            break;
                        }
                    }
                }

                int a1 = 0, a2 = 0, a3 = 0;

                for (int u = 0; u < l1; u++)
                {
                    a1 = (a1 * 10) + values[posit(letters, s1[u])];
                }
                for (int u = 0; u < l2; u++)
                {
                    a2 = (a2 * 10) + values[posit(letters, s2[u])];
                }
                for (int u = 0; u < l3; u++)
                {
                    a3 = (a3 * 10) + values[posit(letters, s3[u])];
                }
               // Console.WriteLine(a1);
                if (a1 + a2 == a3)
                {
                    Console.WriteLine("Solution Found");
                    for (int u = 0; u < l4; u++)
                    {
                        Console.WriteLine(letters[u] + "=" + values[u]);
                    }
                }
            }
            void findvalues() {
                int k;
                for (k = 0; k < l4; k++) {
                    values[k] = random.Next(0, 9);
                }
            }
            int posit(char[] str, char y) {
                int ai, bi;
                bi = str.Length;
                for (ai = 0; ai < bi; ai++) {
                    if (str[ai] == y)
                    {
                        return ai;
                    }
                    
                }
                return 0;


            }
           /* String b = uniqueCharacters(s1, s2, s3);
            b = b.Trim();
            Console.WriteLine(b.Length);
            char[] n_to_assign = b.ToCharArray();
            int n = n_to_assign.Length;
            Console.WriteLine(n);
            //value array that refers character array if unique characters
            int [] values = new int[(n)];
            //Assigning a number to character in unique strings then we will check the rules
            for (int y = 0; y <n;y++) {
                //Assigning a random variable 
                values[y] = 0;

            }
           *//* Random random = new Random();
            findnextValue();
            for (int re = 0; re < n; re++)
            {
                for (int er = re+1; er < n; er++)
                {
                    if (values[re] == values[er])
                    {
                        findnextValue();
                    }
                }
            }*/

           /* foreach (int Val in values)
            {
                Console.WriteLine(Val);
            }*/

            /* void findnextValue(){
                 for (int t = 0; t < n; t++) {
                     values[t] = random.Next(0,9);
                 }*//*




             }*/
            void add(char[] str)
            {
                int i, j, l;
                l = str.Length;
                for (i = 0; i < l; i++) {
                    for (j = l4 - 1; j >= 0; j--) {
                        if (letters[j] == str[i]) {
                            break;
                        }
                    }
                    if (j == -1) {
                        letters[l4] = str[i];
                        l4 = l4 + 1;
                    }
                
                }
            }


           /* static string uniqueCharacters(String str1, String str2, String str3)
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
                for (q = 0; q <= concat.Length-1; q++) {
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
                string numbers_to_assign = new string(no_duplicate);
                Console.WriteLine(numbers_to_assign);
                return numbers_to_assign;
                
                *//*foreach (char c in no_duplicate) {
                    Console.WriteLine(c);
                }*//*
                
                //Console.WriteLine(s11.Length);
            }*/






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
