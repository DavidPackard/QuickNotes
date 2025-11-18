using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuickNotesWin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // .NET 6/7 helper; if unavailable, use Application.EnableVisualStyles() etc.
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        readonly TextBox entry;
        readonly Button addBtn;
        readonly Button callStartBtn;
        readonly Button onHoldBtn;
        readonly Button offHoldBtn;
        readonly Button callEndBtn;
        readonly Button saveAsBtn;
        readonly RichTextBox notesBox;
        readonly FlowLayoutPanel customButtonsPanel;

        public MainForm()
        {
            Text = "Quick Notes";
            Size = new Size(700, 600);
            StartPosition = FormStartPosition.CenterScreen;

            // Top panel for entry + add button
            var topPanel = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(8) };
            Controls.Add(topPanel);

            entry = new TextBox { Width = 420, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            entry.KeyDown += Entry_KeyDown;
            topPanel.Controls.Add(entry);

            addBtn = new Button { Text = "Add Note", AutoSize = true, Left = entry.Right + 6 };
            addBtn.Click += (s, e) => AddNote();
            topPanel.Controls.Add(addBtn);

            // Custom buttons panel (below entry)
            customButtonsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(8),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = false
            };
            Controls.Add(customButtonsPanel);

            callStartBtn = new Button { Text = "Call Start", AutoSize = true, Margin = new Padding(3) };
            callStartBtn.Click += (s, e) => CallStartNote();
            customButtonsPanel.Controls.Add(callStartBtn);

            onHoldBtn = new Button { Text = "On Hold", AutoSize = true, Margin = new Padding(3) };
            onHoldBtn.Click += (s, e) => AddNote("[CALL ON HOLD]");
            customButtonsPanel.Controls.Add(onHoldBtn);

            offHoldBtn = new Button { Text = "Off Hold", AutoSize = true, Margin = new Padding(3) };
            offHoldBtn.Click += (s, e) => AddNote("[CALL OFF HOLD]");
            customButtonsPanel.Controls.Add(offHoldBtn);

            callEndBtn = new Button { Text = "Call End", AutoSize = true, Margin = new Padding(3) };
            callEndBtn.Click += (s, e) => AddNote("=== [CALL ENDED] ===");
            customButtonsPanel.Controls.Add(callEndBtn);

            // RichTextBox for notes (fills remainder)
            notesBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10),
                WordWrap = true,
                AcceptsTab = true
            };
            Controls.Add(notesBox);

            // Bottom panel for Save As
            var bottomPanel = new Panel { Dock = DockStyle.Bottom, Height = 50, Padding = new Padding(8) };
            Controls.Add(bottomPanel);

            saveAsBtn = new Button { Text = "Save As", AutoSize = true };
            saveAsBtn.Click += (s, e) => SaveAs();
            bottomPanel.Controls.Add(saveAsBtn);

            // Handle close event
            FormClosing += MainForm_FormClosing;
        }

        void Entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent ding / newline in single-line TextBox
                AddNote();
            }
        }

        void AddNote(string noteText = null)
        {
            string note;
            if (noteText == null)
            {
                note = entry.Text?.Trim();
            }
            else
            {
                note = noteText;
            }

            if (string.IsNullOrEmpty(note))
                return;

            string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string newEntry = $"[{timestamp}] {note}{Environment.NewLine}";

            notesBox.AppendText(newEntry);
            ScrollToBottom();

            if (noteText == null)
                entry.Clear();
        }

        void CallStartNote()
        {
            string prompt = InputDialog.Show("Call Start", "Phone Number (optional):");
            string full;
            if (!string.IsNullOrWhiteSpace(prompt))
                full = $"=== [CALL START] {prompt.Trim()} ===";
            else
                full = "[CALL START]";
            AddNote(full);
        }

        void SaveAs()
        {
            using var dlg = new SaveFileDialog
            {
                Title = "Save Notes As",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                AddExtension = true,
                FileName = "notes.txt",
                InitialDirectory = Environment.CurrentDirectory
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(dlg.FileName, notesBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to save file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Only prompt if there's any non-whitespace content in the notes box
            if (string.IsNullOrWhiteSpace(notesBox.Text))
                return;

            var res = MessageBox.Show(this, "Do you want to save your notes before exiting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SaveAs();
                // allow close (unless SaveAs failed — we don't detect that here)
            }
            else if (res == DialogResult.No)
            {
                // allow close
            }
            else
            {
                // Cancel
                e.Cancel = true;
            }
        }

        void ScrollToBottom()
        {
            notesBox.SelectionStart = notesBox.TextLength;
            notesBox.ScrollToCaret();
        }
    }

    // Small modal input dialog (reusable)
    public static class InputDialog
    {
        public static string Show(string title, string prompt)
        {
            using (var form = new Form())
            {
                form.Text = title;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ClientSize = new Size(400, 110);
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.ShowInTaskbar = false;

                var label = new Label { Left = 12, Top = 12, Width = 370, Text = prompt };
                var textBox = new TextBox { Left = 12, Top = 36, Width = 370 };
                var ok = new Button { Text = "OK", Left = 220, Width = 75, Top = 68, DialogResult = DialogResult.OK };
                var cancel = new Button { Text = "Cancel", Left = 305, Width = 75, Top = 68, DialogResult = DialogResult.Cancel };

                ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.Controls.AddRange(new Control[] { label, textBox, ok, cancel });
                form.AcceptButton = ok;
                form.CancelButton = cancel;

                var dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    return textBox.Text;
                }
                return null;
            }
        }
    }
}
