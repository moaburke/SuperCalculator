namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalWeight = new System.Windows.Forms.Label();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.txtCmFt = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnOKBMR = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtnExtra = new System.Windows.Forms.RadioButton();
            this.rbtnVery = new System.Windows.Forms.RadioButton();
            this.rbtnModerately = new System.Windows.Forms.RadioButton();
            this.rbtnLightly = new System.Windows.Forms.RadioButton();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpUnit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.grpResults);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.grpUnit);
            this.groupBox1.Controls.Add(this.txtCmFt);
            this.groupBox1.Controls.Add(this.txtInch);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.245F);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  BMI Calculator  ";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtWeight.Location = new System.Drawing.Point(110, 90);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(141, 21);
            this.txtWeight.TabIndex = 4;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblNormalWeight);
            this.grpResults.Controls.Add(this.lblNormalBMI);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Controls.Add(this.lblWeightCat);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.label4);
            this.grpResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResults.ForeColor = System.Drawing.Color.Teal;
            this.grpResults.Location = new System.Drawing.Point(324, 30);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(489, 194);
            this.grpResults.TabIndex = 11;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "  Results  ";
            // 
            // lblNormalWeight
            // 
            this.lblNormalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNormalWeight.Location = new System.Drawing.Point(58, 142);
            this.lblNormalWeight.Name = "lblNormalWeight";
            this.lblNormalWeight.Size = new System.Drawing.Size(379, 38);
            this.lblNormalWeight.TabIndex = 13;
            this.lblNormalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNormalBMI.ForeColor = System.Drawing.Color.Black;
            this.lblNormalBMI.Location = new System.Drawing.Point(78, 119);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(339, 35);
            this.lblNormalBMI.TabIndex = 12;
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your BMI";
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWeightCat.ForeColor = System.Drawing.Color.Black;
            this.lblWeightCat.Location = new System.Drawing.Point(157, 75);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(260, 26);
            this.lblWeightCat.TabIndex = 10;
            this.lblWeightCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBMI.ForeColor = System.Drawing.Color.Black;
            this.lblBMI.Location = new System.Drawing.Point(157, 32);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(260, 26);
            this.lblBMI.TabIndex = 8;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight Categoty";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Teal;
            this.btnOK.Location = new System.Drawing.Point(60, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(191, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Calculate BMI";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rbtnImperial);
            this.grpUnit.Controls.Add(this.rbtnMetric);
            this.grpUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpUnit.ForeColor = System.Drawing.Color.Teal;
            this.grpUnit.Location = new System.Drawing.Point(17, 132);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(269, 92);
            this.grpUnit.TabIndex = 12;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "  Unit  ";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnImperial.ForeColor = System.Drawing.Color.Black;
            this.rbtnImperial.Location = new System.Drawing.Point(12, 55);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(95, 17);
            this.rbtnImperial.TabIndex = 6;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (ft, lbs)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnMetric.ForeColor = System.Drawing.Color.Black;
            this.rbtnMetric.Location = new System.Drawing.Point(12, 29);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(95, 17);
            this.rbtnMetric.TabIndex = 5;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // txtCmFt
            // 
            this.txtCmFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtCmFt.Location = new System.Drawing.Point(110, 61);
            this.txtCmFt.Name = "txtCmFt";
            this.txtCmFt.Size = new System.Drawing.Size(66, 21);
            this.txtCmFt.TabIndex = 2;
            // 
            // txtInch
            // 
            this.txtInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtInch.Location = new System.Drawing.Point(185, 61);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(66, 21);
            this.txtInch.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtName.Location = new System.Drawing.Point(110, 33);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(176, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(18, 89);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHeight.ForeColor = System.Drawing.Color.Black;
            this.lblHeight.Location = new System.Drawing.Point(18, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 23);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox);
            this.groupBox4.Controls.Add(this.btnOKBMR);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.txtAge);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.Teal;
            this.groupBox4.Location = new System.Drawing.Point(16, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(836, 375);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  BMR Calculator  ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.Teal;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(324, 55);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(489, 259);
            this.listBox.TabIndex = 19;
            // 
            // btnOKBMR
            // 
            this.btnOKBMR.Location = new System.Drawing.Point(62, 322);
            this.btnOKBMR.Name = "btnOKBMR";
            this.btnOKBMR.Size = new System.Drawing.Size(182, 34);
            this.btnOKBMR.TabIndex = 4;
            this.btnOKBMR.Text = "Calculate BMR";
            this.btnOKBMR.UseVisualStyleBackColor = true;
            this.btnOKBMR.Click += new System.EventHandler(this.btnOKBMR_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbtnExtra);
            this.groupBox6.Controls.Add(this.rbtnVery);
            this.groupBox6.Controls.Add(this.rbtnModerately);
            this.groupBox6.Controls.Add(this.rbtnLightly);
            this.groupBox6.Controls.Add(this.rbtnSedentary);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox6.ForeColor = System.Drawing.Color.Teal;
            this.groupBox6.Location = new System.Drawing.Point(17, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 175);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "  Weekly actitity level";
            // 
            // rbtnExtra
            // 
            this.rbtnExtra.AutoSize = true;
            this.rbtnExtra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnExtra.Location = new System.Drawing.Point(16, 141);
            this.rbtnExtra.Name = "rbtnExtra";
            this.rbtnExtra.Size = new System.Drawing.Size(226, 17);
            this.rbtnExtra.TabIndex = 4;
            this.rbtnExtra.TabStop = true;
            this.rbtnExtra.Text = "Extra active, hard excercise or physical job";
            this.rbtnExtra.UseVisualStyleBackColor = true;
            // 
            // rbtnVery
            // 
            this.rbtnVery.AutoSize = true;
            this.rbtnVery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnVery.Location = new System.Drawing.Point(16, 113);
            this.rbtnVery.Name = "rbtnVery";
            this.rbtnVery.Size = new System.Drawing.Size(141, 17);
            this.rbtnVery.TabIndex = 3;
            this.rbtnVery.TabStop = true;
            this.rbtnVery.Text = "Very active (6 to 7 times)";
            this.rbtnVery.UseVisualStyleBackColor = true;
            // 
            // rbtnModerately
            // 
            this.rbtnModerately.AutoSize = true;
            this.rbtnModerately.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnModerately.Location = new System.Drawing.Point(16, 84);
            this.rbtnModerately.Name = "rbtnModerately";
            this.rbtnModerately.Size = new System.Drawing.Size(172, 17);
            this.rbtnModerately.TabIndex = 2;
            this.rbtnModerately.TabStop = true;
            this.rbtnModerately.Text = "Moderately active (3 to 5 times)";
            this.rbtnModerately.UseVisualStyleBackColor = true;
            // 
            // rbtnLightly
            // 
            this.rbtnLightly.AutoSize = true;
            this.rbtnLightly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnLightly.Location = new System.Drawing.Point(16, 56);
            this.rbtnLightly.Name = "rbtnLightly";
            this.rbtnLightly.Size = new System.Drawing.Size(150, 17);
            this.rbtnLightly.TabIndex = 1;
            this.rbtnLightly.TabStop = true;
            this.rbtnLightly.Text = "Lightly active (1 to 3 times)";
            this.rbtnLightly.UseVisualStyleBackColor = true;
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnSedentary.Location = new System.Drawing.Point(16, 29);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(175, 17);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedentary (little to no excercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(48, 26);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(108, 23);
            this.txtAge.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Age";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnMale);
            this.groupBox5.Controls.Add(this.rbtnFemale);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox5.ForeColor = System.Drawing.Color.Teal;
            this.groupBox5.Location = new System.Drawing.Point(17, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 78);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  Gender  ";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMale.Location = new System.Drawing.Point(24, 48);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnFemale.Location = new System.Drawing.Point(24, 24);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 705);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Super Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCmFt;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblWeightCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.Label lblNormalWeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnOKBMR;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbtnExtra;
        private System.Windows.Forms.RadioButton rbtnVery;
        private System.Windows.Forms.RadioButton rbtnModerately;
        private System.Windows.Forms.RadioButton rbtnLightly;
        private System.Windows.Forms.RadioButton rbtnSedentary;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}

