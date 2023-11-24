/*Problem Statement:
Design a message display application. Allow users to enter their name and 
favorite saying in a single method that gets invoked two times. First call
the method asking for the person’s name. Send a string argument indicating 
what value should be entered. Invoke the method a second time to retrieve
the favorite saying. Return the string values back to the Main( ) method. 
Call another method, sending the name and saying. From that method, display 
the message showing the person’s name and their saying surrounded by rows of 
greater than/less than symbols(<><><>).
*/

using System;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        // Event handler for the click event of Button1
        private void Button1_Click(object sender, EventArgs e)
        {
            // Retrieve the text from TextBox1
            string name = textBox1.Text;

            // Construct a message with the entered name
            string msg = $"<<{name}>>";

            // Display a message box with the constructed message, title "Confirmed", OK button, and an exclamation icon
            MessageBox.Show(msg, "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Create an instance of Form2 and show it, passing the entered name as a parameter
            Form2 newform = new Form2(textBox1.Text);
            newform.Show();
        }
    }
}
