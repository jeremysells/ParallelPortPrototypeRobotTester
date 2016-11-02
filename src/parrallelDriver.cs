/*
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ParrallelDriverSpace
{
    class ParrallelDriver
    {
        private int[] digitalOutputs = new int[1];
        private int portAddress = 888;  // 378 = 888;  // else= 632;

    //Init
       /**
        * Constructor
        */
        public ParrallelDriver(int numberOfLines, int usePortAddress)
        {
            digitalOutputs = new int[numberOfLines];
            this.portAddress = usePortAddress;
        }

    //Get/sets
      //Gets  
        /**
         * Get digital lines
         */
        public int[] getdigitalLines()
         { return this.digitalOutputs; }

    //Sets 
        /**
         * Set a single output 
         */
        public void setAnIObit(int digitalLineNumber, int value)
        {
            if (value != 0 || value != 1)
                return; //Error catching
            if (digitalLineNumber > digitalOutputs.Length)
                return; //Error not correctly setup

            digitalOutputs[digitalLineNumber] = value;
        }

        /**
         * Set the lot of digital outputs
         */
        public void setEntireIO(int[] allIOs, int intoPosition)
        {
            if ((allIOs.Length + intoPosition) > digitalOutputs.Length) //Can not make the digitalIO array bigger
                return; //Error/mistake
            
            //Intergrate into digital IO

            for (int i = 0; i != allIOs.Length; i++)
            {
                int position = i + intoPosition;
                digitalOutputs[position] = allIOs[i];
            }

        }


    //Do's
        /**
         * Write data to port
         */
        public void writeDataToPort()
        {
            string collatedDigitalOutput = "";

            //Make values into string (rem -> reversing order)
            for (int i = (digitalOutputs.Length); i != 0; i--)
            {
                collatedDigitalOutput += digitalOutputs[i-1].ToString();
            }
            
            int dataToWriteInINT = Convert.ToInt16(collatedDigitalOutput, 2);
            //PortAccess.Output(portAddress, dataToWriteInINT);

           // MessageBox.Show("Output : " + dataToWriteInINT.ToString());
        }
   }
}

/*
 * This class and/or dll was found somewhere online. Unfortuatly I can not remember where and there are several copies of inpout32.dll floating around on the internet.
 * It may have been somewhere like http://www.highrez.co.uk/Downloads/InpOut32/default.htm
 */
public class PortAccess
{
    [DllImport("inpout32.dll", EntryPoint = "Out32")]
    public static extern void Output(int adress, int value);
}