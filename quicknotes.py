import tkinter as tk
from tkinter import messagebox
from datetime import datetime
import os

NOTES_FILE = "notes.txt"

def load_notes():
    """Load notes from file."""
    if not os.path.exists(NOTES_FILE):
        return ""
    with open(NOTES_FILE, "r", encoding="utf-8") as f:
        return f.read()

def save_notes():
    """Overwrite the notes file with the edited text."""
    content = text_area.get("1.0", tk.END).strip()
    with open(NOTES_FILE, "w", encoding="utf-8") as f:
        f.write(content + "\n")

def add_note():
    """Add a new timestamped note at the top of the file."""
    note = entry.get().strip()
    if not note:
        return
    
    timestamp = datetime.now().strftime("%d/%m/%Y %H:%M:%S")
    new_entry = f"[{timestamp}] {note}\n"

    # Insert at the top of the existing notes
    existing = text_area.get("1.0", tk.END).strip()
    updated = new_entry + existing

    text_area.delete("1.0", tk.END)
    text_area.insert(tk.END, updated)

    # Save to file
    with open(NOTES_FILE, "w", encoding="utf-8") as f:
        f.write(updated + "\n")

    entry.delete(0, tk.END)

# ------------------------ GUI ------------------------

app = tk.Tk()
app.title("Quick Notes")
app.geometry("600x500")

# Input area
entry_frame = tk.Frame(app)
entry_frame.pack(pady=10)

entry = tk.Entry(entry_frame, width=50)
entry.pack(side=tk.LEFT, padx=5)

add_btn = tk.Button(entry_frame, text="Add Note", command=add_note)
add_btn.pack(side=tk.LEFT)

# Text editor for all notes
text_area = tk.Text(app, wrap="word", width=70, height=20)
text_area.pack(padx=10, pady=10)

save_btn = tk.Button(app, text="Save Changes", command=save_notes)
save_btn.pack(pady=5)

# Load existing notes on startup
text_area.insert(tk.END, load_notes())

app.mainloop()
