using System;
using System.Collections.Generic;
using System.Text;
using System.Speech.Synthesis;

namespace StringvsStringBuilder
{
    class Program
    {
        static SpeechSynthesizer speaker = new SpeechSynthesizer();

        static void Main(string[] args)
        {
            speaker.Volume = 100;
            Console.WriteLine("*** String vs. StringBuilder ***\n");
            TestString();
            TestStringBuilder();
            Console.WriteLine("\n\n");

            String name1 = "Youngmin ";
            concat1(name1); // s1 is not changed
            Console.WriteLine("Using String Class: " + name1);

            StringBuilder name2 = new StringBuilder("Youngmin ");
            concat2(name2); // s2 is changed
            Console.WriteLine("Using StringBuilder Class: " + name2);
        }

        static private void TestString()
        {
            string myString = "";
            string prompt = "What is your name?";
            Console.WriteLine(prompt);
            speaker.Speak(prompt);
            string myName = Console.ReadLine();

            if (myName == "")
                myName = "Mr. No Name";

            speaker.Speak("Good Morning " + myName);

            Console.WriteLine();
            prompt = "Begin by pressing enter to run the String version";

            Console.WriteLine(prompt);
            speaker.Speak(prompt);
            
            Console.ReadLine();

            DateTime startTime = DateTime.Now;
            Console.WriteLine(startTime);
            
            for (int i = 0; i < 80000; i++)
                myString += i.ToString();

            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime);

            int elapsedTime = (endTime - startTime).Seconds;
            speaker.Speak("Surprisingly that took " + elapsedTime + " seconds");

            Console.WriteLine();
            prompt = "Now press enter to run the String Builder version";
            Console.WriteLine(prompt);
            speaker.Speak(prompt);

            Console.ReadLine();
        }

        static private void TestStringBuilder()
        {
            StringBuilder myString = new StringBuilder("");

            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 80000; i++)
                myString = myString.Append(i);

            string fullString = myString.ToString();

            Console.WriteLine(DateTime.Now);

            speaker.Speak("As you can see, the String Builder version is much faster");
            Console.ReadLine();
        }


        // C# program to demonstrate the difference between String, StringBuilder from GeekforGeeks
        // Concatenates to String
        public static void concat1(String s1)
        {
            // taking a string which
            // is to be Concatenate
            String st = "Chung";

            // using String.Concat method
            // you can also replace it with
            // s1 = s1 + "forgeeks";
            s1 = String.Concat(s1, st);
        }

        // Concatenates to StringBuilder
        public static void concat2(StringBuilder s2)
        {
            // using Append method
            // of StringBuilder class
            s2.Append("Chung");
        }
    }
}
