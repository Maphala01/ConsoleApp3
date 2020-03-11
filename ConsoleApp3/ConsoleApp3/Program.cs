using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string file_path = "I have asked the question in StackOverflow. Therefore i can expect answer here.";
            //Text = Text.ToLower();

            string file_path = @"C:\Users\IQ\Desktop\War and Peace by graf Leo Tolstoy.txt";
            //file_path = file_path.ToLower();

            StreamReader sr = new StreamReader(file_path);

            while (!sr.EndOfStream)
            {
                string text = sr.ReadToEnd();

                Dictionary<string, int> frequencies = null;
                frequencies = new Dictionary<string, int>();
                string[] words = Regex.Split(text, "\\W+");
                foreach (string word in words)
            {
                if (frequencies.ContainsKey(word) )
                {
                        
                    frequencies[word] += 1;
                        
                }
                else
                {
                    frequencies[word] = 1;
                }
            }


            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine(word.ToString() + "," + frequency.ToString());
            }
            Console.ReadLine();
        }
    }
}}

