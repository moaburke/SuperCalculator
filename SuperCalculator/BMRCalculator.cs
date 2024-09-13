//Moa Burke
//13 Sept 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class BMRCalculator
    {
        private int age; //Variable to store user's age
        private string name; //Variable to store user's name
        private double weight; //Variable to store user's weight, in metric unit
        private double height; //Variable to store user's height, in metric unit
        private GenderTypes gender; //Variable to store the selected gender
        private ActivityLevelTypes activityLevel; //Variable to store the selected activity level

        //Constructor to call the methos that initialized the instance variables
        public BMRCalculator()
        {
            gender = GenderTypes.Female; //Default gender value as female
            activityLevel = ActivityLevelTypes.Sedentary; //Default activity level value as sedentary
        }

        #region Setters and getters

        /// <summary>
        /// Getter method: Gets the gender selection.
        /// </summary>
        /// <returns>The value stored in the gender field.</returns>
        public GenderTypes GetGender()
        {
            return gender;
        }

        /// <summary>
        /// Setter method: Sets the gender of the user.
        /// </summary>
        /// <param name="gender">The new value to be stored in the gender field.</param>
        public void SetGender(GenderTypes gender)
        {
            //Sets the gender
            this.gender = gender;
        }

        /// <summary>
        /// Getter method: Gets the activity level selection.
        /// </summary>
        /// <returns>The value stored in the activityLevel field.</returns>
        public ActivityLevelTypes GetActivityLevel()
        {
            return activityLevel;
        }

        /// <summary>
        /// Setter method: Sets the activity level of the user.
        /// </summary>
        /// <param name="activityLevel">The new value to be stored in the activityLevel field.</param>
        public void SetActivityLevel(ActivityLevelTypes activityLevel)
        {
            //Sets the activity level
            this.activityLevel = activityLevel;
        }

        /// <summary>
        /// Getter method: Gets the age input.
        /// </summary>
        /// <returns>The value stored in the age field.</returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// Setter method: Sets the age of the user if given value is not negative.
        /// </summary>
        /// <param name="age">The new value to be stored in the age field.</param>
        public void SetAge(int age)
        {
            //Check if the value is 0 or larger
            if (age >= 0) 
            {
                //Sets the age
                this.age = age; 
            }
        }

        /// <summary>
        /// Getter method: Gets the name input.
        /// </summary>
        /// <returns>The value stored in the name field.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Setter method: Sets the name of the user.
        /// </summary>
        /// <param name="name">The new value to be stored in the name field.</param>
        public void SetName(string name)
        {
            //Check if name input is empty
            if(!string.IsNullOrEmpty(name))
            {
                //Sets the name
                this.name = name; 
            }
        }

        /// <summary>
        /// Getter method: Gets the weight input.
        /// </summary>
        /// <returns>The value stored in the weight field.</returns>
        public double GetWeight()
        {
            return weight;
        }
        /// <summary>
        /// Sets the weight of the user if given value is not negative.
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
        /// Getter method: Gets the height input.
        /// </summary>
        /// <returns>The value stored in the height field.</returns>
        public double GetHeight()
        {
            return height;
        }
        /// <summary>
        /// Sets the height of the user if given value is not negative.
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

        #endregion

        /// <summary>
        /// Calculated the BMR based on the user's weight, height age and selected gender.
        /// </summary>
        /// <returns>The calculated BMR as a double value.</returns>
        public double CalculateBMR()
        {
            double bmrValue; //Variable to store the calculated BMR

            //Calculate the BMR using the Mifflin-St Jeor formula
            bmrValue = (10 * weight) + (6.25 * height) - (5 * age);

            //Check what gender is selected
            if (gender == GenderTypes.Female) //Female is selected
            {
                //Subtract 161 to the BMR value for females
                bmrValue -= 161;
            }
            else //Male is selected
            {
                //Add 5 to the BMR value for males
                bmrValue += 5;
            }

            //Returns the calculated BMR value
            return bmrValue;

        } //end of calculatedBMR method

        /// <summary>
        /// Calculated the BMR value needed to maintain the user's current weight
        /// based on their BMR and activity level.
        /// </summary>
        /// <param name="bmrValue">The user's BMR value, calculated uing age, height, weight and gender.</param>
        /// <returns>The BMR value required to maintain the current weight, considering the user's actiity level.</returns>
        public double KeepCurrentWeight(double bmrValue)
        {
            double activityLevelFactor = 0.0; //Variable for the factor used in the BMR Calculation
            double maintainWeightBMR = 0.0; //Variable to store the BMR value needed to maintain weight

            //Check the user's selected activity level
            if (activityLevel == ActivityLevelTypes.Sedentary) //Sedentary activity level is selected
            {
                activityLevelFactor = 1.2;
            }
            else if (activityLevel == ActivityLevelTypes.Lightly) //Lightly active activity level is selected
            {
                activityLevelFactor = 1.375;
            }
            else if (activityLevel == ActivityLevelTypes.Moderatly) //Moderately active activity level is selected
            {
                activityLevelFactor = 1.550;
            }
            else if (activityLevel == ActivityLevelTypes.Very) //Very active activity level is selected
            {
                activityLevelFactor = 1.725;
            }
            else //Extra active activity level is selected
            {
                activityLevelFactor = 1.9;
            }

            //Calculate the BMR needed to maintain weight
            maintainWeightBMR = bmrValue * activityLevelFactor;

            //Return the calculated BMR value required to maintain the current weight
            return maintainWeightBMR;

        } //end of KeepCurrentWeight method

        /// <summary>
        /// Calculates the BMR values needed to lose or gain specific amount of weight per week.
        /// </summary>
        /// <param name="maintainWeightBMR">The user's BMR value needed to maintain their current weight.</param>
        /// <returns>
        /// A tuple containging BMR values to achieve specific weight changes per week:
        /// - lose500: BMR value needed to lose 500g per week.
        /// - lose1000: BMR value needed to lose 1000g per week.
        /// - gain500: BMR value needed to gain 500g per week.
        /// - gain1000: BMR value needed to gain 1000g per week.
        /// </returns>
        public (double lose500, double lose1000, double gain500, double gain1000) LoseGainWeight(double maintainWeightBMR)
        {
            double lose500; //Variable to store the calculated BMR value needed to lose 500g per week
            double lose1000; //Variable to store the calculated BMR value needed to lose 1000g per week
            double gain500; //Variable to store the calculated BMR value needed to gain 500g per week
            double gain1000; //Variable to store the calculated BMR value needed to gain 1000g per week

            //Calculation to lose 500g per week: Subtract 500 from the maintainWeightBMR
            lose500 = maintainWeightBMR - 500;

            //Calculation to lose 1000g per week: Subtract 1000 from the maintainWeightBMR
            lose1000 = maintainWeightBMR - 1000;

            //Calculation to gain 500g per week: Add 500 from the maintainWeightBMR
            gain500 = maintainWeightBMR + 500;

            //Calculation to gain 1000g per week: Add 1000 from the maintainWeightBMR
            gain1000 = maintainWeightBMR + 1000;

            //Return the calculated values
            return (lose500, lose1000, gain500, gain1000);
        
        } //end of LoseGainWeight method
    }
}
