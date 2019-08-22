using System;
namespace StoryStatement
{
    public class DCP500WinkKick
    {
        static void Main()
        {
            ulong T = ulong.Parse(Console.ReadLine());
            for (ulong t = 1; t <= T; t++)
            {
                string input = Console.ReadLine();
                var inputArray = input.Split(' ');
                
                ulong num1 = ulong.Parse(inputArray[0]);
                ulong num2 = ulong.Parse(inputArray[1]);
                if (num2 != 0)
                {
                    var result = num1 % num2;
                    if (result == 0 && num1!=0)
                    {
                        Console.WriteLine(":wink:");
                    }
                    else
                        Console.WriteLine(":kick:");
                }
            }
        }
    }
}
