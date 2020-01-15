namespace DockerFormat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Right_RichTB = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Smaller_Button = new System.Windows.Forms.Button();
            this.Bigger_Button = new System.Windows.Forms.Button();
            this.CopyLeftButton = new System.Windows.Forms.Button();
            this.PasteLeftButton = new System.Windows.Forms.Button();
            this.CopyRightButton = new System.Windows.Forms.Button();
            this.PasteRightButton = new System.Windows.Forms.Button();
            this.RefreshLeftButton = new System.Windows.Forms.Button();
            this.RefreshRightButton = new System.Windows.Forms.Button();
            this.Left_RichTB = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Right_RichTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Left_RichTB, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Right_RichTB
            // 
            this.Right_RichTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_RichTB.Location = new System.Drawing.Point(375, 3);
            this.Right_RichTB.Name = "Right_RichTB";
            this.Right_RichTB.Size = new System.Drawing.Size(366, 419);
            this.Right_RichTB.TabIndex = 2;
            this.Right_RichTB.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.Smaller_Button, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bigger_Button, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CopyLeftButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PasteLeftButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CopyRightButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.PasteRightButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.RefreshLeftButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.RefreshRightButton, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 428);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Smaller_Button
            // 
            this.Smaller_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Smaller_Button.Location = new System.Drawing.Point(371, 3);
            this.Smaller_Button.Name = "Smaller_Button";
            this.Smaller_Button.Size = new System.Drawing.Size(86, 28);
            this.Smaller_Button.TabIndex = 9;
            this.Smaller_Button.Text = "Font--";
            this.Smaller_Button.UseVisualStyleBackColor = true;
            this.Smaller_Button.Click += new System.EventHandler(this.Smaller_Button_Click);
            // 
            // Bigger_Button
            // 
            this.Bigger_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bigger_Button.Location = new System.Drawing.Point(279, 3);
            this.Bigger_Button.Name = "Bigger_Button";
            this.Bigger_Button.Size = new System.Drawing.Size(86, 28);
            this.Bigger_Button.TabIndex = 8;
            this.Bigger_Button.Text = "Font++";
            this.Bigger_Button.UseVisualStyleBackColor = true;
            this.Bigger_Button.Click += new System.EventHandler(this.Bigger_Button_Click);
            // 
            // CopyLeftButton
            // 
            this.CopyLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyLeftButton.Location = new System.Drawing.Point(3, 3);
            this.CopyLeftButton.Name = "CopyLeftButton";
            this.CopyLeftButton.Size = new System.Drawing.Size(86, 28);
            this.CopyLeftButton.TabIndex = 2;
            this.CopyLeftButton.Text = "Copy";
            this.CopyLeftButton.UseVisualStyleBackColor = true;
            this.CopyLeftButton.Click += new System.EventHandler(this.CopyLeftButton_Click);
            // 
            // PasteLeftButton
            // 
            this.PasteLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasteLeftButton.Location = new System.Drawing.Point(95, 3);
            this.PasteLeftButton.Name = "PasteLeftButton";
            this.PasteLeftButton.Size = new System.Drawing.Size(86, 28);
            this.PasteLeftButton.TabIndex = 0;
            this.PasteLeftButton.Text = "Paste";
            this.PasteLeftButton.UseVisualStyleBackColor = true;
            this.PasteLeftButton.Click += new System.EventHandler(this.PasteLeftButton_Click);
            // 
            // CopyRightButton
            // 
            this.CopyRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyRightButton.Location = new System.Drawing.Point(647, 3);
            this.CopyRightButton.Name = "CopyRightButton";
            this.CopyRightButton.Size = new System.Drawing.Size(88, 28);
            this.CopyRightButton.TabIndex = 7;
            this.CopyRightButton.Text = "Copy";
            this.CopyRightButton.UseVisualStyleBackColor = true;
            this.CopyRightButton.Click += new System.EventHandler(this.CopyRightButton_Click);
            // 
            // PasteRightButton
            // 
            this.PasteRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasteRightButton.Location = new System.Drawing.Point(555, 3);
            this.PasteRightButton.Name = "PasteRightButton";
            this.PasteRightButton.Size = new System.Drawing.Size(86, 28);
            this.PasteRightButton.TabIndex = 6;
            this.PasteRightButton.Text = "Paste";
            this.PasteRightButton.UseVisualStyleBackColor = true;
            this.PasteRightButton.Click += new System.EventHandler(this.PasteRightButton_Click);
            // 
            // RefreshLeftButton
            // 
            this.RefreshLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshLeftButton.Location = new System.Drawing.Point(187, 3);
            this.RefreshLeftButton.Name = "RefreshLeftButton";
            this.RefreshLeftButton.Size = new System.Drawing.Size(86, 28);
            this.RefreshLeftButton.TabIndex = 4;
            this.RefreshLeftButton.Text = ">>";
            this.RefreshLeftButton.UseVisualStyleBackColor = true;
            this.RefreshLeftButton.Click += new System.EventHandler(this.RefreshLeftButton_Click);
            // 
            // RefreshRightButton
            // 
            this.RefreshRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshRightButton.Location = new System.Drawing.Point(463, 3);
            this.RefreshRightButton.Name = "RefreshRightButton";
            this.RefreshRightButton.Size = new System.Drawing.Size(86, 28);
            this.RefreshRightButton.TabIndex = 5;
            this.RefreshRightButton.Text = "<<";
            this.RefreshRightButton.UseVisualStyleBackColor = true;
            this.RefreshRightButton.Click += new System.EventHandler(this.RefreshRightButton_Click);
            // 
            // Left_RichTB
            // 
            this.Left_RichTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left_RichTB.Location = new System.Drawing.Point(3, 3);
            this.Left_RichTB.Name = "Left_RichTB";
            this.Left_RichTB.Size = new System.Drawing.Size(366, 419);
            this.Left_RichTB.TabIndex = 1;
            this.Left_RichTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DockerFormat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox Right_RichTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CopyLeftButton;
        private System.Windows.Forms.Button PasteLeftButton;
        private System.Windows.Forms.Button CopyRightButton;
        private System.Windows.Forms.Button PasteRightButton;
        private System.Windows.Forms.Button RefreshLeftButton;
        private System.Windows.Forms.Button RefreshRightButton;
        private System.Windows.Forms.RichTextBox Left_RichTB;
        private System.Windows.Forms.Button Smaller_Button;
        private System.Windows.Forms.Button Bigger_Button;
    }
}

