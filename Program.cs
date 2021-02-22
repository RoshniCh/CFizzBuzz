using System;
using System.Collections.Generic;
using System.Linq;

namespace CFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToFind3 = "3";
            var result3 = Array.Find(args, element => element == stringToFind3);

            var stringToFind5 = "5";
            var result5 = Array.Find(args, element => element == stringToFind5);

            var stringToFind13 = "13";
            var result13 = Array.Find(args, element => element == stringToFind13);
         
            String inputMaxNumStr;
            int inputMaxNum;
            Console.Write("Till what number do you want to print the output: ");
			inputMaxNumStr = Console.ReadLine();
			inputMaxNum = Convert.ToInt32(inputMaxNumStr);

            for (var counter = 1; counter <= inputMaxNum; counter++)
                { 
                    String strOutput = "";
                    List<String> strOutputList = new List<String>();
                    List<String> strBong = new List<String>{"Bong"};
                    string[] strFezz = { "Fezz" };
                    
                    if (counter%3 == 0 && result3 == "3" )
                    {
                        strOutputList.Add("Fizz");
                    } 
                    if (counter%5 == 0 && result5 == "5" )
                    {
                        strOutputList.Add("Buzz");
                    }
                    if (counter%7 == 0 )
                    {
                        strOutputList.Add("Bang");
                    }
                    if (counter%11 == 0 )
                    {
                        strOutputList = strBong;
                    }
                    if (counter%13 == 0 && result13 == "13")
                    {
                        bool isEmpty = !strOutputList.Any();
                        if(isEmpty) 
                        {
                            strOutputList.InsertRange(0, strFezz);
                        } else if (strOutputList[0] == "Fizz")
                        {
                            strOutputList.InsertRange(1, strFezz);
                        } else
                        {
                            strOutputList.InsertRange(0, strFezz);
                        }
                    }
                    if (counter%17 == 0 )
                    {
                        bool isNotEmpty = strOutputList.Any();
                        if(isNotEmpty) 
                        {
                            strOutputList.Reverse();
                        }
                    }                    

                    strOutput = string.Join("", strOutputList);
                    
                    if (strOutput == "")
                    {
                        Console.WriteLine(counter);
                    }
                    else
                    {
                        Console.WriteLine(strOutput);
                    }
                }
        }
    }
}
