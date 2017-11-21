using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string test = "Brian";
            //char[] name = new char[10];
            //name = test.ToCharArray();

            List<string> imaList = new List<string>();

            imaList.Add("wow");
            imaList.Add("okay");
            imaList.Add("let's see");
            imaList.Insert(1, "candy");

            string test = imaList.ElementAt(2);

            Console.WriteLine(test);

            foreach (string item in imaList)
            {
                Console.WriteLine(item);
            }

            string sentence = "this is original string another string";
            string piece = sentence.Substring(17, 3);

            int times = 0;
            
            if (sentence.Contains(piece))
            {
                times++;
            }

            Console.WriteLine("The string " + "'" + piece + "'" + " occurs " + times + " times.");

            //Console.WriteLine(SubbyString(sentence));



            
        }
   

        //string furtherDown = test.Substring(4);
        //int moreTest = test.IndexOf(' ');

        //Console.WriteLine(furtherDown);
        //Console.WriteLine(test.Substring(moreTest + 2));




        //string x = name[2];


        //Console.WriteLine(name[2]);
        //Console.ReadLine();

        //int[] numbers = { 7, 9, 14, 1, 2, 8, 3, 22, 11, 4 };

        //public static string SubCount(string count)
        //{

        //}




        public static string SubbyString(string original)
        {
            string newString = original.Substring(17, 3);


            return newString;

        }
    }
}
//            string test = "Bobby";
//            string otherTest = "Phil";


//            Console.WriteLine(test += otherTest);

//        }


//        public static int FindEvenIndex(int[] arr)
//        {
//            int[] testArray = new int[1000];

//            for (int i = 0; i <= arr.Length; i++)
//            {
//                if (i < 0)
//                {
//                    i--;
//                }

//                arr[i] = testArray[i];

//                int[] equals = arr;

//                equals.Equals(FindEvenIndex(arr));

              

                

//            }
//        }

//        r
//    }eturn equals;

//}


//public static string Longest(string s1, string s2)
//{
//  if(s1.Substring==s1.Substring

//char[] firstOne = s1.ToCharArray();
//char[] secondOne = s2.ToCharArray();

//if (firstOne.Substring(1, 32))

//for (char i = 'a'; i <= 'z'; i++)
//{
//    if (firstOne

//            }
//        }
//    }
//}





//Below are two ways to solve the maskify challenge to put #### in all but last four cc digits


//public static string Maskify(string cc)
//        {
//            var cs = cc.ToCharArray();

//            for (int i = 0; i < cc.Length - 4; i++)
//            {
//                cs[i] = '#';
//            }

//            return string.Concat(cs);
//        }
//    }
//}
//public static string Maskify(string cc)
//    {
//        int len = cc.Length;
//        if (len<=4)
//        {
//            return cc;
//        }
//        else
//        {
//            return cc.Substring(len).PadLeft(3, '#');
//        }
//        }
//    }
//}
