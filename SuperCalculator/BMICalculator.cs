//Moa Burke
//13 Sept 2024

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator
{
    internal class BMICalculator
    {
        //Instance variabes for input
        private double height; //Variable to store user's height, in any unit
        private double weight; //Variable to store user's weight, inany unit
        private string name; //Variable to store user's name
        private UnitTypes unit; //Unit as a variable that decides whether the calculation will be done in metric or impetial

        //Constructor to call method that initializes the instance variables
        public BMICalculator()
        {
            unit = UnitTypes.Metric; //Default unit value as metric
        }

        #region Setters and getters

        /// <summary>
        /// Getter method: Gets the name input with the first letter to uppercase.
        /// </summary>
        /// <returns>The value stored in the name field.</returns>
        public string GetName()
        {
            return (char.ToUpper(name[0]) + name.Substring(1)); ;
        }

        /// <summary>
        /// Setter method: Sets the name of the user.
        /// </summary>
        /// <param name="name">The new value to be stored in the name field.</param>
        public void SetName(string name)
        {
            //Check if name input is empty
            if (!string.IsNullOrEmpty(name))
            {
                //Sets the name 
                this.name = name; 
            }
        }

        /// <summary>
        /// Getter method: Gets the height input.
        /// </summary>
        /// <returns>The value stored in the height field.</returns>
        public double GetHeight()
        {
            return height; //Returns the value of the height field
        }

        /// <summary>
        /// Setter method: Sets the height of the user if given value is not negative.
        /// </summary>
        /// <param name="height">The new value to be stored in the height field.</param>
        public void SetHeight(double height)
        {
            //Check if the value is 0.0 or larger
            if (height >= 0.0)
            {
                //Sets the height 
                this.height = height; 
            }
        }

        /// <summary>
        /// Getter method: Gets the weight input.
        /// </summary>
        /// <returns>The value stored in the weight field.</returns>
        public double GetWeight()
        {
            return weight; //Returns the value of the weight field
        }

        /// <summary>
        /// Setter method: Set the weight of the user if given value is not negative.
        /// </summary>
        /// <param name="weight">The new value to be stored in the weight field.</param>
        public void SetWeight(double weight)
        {
            //Check if the value is 0.0 or larger
            if (weight >= 0.0)
            {
                //Sets the weight 
                this.weight = weight; 
            }
        }

        /// <summary>
        /// Getter method: Gets the selected unit type.
        /// </summary>
        /// <returns>The value stored in the unitType field.</returns>
        public UnitTypes GetUnit() 
        { 
            return unit;
        }

        /// <summary>
        /// Setter method: Sets the unit type.
        /// </summary>
        /// <param name="unit">The new value to be stored in the unitType field.</param>
        public void SetUnit(UnitTypes unit)
        {
            //Sets the unit
            this.unit = unit; 
        }

        #endregion

        //Calculations
        //Pounds and inches
            //Formula: weight(lbs) / [height (inch)]2 x 703
        //Kilo and meters
            //Formula: weight(lbs) / [height (inch)]2 

        /// <summary>
        /// Calculated and returns the BMI value.
        /// </summary>
        /// <returns>The calculated BMI value.</returns>
        public double CalculateBMI()
        {
            double bmiValue = 0.0; //Variable to store the calculated BMI
            double factor = 1.0; //Variable for the factor used in the BMI calculation

            //Check if the selected unit type is Imperial
            if (unit == UnitTypes.Imperial)
            {
                //If the selected unit type is imperial set the factor to 703
                factor = 703.0;
            }

            //Calculate the BMI
            bmiValue = factor * weight / (height * height);

            //Returns the value of the calculated BMI
            return bmiValue;

        } //end of CalculateBMI method

        /// <summary>
        /// Determines the weight category based on the calculated BMI value and
        /// returns a correspoding string.
        /// Calls the method CalculateBMI before setting the category.
        /// </summary>
        /// <returns>A string representing the weight category based on the BMI-value.</returns>
        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI(); //Get the BMI value and store it in a local variable
            string stringOut = string.Empty; //Variable to store the sting to print 

            //Set string to print to user based on the BMI-value
            if (bmi < 18.5)
            {
                stringOut = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                stringOut = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                stringOut = "Overweight (Pre-obesity)";
            }
            else if (bmi <= 34.9)
            {
                stringOut = "Overweight (Obesity class I)";
            }
            else if (bmi <= 39.9)
            {
                stringOut = "Overweight (Obesity class II)";
            }
            else
            {
                stringOut = "Overweight (Obesity class III)";
            }

            //Returns a string representing the weight category based on the BMI-value
            return stringOut;

        } //end of BMIWeightCategory method

        /// <summary>
        /// Calculates and returns the range of normal weight values based on the user's height.
        /// </summary>
        /// <returns>A string that displays the range of the normal weight.</returns>
        public string NormalWeight()
        {
            string stringOut = ""; //Variable to store the unit selected by user
            string unitSelected = " kg"; //Variable to store the selected unit with metric as default value

            double lowerWeight; //Variable to store the calculated lower weight
            double higherWeight; //Variable to store the calculated higher weight
            double lowerBMIValue = 18.5; //Lowest value for normal BMI
            double higherBMIValue = 24.9; //Highest value for normal BMI

            double factor = 1.0; //Variable for the factor used in the calculation

            //Check what unit is selected
            if (unit == UnitTypes.Imperial) //Imperial is selected
            {
                factor = 703.0;
                unitSelected = " lbs";
            }

            //Calculate the lower weight value
            lowerWeight = (lowerBMIValue * (height * height)) / factor;

            //Calculate the lower weight value
            higherWeight = (higherBMIValue * (height * height)) / factor;

            //String to be displayed to user
            stringOut = "Normal weight for your height should be between " + lowerWeight.ToString("f0") + " and " + higherWeight.ToString("f0") + unitSelected;

            //Returns a string that displays the range of the normal weight
            return stringOut;

        } //end of NormalWeight method
    }
}
