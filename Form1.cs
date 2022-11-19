using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ungdung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult r = o.ShowDialog();
            if(r == DialogResult.OK)
            {  
            fname = o.FileName;
            richTextBox1.LoadFile(fname, RichTextBoxStreamType.RichText);}
            else
            {
                MessageBox.Show("File is not sleected");
            }
            
        }

        private void findAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            richTextBox1.SelectionFont = f.Font;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            richTextBox1.SelectionColor = c.Color;
        }

        string fname="";
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text!= "")
            {
               DialogResult r = MessageBox.Show("Do You Want to Save This...", "Save ?", MessageBoxButtons.YesNoCancel);
                if(r == DialogResult.No) richTextBox1.Text = "" ;
                else if (r == DialogResult.Yes)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.ShowDialog();
                    fname = s.FileName;
                    richTextBox1.SaveFile(fname + ".doc", RichTextBoxStreamType.RichText);
                    this.Text = fname + ":" + this.Text;
                }
                else
                {

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fname == "") {
                SaveFileDialog s = new SaveFileDialog();
                DialogResult r = s.ShowDialog();
                if(r == DialogResult.OK)
                {
                fname = s.FileName;
                richTextBox1.SaveFile(fname + ".doc", RichTextBoxStreamType.RichText);
                this.Text = fname + ":" + this.Text;
                }
              
            }
            else
            {
                richTextBox1.SaveFile(fname + ".doc", RichTextBoxStreamType.RichText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            DialogResult r = s.ShowDialog();
            if (r == DialogResult.OK)
            {
            fname = s.FileName;
            richTextBox1.SaveFile(fname + ".doc", RichTextBoxStreamType.RichText);
            this.Text = fname + ":" + this.Text;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

      

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // string fontname = richTextBox1.Font.Name;
         
           // e.Graphics.DrawString(richTextBox1.Text,new Font)
        }

        private void findsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comparer SearchType;
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;  
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void addBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BulletIndent = 10;
            richTextBox1.SelectionBullet = true;
        }

        private void removeBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = false;
        }

        private void ptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 5;
        }

        private void ptsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 10;
        }

        private void ptsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 15;
        }

        private void ptsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 20;
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
