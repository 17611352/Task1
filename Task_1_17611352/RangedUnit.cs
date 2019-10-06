using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_17611352
{
    class RangedUnit : Unit
    {
        //internal int xPos;
        //internal int yPos;
        //internal int health = 100;
        //internal int maxHealth = 100;
        //internal int speed = 1;
        //internal int attackRange = 5;
        //internal string symbol "[!]";
        //internal bool isAttacking;

        public int Xpos
        {
            get { return base.xPos; }
            set { xPos = value; }
        }

        public int Ypos
        {
            get { return base.yPos; }
            set { yPos = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return base.speed; }
            set { speed = value; }
        }

        public int Attack
        {
            get { return base.attack; }
            set { attack = value; }
        }

        public string Team
        {
            get { return base.team; }
            set { team = value; }
        }

        public string Symbol
        {
            get { return base.symbol; }
            set { symbol = value; }
        }


        Map map = new Map(20, 20);
        int[] listOfSearchedPositionsX;
        int[] listOfSearchedPositionsY;

        public override void ClosestUnit()
        {
            //Form1 form = new Form1();
            //int nearestDistance;

            //for (int i = 0; i < map.units.Count; i++)
            //{
            //    double xSqr = Math.Pow(xPos - map.units.ElementAt(i).xPos, 2);
            //    double ySqr = Math.Pow(yPos - map.units.ElementAt(i).yPos, 2);
            //    double distance = Math.Round(Math.Sqrt(xSqr + ySqr));

            //    //listOfSearchedPositionsX[i] = Convert.ToInt32(xSqr);
            //    //listOfSearchedPositionsY[i] = Convert.ToInt32(ySqr);
            //    form.listOfPositions[i] = Convert.ToInt32(distance);
            //}

            //nearestDistance = form.listOfPositions.Min();

            //for (int b = 0; b < form.listOfPositions.GetLength(0); b++)
            //{
            //    if (form.listOfPositions[b] == nearestDistance)
            //    {
            //        map.positionInList = b;
            //    }
            //}

            //fix finding value closest to 0

            //map.xDistance = listOfSearchedPositionsX.Min();
            //map.yDistance = listOfSearchedPositionsY.Min();
            //listOfSearchedPositions.Min();

            //throw new NotImplementedException();
        }

        public override void Combat()
        {
            throw new NotImplementedException();
        }

        public override void DestroyUnit()
        {
            map.units.Remove(this);
            //throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Range()
        {
            throw new NotImplementedException();
        }
    }
}
