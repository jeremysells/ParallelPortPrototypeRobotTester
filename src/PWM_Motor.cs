/**
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simpleRobot_controller_V1._0
{
    //A class that controlls the motor via pwm
    class PWM_Motor_Driver
    {
        public MotorDriver motor = new MotorDriver(8, 888);//NOTE:Need to make as a private 
        CarDirection currentDirection = new CarDirection();

        int pwmCycleTime = 40;
        double pwmPulseTime = 0.50;
        bool doingPWM = true;   //are we doing pwm

        //Default Constructor
        public PWM_Motor_Driver(int numberOfDigitalIO, int portAddressEG888)
        {
            motor = new MotorDriver(numberOfDigitalIO, portAddressEG888);
        }

   //Public actions
      #region motor direction settings
        //Set current direction Fowards
        public void goDirectionFowards()
        { 
            currentDirection.setDirectionFoward(); 
        }

        //Set current direction Reversed/Backwards
        public void goDirectionReversed()
        { 
            currentDirection.setDirectionBackwards(); 
        }

        //Set no direction
        public void goDirectionStoped()
        { 
            currentDirection.setDirectionStoped(); 
        }

        //Set current direction left
        public void goDirectionLeft()
        { 
            currentDirection.setDirectionLeft(); 
        }

        //Set current direction left 360
        public void goDirectionLeft360()
        { 
            currentDirection.setDirectionLeft360(); 
        }

        //Set current direction right 
        public void goDirectionRight()
        { 
            currentDirection.setDirectionRight(); 
        }

        //Set current direction right 360
        public void goDirectionRight360()
        { 
            currentDirection.setDirectionRight360(); 
        }
      #endregion

        //Do the pwm and return the next time interupt value 
        public int do_PWM_Actio_returnNextPWMValue()
        {
            //If doing TOn of the pwm
            if (doingPWM)
            {
                this.motorDoCurrentDirection();
                doingPWM = false;
                return this.getTimeOFF();
            }
            //If doing Toff
            else
            {
                motor.goDirectionStop();
                doingPWM = true;
                return this.getTimeON();
            }
        }

        //Motor do current direction
        public void motorDoCurrentDirection()
        {
            switch (this.currentDirection.getDirectionString())
            {
                case "Stoped":
                    this.motor.goDirectionStop();
                    break;
                case "Foward":
                    this.motor.goDirectionFoward();
                    break;
                case "Backwards":
                    this.motor.goDirectionReverse();
                    break;
                case "Left":
                    this.motor.goDirectionLeft();
                    break;
                case "Right":
                    this.motor.goDirectionRight();
                    break;
                case "Left360":
                    this.motor.goDirectionLeft360();
                    break;
                case "Right360":
                    this.motor.goDirectionRight360();
                    break;
            }    
        }



    //Sets
        //Set the pulse lenght Ttotal = Ton + Toff
        public void setPulseLength(int Ttotal)
        { 
            pwmPulseTime = Ttotal; 
        }

        //Set the PWM speed
        public void setPWMSpeed(double PWMtimeOnPercentage)
        { 
            this.pwmPulseTime = PWMtimeOnPercentage; 
        }




    //Private methods
        //Get the PWM time on
        private int getTimeON()
        {
            double timeON = pwmCycleTime * pwmPulseTime;
            return Convert.ToInt16(timeON);
        }

        //Get the PWM time off
        private int getTimeOFF()
        {
            double timeON = pwmCycleTime * (1-pwmPulseTime);
            return Convert.ToInt16(timeON);
        }
        
    }







    //Handles the car direction.
    class CarDirection
    {
        public CarDirection()
        { 

        }

        int direction = 0;
        //Int = Direction
        //0   = Stoped
        //1   = Foward
        //2   = Backwards
        //3   = Left
        //4   = Right
        //5   = Left360
        //6   = Right360


        //Sets
        //Set the direction manualy
        public void setDirectionInt(int setDirection)
        { 
            direction = setDirection; 
        }

        public void setDirectionStoped()
        { 
            direction = 0; 
        }

        public void setDirectionFoward()
        { 
            direction = 1; 
        }

        public void setDirectionBackwards()
        { 
            direction = 2; 
        }

        public void setDirectionLeft()
        { 
            direction = 3; 
        }

        public void setDirectionRight()
        { 
            direction = 4; 
        }

        public void setDirectionLeft360()
        { 
            direction = 5; 
        }

        public void setDirectionRight360()
        { 
            direction = 6; 
        }

        //gets
        //Get a string indicating the direction
        public string getDirectionString()
        {
            string directionString = "";
            switch (direction)
            {
                case 0:
                    directionString = "Stoped";
                    break;
                case 1:
                    directionString = "Foward";
                    break;
                case 2:
                    directionString = "Backwards";
                    break;
                case 3:
                    directionString = "Left";
                    break;
                case 4:
                    directionString = "Right";
                    break;
                case 5:
                    directionString = "Left360";
                    break;
                case 6:
                    directionString = "Right360";
                    break;
            }

            return directionString;

        }

        //Get a number indication the direction
        public int getDirectionInt()
        { 
            return direction; 
        }
    }
}
