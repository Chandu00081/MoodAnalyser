using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal  class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How is your mood HAPPY or SAD");
            string message = Console.ReadLine();
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            Console.WriteLine(moodAnalyzer.AnalyseMood(message));
        }
    }
}
