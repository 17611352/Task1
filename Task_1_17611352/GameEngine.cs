using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_17611352
{
    class GameEngine
    {
        public int numOfRound;

        //Gets Filled by FindClosest() method
        int[] listOfPositions;

        Map map = new Map(20, 20);


        public void GameLogic()
        {
            numOfRound++;

            FindClosestUnit();
        }


        public void FindClosestUnit()
        {
            int nearestDistance;

            foreach (Unit unit in map.units)
            {
                for (int i = 0; i < map.units.Count; i++)
                {
                    double xSqr = Math.Pow(unit.xPos - map.units.ElementAt(i).xPos, 2);
                    double ySqr = Math.Pow(unit.yPos - map.units.ElementAt(i).yPos, 2);
                    double distance = Math.Round(Math.Sqrt(xSqr + ySqr));

                    //listOfSearchedPositionsX[i] = Convert.ToInt32(xSqr);
                    //listOfSearchedPositionsY[i] = Convert.ToInt32(ySqr);
                    listOfPositions[i] = Convert.ToInt32(distance);
                }

                nearestDistance = listOfPositions.Min();
                //nearestDistance = 5;

                for (int b = 0; b < listOfPositions.GetLength(0); b++)
                {
                    if (listOfPositions[b] == nearestDistance)
                    {
                        map.positionInList = b;
                    }
                }
            }



        }
    }
}
