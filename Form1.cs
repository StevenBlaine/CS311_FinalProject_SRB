namespace UnitConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int firstUnit = 0;
        public int secondUnit = 0;
        public float inputAmount;

        private void btnConversion_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            float convOutput = 0;

            // set switch case value for determining appropriate formula 
            int formulaDeterminer = firstUnit + secondUnit;

            // calculate the conversion using determined value and appropriate formula
            switch (formulaDeterminer)
            {
                case 15:
                    convOutput = (float)(inputAmount * 3.28);
                    break;

                case 14:
                    convOutput = (float)(inputAmount * 0.3048);
                    break;

                case 21:
                    convOutput = (float)(inputAmount * 0.621731);
                    break;

                case 20:
                    convOutput = (float)(inputAmount * 1.60934);
                    break;

                case 27:
                    convOutput = (float)((inputAmount * 9 / 5) + 32);
                    break;

                case 26:
                    convOutput = (float)((inputAmount - 32) / 1.8);
                    break;

                case 33:
                    convOutput = (float)(2.205 * inputAmount);
                    break;

                case 32:
                    convOutput = (float)(inputAmount / 2.205);
                    break;

                case 39:
                    convOutput = (float)(inputAmount / 28.35);
                    break;

                case 38:
                    convOutput = (float)(inputAmount * 28.35);
                    break;

                default:
                    MessageBox.Show("Conversion not possible.");
                    break;
            }   
            txtOutput.Text = convOutput.ToString("n2");
        }

        // the following code assigns a unique value to each radio button selection
        private void rdoInputMeters_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputMeters = (RadioButton)sender;
            if (rdoInputMeters.Checked)
            { firstUnit = 1; }
        }

        private void rdoInputFeet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputFeet = (RadioButton)sender;
            if (rdoInputFeet.Checked)
            { firstUnit = 2; }
        }

        private void rdoInputKilometers_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputKilometers = (RadioButton)sender;
            if (rdoInputKilometers.Checked)
            { firstUnit = 3; }
        }

        private void rdoInputMiles_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputMiles = (RadioButton)sender;
            if (rdoInputMiles.Checked)
            { firstUnit = 4; }
        }

        private void rdoInputCelsius_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputCelsius = (RadioButton)sender;
            if (rdoInputCelsius.Checked)
            { firstUnit = 5; }
        }

        private void rdoInputFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputFahrenheit = (RadioButton)sender;
            if (rdoInputFahrenheit.Checked)
            { firstUnit = 6; }
        }

        private void rdoInputKilograms_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputKilograms = (RadioButton)sender;
            if (rdoInputKilograms.Checked)
            { firstUnit = 7; }
        }

        private void rdoInputPounds_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputPounds = (RadioButton)sender;
            if (rdoInputPounds.Checked)
            { firstUnit = 8; }
        }

        private void rdoInputGrams_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputGrams = (RadioButton)sender;
            if (rdoInputGrams.Checked)
            { firstUnit = 9; }
        }

        private void rdoInputOunces_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoInputOunces = (RadioButton)sender;
            if (rdoInputOunces.Checked)
            { firstUnit = 10; }
        }

        private void rdoOutputMeters_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputMeters = (RadioButton)sender;
            if (rdoOutputMeters.Checked)
            { secondUnit = 12; }
        }

        private void radioOutputFeet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputFeet = (RadioButton)sender;
            if (rdoOutputFeet.Checked)
            { secondUnit = 14; }
        }

        private void rdoOutputKilometers_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputKilometers = (RadioButton)sender;
            if (rdoOutputKilometers.Checked)
            { secondUnit = 16; }
        }

        private void rdoOutputMiles_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputMiles = (RadioButton)sender;
            if (rdoOutputMiles.Checked)
            { secondUnit = 18; }
        }

        private void rdoOutputCelsius_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputCelsius = (RadioButton)sender;
            if (rdoOutputCelsius.Checked)
            { secondUnit = 20; }
        }

        private void rdoOutputFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputFahrenheit = (RadioButton)sender;
            if (rdoOutputFahrenheit.Checked)
            { secondUnit = 22; }
        }

        private void rdoOutputKilograms_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputKilograms = (RadioButton)sender;
            if (rdoOutputKilograms.Checked)
            { secondUnit = 24; }
        }

        private void rdoOutputPounds_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputPounds = (RadioButton)sender;
            if (rdoOutputPounds.Checked)
            { secondUnit = 26; }
        }

        private void rdoOutputGrams_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputGrams = (RadioButton)sender;
            if (rdoOutputGrams.Checked)
            { secondUnit = 28; }
        }

        private void rdoOutputOunces_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoOutputOunces = (RadioButton)sender;
            if (rdoOutputOunces.Checked)
            { secondUnit = 30; }
        }

        private void txtInputAmount_TextChanged(object sender, EventArgs e)
        {   
            inputAmount = float.Parse(txtInputAmount.Text);
        }
        
        // reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            frmMain NewForm = new frmMain();
            NewForm.Show();
            this.Dispose(false);
        }

        // to accept only numbers and a decimal point
        private void txtInputAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}