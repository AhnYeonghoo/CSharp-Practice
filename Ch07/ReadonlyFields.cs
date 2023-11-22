using System;

namespace ReadonlyField
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1 ,int v2)
        {
            min = v1;
            min = v2;
        }

        /*public void ChangeMax(int newMax)
        {
            max = newMax;
        }*/
    }
}