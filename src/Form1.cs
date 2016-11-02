/**
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParrallelDriverSpace;
using System.Threading;

/*
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
namespace simpleRobot_controller_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerPWM.Start();
        }

      //  motorDriver driver = new motorDriver(8, 888);
        PWM_Motor_Driver driver = new PWM_Motor_Driver(8, 888);

        private void buttonFoward_Click(object sender, EventArgs e)
        {
            driver.goDirectionFowards();
        }

        private void buttonStop1_Click(object sender, EventArgs e)
        {
            driver.goDirectionStoped();
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            driver.goDirectionStoped();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            driver.goDirectionLeft();
        }

        private void buttonLeft360_Click(object sender, EventArgs e)
        {
            driver.goDirectionLeft360();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            driver.goDirectionRight();
        }

        private void buttonRight360_Click(object sender, EventArgs e)
        { 
            driver.goDirectionRight360();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            driver.goDirectionReversed();
        }

        
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            //Check the textbox
            string key = textBox1.Text;
            textBox1.Text = "";

            switch (key)
            {
                case "w":
                        driver.goDirectionFowards();
                        break;
                case "s":
                        driver.goDirectionReversed();
                        break;
                case "a":
                        driver.goDirectionLeft();
                        break;
                case "d":
                        driver.goDirectionRight();
                        break;
                case "q":
                        driver.goDirectionLeft360();
                        break;
                case "e":
                        driver.goDirectionRight360();
                        break;
                case "z":
                        driver.goDirectionStoped();
                        return;
                case "x":
                        driver.goDirectionStoped();
                        return;
            }
        }


        //Doing the PWM via timer ticker.
        private void timerPWM_Tick(object sender, EventArgs e)
        {
            //timerPWM.Stop();
            int newTimerTime = driver.do_PWM_Actio_returnNextPWMValue();
            listBox1.Items.Add(newTimerTime.ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1 ;
            timerPWM.Interval = newTimerTime;
            //timerPWM.Start();
        }

        //Setting the tracker (valueselector)
        private void trackBarMovementSpeed_Move(object sender, EventArgs e)
        {
           
        }

        //Ttotal setting
        private void trackBarMovementSpeed_Scroll(object sender, EventArgs e)
        {
            int value = trackBarMovementSpeed.Value;
            labeltrackBarMovementSpeed.Text = value.ToString();
            driver.setPulseLength(value);            
        }
        
        //PWM % setting
        private void trackBarGapPWM_Scroll(object sender, EventArgs e)
        {
            double value = 0.2; //Convert.ToDouble((trackBarGapPWM.Value / 10));
            labeltrackBarGapPWM.Text = value.ToString();
            driver.setPWMSpeed(value);
        }


    }
}
