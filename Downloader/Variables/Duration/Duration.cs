using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZEMMOURI_Downloader.Variables
{
    /// <summary>
    /// This Classe Describes The Duration
    /// </summary>
    public class Duration
    {
        #region Constructor

        /// <summary>
        /// Constructor of Duration
        /// </summary>
        public Duration()
        {
        }

        /// <summary>
        /// Constructor of Duration
        /// </summary>
        /// <param name="DurationValue">The value of the Duration</param>
        /// <param name="DurationUnit">The Type of the Duration</param>
        public Duration(int DurationValue, DurationType DurationUnit)
        {
            value = DurationValue;
            type = DurationUnit;
        }

        #endregion

        #region Durations


        /// <summary>
        /// The value of the Duration
        /// </summary>
        private int value;

        /// <summary>
        /// The Type of the Duration
        /// </summary>
        private DurationType type;

        #endregion

        #region Proprieties


        /// <summary>
        /// The value of the Duration
        /// </summary>
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// The Type of the Duration
        /// </summary>
        public DurationType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        #endregion

        #region Methodes

        /// <summary>
        /// Return the string representation of the var.
        /// </summary>
        /// <returns>string representation of the var</returns>
        public override string ToString()
        {
            string result = value + " " + Type.ToString();

            if (Value > 1)
                result += "s";

            return result;
        }

        /// <summary>
        /// Get the Duration in TimeSpan
        /// </summary>
        /// <returns>a TimeSpan value</returns>
        public TimeSpan GetDuration()
        {
            long DurationSeconde = (long) Value * 10000000;

            switch (Type)
            {
                case DurationType.Year:
                    DurationSeconde *= 1 * 60 * 60 * 24 * 365;
                    break;
               
                case DurationType.Month:
                    DurationSeconde *= 1 * 60 * 60 * 24 * 30;
                    break;
                case DurationType.Day:
                    DurationSeconde *= 1 * 60 * 60 * 24;
                    break;
                case DurationType.Hour:
                    DurationSeconde *= 1 * 60 * 60;
                    break;
                case DurationType.Minute:
                    DurationSeconde *= 1 * 60;
                    break;
                case DurationType.Second:
                    DurationSeconde *= 1;
                    break;
            }
            return new TimeSpan(DurationSeconde);
        }

      
        #endregion
    }
}