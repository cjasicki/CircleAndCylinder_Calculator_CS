using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_CS
{
    public partial class Form1 : Form
    {
        clsCircle Circle = null;
        clsCylinder Cylinder = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            getData();

        }

        private void getData()
        {
            txtError.Text = "";
            if (!CheckValidData())  // checks if data entered is a decimal and not ""
            {
                setupfromForCircleOrCylinder(); // sets objects on the form to which radio button is checked
                if (rdoCircle.Checked == true)  // updates error textbox if CheckValidData is true
                {
                    txtError.Text = "Radius must be postive numbers.";
                }
                else
                {
                    txtError.Text = "Radius and Height must be postive numbers.";
                }
            }
            else  //runs main code based on what which radio button is checked
            {
                if (rdoCircle.Checked)
                {
                    runCircle();
                }
                else
                {
                    runCylinder();
                }
            }
        }
        private void runCircle() 
        {
            // calculates Circale info using the clsCircle class

            txtError.Text = "Getting info for Circle";

            //initialize new Circle object
            if (Circle == null)
            {
                Circle = new clsCircle();
            }
            // Sets Properties
            Circle.Radius = Convert.ToDecimal(txtRadius.Text);

            // Updates textboxes
            txtCircumference.Text = Circle.Circumference().ToString();
            txtArea.Text = Circle.Area().ToString();

            setupfromForCircleOrCylinder();
        }
        private void runCylinder()
        {
            // calculates Cylinder info using the Cylinder class

            txtError.Text = "Getting info for Cylinder";

            //initialize new Cylinder object
            if (Cylinder == null)
            {
                Cylinder = new clsCylinder();
            }

            // Sets Properties
            Cylinder.Radius = Convert.ToDecimal(txtRadius.Text);
            Cylinder.Height = Convert.ToDecimal(txtHeight.Text);

            // Updates textboxes
            txtArea.Text = Cylinder.Area().ToString();
            txtVolume.Text = Cylinder.Volume().ToString();
            txtCircumference.Text = Cylinder.Circumference().ToString();
            setupfromForCircleOrCylinder();
        }

        private void setupfromForCircleOrCylinder() // modifies form based on which radeo button is checked and if state of objects
        {
            // routine for form setup, which form ojects are visible and enabled ect.. 

            if (rdoCircle.Checked)
            {
                btnCircumf.Enabled = false;
                btnDispose.Enabled = false;
                btnArea.Enabled = false;
                btnNew.Enabled = true;
                btnDefinition.Enabled = false;
                btnVolume.Enabled = false;
                txtHeight.Visible = false;
                lblHeight.Visible = false;
                lblVolume.Visible = false;
                txtVolume.Visible = false;
                txtRadius.Text = "";
                txtArea.Text = "";
                txtCircumference.Text = "";
                txtHeight.Text = "";
                txtVolume.Text = "";

                if (Circle != null)
                {
                    btnCircumf.Enabled = true;
                    btnDispose.Enabled = true;
                    btnDispose.Enabled = true;
                    btnArea.Enabled = true;
                    btnNew.Enabled = false;
                    btnDefinition.Enabled = true;
                    txtRadius.Text = Circle.Radius.ToString();
                    txtCircumference.Text = Circle.Circumference().ToString();
                    txtArea.Text = Circle.Area().ToString();
                    txtError.Text = "Circle Data";
                }
            }
            else if (rdoCylinder.Checked)
            {
                btnNew.Enabled = true;
                txtRadius.Enabled = true;
                txtHeight.Enabled = true;
                lblVolume.Visible = true;
                txtVolume.Visible = true;
                txtHeight.Visible = true;
                lblHeight.Visible = true;
                txtHeight.Text = "";
                txtVolume.Text = "";
                txtRadius.Text = "";
                txtArea.Text = "";
                txtCircumference.Text = "";

                if (Cylinder != null)
                {
                    btnNew.Enabled = false;
                    btnDefinition.Enabled = true;
                    btnCircumf.Enabled = true;
                    btnArea.Enabled = true;
                    btnDispose.Enabled = true;
                    btnVolume.Enabled = true;
                    txtRadius.Text = Cylinder.Radius.ToString();
                    txtHeight.Text = Cylinder.Height.ToString();
                    txtCircumference.Text = Cylinder.Circumference().ToString();
                    txtArea.Text = Cylinder.Area().ToString();
                    txtVolume.Text = Cylinder.Volume().ToString();
                    txtError.Text = "Cylinder Data";
                }
            }
        }

        private Boolean CheckValidData() 
        {
            //returns true if valid data is in the Radius and Height text boxes or false if they don't have valid data

            Boolean blnOK = true;
            Decimal x;

            var lstx = new List<string>() { txtRadius.Text, txtHeight.Text };
            foreach (String a in lstx)
            {
                if (a != "")
                {
                    if (blnOK == true)
                    {
                        if (Decimal.TryParse(a, out x)) //checks if data is a Decimal
                        {
                            if (x < 0)
                            {
                                blnOK = false;
                            }
                        }
                        else
                        {
                            blnOK = false;
                        }
                    }

                    if (rdoCircle.Checked == true)
                    {
                        break;
                    }

                }
            }
            return blnOK;
        }

        private void RdoCylinder_CheckedChanged(object sender, EventArgs e)
        {
                setupfromForCircleOrCylinder();
        }

        private void RdoCircle_CheckedChanged(object sender, EventArgs e)
        {
                setupfromForCircleOrCylinder();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setupfromForCircleOrCylinder();
            txtHeight.Enabled = false;
            txtHeight.Visible = false;
            lblHeight.Visible = false;
        }

        private void BtnDefinition_Click(object sender, EventArgs e)
        {
            txtError.Text = "";

            if (rdoCircle.Checked)
            {
                if (Circle == null)
                {
                    txtError.Text = "Circle does not exist";
                }
                else
                {
                    MessageBox.Show(Circle.Definition().ToString(), "Circle class definition");
                }
            }
            else
            {
                if (Cylinder == null)
                {
                    txtError.Text = "Cylinder does not exist";
                }
                else
                {
                    MessageBox.Show(Cylinder.Definition().ToString(), " Cylinder class definition");
                }
            }
        }

        private void BtnDispose_Click(object sender, EventArgs e) 
        {
            // clears out ojects based on which radio button is checked when the Disposed button is clicked.
            if (rdoCircle.Checked)
            {
                Circle = null;
                txtError.Text = "Circal data removed";
            }
            else
            {
                Cylinder = null;
                txtError.Text = "Cylinder data removed";
            }
            setupfromForCircleOrCylinder();
        }

        private void BtnCircumf_Click(object sender, EventArgs e)
        {
            getData(); //recalculates from data
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            getData(); //recalculates from data
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            getData(); //recalculates from data
        }
    }
}
