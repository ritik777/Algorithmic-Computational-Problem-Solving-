using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 2, 4,4,4 };
            int sum = MinimumSum(l2);
            Console.WriteLine("The sum is:"+ sum);

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            int k = 4;
            Console.WriteLine(ContainsDuplicate(arr, k));

            solvePuzzle();

        }

        public static void solvePuzzle() {
            //Break down of logic

            /*1) we take input strings and output strings 
            2) we add all the strings to get only distinct characters*/
          
                //// .....BRUTE FORCE .....////
          
         /* 3) we assign random numbers to the distinct characters such that numbers are also distinct.
            4) we add all the numerical assignment of character in string 1 and string 2 respectively
            5) we add the resulting numeric output of string 1 and 2 and check it with addition of numerical 
            assigned characters in string 3*/

           /* We iterate over and over with new randomized assigned value set until our rules get matched
                */


            // Input Strings
            Console.WriteLine("Enter the first String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter the second String");
            String s2 = Console.ReadLine();

            //Output Strings
            Console.WriteLine("Enter the Output String");
            String s3 = Console.ReadLine();
            //String lengths
            int l1 = s1.Length;
            int l2 = s2.Length;
            int l3 = s3.Length;
            int l4 = 0;
            /*// Since we are getting distinct numbers for distinct characters between 0 and 9
            //so there cannot be more than 10 values*/
            int[] values = new int[(10)];
            //letters for distinct letters
            char[] letters = new char[(10)];
            //for random variables
            Random random = new Random();
            //duplicate_removal calls for a function to remove duplicate characters when added
            // after removing duplicates they are added to letters character array
            duplicate_removal(s1.ToCharArray());
            duplicate_removal(s2.ToCharArray());
            duplicate_removal(s3.ToCharArray());

            //printing duplicate elements
            Console.WriteLine("Distinct elements are as follows:");
            for (int y = 0; y < letters.Length; y++) {
                Console.Write(letters[y]);
            }

            //initiating the value array to 0.
            // indirectly this array will pinpoint to distinct letters array when we do number assignment check
            for (int v = 0; v < letters.Length; v++) {
                values[v] = 0;
            }
            // iteration means maximum times our algorithm will check until we get our desired rules and numbers
            int iteration = 10000000;
            for (int i = 1; i < iteration; i++)
            {
                //findvalues referes to random assignment of numbers to value array which is indirectly referenced by letter array
                findvalues();
                /*// since every alphabet will have only one distinct number so we iterate again if there are same values
                for two or more characters*/
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
                /*// following code checks our number assigned for rules
                eg(uber + cool = uncle)*/
                int a1 = 0, a2 = 0, a3 = 0;

                for (int u = 0; u < l1; u++)
                {
                    /* posit() is the function that indirectly assigns our distinct letter in ( letters array)
                     to a number in values array*/

                    /*function returns the position of character traversed now in the string and here it is
                    referenced to values array which has random distinct numbers*/

                    /* multiplied by 10 for carryover operations. 
                         Also, added all the numeric assignments in the given string*/


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
               /*//check if addition of numbers assigned of input string results in equality of addition of number
               assigned in output string*/
                if (a1 + a2 == a3)
                {
                    Console.WriteLine("Solution Found");
                    for (int u = 0; u < l4; u++)
                    {
                        Console.WriteLine(letters[u] + "=" + values[u]);
                    }
                    break;
                }
                
            }
            void findvalues() {
                int k;
                for (k = 0; k < l4; k++) {
                    values[k] = random.Next(1, 9);
                }
            }
            // This is the posit function: 
           /* it takes parameters as in character string(letters)
                and the character in the input or output string*/

            //This function returns the position of matched letter in the string to letters array. 
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
          
            void duplicate_removal(char[] str)
            {
                //function to check duplicate values and only taking distinct elements
                int i, j, l;
                l = str.Length;
                for (i = 0; i < l; i++) {
                    for (j = l4 - 1; j >= 0; j--) {
                        if (letters[j] == str[i]) {
                            break;
                        }
                    }
                    // this condition inserts distinct value in letters
                    if (j == -1) {
                        letters[l4] = str[i];
                        l4 = l4 + 1;
                    }
                
                }
            }







        }

        public static int MinimumSum(int[] l2)
        {
           
           

            try
            {
                //Initiated the sum with first value as the array 0th position
                int sum = l2[0];
                int i;
                //Traversing i till end of l2 array -1 
                for (i = 0; i < l2.Length - 1; i++)
                {   /*//
                    This condition compares the number ahead with number before in the array
                    if it finds duplicate numbers it adds the number which is ahead by 1.
                    */
                    if (l2[i + 1] == l2[i])
                    {
                        l2[i + 1] = l2[i] + 1;

                        /*//if there are multiple duplicates in range eg. 2,2,2,2
                        then it would only change the next digit. All other digit will still remain the same
                         violating question's condition of being a sorted array.*/
                        // eg.(2,2,2,2) -> 2,3,2,2
                         
                        //code below solves such a problem

                       // traverses till there can not be anymore violation of sorting 
                        if (i < l2.Length - 2)
                        {
                            //for repetative duplicates like (2,2,2....). 
                            //Since now the previous element has changed for eg.(2,2,2..)->(2,3,2).
                  /*//so in this case 
                   * we change the element after changed number, by the absolute difference of changed number
                   * and number after that*/ 
                            if (l2[i + 2] < l2[i + 1])
                            {
                                int c = l2[i + 1] - l2[i + 2];
                //adding the difference to the number after that
                //i.e eg(2,3,2) -> (2,3,3) 
                                l2[i + 2] = c + l2[i + 2];
                    // so now in the other iteration from now, our condition to check duplicates won't fail
                            }
                        }
                    }
                    //iteratively generating the sum
                    sum = sum + l2[i +1];
                    
                }
                Console.WriteLine("transformed array if duplicates were found: ");
                for (int j = 0; j < l2.Length; j++)
                {
                    Console.Write(l2[j]+", ");
                }
                return sum;
            }
            catch (Exception)
            {
                throw;
            }

            
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                Dictionary<char, int> myDict = new Dictionary<char, int>();
               //traversing through each element in the array
                for (int i = 0; i < arr.Length; i++) {
                    //following if condition performs two functions
                    /*1) if element is in the array and not in dictionary 
                    add that into dictionary with value being its position */

                /*2) if element is in the dictionary already go to else function where 
                    difference in position is calculated and stored in dictionary
               */
                    if (!myDict.ContainsKey(arr[i]))
                    {
                        myDict.Add(arr[i], i );
                    }

                    else {
                        // v takes the value of previous position of the identical key
                        int v = myDict[arr[i]];
                        // new_v is calculated as difference between current position and previous position 
                        int new_v = i - v;
                        //This new value is substituted in place of previous held key 
                        //and value marking the difference in the position
                        myDict[arr[i]] = new_v;
                        
                        //check condition if the change in value is less than k.

                        if (myDict[arr[i]] <= k)
                        {
                            return true;
                        }
                        
                        
                    }
                    
                   
                }
                return false;
                






            }
            catch (Exception)
            {
                throw;
            }
            
        }


    }


}
