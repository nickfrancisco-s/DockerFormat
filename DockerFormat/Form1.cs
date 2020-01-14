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
    

    public partial class Form1 : Form
    {
        static float FontSize;
        Vocab DockerSyntax;
              

        public Form1()
        {
            InitializeComponent();            
            FontSize = PasteLeftButton.Font.Size + 2;
            initVocab();
        }
               

        private void PasteLeftButton_Click(object sender, EventArgs e)
        {
            Left_RichTB.Clear();
            FormatRichText(ref Left_RichTB, Clipboard.GetText(),false);
        }

        private void CopyLeftButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)Left_RichTB.Text);
        }

        private void CopyRightButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)Right_RichTB.Text);
        }

        private void PasteRightButton_Click(object sender, EventArgs e)
        {
            PasteRight();
        }


        private void PasteLeft() 
        {            
            Left_RichTB.Clear();
            FormatRichText(ref Left_RichTB, Clipboard.GetText(), false);
        }

        private void PasteRight()
        {
            Right_RichTB.Clear();
            FormatRichText(ref Right_RichTB, Clipboard.GetText(), true);
        }

        private void Bigger_Button_Click(object sender, EventArgs e)
        {
            FontSize++;
            PasteLeft();
            PasteRight();
        }

        private void Smaller_Button_Click(object sender, EventArgs e)
        {
            FontSize--;
            PasteLeft();
            PasteRight();
        }
       

        private void initVocab() 
        {
            string DaLingPath =  System.Environment.CurrentDirectory + "\\Language.json";
            DockerSyntax = new Vocab(DaLingPath);           
        }

        private System.Drawing.Color ApplyFormatting(string Token, Vocab TheSyntax) 
        {
            Color DaCol = Color.Black;

            //Global Replace
            if (TheSyntax.Items.ContainsKey(Token))
            {
                //we do a ting then apply
                DaCol = DockerSyntax.Items[Token].Color;                               
            }

            //prefixes
           foreach(KeyValuePair<string,Color> kvp in TheSyntax.Prefixes  )
           {
               int Len = kvp.Key.Length;
               if (Token.Length > Len) 
               {
                   if ((Token.Substring(0, Len)) == kvp.Key) 
                   { 
                     // Do the whole token
                       DaCol = kvp.Value;
                       break; //We foudn summat, no need to ncontinues
                   }
               }
           }

            return DaCol;
        }
        private int FormatRichText(ref RichTextBox targetObject, string Text, bool SingleLines) 
        {
            int ret = 0;
            string Raw;           
            int CountSinceLastPair = 0;
            bool StartCounting = false;
                        
            targetObject.Font = new Font(targetObject.Font.FontFamily, FontSize);

            //ensure we only got single spaces
            Raw = Text.Replace("  ", " ");
            List<string> Tokens = new List<string>();
            
            //split tokens
            Tokens.AddRange(Raw.Split(' ').ToList());

            //                      
            int Max = Tokens.Count();
            int cnt= 0;

            //TODO apply formatting
            foreach (string Tok in Tokens) 
            { 
                //Check VS ling 
                bool Bold = false;
                cnt++;
                System.Drawing.Color DaColor = Color.Black;

                if (StartCounting)
                {
                    CountSinceLastPair++;
                }

                //global keywork replacements                
                DaColor = ApplyFormatting(Tok, DockerSyntax);


                //Check if uppercase :

               
                //append to the box
                targetObject.AppendText(Tok, DaColor);

                //Carraige returns
                if (SingleLines) 
                {
                    if (Tok.Length > 2)
                    {
                        if (Tok.Substring(0, 2) == "--")
                        {                           
                            StartCounting = true;
                        }
                    }
                }

                if(cnt != Max)
                {
                    targetObject.AppendText(" ");
                  
                    if (SingleLines) 
                    {
                        if (CountSinceLastPair==1) 
                        {
                            CountSinceLastPair = 0;
                            StartCounting = false;
                            targetObject.AppendText("\r\n");
                        }
                    }
                }

            }
           

            return ret;
        }

        private void RefreshRightButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshLeftButton_Click(object sender, EventArgs e)
        {
            //Breaks the text to lines then spits it out
        }

       
    }

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
}
