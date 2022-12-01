
namespace Independent_Work
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showall = new System.Windows.Forms.Button();
            this.minprice = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.maxprice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxprice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Peru;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 200;
            this.dataGridView1.Size = new System.Drawing.Size(776, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // showall
            // 
            this.showall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showall.Location = new System.Drawing.Point(12, 296);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(113, 42);
            this.showall.TabIndex = 1;
            this.showall.Text = "Показать список всех номеров";
            this.showall.UseVisualStyleBackColor = false;
            this.showall.Click += new System.EventHandler(this.button1_Click);
            // 
            // minprice
            // 
            this.minprice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minprice.Location = new System.Drawing.Point(279, 299);
            this.minprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(59, 20);
            this.minprice.TabIndex = 5;
            this.minprice.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Фильтровать по цене";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // maxprice
            // 
            this.maxprice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxprice.Location = new System.Drawing.Point(279, 318);
            this.maxprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxprice.Name = "maxprice";
            this.maxprice.Size = new System.Drawing.Size(59, 20);
            this.maxprice.TabIndex = 7;
            this.maxprice.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxprice.ValueChanged += new System.EventHandler(this.maxprice_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "От:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Только свободные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standart",
            "Family room",
            "Honeymoon room",
            "Balcony",
            "Business",
            "Connected rooms",
            "Apartment",
            "De luxe",
            "President"});
            this.comboBox1.Location = new System.Drawing.Point(491, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выбрать по типу номера";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(461, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тип:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxprice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.NumericUpDown minprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown maxprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}