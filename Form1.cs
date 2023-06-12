using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DesktopNoteApp
{
    public partial class NoteApp : Form
    {
        DataTable notesTable = new DataTable();
        bool editing = false;

        private SQLiteConnection conn;
        private int loadedNote = -1;


        public NoteApp()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=NotesDB.db;Version=3;");
            conn.Open();
        }


        private void NoteApp_Load(object sender, EventArgs e)
        {
            notesTable.Columns.Add("Note");
            notesTable.Columns.Add("Info");

            string selectAllQuery = "SELECT Note, Info FROM Notes";
            SQLiteCommand selectAllCmd = new SQLiteCommand(selectAllQuery, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectAllCmd);
            adapter.Fill(notesTable);

            notesList.DataSource = notesTable; // Set the DataSource property of notesList to the notes DataTable
            notesList.ClearSelection();
            notesList.CurrentCell = null;
        }
        private void RefreshNotesList()
        {
            notesTable.Clear(); // Clear selection in the DataTable - Prevents accidentally deleting notes when loading and/or editing
            string selectAllQuery = "SELECT Note, Info FROM Notes";
            SQLiteCommand selectAllCmd = new SQLiteCommand(selectAllQuery, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectAllCmd);
            adapter.Fill(notesTable);

            notesList.DataSource = notesTable;
        }



        private void newBtn_Click(object sender, EventArgs e)
        {
            noteBox.Text = "";
            infoBox.Text = "";

            RefreshNotesList();
            notesList.ClearSelection();
            notesList.CurrentCell = null;

            loadedNote = -1; // Reset loadedNote so as not to overwrite an existing note
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editing && loadedNote >= 0 && loadedNote < notesTable.Rows.Count)
            {
                DataRow row = notesTable.Rows[loadedNote];

                string previousNote = row["Note"].ToString(); // Store the previous note title

                row["Note"] = noteBox.Text;
                row["Info"] = infoBox.Text;

                string updateQuery = "UPDATE Notes SET Note = @Note, Info = @Info WHERE Note = @PreviousNote";
                SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@Note", noteBox.Text);
                updateCmd.Parameters.AddWithValue("@Info", infoBox.Text);
                updateCmd.Parameters.AddWithValue("@PreviousNote", previousNote);
                updateCmd.ExecuteNonQuery();
            }
            else
            {
                // When not editing and adding new note
                DataRow newRow = notesTable.NewRow();
                newRow["Note"] = noteBox.Text;
                newRow["Info"] = infoBox.Text;
                notesTable.Rows.Add(newRow);
                
                string insertQuery = "INSERT INTO Notes (Note, Info) VALUES (@Note, @Info)";
                SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Note", noteBox.Text);
                insertCmd.Parameters.AddWithValue("@Info", infoBox.Text);
                insertCmd.ExecuteNonQuery();
            }
            RefreshNotesList();
            noteBox.Text = "";
            infoBox.Text = "";
            editing = false;
            notesList.CurrentCell = null;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = notesList.CurrentCell?.RowIndex ?? -1;
            if (rowIndex >= 0 && rowIndex < notesTable.Rows.Count)
            {
                noteBox.Text = notesTable.Rows[rowIndex].ItemArray[0].ToString();
                infoBox.Text = notesTable.Rows[rowIndex].ItemArray[1].ToString();
                loadedNote = rowIndex; // Update the last loaded note index
                editing = true;
            }
            notesList.CurrentCell = null;
        }
        private void notesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = notesList.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < notesTable.Rows.Count)
            {
                noteBox.Text = notesTable.Rows[rowIndex].ItemArray[0].ToString();
                infoBox.Text = notesTable.Rows[rowIndex].ItemArray[1].ToString();
                loadedNote = rowIndex; // Update the last loaded note index
                editing = true;
            }
            notesList.CurrentCell = null;
        }
        
        private void delBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = notesList.CurrentCell?.RowIndex ?? -1;
            if (rowIndex >= 0 && rowIndex < notesTable.Rows.Count)
            {
                string previousNote = notesTable.Rows[rowIndex]["Note"].ToString();

                string deleteQuery = "DELETE FROM Notes WHERE Note = @PreviousNote";
                SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@PreviousNote", previousNote);
                deleteCmd.ExecuteNonQuery();

                notesTable.Rows.RemoveAt(rowIndex);
            }
            notesList.CurrentCell = null;
        }
    }
}
