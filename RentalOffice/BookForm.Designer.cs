namespace RentalOffice
{
    partial class BookForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPrice = new Label();
            label99 = new Label();
            lblDate = new Label();
            label3 = new Label();
            label2 = new Label();
            cbxCustomer = new ComboBox();
            cbxMovie = new ComboBox();
            cbxWorker = new ComboBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            bttnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(label99, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(cbxCustomer, 1, 0);
            tableLayoutPanel1.Controls.Add(cbxMovie, 1, 1);
            tableLayoutPanel1.Controls.Add(cbxWorker, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpDate, 1, 3);
            tableLayoutPanel1.Controls.Add(bttnSave, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(333, 356);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(330, 255);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 10;
            // 
            // label99
            // 
            label99.Anchor = AnchorStyles.Right;
            label99.AutoSize = true;
            label99.Location = new Point(121, 255);
            label99.Name = "label99";
            label99.Size = new Size(42, 20);
            label99.TabIndex = 9;
            label99.Text = "Cena";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(122, 196);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 8;
            lblDate.Text = "Data";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(87, 137);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Pracownik";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(126, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 6;
            label2.Text = "Film";
            // 
            // cbxCustomer
            // 
            cbxCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(169, 15);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(161, 28);
            cbxCustomer.TabIndex = 0;
            // 
            // cbxMovie
            // 
            cbxMovie.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxMovie.FormattingEnabled = true;
            cbxMovie.Location = new Point(169, 74);
            cbxMovie.Name = "cbxMovie";
            cbxMovie.Size = new Size(161, 28);
            cbxMovie.TabIndex = 1;
            cbxMovie.SelectedIndexChanged += cbxMovie_SelectedIndexChanged;
            // 
            // cbxWorker
            // 
            cbxWorker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxWorker.FormattingEnabled = true;
            cbxWorker.Location = new Point(169, 133);
            cbxWorker.Name = "cbxWorker";
            cbxWorker.Size = new Size(161, 28);
            cbxWorker.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "Klient";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Location = new Point(169, 193);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(161, 27);
            dtpDate.TabIndex = 11;
            // 
            // bttnSave
            // 
            bttnSave.Dock = DockStyle.Fill;
            bttnSave.Location = new Point(169, 298);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(161, 55);
            bttnSave.TabIndex = 12;
            bttnSave.Text = "Zapisz";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 356);
            Controls.Add(tableLayoutPanel1);
            Name = "BookForm";
            Text = "Form1";
            Load += BookForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label99;
        private Label lblDate;
        private Label label3;
        private Label label2;
        private ComboBox cbxCustomer;
        private ComboBox cbxMovie;
        private ComboBox cbxWorker;
        private Label label1;
        private Label lblPrice;
        private DateTimePicker dtpDate;
        private Button bttnSave;
    }
}