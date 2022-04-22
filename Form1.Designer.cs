namespace UnitConverter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInputAmt = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnConversion = new System.Windows.Forms.Button();
            this.grpInputUnits = new System.Windows.Forms.GroupBox();
            this.rdoInputOunces = new System.Windows.Forms.RadioButton();
            this.rdoInputPounds = new System.Windows.Forms.RadioButton();
            this.rdoInputFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoInputMiles = new System.Windows.Forms.RadioButton();
            this.rdoInputFeet = new System.Windows.Forms.RadioButton();
            this.rdoInputGrams = new System.Windows.Forms.RadioButton();
            this.rdoInputKilograms = new System.Windows.Forms.RadioButton();
            this.rdoInputCelsius = new System.Windows.Forms.RadioButton();
            this.rdoInputKilometers = new System.Windows.Forms.RadioButton();
            this.rdoInputMeters = new System.Windows.Forms.RadioButton();
            this.grpOutputUnits = new System.Windows.Forms.GroupBox();
            this.rdoOutputOunces = new System.Windows.Forms.RadioButton();
            this.rdoOutputPounds = new System.Windows.Forms.RadioButton();
            this.rdoOutputFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoOutputMiles = new System.Windows.Forms.RadioButton();
            this.radioOutputFeet = new System.Windows.Forms.RadioButton();
            this.rdoOutputGrams = new System.Windows.Forms.RadioButton();
            this.rdoOutputKilograms = new System.Windows.Forms.RadioButton();
            this.rdoOutputCelsius = new System.Windows.Forms.RadioButton();
            this.rdoOutputKilometers = new System.Windows.Forms.RadioButton();
            this.rdoOutputMeters = new System.Windows.Forms.RadioButton();
            this.txtInputAmount = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInstruct1 = new System.Windows.Forms.Label();
            this.lblInstruct2 = new System.Windows.Forms.Label();
            this.lblInstruct4 = new System.Windows.Forms.Label();
            this.lblInstruct3 = new System.Windows.Forms.Label();
            this.lblInstruct5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpInputUnits.SuspendLayout();
            this.grpOutputUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(295, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UNIT CONVERTER";
            // 
            // lblInputAmt
            // 
            this.lblInputAmt.AutoSize = true;
            this.lblInputAmt.Location = new System.Drawing.Point(174, 104);
            this.lblInputAmt.Name = "lblInputAmt";
            this.lblInputAmt.Size = new System.Drawing.Size(172, 15);
            this.lblInputAmt.TabIndex = 1;
            this.lblInputAmt.Text = "Enter Amount to be Converted:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(171, 392);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(175, 15);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Here\'s Your Converted Amount:";
            // 
            // btnConversion
            // 
            this.btnConversion.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConversion.Location = new System.Drawing.Point(339, 223);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(84, 46);
            this.btnConversion.TabIndex = 5;
            this.btnConversion.Text = "PRESS TO CONVERT";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // grpInputUnits
            // 
            this.grpInputUnits.Controls.Add(this.rdoInputOunces);
            this.grpInputUnits.Controls.Add(this.rdoInputPounds);
            this.grpInputUnits.Controls.Add(this.rdoInputFahrenheit);
            this.grpInputUnits.Controls.Add(this.rdoInputMiles);
            this.grpInputUnits.Controls.Add(this.rdoInputFeet);
            this.grpInputUnits.Controls.Add(this.rdoInputGrams);
            this.grpInputUnits.Controls.Add(this.rdoInputKilograms);
            this.grpInputUnits.Controls.Add(this.rdoInputCelsius);
            this.grpInputUnits.Controls.Add(this.rdoInputKilometers);
            this.grpInputUnits.Controls.Add(this.rdoInputMeters);
            this.grpInputUnits.Location = new System.Drawing.Point(33, 165);
            this.grpInputUnits.Name = "grpInputUnits";
            this.grpInputUnits.Size = new System.Drawing.Size(283, 168);
            this.grpInputUnits.TabIndex = 6;
            this.grpInputUnits.TabStop = false;
            this.grpInputUnits.Text = "Select Unit to Convert from:";
            // 
            // rdoInputOunces
            // 
            this.rdoInputOunces.AutoSize = true;
            this.rdoInputOunces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoInputOunces.Location = new System.Drawing.Point(151, 124);
            this.rdoInputOunces.Name = "rdoInputOunces";
            this.rdoInputOunces.Size = new System.Drawing.Size(65, 19);
            this.rdoInputOunces.TabIndex = 9;
            this.rdoInputOunces.TabStop = true;
            this.rdoInputOunces.Text = "Ounces";
            this.rdoInputOunces.UseVisualStyleBackColor = true;
            this.rdoInputOunces.CheckedChanged += new System.EventHandler(this.rdoInputOunces_CheckedChanged);
            // 
            // rdoInputPounds
            // 
            this.rdoInputPounds.AutoSize = true;
            this.rdoInputPounds.ForeColor = System.Drawing.Color.Lime;
            this.rdoInputPounds.Location = new System.Drawing.Point(151, 99);
            this.rdoInputPounds.Name = "rdoInputPounds";
            this.rdoInputPounds.Size = new System.Drawing.Size(65, 19);
            this.rdoInputPounds.TabIndex = 8;
            this.rdoInputPounds.TabStop = true;
            this.rdoInputPounds.Text = "Pounds";
            this.rdoInputPounds.UseVisualStyleBackColor = true;
            this.rdoInputPounds.CheckedChanged += new System.EventHandler(this.rdoInputPounds_CheckedChanged);
            // 
            // rdoInputFahrenheit
            // 
            this.rdoInputFahrenheit.AutoSize = true;
            this.rdoInputFahrenheit.ForeColor = System.Drawing.Color.Yellow;
            this.rdoInputFahrenheit.Location = new System.Drawing.Point(151, 72);
            this.rdoInputFahrenheit.Name = "rdoInputFahrenheit";
            this.rdoInputFahrenheit.Size = new System.Drawing.Size(81, 19);
            this.rdoInputFahrenheit.TabIndex = 7;
            this.rdoInputFahrenheit.TabStop = true;
            this.rdoInputFahrenheit.Text = "Fahrenheit";
            this.rdoInputFahrenheit.UseVisualStyleBackColor = true;
            this.rdoInputFahrenheit.CheckedChanged += new System.EventHandler(this.rdoInputFahrenheit_CheckedChanged);
            // 
            // rdoInputMiles
            // 
            this.rdoInputMiles.AutoSize = true;
            this.rdoInputMiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoInputMiles.Location = new System.Drawing.Point(151, 47);
            this.rdoInputMiles.Name = "rdoInputMiles";
            this.rdoInputMiles.Size = new System.Drawing.Size(53, 19);
            this.rdoInputMiles.TabIndex = 6;
            this.rdoInputMiles.TabStop = true;
            this.rdoInputMiles.Text = "Miles";
            this.rdoInputMiles.UseVisualStyleBackColor = true;
            this.rdoInputMiles.CheckedChanged += new System.EventHandler(this.rdoInputMiles_CheckedChanged);
            // 
            // rdoInputFeet
            // 
            this.rdoInputFeet.AutoSize = true;
            this.rdoInputFeet.ForeColor = System.Drawing.Color.Red;
            this.rdoInputFeet.Location = new System.Drawing.Point(151, 22);
            this.rdoInputFeet.Name = "rdoInputFeet";
            this.rdoInputFeet.Size = new System.Drawing.Size(47, 19);
            this.rdoInputFeet.TabIndex = 5;
            this.rdoInputFeet.TabStop = true;
            this.rdoInputFeet.Text = "Feet";
            this.rdoInputFeet.UseVisualStyleBackColor = true;
            this.rdoInputFeet.CheckedChanged += new System.EventHandler(this.rdoInputFeet_CheckedChanged);
            // 
            // rdoInputGrams
            // 
            this.rdoInputGrams.AutoSize = true;
            this.rdoInputGrams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoInputGrams.Location = new System.Drawing.Point(23, 124);
            this.rdoInputGrams.Name = "rdoInputGrams";
            this.rdoInputGrams.Size = new System.Drawing.Size(59, 19);
            this.rdoInputGrams.TabIndex = 4;
            this.rdoInputGrams.TabStop = true;
            this.rdoInputGrams.Text = "Grams";
            this.rdoInputGrams.UseVisualStyleBackColor = true;
            this.rdoInputGrams.CheckedChanged += new System.EventHandler(this.rdoInputGrams_CheckedChanged);
            // 
            // rdoInputKilograms
            // 
            this.rdoInputKilograms.AutoSize = true;
            this.rdoInputKilograms.ForeColor = System.Drawing.Color.Black;
            this.rdoInputKilograms.Location = new System.Drawing.Point(23, 99);
            this.rdoInputKilograms.Name = "rdoInputKilograms";
            this.rdoInputKilograms.Size = new System.Drawing.Size(78, 19);
            this.rdoInputKilograms.TabIndex = 3;
            this.rdoInputKilograms.TabStop = true;
            this.rdoInputKilograms.Text = "Kilograms";
            this.rdoInputKilograms.UseVisualStyleBackColor = true;
            this.rdoInputKilograms.CheckedChanged += new System.EventHandler(this.rdoInputKilograms_CheckedChanged);
            // 
            // rdoInputCelsius
            // 
            this.rdoInputCelsius.AutoSize = true;
            this.rdoInputCelsius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoInputCelsius.Location = new System.Drawing.Point(23, 72);
            this.rdoInputCelsius.Name = "rdoInputCelsius";
            this.rdoInputCelsius.Size = new System.Drawing.Size(62, 19);
            this.rdoInputCelsius.TabIndex = 2;
            this.rdoInputCelsius.TabStop = true;
            this.rdoInputCelsius.Text = "Celsius";
            this.rdoInputCelsius.UseVisualStyleBackColor = true;
            this.rdoInputCelsius.CheckedChanged += new System.EventHandler(this.rdoInputCelsius_CheckedChanged);
            // 
            // rdoInputKilometers
            // 
            this.rdoInputKilometers.AutoSize = true;
            this.rdoInputKilometers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdoInputKilometers.Location = new System.Drawing.Point(23, 47);
            this.rdoInputKilometers.Name = "rdoInputKilometers";
            this.rdoInputKilometers.Size = new System.Drawing.Size(81, 19);
            this.rdoInputKilometers.TabIndex = 1;
            this.rdoInputKilometers.TabStop = true;
            this.rdoInputKilometers.Text = "Kilometers";
            this.rdoInputKilometers.UseVisualStyleBackColor = true;
            this.rdoInputKilometers.CheckedChanged += new System.EventHandler(this.rdoInputKilometers_CheckedChanged);
            // 
            // rdoInputMeters
            // 
            this.rdoInputMeters.AutoSize = true;
            this.rdoInputMeters.ForeColor = System.Drawing.Color.Maroon;
            this.rdoInputMeters.Location = new System.Drawing.Point(23, 22);
            this.rdoInputMeters.Name = "rdoInputMeters";
            this.rdoInputMeters.Size = new System.Drawing.Size(61, 19);
            this.rdoInputMeters.TabIndex = 0;
            this.rdoInputMeters.TabStop = true;
            this.rdoInputMeters.Text = "Meters";
            this.rdoInputMeters.UseVisualStyleBackColor = true;
            this.rdoInputMeters.CheckedChanged += new System.EventHandler(this.rdoInputMeters_CheckedChanged);
            // 
            // grpOutputUnits
            // 
            this.grpOutputUnits.Controls.Add(this.rdoOutputOunces);
            this.grpOutputUnits.Controls.Add(this.rdoOutputPounds);
            this.grpOutputUnits.Controls.Add(this.rdoOutputFahrenheit);
            this.grpOutputUnits.Controls.Add(this.rdoOutputMiles);
            this.grpOutputUnits.Controls.Add(this.radioOutputFeet);
            this.grpOutputUnits.Controls.Add(this.rdoOutputGrams);
            this.grpOutputUnits.Controls.Add(this.rdoOutputKilograms);
            this.grpOutputUnits.Controls.Add(this.rdoOutputCelsius);
            this.grpOutputUnits.Controls.Add(this.rdoOutputKilometers);
            this.grpOutputUnits.Controls.Add(this.rdoOutputMeters);
            this.grpOutputUnits.Location = new System.Drawing.Point(446, 165);
            this.grpOutputUnits.Name = "grpOutputUnits";
            this.grpOutputUnits.Size = new System.Drawing.Size(283, 168);
            this.grpOutputUnits.TabIndex = 7;
            this.grpOutputUnits.TabStop = false;
            this.grpOutputUnits.Text = "Select Unit to Convert to:";
            // 
            // rdoOutputOunces
            // 
            this.rdoOutputOunces.AutoSize = true;
            this.rdoOutputOunces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoOutputOunces.Location = new System.Drawing.Point(143, 124);
            this.rdoOutputOunces.Name = "rdoOutputOunces";
            this.rdoOutputOunces.Size = new System.Drawing.Size(65, 19);
            this.rdoOutputOunces.TabIndex = 9;
            this.rdoOutputOunces.TabStop = true;
            this.rdoOutputOunces.Text = "Ounces";
            this.rdoOutputOunces.UseVisualStyleBackColor = true;
            this.rdoOutputOunces.CheckedChanged += new System.EventHandler(this.rdoOutputOunces_CheckedChanged);
            // 
            // rdoOutputPounds
            // 
            this.rdoOutputPounds.AutoSize = true;
            this.rdoOutputPounds.ForeColor = System.Drawing.Color.Black;
            this.rdoOutputPounds.Location = new System.Drawing.Point(143, 99);
            this.rdoOutputPounds.Name = "rdoOutputPounds";
            this.rdoOutputPounds.Size = new System.Drawing.Size(65, 19);
            this.rdoOutputPounds.TabIndex = 8;
            this.rdoOutputPounds.TabStop = true;
            this.rdoOutputPounds.Text = "Pounds";
            this.rdoOutputPounds.UseVisualStyleBackColor = true;
            this.rdoOutputPounds.CheckedChanged += new System.EventHandler(this.rdoOutputPounds_CheckedChanged);
            // 
            // rdoOutputFahrenheit
            // 
            this.rdoOutputFahrenheit.AutoSize = true;
            this.rdoOutputFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoOutputFahrenheit.Location = new System.Drawing.Point(143, 72);
            this.rdoOutputFahrenheit.Name = "rdoOutputFahrenheit";
            this.rdoOutputFahrenheit.Size = new System.Drawing.Size(81, 19);
            this.rdoOutputFahrenheit.TabIndex = 7;
            this.rdoOutputFahrenheit.TabStop = true;
            this.rdoOutputFahrenheit.Text = "Fahrenheit";
            this.rdoOutputFahrenheit.UseVisualStyleBackColor = true;
            this.rdoOutputFahrenheit.CheckedChanged += new System.EventHandler(this.rdoOutputFahrenheit_CheckedChanged);
            // 
            // rdoOutputMiles
            // 
            this.rdoOutputMiles.AutoSize = true;
            this.rdoOutputMiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdoOutputMiles.Location = new System.Drawing.Point(143, 47);
            this.rdoOutputMiles.Name = "rdoOutputMiles";
            this.rdoOutputMiles.Size = new System.Drawing.Size(53, 19);
            this.rdoOutputMiles.TabIndex = 6;
            this.rdoOutputMiles.TabStop = true;
            this.rdoOutputMiles.Text = "Miles";
            this.rdoOutputMiles.UseVisualStyleBackColor = true;
            this.rdoOutputMiles.CheckedChanged += new System.EventHandler(this.rdoOutputMiles_CheckedChanged);
            // 
            // radioOutputFeet
            // 
            this.radioOutputFeet.AutoSize = true;
            this.radioOutputFeet.ForeColor = System.Drawing.Color.Maroon;
            this.radioOutputFeet.Location = new System.Drawing.Point(143, 22);
            this.radioOutputFeet.Name = "radioOutputFeet";
            this.radioOutputFeet.Size = new System.Drawing.Size(47, 19);
            this.radioOutputFeet.TabIndex = 5;
            this.radioOutputFeet.TabStop = true;
            this.radioOutputFeet.Text = "Feet";
            this.radioOutputFeet.UseVisualStyleBackColor = true;
            this.radioOutputFeet.CheckedChanged += new System.EventHandler(this.radioOutputFeet_CheckedChanged);
            // 
            // rdoOutputGrams
            // 
            this.rdoOutputGrams.AutoSize = true;
            this.rdoOutputGrams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoOutputGrams.Location = new System.Drawing.Point(25, 124);
            this.rdoOutputGrams.Name = "rdoOutputGrams";
            this.rdoOutputGrams.Size = new System.Drawing.Size(59, 19);
            this.rdoOutputGrams.TabIndex = 4;
            this.rdoOutputGrams.TabStop = true;
            this.rdoOutputGrams.Text = "Grams";
            this.rdoOutputGrams.UseVisualStyleBackColor = true;
            this.rdoOutputGrams.CheckedChanged += new System.EventHandler(this.rdoOutputGrams_CheckedChanged);
            // 
            // rdoOutputKilograms
            // 
            this.rdoOutputKilograms.AutoSize = true;
            this.rdoOutputKilograms.ForeColor = System.Drawing.Color.Lime;
            this.rdoOutputKilograms.Location = new System.Drawing.Point(24, 99);
            this.rdoOutputKilograms.Name = "rdoOutputKilograms";
            this.rdoOutputKilograms.Size = new System.Drawing.Size(78, 19);
            this.rdoOutputKilograms.TabIndex = 3;
            this.rdoOutputKilograms.TabStop = true;
            this.rdoOutputKilograms.Text = "Kilograms";
            this.rdoOutputKilograms.UseVisualStyleBackColor = true;
            this.rdoOutputKilograms.CheckedChanged += new System.EventHandler(this.rdoOutputKilograms_CheckedChanged);
            // 
            // rdoOutputCelsius
            // 
            this.rdoOutputCelsius.AutoSize = true;
            this.rdoOutputCelsius.ForeColor = System.Drawing.Color.Yellow;
            this.rdoOutputCelsius.Location = new System.Drawing.Point(25, 72);
            this.rdoOutputCelsius.Name = "rdoOutputCelsius";
            this.rdoOutputCelsius.Size = new System.Drawing.Size(62, 19);
            this.rdoOutputCelsius.TabIndex = 2;
            this.rdoOutputCelsius.TabStop = true;
            this.rdoOutputCelsius.Text = "Celsius";
            this.rdoOutputCelsius.UseVisualStyleBackColor = true;
            this.rdoOutputCelsius.CheckedChanged += new System.EventHandler(this.rdoOutputCelsius_CheckedChanged);
            // 
            // rdoOutputKilometers
            // 
            this.rdoOutputKilometers.AutoSize = true;
            this.rdoOutputKilometers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoOutputKilometers.Location = new System.Drawing.Point(24, 47);
            this.rdoOutputKilometers.Name = "rdoOutputKilometers";
            this.rdoOutputKilometers.Size = new System.Drawing.Size(81, 19);
            this.rdoOutputKilometers.TabIndex = 1;
            this.rdoOutputKilometers.TabStop = true;
            this.rdoOutputKilometers.Text = "Kilometers";
            this.rdoOutputKilometers.UseVisualStyleBackColor = true;
            this.rdoOutputKilometers.CheckedChanged += new System.EventHandler(this.rdoOutputKilometers_CheckedChanged);
            // 
            // rdoOutputMeters
            // 
            this.rdoOutputMeters.AutoSize = true;
            this.rdoOutputMeters.ForeColor = System.Drawing.Color.Red;
            this.rdoOutputMeters.Location = new System.Drawing.Point(25, 22);
            this.rdoOutputMeters.Name = "rdoOutputMeters";
            this.rdoOutputMeters.Size = new System.Drawing.Size(61, 19);
            this.rdoOutputMeters.TabIndex = 0;
            this.rdoOutputMeters.TabStop = true;
            this.rdoOutputMeters.Text = "Meters";
            this.rdoOutputMeters.UseVisualStyleBackColor = true;
            this.rdoOutputMeters.CheckedChanged += new System.EventHandler(this.rdoOutputMeters_CheckedChanged);
            // 
            // txtInputAmount
            // 
            this.txtInputAmount.Location = new System.Drawing.Point(361, 96);
            this.txtInputAmount.Name = "txtInputAmount";
            this.txtInputAmount.PlaceholderText = "Please Enter Number";
            this.txtInputAmount.Size = new System.Drawing.Size(129, 23);
            this.txtInputAmount.TabIndex = 8;
            this.txtInputAmount.TextChanged += new System.EventHandler(this.txtInputAmount_TextChanged);
            this.txtInputAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputAmount_KeyPress);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(361, 384);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(129, 23);
            this.txtOutput.TabIndex = 9;
            // 
            // lblInstruct1
            // 
            this.lblInstruct1.AutoSize = true;
            this.lblInstruct1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct1.Location = new System.Drawing.Point(124, 104);
            this.lblInstruct1.Name = "lblInstruct1";
            this.lblInstruct1.Size = new System.Drawing.Size(44, 15);
            this.lblInstruct1.TabIndex = 10;
            this.lblInstruct1.Text = "STEP 1";
            // 
            // lblInstruct2
            // 
            this.lblInstruct2.AutoSize = true;
            this.lblInstruct2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct2.Location = new System.Drawing.Point(39, 147);
            this.lblInstruct2.Name = "lblInstruct2";
            this.lblInstruct2.Size = new System.Drawing.Size(44, 15);
            this.lblInstruct2.TabIndex = 11;
            this.lblInstruct2.Text = "STEP 2";
            // 
            // lblInstruct4
            // 
            this.lblInstruct4.AutoSize = true;
            this.lblInstruct4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct4.Location = new System.Drawing.Point(361, 205);
            this.lblInstruct4.Name = "lblInstruct4";
            this.lblInstruct4.Size = new System.Drawing.Size(44, 15);
            this.lblInstruct4.TabIndex = 12;
            this.lblInstruct4.Text = "STEP 4";
            // 
            // lblInstruct3
            // 
            this.lblInstruct3.AutoSize = true;
            this.lblInstruct3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct3.Location = new System.Drawing.Point(446, 147);
            this.lblInstruct3.Name = "lblInstruct3";
            this.lblInstruct3.Size = new System.Drawing.Size(44, 15);
            this.lblInstruct3.TabIndex = 13;
            this.lblInstruct3.Text = "STEP 3";
            // 
            // lblInstruct5
            // 
            this.lblInstruct5.AutoSize = true;
            this.lblInstruct5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct5.Location = new System.Drawing.Point(203, 336);
            this.lblInstruct5.Name = "lblInstruct5";
            this.lblInstruct5.Size = new System.Drawing.Size(348, 12);
            this.lblInstruct5.TabIndex = 14;
            this.lblInstruct5.Text = "* PLEASE NOTE THAT POSSIBLE UNIT COMBINATIONS ARE COLOR-CODED *";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "PRESS TO RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(766, 469);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblInstruct5);
            this.Controls.Add(this.lblInstruct3);
            this.Controls.Add(this.lblInstruct4);
            this.Controls.Add(this.lblInstruct2);
            this.Controls.Add(this.lblInstruct1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInputAmount);
            this.Controls.Add(this.grpOutputUnits);
            this.Controls.Add(this.grpInputUnits);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInputAmt);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Unit Converter";
            this.grpInputUnits.ResumeLayout(false);
            this.grpInputUnits.PerformLayout();
            this.grpOutputUnits.ResumeLayout(false);
            this.grpOutputUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblInputAmt;
        private Label lblOutput;
        private Button btnConversion;
        private GroupBox grpInputUnits;
        private RadioButton rdoInputOunces;
        private RadioButton rdoInputPounds;
        private RadioButton rdoInputFahrenheit;
        private RadioButton rdoInputMiles;
        private RadioButton rdoInputFeet;
        private RadioButton rdoInputGrams;
        private RadioButton rdoInputKilograms;
        private RadioButton rdoInputCelsius;
        private RadioButton rdoInputKilometers;
        private RadioButton rdoInputMeters;
        private GroupBox grpOutputUnits;
        private RadioButton rdoOutputOunces;
        private RadioButton rdoOutputPounds;
        private RadioButton rdoOutputFahrenheit;
        private RadioButton rdoOutputMiles;
        private RadioButton radioOutputFeet;
        private RadioButton rdoOutputGrams;
        private RadioButton rdoOutputKilograms;
        private RadioButton rdoOutputCelsius;
        private RadioButton rdoOutputKilometers;
        private RadioButton rdoOutputMeters;
        private TextBox txtInputAmount;
        private TextBox txtOutput;
        private Label lblInstruct1;
        private Label lblInstruct2;
        private Label lblInstruct4;
        private Label lblInstruct3;
        private Label lblInstruct5;
        private Button btnReset;
    }
}