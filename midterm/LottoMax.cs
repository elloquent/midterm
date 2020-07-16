using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace midterm
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        /// <summary>
        /// method that is called to display the result on the screen
        /// </summary>
        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            for (int p = 1; p <= 7; p++)
            {
                base.PickElements();
                Console.WriteLine(base.ToString());
            }
        
        }
    }
}