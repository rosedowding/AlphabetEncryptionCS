using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetEncryption
{
    public partial class Form1 : Form
    {
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ,-!?.1234567890"; //This string contains the standard alphabet
        string cipher = "YZABCDEFGHIJKLMNOPQRSTUVWX ,-!?.0142536798"; //This string contains the cipher alphabet

        public Form1()
        {
            InitializeComponent(); //This method tells the program to create and open the physical form
        }

        private void encryptionButton_Click(object sender, EventArgs e) //This method is ran when the encryption button is clicked
        {
            List<char> output = new List<char>(); //Create a new list of characters that will be used to store the output value

            string input = inputBox.Text.ToUpper(); //Convert the input string to uppercase. This is because our cipher only makes use of uppercase characters

            for (int i = 0; i < input.Length; i++) //Repeat loop for the number of characters in string
            {
                for (int j = 0; j < alpha.Length; j++) //Repeat loop for the number of characters in the alphabet and cipher
                {
                    if (input[i] == alpha[j]) //If the character is equal to a certain value of the standard alphabet
                    {
                        output.Add(cipher[j]); //Add the cipher counterpart to the output
                    }
                }
            }

            MessageBox.Show(new string(output.ToArray()), "Encryption Complete"); //Convert the list to an array, so that it can then be converted to a string, and output the response in a message box.
        }
    }
}
