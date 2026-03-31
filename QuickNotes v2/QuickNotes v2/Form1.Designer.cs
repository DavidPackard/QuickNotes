namespace QuickNotes_v2
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
            this.input_textbox = new System.Windows.Forms.RichTextBox();
            this.AddNote_Button = new System.Windows.Forms.Button();
            this.StartCall_PreButton = new System.Windows.Forms.Button();
            this.OnHold_PreButton = new System.Windows.Forms.Button();
            this.OffHold_PreButton = new System.Windows.Forms.Button();
            this.EndCall_Button = new System.Windows.Forms.Button();
            this.log_textbox = new System.Windows.Forms.RichTextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.asset_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_textbox.Location = new System.Drawing.Point(12, 12);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(302, 48);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.Text = "";
            // 
            // AddNote_Button
            // 
            this.AddNote_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNote_Button.Location = new System.Drawing.Point(431, 13);
            this.AddNote_Button.Name = "AddNote_Button";
            this.AddNote_Button.Size = new System.Drawing.Size(85, 47);
            this.AddNote_Button.TabIndex = 2;
            this.AddNote_Button.Text = "Add Note\r\n[Enter]";
            this.AddNote_Button.UseVisualStyleBackColor = true;
            // 
            // StartCall_PreButton
            // 
            this.StartCall_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCall_PreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartCall_PreButton.Location = new System.Drawing.Point(431, 67);
            this.StartCall_PreButton.Name = "StartCall_PreButton";
            this.StartCall_PreButton.Size = new System.Drawing.Size(85, 27);
            this.StartCall_PreButton.TabIndex = 3;
            this.StartCall_PreButton.Text = "Start Call";
            this.StartCall_PreButton.UseVisualStyleBackColor = false;
            // 
            // OnHold_PreButton
            // 
            this.OnHold_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnHold_PreButton.Location = new System.Drawing.Point(431, 96);
            this.OnHold_PreButton.Name = "OnHold_PreButton";
            this.OnHold_PreButton.Size = new System.Drawing.Size(85, 27);
            this.OnHold_PreButton.TabIndex = 3;
            this.OnHold_PreButton.Text = "On Hold";
            this.OnHold_PreButton.UseVisualStyleBackColor = true;
            // 
            // OffHold_PreButton
            // 
            this.OffHold_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OffHold_PreButton.Location = new System.Drawing.Point(431, 125);
            this.OffHold_PreButton.Name = "OffHold_PreButton";
            this.OffHold_PreButton.Size = new System.Drawing.Size(85, 27);
            this.OffHold_PreButton.TabIndex = 3;
            this.OffHold_PreButton.Text = "Off Hold";
            this.OffHold_PreButton.UseVisualStyleBackColor = true;
            // 
            // EndCall_Button
            // 
            this.EndCall_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndCall_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndCall_Button.Location = new System.Drawing.Point(432, 154);
            this.EndCall_Button.Name = "EndCall_Button";
            this.EndCall_Button.Size = new System.Drawing.Size(85, 27);
            this.EndCall_Button.TabIndex = 3;
            this.EndCall_Button.Text = "End Call";
            this.EndCall_Button.UseVisualStyleBackColor = false;
            // 
            // log_textbox
            // 
            this.log_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_textbox.Location = new System.Drawing.Point(13, 67);
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.Size = new System.Drawing.Size(412, 189);
            this.log_textbox.TabIndex = 4;
            this.log_textbox.Text = "";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_Button.Location = new System.Drawing.Point(101, 258);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(53, 23);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // asset_textbox
            // 
            this.asset_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asset_textbox.Location = new System.Drawing.Point(320, 35);
            this.asset_textbox.Name = "asset_textbox";
            this.asset_textbox.Size = new System.Drawing.Size(105, 26);
            this.asset_textbox.TabIndex = 1;
            this.asset_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Asset";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear.BackColor = System.Drawing.Color.IndianRed;
            this.button_clear.Location = new System.Drawing.Point(12, 258);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(53, 23);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load Autosave";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.EndCall_Button);
            this.Controls.Add(this.OffHold_PreButton);
            this.Controls.Add(this.OnHold_PreButton);
            this.Controls.Add(this.StartCall_PreButton);
            this.Controls.Add(this.AddNote_Button);
            this.Controls.Add(this.asset_textbox);
            this.Controls.Add(this.input_textbox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 255);
            this.Name = "Form1";
            this.Text = "QuickNotes v2.6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox input_textbox;
        private System.Windows.Forms.Button AddNote_Button;
        private System.Windows.Forms.Button StartCall_PreButton;
        private System.Windows.Forms.Button OnHold_PreButton;
        private System.Windows.Forms.Button OffHold_PreButton;
        private System.Windows.Forms.Button EndCall_Button;
        private System.Windows.Forms.RichTextBox log_textbox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.RichTextBox asset_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

