using System;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                

                using (Stream fs = File.Open(saveFileDialog1.FileName, FileMode.Create))
                {
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
                    
                    fs.Write(bytes, 0, bytes.Length);

                }



                

                
                
            }

           
    }
    }



    


    
}
