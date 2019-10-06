using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_17611352
{
    abstract class Unit
    {
        internal int xPos;
        internal int yPos;
        internal int health;
        internal int maxHealth;
        internal int speed;
        internal int attack;
        internal int attackRange;
        internal string team;
        internal string symbol;
        internal bool isAttacking;


        //public Unit(int Xpos, int Ypos, int Health, int Speed, int Attact, int AttackRange, string Team, string Symbol)
        //{
        //    xPos = Xpos;
        //    yPos = Ypos;
        //    health = Health;
        //    maxHealth = 100;
        //    speed = Speed;
        //    attack = Attact;
        //    attackRange = AttackRange;
        //    team = Team;
        //    symbol = Symbol;
        //}

        //public Unit()
        //{

        //}



        public abstract void Move();

        public abstract void Combat();

        public abstract void Range();

        public abstract void ClosestUnit();

        public abstract void DestroyUnit();
 
    }
}
