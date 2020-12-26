using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryTestSolid
{
    class Operations
    {
        int x;
        int y;

        /// <summary>
        /// Method add
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Addition(int x, int y)
        {
            this.x = x;
            this.y = y;
            int result = this.x + this.y;

            return result;
        }
    }
}
