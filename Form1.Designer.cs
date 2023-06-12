namespace DesktopNoteApp
{
    partial class NoteApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            noteBox = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            infoBox = new TextBox();
            notesList = new DataGridView();
            newBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            delBtn = new Button();
            arrowExpand = new Label();
            ((System.ComponentModel.ISupportInitialize)notesList).BeginInit();
            SuspendLayout();
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            noteBox.Location = new Point(51, 77);
            noteBox.Margin = new Padding(4, 3, 4, 3);
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(366, 24);
            noteBox.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(935, 312);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(364, 284);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(421, 25);
            label1.TabIndex = 0;
            label1.Text = "Note";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(935, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(364, 25);
            label3.TabIndex = 6;
            label3.Text = "Temporary Info Boxes (WIP)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left;
            textBox6.Location = new Point(935, 77);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(364, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Location = new Point(935, 116);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(364, 180);
            textBox7.TabIndex = 9;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 121);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(421, 25);
            label5.TabIndex = 10;
            label5.Text = "Info";
            // 
            // infoBox
            // 
            infoBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            infoBox.Location = new Point(51, 147);
            infoBox.Margin = new Padding(4, 3, 4, 3);
            infoBox.Multiline = true;
            infoBox.Name = "infoBox";
            infoBox.ScrollBars = ScrollBars.Vertical;
            infoBox.Size = new Size(366, 328);
            infoBox.TabIndex = 11;
            // 
            // notesList
            // 
            notesList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            notesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            notesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesList.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            notesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            notesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesList.Location = new Point(431, 77);
            notesList.Margin = new Padding(4, 3, 4, 3);
            notesList.Name = "notesList";
            notesList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            notesList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            notesList.Size = new Size(364, 519);
            notesList.TabIndex = 12;
            notesList.CellDoubleClick += notesList_CellDoubleClick;
            // 
            // newBtn
            // 
            newBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newBtn.Location = new Point(51, 491);
            newBtn.Margin = new Padding(4, 3, 4, 3);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(178, 47);
            newBtn.TabIndex = 13;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(239, 491);
            saveBtn.Margin = new Padding(4, 3, 4, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(178, 47);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadBtn.Location = new Point(51, 549);
            loadBtn.Margin = new Padding(4, 3, 4, 3);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(178, 47);
            loadBtn.TabIndex = 15;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delBtn.Location = new Point(239, 549);
            delBtn.Margin = new Padding(4, 3, 4, 3);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(178, 47);
            delBtn.TabIndex = 16;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // arrowExpand
            // 
            arrowExpand.BackColor = Color.Transparent;
            arrowExpand.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            arrowExpand.ForeColor = Color.FromArgb(0, 90, 145);
            arrowExpand.Location = new Point(797, 310);
            arrowExpand.Margin = new Padding(4, 0, 4, 0);
            arrowExpand.Name = "arrowExpand";
            arrowExpand.Size = new Size(49, 47);
            arrowExpand.TabIndex = 17;
            arrowExpand.Text = "→";
            arrowExpand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NoteApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(847, 686);
            Controls.Add(arrowExpand);
            Controls.Add(delBtn);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(newBtn);
            Controls.Add(notesList);
            Controls.Add(label5);
            Controls.Add(infoBox);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(noteBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NoteApp";
            Text = "NoteApp";
            Load += NoteApp_Load;
            ((System.ComponentModel.ISupportInitialize)notesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.DataGridView notesList;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label arrowExpand;
    }
}

