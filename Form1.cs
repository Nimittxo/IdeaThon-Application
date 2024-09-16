using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPsi
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Destructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        // Methods

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count); 
            }
            tempIndex = index;  
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
            if(currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (childForm != null)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                ActivateButton(btnsender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPanel.Controls.Add(childForm);
                this.panelDesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            // This if for DashBoard!
            OpenChildForm(new Forms.FormDashboard(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is for Posts !
            ActivateButton(sender);
            OpenChildForm(new Forms.FormPosts(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This for Community !
            ActivateButton(sender);
            OpenChildForm(new Forms.FormCommunity(), sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This is for Connect !
            ActivateButton(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This is for Contact Us !
            ActivateButton(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //This is for Settings !
            ActivateButton(sender);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
