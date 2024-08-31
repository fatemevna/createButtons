using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicallyCreateButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox.TextChanged += textBox_TextChanged;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null) return;
        
            var count = Convert.ToInt16(txtBox.Text);
            //
            var xPosition = 0;
            for (var i = 1; i <= count; i++)
            {
                var button = new Button
                {
                    Tag = string.Format("Btn{0}", i),
                    Text = string.Format("Button{0}", i),
                    Location = new Point(xPosition, 20)
                     

                };// MessageBox.Show ($"button created");
                xPosition = xPosition + 200;
                Controls.Add(button);
                if (i % 3 == 0) { button.BackColor = Color.Pink; button.ForeColor = Color.Red;
                }
                else if (i % 2 == 0) { button.BackColor = Color.AliceBlue; }
                else if (i% 5 == 0) { button.BackColor= Color.YellowGreen; }
                else { button.BackColor = Color.White; button.ForeColor = Color.YellowGreen; }
                
               // MessageBox.Show("button added to the form");
            }

            
        }
    } }
