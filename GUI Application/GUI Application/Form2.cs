using System;
using System.Windows.Forms;

namespace GUI_Application
{
   
    public partial class Form2 : Form
    {
        // Variable to store the name
        string name;

        // Constructor for Form2, takes a string parameter Str_Value
        public Form2(string Str_Value)
        {
            
            InitializeComponent();

            // Assign the value of Str_Value to the name variable
            name = Str_Value;
        }

        // Event handler for the click event of Button1
        private void Button1_Click(object sender, EventArgs e)
        {
            // Retrieve the text from TextBox1
            string saying = textBox1.Text;

            // Construct a message with the entered name and saying
            string msg = $"<<{name}>>\n<<{saying}>>";

            // Display a message box with the constructed message, title "Confirmed", OK button, and an information icon
            MessageBox.Show(msg, "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
