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
        string ClipboardCopy;

        public Form1()
        {
            InitializeComponent();            
            FontSize = PasteLeftButton.Font.Size + 2;
            ClipboardCopy = Clipboard.GetText(); //bakup what we had
            initVocab();
        }

        private void PasteLeftButton_Click(object sender, EventArgs e)
        {
            Left_RichTB.Clear();
            FormatRichText(ref Left_RichTB, Clipboard.GetText(),false);
        }

        private void CopyRight() 
        {           
            //we dont wanna replace the clipboard with nowts
            if (Right_RichTB.Text == "") 
            {
                return;
            }

            Clipboard.SetData(DataFormats.Text, (Object)(Right_RichTB.Text));
        }

        private void CopyLeft() 
        {
            if (Left_RichTB.Text == "")
            {
                return;
            }

            Clipboard.SetData(DataFormats.Text, (Object)Left_RichTB.Text);
        }

        private void CopyLeftButton_Click(object sender, EventArgs e)
        {
            CopyLeft();
        }

        private void CopyRightButton_Click(object sender, EventArgs e)
        {
            CopyRight();
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

        private System.Drawing.Color ApplyFormatting(ref string Token, Vocab TheSyntax , bool AllowNewLines) 
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

                       //silly rules
                       if (kvp.Key == "--") 
                       {
                           if (AllowNewLines)
                           {
                               Token = "\r\n" + Token;
                           }
                       }

                       break; //We foudn summat, no need to ncontinues
                   }
               }
           }

            return DaCol;
        }
        private int FormatRichText(ref RichTextBox targetObject, string Text, bool IndividualLines) 
        {
            int ret = 0;
            string Raw;           
            int CountSinceLastPair = 0;
            bool StartCounting = false;
                        
            targetObject.Font = new Font(targetObject.Font.FontFamily, FontSize);
            targetObject.Clear();

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
                string TokCopy = Tok;

                if (StartCounting)
                {
                    CountSinceLastPair++;
                }

                //we replace incoming \r\ns anyway...
                TokCopy = Tok.Replace("\r\n", "");
                TokCopy = TokCopy.Replace("\r", "");
                TokCopy = TokCopy.Replace("\n", "");

                //global keywork replacements                
                DaColor = ApplyFormatting(ref TokCopy, DockerSyntax, IndividualLines);

              

                //Check if uppercase :

                //CHeck for substring ,in token sply by an equall

                List<string> SubTokens = new List<string>();
                List<string> splitters = new List<string>();
                char[] spearator = { '=', ',' };
                string workCopy = TokCopy;
                int dk = 0;
                SubTokens = TokCopy.Split(spearator).ToList();                
               

               // SubTokens.AddRange(Tok.Split('=').ToList());

                //append to the box
                if (SubTokens.Count > 1) 
                {
                    int daC = -1;
                    
                    foreach (string s in SubTokens)
                    {
                        dk++;
                        if (dk == SubTokens.Count) 
                        {
                            break; // last one no separator
                        }

                        workCopy = workCopy.Substring(s.Length, workCopy.Length - s.Length);
                        string sep = workCopy.Substring(0, 1);
                        splitters.Add(sep);

                        //remove the separator
                        workCopy = workCopy.Substring(1, workCopy.Length - 1);
                    }

                    //we have all the sub tokens and we have the separators
                    foreach (string s in SubTokens)
                    {
                        daC++;
                        string s_copy = s;
                        DaColor = ApplyFormatting(ref s_copy, DockerSyntax, IndividualLines);
                        targetObject.AppendText( s_copy, DaColor);
                        if (daC < splitters.Count) // LAst case
                        {
                            targetObject.AppendText(splitters[daC], System.Drawing.Color.Brown);
                        }
                    }
                }
                else
                {
                    //jsut the one token
                    targetObject.AppendText(TokCopy, DaColor);
                }
                

                //Carraige returns
                if (IndividualLines) 
                {
                    if (TokCopy.Length > 2)
                    {
                        if (TokCopy.Substring(0, 2) == "--")
                        {                           
                            StartCounting = true;
                        }
                    }
                }

                if(cnt != Max)
                {
                    targetObject.AppendText(" ");
                  
                    if (IndividualLines) 
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
            PushToLeft();
        }

        private void PushToLeft() 
        {
            if (Right_RichTB.Text == "") //iGNORE BLANK INFO
            {
                return;
            }
            //copy what is on right and paste on left   
            try
            {
                Clipboard.SetText(Right_RichTB.Text);
                FormatRichText(ref Left_RichTB, Clipboard.GetText(), false);
            }
            catch 
            {
                MessageBox.Show("Error Accessing Clipboard, try again!");
            }

        }

        private void PushToRight() 
        {
            if (Left_RichTB.Text == "")
            {
                return;
            }
            //copy what on left and past on right
            //Clipboard.SetData(DataFormats.Text, (Object)(Left_RichTB.Text));
            try { 
                Clipboard.SetText(Left_RichTB.Text);
                FormatRichText(ref Right_RichTB, Clipboard.GetText(), true  );
            }
            catch
            {
                MessageBox.Show("Error Accessing Clipboard, try again");
            }
        }

        private void RefreshLeftButton_Click(object sender, EventArgs e)
        {
            //Breaks the text to lines then spits it out
            PushToRight();
        }

        private void RestoreClipboard()
        {
            MessageBox.Show("Restored original Clipboard contents");
            Clipboard.SetData(DataFormats.Text, ClipboardCopy);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestoreClipboard();
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
