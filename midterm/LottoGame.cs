﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<int> ElementList
        {
            get
            {
                return _elementList;
            }
        }
        public int ElementNumber { get; set; }
        public List<int> NumberList
        {
            get
            {
                return _numberList;
            }
        }
        public Random Random { get; }
        public int SetSize { get; set; }


        // CREATE public properties here -----------------------------------------

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// method initializing the instance of the lists
        /// </summary>
        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {
            _numberList = new List<int>();
            _elementList = new List<int>();
            _random = new Random();
        }

        /// <summary>
        /// method build is used the add numbers from 1 to 49 to the list
        /// </summary>
        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
            for (int i = 1; i <= SetSize; i++)
            {
                _numberList.Add(i);
            }

        }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;
            
            // for each lottoNumber in ElementList, loop...
          
                foreach (int lottoNumber in ElementList)
                {
                    // add lottoNumber and appropriate spaces to the lottoNumberString variable

                    lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
                
                }
                
            

            return $"Ticket: {lottoNumberString}";
        }
        /// <summary>
        /// this method is used to add random numbers to the list and also used to clear the list base on criteria
        /// </summary>
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void PickElements()
        {
            int count = 1;
            if (ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();
                _build();
            }
            while (count <= ElementNumber)
            {
                int selectnumber = _random.Next(_numberList.Count);
                _elementList.Add(selectnumber);
                NumberList.Remove(selectnumber);
                _elementList.Sort();
                count++;
            }
            


        }

        // CREATE the public PickElements method here ----------------------------
    }
}
