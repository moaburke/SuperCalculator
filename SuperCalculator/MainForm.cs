//Moa Burke
//13 Sept 2024


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class MainForm : Form
    {
        //Create an object of the BMICalculator
        private BMICalculator bmiCalc = new BMICalculator();

        //Create an object of the BMRCalculator
        private BMRCalculator bmrCalc = new BMRCalculator();

        //Instance variable to save user input
        private string name = string.Empty; //User`s name
  
        public MainForm()
        {
            InitializeComponent();
            //Prepare the GUI
            InitializeGUI();
        }

        /// <summary>
        /// Center the window on the screen
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Center form to screen
            CenterToScreen();
        }

        /// <summary>
        /// Initialize the GUI with some present options.
        /// </summary>
        private void InitializeGUI()
        {
            //Change title of the form
            this.Text += " by Moa Burke";

            //Clear design-time texts for the BMI Caltulator
            lblBMI.Text = String.Empty;
            lblWeightCat.Text = String.Empty;
            lblNormalWeight.Text = String.Empty;

            lblNormalBMI.Text = "Normal BMI is between 18.50 and 24.9"; //Display the normal BMI value
            rbtnMetric.Checked = true; //Set metric radio button as default value
            rbtnFemale.Checked = true; //Set female radio button as default value
            rbtnSedentary.Checked = true; //Set sedentary radio button as default value  

        }// end of InitializeGUI method

        /// <summary>
        /// Reset the BMR calculation results and input fields.
        /// Clears all the results displayed in the list box, resets the age input field, 
        /// and sets the default selection for gender and activity level.
        /// </summary>
        private void EmptyBMRResults()
        {
            listBox.Items.Clear(); //Clear items in the list-box
            txtAge.Text = string.Empty; //Clear age input
            rbtnFemale.Checked = true; //Set the gender to female as default value
            rbtnSedentary.Checked = true; //Set activity level to sedentary as default value
        }// end of EmptyBMRResults

        /// <summary>
        /// Updates the label for height input depending on unit, metric or imperial, selected by user. 
        /// </summary>
        private void UpdateHeightText()
        {
            if (rbtnMetric.Checked) //If metric is selected
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInch.Visible = false; //Inch input dissapears
                //Clear the text in the text boxes for weight and height when changing unit
                txtCmFt.Text = String.Empty; 
                txtInch.Text = String.Empty;
                txtWeight.Text = String.Empty;
                lblNormalWeight.Text = "";  //Clear the text that displays the range of the normal weight
            }
            else //If imperial is selected
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
                txtInch.Visible = true; //Inch input appears
                //Clear the text in the text boxes for weight and height when changing unit
                txtCmFt.Text = String.Empty; 
                txtInch.Text = String.Empty;
                txtWeight.Text = String.Empty;
                lblNormalWeight.Text = string.Empty;  //Clear the text that displays the range of the normal weight

            }

            //Clear results when changing unit
            lblWeightCat.Text = string.Empty;
            lblBMI.Text = string.Empty;

        }// end of UpdateHeight method

        //Metric radiobutton is selected by the user.
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            //Call the method to update the label forr the height input
            UpdateHeightText();

        }
        //Imperial radiobutton is selected by the user.
        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            //Call the method to update the label forr the height input
            UpdateHeightText();
        }

        /// <summary>
        /// Event-handeler method connected to the button.
        /// Excecuted automatically when the button is clicked.
        /// Read the input given by the user, if input is ok perform calculation and display results.
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Read input from the BMI Calculator
            bool ok = ReadInputBMI();

            //Check if the input is valid
            if (ok) //ok == true
            {
                //If the input is valid perform calculations and display the results
                CalculateAndDisplayResults();

                //Clear the BMR results
                EmptyBMRResults();

            }

        }// end of btnOK_Click method

        /// <summary>
        /// Method for reading the user's input from the GUI.
        /// Save the values in an object of the bmiCalc.
        /// </summary>
        /// <returns>True if the name, height and weight inputs are all valid; otherwise false.</returns>
        private bool ReadInputBMI()
        {
            ReadUnit(); //Get the selected unit
            ReadName(); //Get the name input
            bool heightOK = ReadHeight(); //Get the height input
            bool weightOK = ReadWeight(); //Get the weight input

            //Returns a true value if name, height and weight input is valid
            return heightOK && weightOK;
        } //end of the RedInputBMI method

        /// <summary>
        /// Method for getting the selected unit by the user.
        /// Assigns the correct unit to the bmiCalc object based on user's selection.
        /// </summary>
        private void ReadUnit()
        {
            if (rbtnMetric.Checked) //Metric is selected
            {
                //Set the unit type to metric
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else //Imperial is selected
            {
                //Set the unit type to imperial
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }

        } //end of ReadUnit method

        /// <summary>
        /// Method for getting the name input by user.
        /// </summary>
        /// <returns>True if the input is not empty and valid; otherwise false.</returns>
        private void ReadName()
        {
            //Trim contents of the text input
            txtName.Text.Trim();

            //If name input is empty
            if (!string.IsNullOrEmpty(txtName.Text)) //Input is not empty
            {
                bmiCalc.SetName(txtName.Text); //Set the name in the bmiCalc object
                bmrCalc.SetName(txtName.Text); //Set the name in the bmrCalc object
            }
            else //Input is empty
            {
                bmiCalc.SetName("Unknown"); //Set the name in the bmiCalc object to "Unknown"
                bmrCalc.SetName("Unknown"); //Set the name in the bmrCalc object to "Unknown"
            }

        } //end of ReadName method

        /// <summary>
        /// Method for getting the height input by user.
        /// </summary>
        /// <returns>True if the height input is a valid numerical value; otherwise false.</returns>
        private bool ReadHeight()
        {
            double height = 0.0; //Local variable for the height input to set to the bmiCalc object
            double heightBMR = 0.0; // Local variable for the height input to set to the bmrCalc object

            //Try to parse the text from the height input into the 'height' variable
            bool ok = double.TryParse(txtCmFt.Text, out height);

            //Check if height input it a valid numerical value
            if (!ok) //ok == false
            {
                //If the input is not valid, display an error message to user
                MessageBox.Show("The height value is invalid", "Error");
            }

            //If Imperial value is selected then also check input for inch 
            double inch = 0.0; //Local variable for the height (inch) input by user
            if (rbtnImperial.Checked)
            {
                //Try to parse the text from the inch input into the 'inch' variable
                ok = double.TryParse(txtInch.Text, out inch);

                //Check if inch input it a valid numerical value
                if (!ok) //ok == false
                {
                    //If the input is not a numerical number, display an error message to user
                    MessageBox.Show("The inch value is invalid", "Error");
                }
            }

            //Change cm --> m if metric is selected, otherwise ft --> inch
            if (bmiCalc.GetUnit() == UnitTypes.Metric) //Metric is selected
            {
                //Height in cm used for calculation in the BMR Calculation
                heightBMR = height;
                //Calculation to change cm to meter
                height = height / 100.00;
            }
            else //Imperial is selected
            {
                //Calculate to change the input value of feet to inch, and add the input inch value
                height = (height * 12) + inch;
                //Convert the value of the height in inch to cm to be used in the BMR Calculation
                // inch * 2.54 = cm
                heightBMR = height * 2.54;
            }

            //Set the height value to the bmiCalc object
            bmiCalc.SetHeight(height);
            //Set the height value to the bmiCalc object
            bmrCalc.SetHeight(heightBMR);

            //return true if the height input is valid, otherwise false
            return ok;

        } //end of the ReadHeight method

        /// <summary>
        /// Method for getting the weight input by user.
        /// </summary>
        /// <returns>True if the weight input is a valid numerical value, otherwise false.</returns>
        private bool ReadWeight()
        {
            double weight = 0.0; //Local variable for the weight input to set to the bmiCalc object
            double weightBMR = 0.0; //Local variable for the weigh input to set to the bmrCalc object

            //Try to parse the text from the weight input into the 'weight' variable
            bool ok = double.TryParse(txtWeight.Text, out weight);

            //Check if weight input it a valid numerical value
            if (!ok) //ok == false
            {
                //If the input is not a numerical number, display an error message to user
                MessageBox.Show("The weight value is invalid", "Error");
            }

            //Change lbs --> kg if imperial is selected; to be used in the BMR Calculation
            if (bmiCalc.GetUnit() == UnitTypes.Imperial) //Imperial is selected
            {
                //Convert pounds to kg
                //lbs / 2.205 = kg
                weightBMR = weight / 2.205;
            }
            else //Metric is selected
            {
                weightBMR = weight;
            }

            //Set the weight value to the bmiCalc object
            bmiCalc.SetWeight(weight);
            //Set the weight value to the bmrCalc object
            bmrCalc.SetWeight(weightBMR);

            //Returns true if weight input is valid, otherwise false
            return ok;

        }//end of ReadWeight method

        /// <summary>
        /// Calculates the BMI and displays the results to the user.
        /// </summary>
        private void CalculateAndDisplayResults()
        {
            //Declare the BMI as a local variable
            double bmi = bmiCalc.CalculateBMI();
            //Display the value of the BMI to the user
            lblBMI.Text = bmi.ToString("f2");
            //Display the weight category to the user
            lblWeightCat.Text = bmiCalc.BMIWeightCategory();
            //Display the lower and higher weight for normal BMI based on the users height 
            lblNormalWeight.Text = bmiCalc.NormalWeight();
            //Update the name of the group box for the results
            grpResults.Text = "  Results for " + bmiCalc.GetName() + "  ";

        }// end of CalculateAndDisplayResults method

        /// <summary>
        /// Event-handeler method connected to the button.
        /// Excecuted automatically when the button is clicked.
        /// Read the input given by the user, if input is ok perform calculation and display results.
        /// </summary>
        private void btnOKBMR_Click(object sender, EventArgs e)
        {
            //Read input from the BMR Caltulator
            bool ok = ReadInputBMR();

            //Check if the input is valid
            if (ok) //ok == true
            {
                //If the input is valid, perform calculations and display the BMR results
                CalculateAndDisplayResultsBMR();
            }

        }// end of btnOKBMR_Click method

        /// <summary>
        /// Method for reading the user's input from the GUI.
        /// Save the values in an object of the bmrCalc.
        /// </summary>
        /// <returns>True if the age, height and weight inputs are all valid; otherwise false.</returns>
        private bool ReadInputBMR()
        {
            ReadInputBMI(); //Get the input from the BMI Caltulator
            ReadGender(); //Get the gender selection
            ReadActivityLevel(); //Get the actvity level selection
            bool okAge = ReadAge(); //Get the age input
            bool heightOK = ReadHeight(); //Get the height input
            bool weightOK = ReadWeight(); //Get the weight input

            //Returns a true value if age, height and weight input is valid
            return okAge && heightOK && weightOK;

        }// end of ReadInputBMR method

        /// <summary>
        /// Method for getting the selected gender by the user.
        /// Assigns the correct unit to the bmrCalc object based on user's selection.
        /// </summary>
        private void ReadGender()
        {
            if(rbtnFemale.Checked) //Female is selected
            {
                //Set the gender to female
                bmrCalc.SetGender(GenderTypes.Female);
            } 
            else //Male is selected
            {
                //Set the gender to male
                bmrCalc.SetGender(GenderTypes.Male);
            }
            
        } //end of ReadGender method

        /// <summary>
        /// Method for getting the age input by the user, given in years.
        /// </summary>
        /// <returns>True if the input is a valid numerical value, otherwise false.</returns>
        private bool ReadAge()
        {
            int age = 0; //Variable for storing the age input by user

            //Try to parse the text from the age input into the 'age' variable
            bool ok = int.TryParse(txtAge.Text, out age);

            //Check if age input it a valid numerical value
            if (!ok) //ok == false
            {
                //If the input is not an integer, display an error message to user
                MessageBox.Show("The age valis is invalid", "Error");
            }

            //Set the age value to the bmrCalc object
            bmrCalc.SetAge(age);

            return ok;

        }// end of ReadAge method

        /// <summary>
        /// Method for getting the activity level selection by the user.
        /// Assigns the correct unit to the bmrCalc object based on user's selection.
        /// </summary>
        private void ReadActivityLevel()
        {
            //Check which activitylevel is selected
            if (rbtnSedentary.Checked) //Sedentary, very low activity of level, is selected
            {
                //Set the activity level to Sedentary
                bmrCalc.SetActivityLevel(ActivityLevelTypes.Sedentary);
            }
            else if (rbtnLightly.Checked) //Lighlty, a slightly more active lifestyle, is selected
            {
                //Set the activity level to Lightly
                bmrCalc.SetActivityLevel(ActivityLevelTypes.Lightly);
            }
            else if (rbtnModerately.Checked) //Moderately, a moderate level of activity, is selected
            {
                //Set the activity level to Moderatly
                bmrCalc.SetActivityLevel(ActivityLevelTypes.Moderatly);
            }
            else if (rbtnVery.Checked) //Very, a high active level of activity, is selected
            {
                //Set the activity level to Very
                bmrCalc.SetActivityLevel(ActivityLevelTypes.Very);
            }
            else //High, an extremely high level of activity, is selected
            {
                //Set the activity level to Extra
                bmrCalc.SetActivityLevel(ActivityLevelTypes.Extra);
            }
        }// end of the ReadActivityLevel method

        /// <summary>
        /// Calculates the BMR and display the results to the user.
        /// </summary>
        private void CalculateAndDisplayResultsBMR()
        {
            //Declare the name as a local variable
            string name = bmrCalc.GetName();

            //Clear the items in the list-box
            listBox.Items.Clear();

            //Update the title of the group-box with the name of the user, in upper cases
            listBox.Items.Add("BMR RESULTS FOR " + name.ToUpper() + "  ");
            listBox.Items.Add(""); //Empty line
            //Declare the BMR value as a local variable
            double bmrValue = bmrCalc.CalculateBMR();
            //Display the BMR value with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Your BMR (calories/day)      ", bmrValue));
            //Declare the value of the BMR to maintain weight as a local variable
            double maintainWeightBMR = bmrCalc.KeepCurrentWeight(bmrValue);
            //Display the value of the BMR to maintain weight with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Calories to maintain your weight", maintainWeightBMR));
            //Declare the calculations for losing and gaining weight as a local variable
            var loseGainCalculations = bmrCalc.LoseGainWeight(maintainWeightBMR);
            //Declare the value for losing 500g/week as a local variable
            double lose500g = loseGainCalculations.lose500;
            //Display the value of the BMR to lose 500g/week with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Calories to lose 0,5 kg per week", lose500g));
            //Declare the value for losing 1000g/week as a local variable
            double lose1000g = loseGainCalculations.lose1000;
            //Display the value of the BMR to lose 1000g/week with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Calories to lose 1,0 kg per week", lose1000g));
            //Declare the value for gaining 500g/week as a local variable
            double gain500g = loseGainCalculations.gain500;
            //Display the value of the BMR to gain 500g/week with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Calories to gain 0,5 kg per week", gain500g));
            //Declare the value for gaining 1000g/week as a local variable
            double gain1000g = loseGainCalculations.gain1000;
            //Display the value of the BMR to gain 1000g/week with a formatted string by adding an item to the list-box
            listBox.Items.Add(string.Format("{0,-40} {1,15:f0}", "Calories to gain 1,0 kg per week", gain1000g));
            listBox.Items.Add(""); //Empty line
            listBox.Items.Add("Losing more than 1000 calories per day is to be avoided."); //Display information to the user

        }// end of the CalculateAndDisplayResultsBMR method

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
