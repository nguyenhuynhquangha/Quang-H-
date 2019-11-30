namespace CNPM
{
    partial class YourProduct
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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.nameCartTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editCartButton = new System.Windows.Forms.Button();
            this.deleteCartButton = new System.Windows.Forms.Button();
            this.addCartButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpNongSan = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.namensTextBox = new System.Windows.Forms.TextBox();
            this.idnsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nsDataGridView = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.statisticalButton = new System.Windows.Forms.Button();
            this.todateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.billDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.tcYP = new System.Windows.Forms.TabControl();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpNongSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsDataGridView)).BeginInit();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            this.tcYP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.nameCartTextBox);
            this.tpAccount.Controls.Add(this.userTextBox);
            this.tpAccount.Controls.Add(this.Name);
            this.tpAccount.Controls.Add(this.label7);
            this.tpAccount.Controls.Add(this.editCartButton);
            this.tpAccount.Controls.Add(this.deleteCartButton);
            this.tpAccount.Controls.Add(this.addCartButton);
            this.tpAccount.Controls.Add(this.dataGridView2);
            this.tpAccount.Location = new System.Drawing.Point(4, 26);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(595, 340);
            this.tpAccount.TabIndex = 3;
            this.tpAccount.Text = "Cart";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // nameCartTextBox
            // 
            this.nameCartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameCartTextBox.Location = new System.Drawing.Point(390, 122);
            this.nameCartTextBox.Name = "nameCartTextBox";
            this.nameCartTextBox.Size = new System.Drawing.Size(180, 26);
            this.nameCartTextBox.TabIndex = 29;
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userTextBox.Location = new System.Drawing.Point(390, 90);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(180, 26);
            this.userTextBox.TabIndex = 30;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Name.Location = new System.Drawing.Point(331, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(53, 20);
            this.Name.TabIndex = 27;
            this.Name.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(331, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // editCartButton
            // 
            this.editCartButton.Location = new System.Drawing.Point(494, 230);
            this.editCartButton.Name = "editCartButton";
            this.editCartButton.Size = new System.Drawing.Size(76, 67);
            this.editCartButton.TabIndex = 24;
            this.editCartButton.Text = "Edit";
            this.editCartButton.UseVisualStyleBackColor = true;
            this.editCartButton.Click += new System.EventHandler(this.EditCartButton_Click);
            // 
            // deleteCartButton
            // 
            this.deleteCartButton.Location = new System.Drawing.Point(412, 230);
            this.deleteCartButton.Name = "deleteCartButton";
            this.deleteCartButton.Size = new System.Drawing.Size(76, 67);
            this.deleteCartButton.TabIndex = 25;
            this.deleteCartButton.Text = "Delelte";
            this.deleteCartButton.UseVisualStyleBackColor = true;
            this.deleteCartButton.Click += new System.EventHandler(this.DeleteCartButton_Click);
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(330, 230);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.Size = new System.Drawing.Size(76, 67);
            this.addCartButton.TabIndex = 26;
            this.addCartButton.Text = "Add";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.AddCartButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(277, 328);
            this.dataGridView2.TabIndex = 22;
            // 
            // tpNongSan
            // 
            this.tpNongSan.Controls.Add(this.numericUpDown1);
            this.tpNongSan.Controls.Add(this.comboBox1);
            this.tpNongSan.Controls.Add(this.namensTextBox);
            this.tpNongSan.Controls.Add(this.idnsTextBox);
            this.tpNongSan.Controls.Add(this.label3);
            this.tpNongSan.Controls.Add(this.label4);
            this.tpNongSan.Controls.Add(this.label1);
            this.tpNongSan.Controls.Add(this.label2);
            this.tpNongSan.Controls.Add(this.editButton);
            this.tpNongSan.Controls.Add(this.deleteButton);
            this.tpNongSan.Controls.Add(this.addButton);
            this.tpNongSan.Controls.Add(this.nsDataGridView);
            this.tpNongSan.Location = new System.Drawing.Point(4, 26);
            this.tpNongSan.Name = "tpNongSan";
            this.tpNongSan.Padding = new System.Windows.Forms.Padding(3);
            this.tpNongSan.Size = new System.Drawing.Size(595, 340);
            this.tpNongSan.TabIndex = 1;
            this.tpNongSan.Text = "Nong San";
            this.tpNongSan.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(434, 193);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 26);
            this.numericUpDown1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // namensTextBox
            // 
            this.namensTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.namensTextBox.Location = new System.Drawing.Point(434, 126);
            this.namensTextBox.Name = "namensTextBox";
            this.namensTextBox.Size = new System.Drawing.Size(137, 26);
            this.namensTextBox.TabIndex = 6;
            // 
            // idnsTextBox
            // 
            this.idnsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idnsTextBox.Location = new System.Drawing.Point(434, 94);
            this.idnsTextBox.Name = "idnsTextBox";
            this.idnsTextBox.ReadOnly = true;
            this.idnsTextBox.Size = new System.Drawing.Size(137, 26);
            this.idnsTextBox.TabIndex = 6;
            this.idnsTextBox.TextChanged += new System.EventHandler(this.IdnsTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(348, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nong san";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(348, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(348, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(348, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(513, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(76, 67);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(431, 224);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 67);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delelte";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(349, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 67);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // nsDataGridView
            // 
            this.nsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.nsDataGridView.Name = "nsDataGridView";
            this.nsDataGridView.Size = new System.Drawing.Size(324, 328);
            this.nsDataGridView.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.statisticalButton);
            this.tpBill.Controls.Add(this.todateDateTimePicker);
            this.tpBill.Controls.Add(this.dateTimePicker1);
            this.tpBill.Controls.Add(this.button1);
            this.tpBill.Controls.Add(this.billDateTimePicker);
            this.tpBill.Controls.Add(this.billDataGridView);
            this.tpBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tpBill.Location = new System.Drawing.Point(4, 26);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(595, 340);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Bill";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // statisticalButton
            // 
            this.statisticalButton.Location = new System.Drawing.Point(490, 14);
            this.statisticalButton.Name = "statisticalButton";
            this.statisticalButton.Size = new System.Drawing.Size(75, 23);
            this.statisticalButton.TabIndex = 7;
            this.statisticalButton.Text = "statistical";
            this.statisticalButton.UseVisualStyleBackColor = true;
            this.statisticalButton.Click += new System.EventHandler(this.StatisticalButton_Click);
            // 
            // todateDateTimePicker
            // 
            this.todateDateTimePicker.Location = new System.Drawing.Point(238, 14);
            this.todateDateTimePicker.Name = "todateDateTimePicker";
            this.todateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.todateDateTimePicker.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // billDateTimePicker
            // 
            this.billDateTimePicker.Location = new System.Drawing.Point(6, 15);
            this.billDateTimePicker.Name = "billDateTimePicker";
            this.billDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.billDateTimePicker.TabIndex = 6;
            // 
            // billDataGridView
            // 
            this.billDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Location = new System.Drawing.Point(6, 45);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.Size = new System.Drawing.Size(583, 284);
            this.billDataGridView.TabIndex = 3;
            // 
            // tcYP
            // 
            this.tcYP.Controls.Add(this.tpBill);
            this.tcYP.Controls.Add(this.tpNongSan);
            this.tcYP.Controls.Add(this.tpAccount);
            this.tcYP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tcYP.Location = new System.Drawing.Point(13, 13);
            this.tcYP.Name = "tcYP";
            this.tcYP.SelectedIndex = 0;
            this.tcYP.Size = new System.Drawing.Size(603, 370);
            this.tcYP.TabIndex = 0;
            // 
            // YourProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 398);
            this.Controls.Add(this.tcYP);
            this.Text = "YourProduct";
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpNongSan.ResumeLayout(false);
            this.tpNongSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsDataGridView)).EndInit();
            this.tpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            this.tcYP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TextBox nameCartTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editCartButton;
        private System.Windows.Forms.Button deleteCartButton;
        private System.Windows.Forms.Button addCartButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpNongSan;
        private System.Windows.Forms.TextBox namensTextBox;
        private System.Windows.Forms.TextBox idnsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView nsDataGridView;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Button statisticalButton;
        private System.Windows.Forms.DateTimePicker todateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker billDateTimePicker;
        private System.Windows.Forms.DataGridView billDataGridView;
        private System.Windows.Forms.TabControl tcYP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}