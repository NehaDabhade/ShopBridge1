using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ShopBridge1
{
    public partial class Form1 : Form
    {

        PictureBox pictureBox1;
        PictureBox pic;
        TextBox label4 = new TextBox();
        Label label5 = new Label();
        string v = null;
        int parsedValue=0;
        string m = null;

        

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1!=null)
            {
                pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(79, 40);
                pictureBox1.Name = textBox1.Text;
                pictureBox1.Size = new System.Drawing.Size(250, 1000);
                pictureBox1.BackColor = Color.White;
                pictureBox1.Image = Image.FromFile(@"E:\images\no-photo.png");

                panel1.Controls.Add(pictureBox1);


                label4.Parent = pictureBox1;
                label4.Text = ($"Name: { v}") + "\n " + ($"Price: {m}");
                label4.TextAlign = HorizontalAlignment.Center;//(ContentAlignment)4;

                Button button = new Button();
                button.Parent = pictureBox1;
                button.Text = "Delete";
                button.Location = new Point(150, 170);
                pictureBox1.Controls.Add(button);

                Button butto = new Button();
                butto.Parent = pictureBox1;
                butto.Text = "View";
                butto.Location = new Point(10, 170);
                pictureBox1.Controls.Add(butto);


                button.Click += new EventHandler(this.button_Click);
                butto.Click += new EventHandler(this.butto_Click);

                //textBox1.Clear();
                //textBox3.Clear();
                button1.Click += new EventHandler(this.button1_Click);

            }
            else
            {
                pictureBox1 = new PictureBox();
            }

        }

        
    void button_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Dispose();
            pic.Dispose();
        }
        void butto_Click(object sender, System.EventArgs e)
        {
            pic = new PictureBox();
            pic.Image = new Bitmap(@"E:\images\no-photo.png");
            pic.Location = new System.Drawing.Point(400, -250);
            pic.Name = textBox1.Text;
            pic.Size = new System.Drawing.Size(250, 1000);
            pic.BackColor = Color.White;
            panel1.Controls.Add(pic);

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            v = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string textboxValue = textBox3.Text;
            int i;
            if (!int.TryParse(textBox3.Text, out i))
            {
                
                m = i.ToString();
                try
                {
                    if (m == "0")
                    {
                        throw new InvalidOperationException(e.ToString());
                    }
                    
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Invalid input for price");
                }
            }
            
            else if (string.IsNullOrEmpty(textboxValue))
            
            {
                
            }
            else
            {
                m = textBox3.Text;
            }
        }

        
    }
}

