using System;

namespace _08_Orange_Tree
{
    public class OrangeTree
    {
        private int age = 0;
        private int height = 0;
        public bool treealive = true;
        private int numoranges = 0;
        private int orangeseaten = 0;

        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public bool TreeAlive
        {
            get
            {
                return treealive;
            }
            set
            {

            }

        }

        public int NumOranges
        {
            get
            {
                return numoranges;
            }
            set
            {
                numoranges = value;
            }
        }

        public int OrangesEaten
        {
            get
            {
                return orangeseaten;
            }
            set
            {
                orangeseaten = value;
            }
        }

        public void OneYearPasses()
        {
            age++;
            height = height + 2;
            if (age == 80)
                treealive = false;
            if (age >= 2)
                numoranges = numoranges + 5;
        }

        public void EatOrange(int v)
        {
            orangeseaten = orangeseaten + v;

            if (numoranges == 0) { throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat"); }
        }
    }
}