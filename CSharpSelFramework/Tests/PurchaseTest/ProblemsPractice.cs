using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelFramework.Tests.PurchaseTest
{
    class ProblemsPractice
    {
        //wwwwprreetrtw
        //w4p1r2e2t1r1t1w1

        //[Test]
        //public void Practice()
        //{
        //    String str = "wwwwprreetrtw";
        //    HashSet<Char> set = new HashSet<Char>();
        //    foreach(Char c in str)
        //    {
        //        set.Add(c);
        //    }

        //    foreach(char c in set)
        //    {
        //        for(int i = 0; i < str.Length; i++)
        //        {
        //            int count = 0;
        //            while(c == str[i])
        //            {
        //                count++;
        //                i++;
        //            }
        //            Console.WriteLine(c+" "+count);
        //        }
        //    }
        //}

        //[Test]
        public void numberofoccuranceofeachchar()
        {
            string str = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach (char c in str)
            {
                set.Add(c);
            }
            foreach (char ch in set)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ch)
                    {
                        count++;
                    }
                }
                Console.WriteLine(ch + " : " + count);
            }
        }

        //[Test]
        public void PrintOnlyDuplicateCharInTheGivenString()
        {
            string str = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach(char c in str)
            {
                set.Add(c);
            }
            foreach(char ch in set)
            {
                int count = 0;
                for(int i = 0; i < str.Length; i++)
                {
                    if(str[i] == ch)
                    {
                        count++;
                    }
                }
                if(count > 1)
                {
                    Console.WriteLine(ch+" : "+count);
                }
            }
        }

        //[Test]
        public void PrintOnlyUniqueCharInTheGivenString()
        {
            string str = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach(char c in str)
            {
                set.Add(c);
            }
            foreach(Char ch in set)
            {
                int count = 0;
                for(int i = 0; i < str.Length; i++)
                {
                    if(str[i] == ch)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(ch+" : "+count);
                }
            }
        }

        //[Test]
        public void RemoveDuplicateCharFromGivenString()
        {
            string str = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach(char c in str)
            {
                set.Add(c);
            }
            foreach(char ch in set)
            {
                Console.Write(ch);
            }
        }

        //[Test]
        public void NumberOfOccuranceOfEachWordInTheGivenSring()
        {
            string str = "Hello I am from Bangalore and I am in Yelahanka";
            String[] word = str.Split(' ');
            HashSet<String> set = new HashSet<String>();
            foreach(String s in word)
            {
                set.Add(s);
            }
            foreach(String st in set)
            {
                int count = 0;
                for(int i = 0; i < word.Length; i++)
                {
                    if(word[i] == st)
                    {
                        count++;
                    }
                }
                Console.WriteLine(st+" : "+count);
            }          
        }

        //[Test]
        public void PrintOnlyDuplicatWordInTheGivenStirng()
        {
            string str = "I am from Bangalore I am in Yelahanka";
            String[] word = str.Split(' ');
            HashSet<string> set = new HashSet<string>();
            foreach(string s in word)
            {
                set.Add(s);
            }
            foreach(string st in set)
            {
                int count = 0;
                for(int i = 0; i < word.Length; i++)
                {
                    if(word[i] == st)
                    {
                        count++;
                    }
                }
                if(count > 1)
                {
                    Console.WriteLine(st+" : "+count);
                }
            }
        }

        //[Test]
        public void PrintOnlyUniqueWordFromTheGivenString()
        {
            String str = "I am from Bangalore I am in Yelahanka";
            String[] word = str.Split(' ');
            HashSet<string> set = new HashSet<string>();
            foreach(String s in word)
            {
                set.Add(s);
            }
            foreach(String st in set)
            {
                int count = 0;
                for(int i = 0; i < word.Length; i++)
                {
                    if(word[i] == st)
                    {
                        count++;
                    }
                }
                if( count == 1)
                {
                    Console.WriteLine(st+" : "+count);
                }
            }
        }

        //[Test]
        public void AuthenticationPopupHandle()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth");
            Thread.Sleep(4000);
        }

        //[Test]
        public void FileUploadPopUp()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"C:\Users\Rahul Srivastava\OneDrive\Desktop\FileUploadPopup.html");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("cv")).SendKeys(@"C:\Users\Rahul Srivastava\OneDrive\Desktop\XPATH INTERVIEW QUESTIONS.docx");
            Thread.Sleep(3000);
        }

        [Test]
        public void PrintLastThreeStringElements()
        {
            String str = "Rahul";
            //int count = str.Length;
           
                Console.WriteLine(str.Substring(str.Length-3));
        }
    }
}
