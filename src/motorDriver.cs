/**
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParrallelDriverSpace;

namespace simpleRobot_controller_V1._0
{
    class MotorDriver
    {     



        private ParrallelDriver parallelPortIO = new ParrallelDriver(8, 888);
        //private carDirection directionGoing = new carDirection();

        //Public constructor - Inititalisation.
        public MotorDriver(int numberOfDigitalIO, int portAddressEG888)
        {
            parallelPortIO = new ParrallelDriver(numberOfDigitalIO, portAddressEG888);
        }



        
        //public methods (new)
            //Gets

            //Sets
        

            //Dos
                //Do action
                


                //Movement methods
                #region Motor movements
                    //Make motors go foward
                    public void goDirectionFoward()
                    {
                        //Output int=10,bool={0101}
                        int[] directionBinary = {0,1,0,1};
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }
                    
                    //Make motors Stop
                    public void goDirectionStop()
                    {
                        //Output int=0,bool={0000}
                        int[] directionBinary = { 0, 0, 0, 0 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors Stop2
                    public void goDirectionStop2()
                    {
                        //Output int=15,bool={1111}
                        int[] directionBinary = { 1, 1, 1, 1 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors go Reverse
                    public void goDirectionReverse()
                    {
                        //Output int=5,bool={1010}
                        int[] directionBinary = { 1, 0, 1, 0 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors go Left
                    public void goDirectionLeft()
                    {
                        //Output int=8,bool={0001}
                        int[] directionBinary = { 0, 0, 0, 1 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors go Right
                    public void goDirectionRight()
                    {
                        //Output int=14,bool={0111}
                        int[] directionBinary = { 0, 1, 1, 1 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors go Left
                    public void goDirectionLeft360()
                    {
                        //Output int=9,bool={1001}
                        int[] directionBinary = { 1, 0, 0, 1 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                    //Make motors go Right
                    public void goDirectionRight360()
                    {
                        //Output int=6,bool={0110}
                        int[] directionBinary = { 0, 1, 1, 0 };
                        setEntireIO(directionBinary, 0);
                        this.writeDataToPort();
                    }

                #endregion






        //public methods (carried through)
        #region
             //Gets
                //Get current States
                public int[] getdigitalLines()
                { 
                    return this.parallelPortIO.getdigitalLines(); 
                }
                

            //Sets
                //Put data in
                public void setAnIObit(int digitalLineNumber, int value)
                { 
                    this.parallelPortIO.setAnIObit(digitalLineNumber, value); 
                }
        
                public void setEntireIO(int[] allIOs, int intoPosition)
                { 
                    this.parallelPortIO.setEntireIO(allIOs, intoPosition); 
                }
                

            //Dos
                //Write Data to port
                public void writeDataToPort()
                { 
                    this.parallelPortIO.writeDataToPort(); 
                }
        #endregion

    }


    
}
