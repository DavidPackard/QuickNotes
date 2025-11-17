import tkinter as tk
from tkinter import messagebox
from tkinter import filedialog
from tkinter import simpledialog
from datetime import datetime
import os

def save_as():
    """Prompt for a file name and save all notes from the text widget."""
    filename = filedialog.asksaveasfilename(
        title="Save Notes As",
        defaultextension=".txt",
        filetypes=[("Text Files", "*.txt"), ("All Files", "*.*")]
    )
    if not filename:
        return  # User cancelled

    content = text_area.get("1.0", tk.END).strip()
    with open(filename, "w", encoding="utf-8") as f:
        f.write(content + "\n")

def add_note(event=None, note_text=None):
    """Add a new timestamped note at the end of the text area."""
    if note_text is None:
        note = entry.get().strip()
    else:
        note = note_text

    if not note:
        return

    timestamp = datetime.now().strftime("%d/%m/%Y %H:%M:%S")
    new_entry = f"[{timestamp}] {note}\n"

    # Only insert in the text widget
    text_area.insert(tk.END, new_entry)
    text_area.see(tk.END)

    if note_text is None:
        entry.delete(0, tk.END)

def on_close():
    """Prompt to save notes before closing."""
    answer = messagebox.askyesnocancel("Exit", "Do you want to save your notes before exiting?")
    
    if answer is True:  # Yes
        save_as()
        app.destroy()
    elif answer is False:  # No
        app.destroy()
    else:  # Cancel
        pass  # Do nothing, stay in the app

# ------------------------ GUI ------------------------

app = tk.Tk()
app.title("Quick Notes")
app.geometry("600x500")
app.protocol("WM_DELETE_WINDOW", on_close)

entry_frame = tk.Frame(app)
entry_frame.pack(pady=10)

entry = tk.Entry(entry_frame, width=50)
entry.pack(side=tk.LEFT, padx=5)

add_btn = tk.Button(entry_frame, text="Add Note", command=add_note)
add_btn.pack(side=tk.LEFT, padx=5)

# Pre-prepared note buttons
def call_start_note():
    """Add a [CALL START] note, optionally with extra text from the user."""
    extra_text = simpledialog.askstring("Call Start", "Phone Number:")
    if extra_text:
        full_note = f"=== [CALL START] {extra_text.strip()} ==="
    else:
        full_note = "[CALL START]"
    add_note(note_text=full_note)

custom_buttons_frame = tk.Frame(app)
custom_buttons_frame.pack(pady=5)

custombutton_padx = 3

callstart_btn = tk.Button(custom_buttons_frame, text="Call Start", command=call_start_note)
callstart_btn.pack(side=tk.LEFT, padx=custombutton_padx)

on_hold_btn = tk.Button(custom_buttons_frame, text="On Hold", command=lambda: add_note(note_text="[CALL ON HOLD]"))
on_hold_btn.pack(side=tk.LEFT, padx=custombutton_padx)

off_hold_btn = tk.Button(custom_buttons_frame, text="Off Hold", command=lambda: add_note(note_text="[CALL OFF HOLD]"))
off_hold_btn.pack(side=tk.LEFT, padx=custombutton_padx)

call_end_btn = tk.Button(custom_buttons_frame, text="Call End", command=lambda: add_note(note_text="=== [CALL ENDED] ==="))
call_end_btn.pack(side=tk.LEFT, padx=custombutton_padx)

entry.bind("<Return>", add_note)

# Text box for showing/editing notes
text_area = tk.Text(app, wrap="word", width=70, height=20)
text_area.pack(padx=10, pady=10)

save_btn = tk.Button(app, text="Save As", command=save_as)
save_btn.pack(pady=5)

app.mainloop()
