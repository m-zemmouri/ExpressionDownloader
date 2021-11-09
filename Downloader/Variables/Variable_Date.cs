﻿/*
* ============================================================================
* THIS CODE IS GENERATED BY 'ClasseCodeGenerator'
* ZEMMOURI Mohamed m.zemmouri@gmail.com
* ============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZEMMOURI_Downloader.File_SourceDestination;

namespace ZEMMOURI_Downloader.Variables
{

    /// <summary>
    /// This Classe Describes The Date Vars 
    /// </summary>
    public class Variable_Date : Variable
    {
        #region Constructor

        /// <summary>
        /// The Constructor of DateVar
        /// </summary>
        public Variable_Date()
            : base(VariableType.Date)
        {
        }

        /// <summary>
        /// The Constructor of DateVar
        /// </summary>
        /// <param name="VarSymbol">The Symbol how represents the Var</param>
        /// <param name="FirstValue">The First Value</param>
        /// <param name="LastValue">The Last Value</param>
        /// <param name="StepValue">The Step Value</param>
        /// <param name="FormatValue">The Format of the Date</param>
        public Variable_Date(string VarSymbol, DateTime FirstValue, DateTime LastValue, Duration StepValue, string FormatValue)
            : base(VarSymbol, VariableType.Date)
        {
            first = FirstValue;
            last = LastValue;
            step = StepValue;
            format = FormatValue;
        }

        /// <summary>
        /// The Constructor of DateVar
        /// </summary>
        /// <param name="VarSymbol">The Symbol how represents the Var</param>
        /// <param name="FirstValue">The First Value</param>
        /// <param name="LastValue">The Last Value</param>
        /// <param name="StepValue">The Step Value</param>
        /// <param name="StepType">The Step Type</param>
        /// <param name="FormatValue">The Format of date</param>
        public Variable_Date(string VarSymbol, DateTime FirstValue, DateTime LastValue, int StepValue, DurationType StepType, string FormatValue)
            : base(VarSymbol, VariableType.Date)
        {
            first = FirstValue;
            last = LastValue;
            step = new Duration(StepValue, StepType);
            format = FormatValue;
        }
        #endregion

        #region Variables


        /// <summary>
        /// The First Value
        /// </summary>
        private DateTime first;

        /// <summary>
        /// The Last Value
        /// </summary>
        private DateTime last;

        /// <summary>
        /// The Step Value
        /// </summary>
        private Duration step;

        /// <summary>
        /// The Format Value
        /// </summary>
        private string format;

        #endregion

        #region Proprieties


        /// <summary>
        /// Get Or Set The First Value
        /// </summary>
        public DateTime First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        /// <summary>
        /// Get Or Set The Last Value
        /// </summary>
        public DateTime Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        /// <summary>
        /// Get Or Set The Step Value
        /// </summary>
        public Duration Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
            }
        }

        /// <summary>
        /// Get Or Set The Step Value
        /// </summary>
        public string Format
        {
            get
            {
                return format;
            }
            set
            {
                format = value;
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
            return "(" + Symbol + " : " + Type + " ; [" + First.ToString(Format) + "-" + Last.ToString(Format) + "]; " + Step.ToString() + ")";
        }

        /// <summary>
        /// Evaluate a FileSourceDestination that contient a variable
        /// </summary>
        /// <param name="Expression">Expression FileSourceDestination to evaluate</param>
        /// <returns>a List of FileSourceDestination </returns>
        public override List<FileSourceDestination> Evaluate(FileSourceDestination Expression)
        {
            List<FileSourceDestination> result = new List<FileSourceDestination>();
            if (Expression.SymbolExist(Symbol))
            {
                string value;
                for (DateTime index = First; DateTime.Compare(index, Last) <= 0; index = index.Add(Step.GetDuration()))
                {
                    value = index.ToString(Format);
                    result.Add(Expression.SymbolReplace(Symbol, value));
                }
            }
            else
            {
                result.Add(Expression);
            }
            return result;
        }

        #endregion

    }
}
