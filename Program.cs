using System;
using System.Collections.Generic;
using System.Linq;

namespace CFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Output!");
            for (var counter = 1; counter < 501; counter++)
                { 
                    String strOutput = "";
                    List<String> strOutputList = new List<String>();
                    List<String> strBong = new List<String>{"Bong"};
                    string[] strFezz = { "Fezz" };
                    
                    if (counter%3 == 0 )
                    {
                        strOutputList.Add("Fizz");
                    } 
                    if (counter%5 == 0 )
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
                    if (counter%13 == 0 )
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
