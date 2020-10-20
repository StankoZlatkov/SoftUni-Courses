using System;
using System.Linq;

namespace E10LadyBugs
{
    class LadyBugs
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string initialPosition = Console.ReadLine();
            string[] arrayPosition = initialPosition.Split(' ');
            int[] indexesOfLadyBugs = new int[fieldSize];

            for (int i = 0; i < indexesOfLadyBugs.Length; i++)
            {
                indexesOfLadyBugs[i] = 0;
                for (int k = 0; k < arrayPosition.Length; k++)
                {
                    if (i == int.Parse(arrayPosition[k]))
                    {
                        indexesOfLadyBugs[i] = 1;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (fieldSize == 0)
                {
                    continue;
                }

                string moveTo = string.Empty;
                int fromField = 0;
                int toField = 0;

                string[] arrayCommand = command.Split(' ');
                moveTo = arrayCommand[1];
                fromField = int.Parse(arrayCommand[0]);
                toField = int.Parse(arrayCommand[2]);

                int direction = 0;
                if (moveTo == "right")
                {
                    direction = 1;
                }
                else if (moveTo == "left")
                {
                    direction = -1;
                }

                if (fromField < 0 || fromField >= fieldSize || indexesOfLadyBugs[fromField] == 0)
                {
                    continue;
                }

                indexesOfLadyBugs[fromField] = 0;

                while (true)
                {
                    if (fromField + toField * direction >= fieldSize || fromField + toField * direction < 0)
                    {
                        break;
                    }
                    else if (indexesOfLadyBugs[fromField + toField * direction] == 1)
                    {
                        toField += toField;
                    }
                    else
                    {
                        indexesOfLadyBugs[fromField + toField * direction] = 1;
                        break;
                    }
                }
            }

            foreach (int index in indexesOfLadyBugs)
            {
                Console.Write(index + " ");
            }
        }
    }
}
