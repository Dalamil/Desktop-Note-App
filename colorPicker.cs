using DesktopNoteApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace colorPicker
{
    public class ColorPicker
    {
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView notesList;
        private ToolStripMenuItem toolStripMenuItem1;

        public ColorPicker(DataGridView notesList)
        {
            this.notesList = notesList;

            contextMenuStrip1 = new ContextMenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem("Recolor");

            contextMenuStrip1.Items.Add(toolStripMenuItem1);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;


            // Set the contextMenuStrip1 for the notesList
            notesList.ContextMenuStrip = contextMenuStrip1;
        }


        public void AttachRightClickEvent()
        {
            notesList.CellMouseClick -= DataGridView_CellMouseClick;
            notesList.CellMouseClick += DataGridView_CellMouseClick;
            notesList.ContextMenuStrip = contextMenuStrip1;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuItem1) // Check if the clicked item is the color menu item
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    // Applies selected color to the entire row (both note and info)
                    DataGridViewRow selectedRow = notesList.CurrentRow;
                    if (selectedRow != null)
                    {
                        ApplyColorToRow(selectedRow, selectedColor);
                    }
                }
            }
        }

        public static void ApplyColorToRow(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }


        public static void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                dataGridView.Rows[e.RowIndex].Selected = true; // Select the entire row
                dataGridView.ContextMenuStrip.Show(dataGridView, e.Location); // Show context menu at mouse position
            }
        }




        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                foreach (DataGridViewRow selectedRow in notesList.SelectedRows)
                {
                    ApplyColorToRow(selectedRow, selectedColor);
                }
            }
        }

    }
}
