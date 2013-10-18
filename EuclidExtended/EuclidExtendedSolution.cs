/*
 * Written by Benjamin Mestdagh (2013)
 * 
 */

using System;

namespace EuclidExtended
{
    public class EuclidExtendedSolution
    {
        private long x, y, d;

        public long X
        {
            get
            {
                return this.x;
            }
        }

        public long Y
        {
            get
            {
                return this.y;
            }
        }

        public long D
        {
            get
            {
                return this.d;
            }
        }

        public EuclidExtendedSolution(long x, long y, long d)
        {
            this.x = x;
            this.y = y;
            this.d = d;
        }
    }
}