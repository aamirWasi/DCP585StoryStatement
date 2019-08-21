using System;
namespace StoryStatement
{
    public class DCP544GAMORAConfusion
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string name = Console.ReadLine();
                if (name.Contains("Quill"))
                {
                    Console.WriteLine("I am going to ask you this one time, where is Gamora?");
                }
                else if (name.Contains("Stark"))
                {
                    Console.WriteLine("I will do you one better, who is Gamora?");
                }
                else if (name.Contains("Drax"))
                {
                    Console.WriteLine("I will do you one better, why is Gamora?");
                }
                else
                {
                    Console.WriteLine("What is Gamora?");
                }
            }
        }
    }
}
