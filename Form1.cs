using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Component2
{
    
    public partial class Form1 : Form
    {
     
        public Graphics g;
       
        Drawing NewDrawing;

        const int bit = 640;
        const int bit2 = 480;
        public Bitmap mybitmap = new Bitmap(bit, bit2);
        public Form1()
        {
            InitializeComponent();
            NewDrawing = new Drawing(Graphics.FromImage(mybitmap));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String command = textBox1.Text.Trim().ToLower();
                string multicommand = richTextBox1.Text.Trim().ToLower();
                commandParser commandparser = new commandParser();
                commandparser.Commands(command, multicommand, NewDrawing);
                Refresh();
            }
        }

         private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImageUnscaled(mybitmap, 0, 0);
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text File (.txt)|*.txt";
            loadFileDialog.Title = "Open File...";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(loadFileDialog.FileName);
                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }

        }

    
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (.txt)| *.txt";
            saveFileDialog.Title = "Save File...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fWriter = new StreamWriter(saveFileDialog.FileName);
                fWriter.Write(richTextBox1.Text);
                fWriter.Close();
            }
            richTextBox1.Text += "Command Save";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String command = textBox1.Text.Trim().ToLower();
            string multicommand = richTextBox1.Text.Trim().ToLower();
            commandParser commandparser = new commandParser();
            commandparser.Commands(command, multicommand, NewDrawing);
            Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
