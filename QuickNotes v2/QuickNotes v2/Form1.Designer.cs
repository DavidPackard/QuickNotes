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
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_textbox.Location = new System.Drawing.Point(12, 12);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(420, 48);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.Text = "";
            // 
            // AddNote_Button
            // 
            this.AddNote_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNote_Button.Location = new System.Drawing.Point(438, 13);
            this.AddNote_Button.Name = "AddNote_Button";
            this.AddNote_Button.Size = new System.Drawing.Size(85, 47);
            this.AddNote_Button.TabIndex = 2;
            this.AddNote_Button.Text = "Add Note";
            this.AddNote_Button.UseVisualStyleBackColor = true;
            // 
            // StartCall_PreButton
            // 
            this.StartCall_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCall_PreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartCall_PreButton.Location = new System.Drawing.Point(438, 79);
            this.StartCall_PreButton.Name = "StartCall_PreButton";
            this.StartCall_PreButton.Size = new System.Drawing.Size(85, 27);
            this.StartCall_PreButton.TabIndex = 3;
            this.StartCall_PreButton.Text = "Start Call";
            this.StartCall_PreButton.UseVisualStyleBackColor = false;
            // 
            // OnHold_PreButton
            // 
            this.OnHold_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnHold_PreButton.Location = new System.Drawing.Point(438, 112);
            this.OnHold_PreButton.Name = "OnHold_PreButton";
            this.OnHold_PreButton.Size = new System.Drawing.Size(85, 27);
            this.OnHold_PreButton.TabIndex = 3;
            this.OnHold_PreButton.Text = "On Hold";
            this.OnHold_PreButton.UseVisualStyleBackColor = true;
            // 
            // OffHold_PreButton
            // 
            this.OffHold_PreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OffHold_PreButton.Location = new System.Drawing.Point(438, 145);
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
            this.EndCall_Button.Location = new System.Drawing.Point(438, 178);
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
            this.log_textbox.Size = new System.Drawing.Size(419, 204);
            this.log_textbox.TabIndex = 4;
            this.log_textbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.EndCall_Button);
            this.Controls.Add(this.OffHold_PreButton);
            this.Controls.Add(this.OnHold_PreButton);
            this.Controls.Add(this.StartCall_PreButton);
            this.Controls.Add(this.AddNote_Button);
            this.Controls.Add(this.input_textbox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 255);
            this.Name = "Form1";
            this.Text = "QuickNotes v2.0";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox input_textbox;
        private System.Windows.Forms.Button AddNote_Button;
        private System.Windows.Forms.Button StartCall_PreButton;
        private System.Windows.Forms.Button OnHold_PreButton;
        private System.Windows.Forms.Button OffHold_PreButton;
        private System.Windows.Forms.Button EndCall_Button;
        private System.Windows.Forms.RichTextBox log_textbox;
    }
}

