namespace ShoppingListApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnRemove = new Button();
            btnAdd = new Button();
            comboUnits = new ComboBox();
            tbxAmount = new TextBox();
            tbxItem = new TextBox();
            lblAmount = new Label();
            lblDescription = new Label();
            lbxShoppingList = new ListBox();
            lblError = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(comboUnits);
            groupBox1.Controls.Add(tbxAmount);
            groupBox1.Controls.Add(tbxItem);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Description";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(503, 69);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(105, 37);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(503, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 37);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboUnits
            // 
            comboUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnits.FormattingEnabled = true;
            comboUnits.Location = new Point(307, 78);
            comboUnits.Name = "comboUnits";
            comboUnits.Size = new Size(174, 28);
            comboUnits.TabIndex = 4;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(146, 78);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(136, 27);
            tbxAmount.TabIndex = 3;
            // 
            // tbxItem
            // 
            tbxItem.Location = new Point(146, 36);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(335, 27);
            tbxItem.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 85);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            // 
            // lbxShoppingList
            // 
            lbxShoppingList.Font = new Font("Courier New", 10F);
            lbxShoppingList.FormattingEnabled = true;
            lbxShoppingList.Location = new Point(12, 197);
            lbxShoppingList.Name = "lbxShoppingList";
            lbxShoppingList.Size = new Size(719, 184);
            lbxShoppingList.TabIndex = 2;
            lbxShoppingList.SelectedIndexChanged += lbxShoppingList_SelectedIndexChanged;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(255, 128, 128);
            lblError.Dock = DockStyle.Bottom;
            lblError.ForeColor = Color.White;
            lblError.Location = new Point(0, 430);
            lblError.Name = "lblError";
            lblError.Size = new Size(800, 20);
            lblError.TabIndex = 3;
            lblError.Text = "label3";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lbxShoppingList);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Shopping List";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox comboUnits;
        private TextBox tbxAmount;
        private TextBox tbxItem;
        private Label lblAmount;
        private Label lblDescription;
        private Button btnRemove;
        private Button btnAdd;
        private ListBox lbxShoppingList;
        private Label lblError;
    }
}
