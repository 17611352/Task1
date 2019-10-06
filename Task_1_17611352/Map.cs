using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_17611352
{
    class Map
    {
        Random r = new Random();
        int mapSizeX = 20;
        int mapSizeY = 20;
        int totalNumMeleeUnit;
        int totalNumRangedUnit;

        int newXPos;
        int newYPos;

        public List<Unit> units = new List<Unit>();

        //List<int> usedXLocations = new List<int>();
        //List<int> usedYLocations = new List<int>();

        int[] usedXLocations = new int[20];
        int[] usedYLocations = new int[20];

        //Value assigned from FindClosestUnit() Method in GameEngine
        public int positionInList;


        //For Testing
        public int unitAt5Health;
        bool check = false;
        bool checkS = false;




        public Map(int totalMeleeUnit, int totalRangedUnit)
        {
            totalNumMeleeUnit = totalMeleeUnit;
            totalNumRangedUnit = totalRangedUnit;
        }


        public void GenerateMap()//Should only be called once as this method is only used to create objects of a specific unit
        {
            
            for (int i = 0; i < totalNumMeleeUnit; i++)
            {
                newXPos = r.Next(0, mapSizeX);
                newYPos = r.Next(0, mapSizeY);

                MeleeUnit mU = new MeleeUnit();
                mU.xPos = newXPos;
                mU.yPos = newXPos;
                mU.symbol = "{:}";
                mU.health = 150;
                mU.maxHealth = 150;

                units.Add(mU);

            }

            for (int i = 0; i < totalNumRangedUnit; i++)
            {
                RangedUnit rU = new RangedUnit();
                rU.xPos = r.Next(0, mapSizeX);
                rU.yPos = r.Next(0, mapSizeY);
                rU.symbol = "[!]";
                rU.health = 100;
                rU.maxHealth = 100;

                units.Add(rU);
            }

        }



        public void RealTimeMovement()//Updates new positons for all units
        {
            foreach(Unit unit in units)
            {    
                int newXPos;
                int newYPos;

                newXPos = units.ElementAt(positionInList).xPos;
                newYPos = units.ElementAt(positionInList).yPos;

                double xSqr = newXPos - unit.xPos;
                double ySqr = newYPos - unit.yPos;

                //unit.xPos += r.Next(-1, 1);
                //unit.yPos += r.Next(-1, 1);


                if (xSqr < 0)
                {
                    unit.xPos -= 1;
                }
                else if(xSqr > 0)
                {
                    unit.xPos += 1;
                }


                if(ySqr < 0)
                {
                    unit.yPos += 1;
                }
                else if (ySqr > 0)
                {
                    unit.yPos -= 1;
                }



                //These if statements makes sure that all object stay within the defined "group_box" area
                if (unit.xPos * 20 <= 0)
                {
                    unit.xPos += 5;
                }
                
                if(unit.xPos * 20 >= 400)
                {
                    unit.xPos -= 5;
                }

                if (unit.yPos * 15 <= 0)
                {
                    unit.yPos += 5;
                }

                if (unit.yPos * 15 >= 300)
                {
                    unit.yPos -= 5;
                }

            }

            //For Testing
            units.ElementAt(5).health -= 10;
            unitAt5Health = units.ElementAt(5).health;

            if (unitAt5Health <= 0)
            {
                unitAt5Health = 0;
            }


            int posOfUnitToRemove = 0;
            int var = 0;

            foreach (Unit unit in units)
            {
                var++;

                if (unit.health <= 0 && checkS == false)
                {
                    posOfUnitToRemove = var;
                    check = true;
                }
            }


            if(check == true)
            {
                units.RemoveAt(posOfUnitToRemove);
                check = false;
                checkS = true;
            }

        }
    }
}
