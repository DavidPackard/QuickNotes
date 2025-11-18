using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNotes_v2
{
    public partial class Form1 : Form
    {
        private void AddNote(string overrideText = null)
        {
            string noteText;

            if (overrideText == null)
            {
                noteText = input_textbox.Text.Trim();
                if (string.IsNullOrEmpty(noteText))
                    return;
            }
            else
            {
                noteText = overrideText;
            }

            string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string entry = $"[{timestamp}] {noteText}{Environment.NewLine}";

            log_textbox.AppendText(entry);
            log_textbox.ScrollToCaret();

            if (overrideText == null)
                input_textbox.Clear();
        }

        private void AddCallStart()
        {
            string phone = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter caller ID / phone number (optional):",
                "Call Start",
                "");

            string entry;

            if (!string.IsNullOrWhiteSpace(phone))
                entry = $"=== [CALL START] {phone.Trim()} ===";
            else
                entry = "=== [CALL START] ===";

            AddNote(entry);
        }
        private void Input_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddNote();
            }
        }



        public Form1()
        {
            InitializeComponent();

            AddNote_Button.Click += (s, e) => AddNote();
            StartCall_PreButton.Click += (s, e) => AddCallStart();
            OnHold_PreButton.Click += (s, e) => AddNote("[CALL ON HOLD]");
            OffHold_PreButton.Click += (s, e) => AddNote("[CALL OFF HOLD]");
            EndCall_Button.Click += (s, e) => AddNote("=== [CALL ENDED] ===");

            input_textbox.KeyDown += Input_textbox_KeyDown;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
