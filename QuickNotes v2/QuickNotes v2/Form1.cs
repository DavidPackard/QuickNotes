using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNotes_v2
{
    public partial class Form1 : Form
    {
        private readonly string AutoSavePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "QuickNotesDraft.txt");

        private Timer autoSaveTimer;

        private void AddNote(string noteText = null, bool addTimestamp = true)
        {
            if (noteText == null)
            {
                noteText = input_textbox.Text.Trim();
                if (string.IsNullOrEmpty(noteText))
                    return;

                input_textbox.Clear();
            }

            string entry = noteText;

            if (addTimestamp)
            {
                string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                entry = $"[{timestamp}] {noteText}";
            }

            log_textbox.AppendText(entry + Environment.NewLine);
            log_textbox.ScrollToCaret();
        }


        private void AddCallStart()
        {
            // Prompt for basic customer info
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Customer Name:", "Call Start", "");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Enter Phone Number:", "Call Start", "");
            string issue = Microsoft.VisualBasic.Interaction.InputBox("Issue:", "Call Start", "");

            AddNote("=== [CALL START] ===", addTimestamp: true);
            // Build the template
            string template =
            $@"Name: {name}
Phone: {phone}
Issue: {issue}";

            AddNote(template, addTimestamp: false);
        }

        private void Input_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddNote();
            }
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(AutoSavePath, log_textbox.Text);
            }
            catch
            {
                // Fail silently
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Load draft if it exists
            if (File.Exists(AutoSavePath))
            {
                log_textbox.Text = File.ReadAllText(AutoSavePath);
            }

            // Setup auto-save timer (every 30 seconds)
            autoSaveTimer = new Timer();
            autoSaveTimer.Interval = 30_000; // 30 seconds
            autoSaveTimer.Tick += AutoSaveTimer_Tick;
            autoSaveTimer.Start();


            AddNote_Button.Click += (s, e) => AddNote();
            StartCall_PreButton.Click += (s, e) => AddCallStart();
            OnHold_PreButton.Click += (s, e) => AddNote("[CALL ON HOLD]");
            OffHold_PreButton.Click += (s, e) => AddNote("[CALL OFF HOLD]");
            EndCall_Button.Click += (s, e) => AddNote("=== [ CALL END ] ===");

            input_textbox.KeyDown += Input_textbox_KeyDown;

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Notes";
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Set initial directory to the folder where the EXE is running
                sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Default file name
                sfd.FileName = "notes.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, log_textbox.Text);
                        MessageBox.Show("Notes saved successfully.", "Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save file:\n{ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
