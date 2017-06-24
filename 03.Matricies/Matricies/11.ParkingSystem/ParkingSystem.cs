using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ParkingSystem
{
    class ParkingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<int, HashSet<int>> parking = new Dictionary<int, HashSet<int>>();
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int totalRows = dimensions[0];
            int totalCols = dimensions[1];

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var parkTokens = input.Split().Select(int.Parse).ToArray();
                int entryRow = parkTokens[0];
                int targetRow = parkTokens[1];
                int targetCol = parkTokens[2];

                if (!IsPlaceOccupied(parking,targetRow,targetCol))
                {
                    OccupyPlace(parking, targetRow, targetCol);
                    int distance = Math.Abs( entryRow - targetRow);
                    distance += targetCol + 1;
                    Console.WriteLine(distance); 
                }
                else
                {
                    targetCol = TryFindEmptySpace(parking[targetRow],totalCols,targetCol);

                    if (targetCol==0)
                    {
                        Console.WriteLine($"Row {targetRow} full");
                    }
                    else
                    {
                        OccupyPlace(parking, targetRow, targetCol);
                        int distance = Math.Abs(entryRow - targetRow);
                        distance += targetCol + 1;
                        Console.WriteLine(distance);
                    }
                }
                input = Console.ReadLine();
            }
        }

        private static int TryFindEmptySpace(HashSet<int> hashSet,int totalNumberOfCols,int targetCol)
        {
            int targetCollIndex = 0;
            int minDistance = int.MaxValue;

            if (hashSet.Count==totalNumberOfCols-1)
            {
                return targetCollIndex;
            }
            else
            {
                for (int i = 1; i < totalNumberOfCols; i++)
                {
                    int currentDistance = Math.Abs(targetCol - i);
                    if (!hashSet.Contains(i) && currentDistance < minDistance)
                    {
                        targetCollIndex = i;
                        minDistance = currentDistance;
                    }
                }

                return targetCollIndex;
            }
        }

        public static bool IsPlaceOccupied(Dictionary<int, HashSet<int>> parking,int targetRow,int targetCol)
        {
            return parking.ContainsKey(targetRow) && parking[targetRow].Contains(targetCol);
        }

        public static void OccupyPlace(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            if (!parking.ContainsKey(targetRow))
            {
                parking.Add(targetRow, new HashSet<int>());
            }
            parking[targetRow].Add(targetCol);
        }
    }
}
