namespace LadyBugs
{
    using System;
    using System.Linq;

    public class LadyBugs
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var ladyBugsIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var ladybugs = new int[size];
            foreach (var ladyBugsIndex in ladyBugsIndexes)
            {
                if (ladyBugsIndex < 0 || ladyBugsIndex >= size) continue;
                ladybugs[ladyBugsIndex] = 1;
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                var inputParams = input.Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

                var currentIndex = int.Parse(inputParams[0]);
                var direction = inputParams[1];
                var flyLength = int.Parse(inputParams[2]);

                if (currentIndex < 0 || currentIndex >= size)
                {
                    continue;
                }

                if (ladybugs[currentIndex] == 0)
                {
                    continue;
                }

                ladybugs[currentIndex] = 0;
                var position = currentIndex;

                while (true)
                {
                    if (direction == "right") 
                    {
                        position += flyLength;
                    }

                    else
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (ladybugs[position] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        ladybugs[position] = 1;
                        break;
                    }

                }
            }
            Console.WriteLine(string.Join(" ",ladybugs));
        }
    }
}
