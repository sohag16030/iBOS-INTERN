using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;

namespace ProblemSolvingModule
{
    class Program
    {
        static int x = int.Parse(Console.ReadLine());
        static IList<string> record = new List<string>();
        static IList<IList<string>> myList = new List<IList<string>>();
        static void Main(string[] args)
        {
            for (int i = 0; i < x; i++)
            {
                var preRec = Console.ReadLine().Split(' ');
                myList.Add(new List<string> { preRec[0], preRec[1], preRec[2] });

            }

            var line = Console.ReadLine().Split(' ');
            var ruleKey = line[0];
            var ruleValue = line[1];
            int ans = CountMatches(myList, ruleKey, ruleValue);
        }

        public static int CountMatches(IList<IList<string>> myList, string ruleKey, string ruleValue)
        {
            Dictionary<string, int> myDic1 = new Dictionary<string, int>();
            Dictionary<string, int> myDic2 = new Dictionary<string, int>();
            Dictionary<string, int> myDic3 = new Dictionary<string, int>();
            for (int i = 0; i < myList.Count; i++)
            {
                var type = myList[i][0];
                var color = myList[i][1];
                var name = myList[i][2];

                 if (myDic1.ContainsKey(type))
                    myDic1[type]++;
                 if (!myDic1.ContainsKey(type))
                    myDic1.Add(type, 1);
                 if (myDic2.ContainsKey(color))
                    myDic2[color]++;
                 if (!myDic2.ContainsKey(color))
                    myDic2.Add(color, 1);
                 if (myDic3.ContainsKey(name))
                    myDic3[name]++;
                 if (!myDic3.ContainsKey(name))
                    myDic3.Add(name, 1);
            }
            if (ruleKey == "type")
               return myDic1[ruleValue];
            else if (ruleKey == "color")
                return myDic2[ruleValue];
            else return myDic3[ruleValue];

           
        }
        
    }
}
