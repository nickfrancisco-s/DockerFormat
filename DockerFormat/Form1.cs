using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerFormat
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    public partial class Form1 : Form
    {
        static float FontSize;
        DockerTypes Keywords;       

        public Form1()
        {
            InitializeComponent();            
            FontSize = PasteLeftButton.Font.Size;
            initVocab();
        }
               

        private void PasteLeftButton_Click(object sender, EventArgs e)
        {
            FormatRichText(ref Left_RichTB, Clipboard.GetText());
        }

        private void CopyLeftButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)Left_RichTB.Text);
        }

        private void CopyRightButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)Right_RichTB.Text);
        }

       

        private void initVocab() 
        {
            string DaLingPath =  System.Environment.CurrentDirectory + "\\Language.json";
            Keywords = new DockerTypes(DaLingPath);
        }

        private int FormatRichText(ref RichTextBox targetObject, string Text) 
        {
            int ret = 0;
            string Raw;

            targetObject.Text = Text;
            targetObject.Font = new Font(targetObject.Font.FontFamily, FontSize);

            //ensure we only got single spaces
            Raw = Text.Replace("  ", " ");
            List<string> Tokens = new List<string>();
            
            //split tokens
            Tokens.AddRange(Raw.Split(' ').ToList());

            //

            

            //TODO apply formatting
           

            return ret;
        }

        private void PasteRightButton_Click(object sender, EventArgs e)
        {
            FormatRichText(ref Right_RichTB, Clipboard.GetText());
        }

        private void Bigger_Button_Click(object sender, EventArgs e)
        {
            FontSize++;
        }

        private void Smaller_Button_Click(object sender, EventArgs e)
        {
            FontSize--;
        }
    }
}
