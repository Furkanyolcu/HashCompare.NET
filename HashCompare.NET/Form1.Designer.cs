namespace HashingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ListBox listBoxRandomNumbers;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button buttonMyHashing;
        private System.Windows.Forms.Button buttonEischHashing;
        private System.Windows.Forms.Button buttonLichHashing;
        private System.Windows.Forms.Button buttonLischHashing;
        private System.Windows.Forms.Button buttonReischHashing;
        private System.Windows.Forms.Button buttonBlischHashing;
        private System.Windows.Forms.Button buttonRelischHashing;
        private System.Windows.Forms.Button buttonBeischHashing;
        private System.Windows.Forms.ComboBox comboBoxNumbers;


        private System.Windows.Forms.DataGridViewTextBoxColumn Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Steps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collisions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.Algorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Steps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collisions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxRandomNumbers = new System.Windows.Forms.ListBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.buttonMyHashing = new System.Windows.Forms.Button();
            this.buttonEischHashing = new System.Windows.Forms.Button();
            this.buttonLichHashing = new System.Windows.Forms.Button();
            this.buttonLischHashing = new System.Windows.Forms.Button();
            this.buttonReischHashing = new System.Windows.Forms.Button();
            this.buttonBlischHashing = new System.Windows.Forms.Button();
            this.buttonRelischHashing = new System.Windows.Forms.Button();
            this.buttonBeischHashing = new System.Windows.Forms.Button();
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.Performans_karsilastir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Algorithm,
            this.Time,
            this.Steps,
            this.Collisions});
            this.dataGridViewResults.Location = new System.Drawing.Point(39, 93);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(554, 223);
            this.dataGridViewResults.TabIndex = 1;
            // 
            // Algorithm
            // 
            this.Algorithm.MinimumWidth = 6;
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Width = 125;
            // 
            // Time
            // 
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Steps
            // 
            this.Steps.MinimumWidth = 6;
            this.Steps.Name = "Steps";
            this.Steps.Width = 125;
            // 
            // Collisions
            // 
            this.Collisions.MinimumWidth = 6;
            this.Collisions.Name = "Collisions";
            this.Collisions.Width = 125;
            // 
            // listBoxRandomNumbers
            // 
            this.listBoxRandomNumbers.FormattingEnabled = true;
            this.listBoxRandomNumbers.ItemHeight = 16;
            this.listBoxRandomNumbers.Location = new System.Drawing.Point(622, 43);
            this.listBoxRandomNumbers.Name = "listBoxRandomNumbers";
            this.listBoxRandomNumbers.Size = new System.Drawing.Size(99, 372);
            this.listBoxRandomNumbers.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(39, 36);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(165, 38);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Algoritmaları Çalıştır";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // buttonMyHashing
            // 
            this.buttonMyHashing.Location = new System.Drawing.Point(39, 340);
            this.buttonMyHashing.Name = "buttonMyHashing";
            this.buttonMyHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonMyHashing.TabIndex = 2;
            this.buttonMyHashing.Text = "MyHashing";
            this.buttonMyHashing.UseVisualStyleBackColor = true;
            this.buttonMyHashing.Click += new System.EventHandler(this.buttonMyHashing_Click);
            // 
            // buttonEischHashing
            // 
            this.buttonEischHashing.Location = new System.Drawing.Point(39, 385);
            this.buttonEischHashing.Name = "buttonEischHashing";
            this.buttonEischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonEischHashing.TabIndex = 3;
            this.buttonEischHashing.Text = "EischHashing";
            this.buttonEischHashing.UseVisualStyleBackColor = true;
            this.buttonEischHashing.Click += new System.EventHandler(this.buttonEischHashing_Click);
            // 
            // buttonLichHashing
            // 
            this.buttonLichHashing.Location = new System.Drawing.Point(195, 340);
            this.buttonLichHashing.Name = "buttonLichHashing";
            this.buttonLichHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonLichHashing.TabIndex = 4;
            this.buttonLichHashing.Text = "LichHashing";
            this.buttonLichHashing.UseVisualStyleBackColor = true;
            this.buttonLichHashing.Click += new System.EventHandler(this.buttonLichHashing_Click);
            // 
            // buttonLischHashing
            // 
            this.buttonLischHashing.Location = new System.Drawing.Point(195, 385);
            this.buttonLischHashing.Name = "buttonLischHashing";
            this.buttonLischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonLischHashing.TabIndex = 5;
            this.buttonLischHashing.Text = "LischHashing";
            this.buttonLischHashing.UseVisualStyleBackColor = true;
            this.buttonLischHashing.Click += new System.EventHandler(this.buttonLischHashing_Click);
            // 
            // buttonReischHashing
            // 
            this.buttonReischHashing.Location = new System.Drawing.Point(345, 340);
            this.buttonReischHashing.Name = "buttonReischHashing";
            this.buttonReischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonReischHashing.TabIndex = 6;
            this.buttonReischHashing.Text = "ReischHashing";
            this.buttonReischHashing.UseVisualStyleBackColor = true;
            this.buttonReischHashing.Click += new System.EventHandler(this.buttonReischHashing_Click);
            // 
            // buttonBlischHashing
            // 
            this.buttonBlischHashing.Location = new System.Drawing.Point(493, 340);
            this.buttonBlischHashing.Name = "buttonBlischHashing";
            this.buttonBlischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonBlischHashing.TabIndex = 7;
            this.buttonBlischHashing.Text = "BlischHashing";
            this.buttonBlischHashing.UseVisualStyleBackColor = true;
            this.buttonBlischHashing.Click += new System.EventHandler(this.buttonBlischHashing_Click);
            // 
            // buttonRelischHashing
            // 
            this.buttonRelischHashing.Location = new System.Drawing.Point(345, 385);
            this.buttonRelischHashing.Name = "buttonRelischHashing";
            this.buttonRelischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonRelischHashing.TabIndex = 8;
            this.buttonRelischHashing.Text = "RelischHashing";
            this.buttonRelischHashing.UseVisualStyleBackColor = true;
            this.buttonRelischHashing.Click += new System.EventHandler(this.buttonRelischHashing_Click);
            // 
            // buttonBeischHashing
            // 
            this.buttonBeischHashing.Location = new System.Drawing.Point(493, 385);
            this.buttonBeischHashing.Name = "buttonBeischHashing";
            this.buttonBeischHashing.Size = new System.Drawing.Size(100, 30);
            this.buttonBeischHashing.TabIndex = 9;
            this.buttonBeischHashing.Text = "BeischHashing";
            this.buttonBeischHashing.UseVisualStyleBackColor = true;
            this.buttonBeischHashing.Click += new System.EventHandler(this.buttonBeischHashing_Click);
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.Location = new System.Drawing.Point(472, 44);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumbers.TabIndex = 2;
            // 
            // Performans_karsilastir
            // 
            this.Performans_karsilastir.Location = new System.Drawing.Point(232, 36);
            this.Performans_karsilastir.Name = "Performans_karsilastir";
            this.Performans_karsilastir.Size = new System.Drawing.Size(102, 38);
            this.Performans_karsilastir.TabIndex = 10;
            this.Performans_karsilastir.Text = "Compare";
            this.Performans_karsilastir.UseVisualStyleBackColor = true;
            this.Performans_karsilastir.Click += new System.EventHandler(this.Performans_karsilastir_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(749, 455);
            this.Controls.Add(this.Performans_karsilastir);
            this.Controls.Add(this.comboBoxNumbers);
            this.Controls.Add(this.listBoxRandomNumbers);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.buttonMyHashing);
            this.Controls.Add(this.buttonEischHashing);
            this.Controls.Add(this.buttonLichHashing);
            this.Controls.Add(this.buttonLischHashing);
            this.Controls.Add(this.buttonReischHashing);
            this.Controls.Add(this.buttonBlischHashing);
            this.Controls.Add(this.buttonRelischHashing);
            this.Controls.Add(this.buttonBeischHashing);
            this.Name = "Form1";
            this.Text = "Hashing Algoritma Performans Karşılaştırması";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button Performans_karsilastir;
    }
}
