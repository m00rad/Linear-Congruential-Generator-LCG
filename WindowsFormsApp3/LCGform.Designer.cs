namespace WindowsFormsApp3
{
    partial class LCGform
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.counterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linearCongruentialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.Multiplier = new System.Windows.Forms.Label();
            this.Seed = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Label();
            this.Modulus = new System.Windows.Forms.Label();
            this.CycleLength = new System.Windows.Forms.Label();
            this.CycleLengthVal = new System.Windows.Forms.Label();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.MultiplierVal = new System.Windows.Forms.TextBox();
            this.ModulusVal = new System.Windows.Forms.TextBox();
            this.IncrementVal = new System.Windows.Forms.TextBox();
            this.SeedVal = new System.Windows.Forms.TextBox();
            this.MethodName = new System.Windows.Forms.Label();
            this.NumOfIteration = new System.Windows.Forms.Label();
            this.NunOfIterVal = new System.Windows.Forms.TextBox();
            this.linearCongruentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearCongruentialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearCongruentialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counterDataGridViewTextBoxColumn,
            this.randomNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.linearCongruentialBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // counterDataGridViewTextBoxColumn
            // 
            this.counterDataGridViewTextBoxColumn.DataPropertyName = "Counter";
            this.counterDataGridViewTextBoxColumn.HeaderText = "Counter";
            this.counterDataGridViewTextBoxColumn.Name = "counterDataGridViewTextBoxColumn";
            // 
            // randomNumDataGridViewTextBoxColumn
            // 
            this.randomNumDataGridViewTextBoxColumn.DataPropertyName = "RandomNum";
            this.randomNumDataGridViewTextBoxColumn.HeaderText = "RandomNum";
            this.randomNumDataGridViewTextBoxColumn.Name = "randomNumDataGridViewTextBoxColumn";
            // 
            // linearCongruentialBindingSource1
            // 
            this.linearCongruentialBindingSource1.DataSource = typeof(WindowsFormsApp3.LinearCongruential);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.Location = new System.Drawing.Point(299, 378);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(137, 50);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // Multiplier
            // 
            this.Multiplier.AutoSize = true;
            this.Multiplier.Location = new System.Drawing.Point(306, 73);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(61, 13);
            this.Multiplier.TabIndex = 2;
            this.Multiplier.Text = "Multiplier(A)";
            this.Multiplier.Click += new System.EventHandler(this.Multiplier_Click);
            // 
            // Seed
            // 
            this.Seed.AutoSize = true;
            this.Seed.Location = new System.Drawing.Point(306, 142);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(54, 13);
            this.Seed.TabIndex = 3;
            this.Seed.Text = "Seed (Xo)";
            // 
            // Increment
            // 
            this.Increment.AutoSize = true;
            this.Increment.Location = new System.Drawing.Point(306, 206);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(67, 13);
            this.Increment.TabIndex = 4;
            this.Increment.Text = "Increment(C)";
            // 
            // Modulus
            // 
            this.Modulus.AutoSize = true;
            this.Modulus.Location = new System.Drawing.Point(306, 269);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(62, 13);
            this.Modulus.TabIndex = 5;
            this.Modulus.Text = "Modulus(M)";
            // 
            // CycleLength
            // 
            this.CycleLength.AutoSize = true;
            this.CycleLength.Location = new System.Drawing.Point(317, 462);
            this.CycleLength.Name = "CycleLength";
            this.CycleLength.Size = new System.Drawing.Size(69, 13);
            this.CycleLength.TabIndex = 10;
            this.CycleLength.Text = "Cycle Length";
            // 
            // CycleLengthVal
            // 
            this.CycleLengthVal.AutoSize = true;
            this.CycleLengthVal.Location = new System.Drawing.Point(461, 462);
            this.CycleLengthVal.Name = "CycleLengthVal";
            this.CycleLengthVal.Size = new System.Drawing.Size(37, 13);
            this.CycleLengthVal.TabIndex = 12;
            this.CycleLengthVal.Text = "        0";
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Location = new System.Drawing.Point(371, 18);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(79, 13);
            this.IntroLabel.TabIndex = 14;
            this.IntroLabel.Text = "Welcom ( ^_^ )";
            this.IntroLabel.Click += new System.EventHandler(this.IntroLabel_Click);
            // 
            // MultiplierVal
            // 
            this.MultiplierVal.Location = new System.Drawing.Point(464, 66);
            this.MultiplierVal.Name = "MultiplierVal";
            this.MultiplierVal.Size = new System.Drawing.Size(100, 20);
            this.MultiplierVal.TabIndex = 15;
            // 
            // ModulusVal
            // 
            this.ModulusVal.BackColor = System.Drawing.Color.White;
            this.ModulusVal.Location = new System.Drawing.Point(464, 262);
            this.ModulusVal.Name = "ModulusVal";
            this.ModulusVal.Size = new System.Drawing.Size(100, 20);
            this.ModulusVal.TabIndex = 16;
            // 
            // IncrementVal
            // 
            this.IncrementVal.Location = new System.Drawing.Point(464, 199);
            this.IncrementVal.Name = "IncrementVal";
            this.IncrementVal.Size = new System.Drawing.Size(100, 20);
            this.IncrementVal.TabIndex = 17;
            // 
            // SeedVal
            // 
            this.SeedVal.Location = new System.Drawing.Point(464, 135);
            this.SeedVal.Name = "SeedVal";
            this.SeedVal.Size = new System.Drawing.Size(100, 20);
            this.SeedVal.TabIndex = 18;
            this.SeedVal.TextChanged += new System.EventHandler(this.IncrementVal_TextChanged);
            // 
            // MethodName
            // 
            this.MethodName.AutoSize = true;
            this.MethodName.Location = new System.Drawing.Point(317, 431);
            this.MethodName.Name = "MethodName";
            this.MethodName.Size = new System.Drawing.Size(0, 13);
            this.MethodName.TabIndex = 19;
            // 
            // NumOfIteration
            // 
            this.NumOfIteration.AutoSize = true;
            this.NumOfIteration.Location = new System.Drawing.Point(306, 335);
            this.NumOfIteration.Name = "NumOfIteration";
            this.NumOfIteration.Size = new System.Drawing.Size(102, 13);
            this.NumOfIteration.TabIndex = 20;
            this.NumOfIteration.Text = "Number of Iterations\r\n";
            this.NumOfIteration.Click += new System.EventHandler(this.NumOfIteration_Click);
            // 
            // NunOfIterVal
            // 
            this.NunOfIterVal.BackColor = System.Drawing.Color.White;
            this.NunOfIterVal.Location = new System.Drawing.Point(464, 328);
            this.NunOfIterVal.Name = "NunOfIterVal";
            this.NunOfIterVal.Size = new System.Drawing.Size(100, 20);
            this.NunOfIterVal.TabIndex = 21;
            this.NunOfIterVal.TextChanged += new System.EventHandler(this.NunOfIterVal_TextChanged);
            // 
            // linearCongruentialBindingSource
            // 
            this.linearCongruentialBindingSource.DataSource = typeof(WindowsFormsApp3.LinearCongruential);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(481, 385);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(74, 37);
            this.ClearBtn.TabIndex = 22;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LCGform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.RandNumsImg;
            this.ClientSize = new System.Drawing.Size(634, 490);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.NunOfIterVal);
            this.Controls.Add(this.NumOfIteration);
            this.Controls.Add(this.MethodName);
            this.Controls.Add(this.SeedVal);
            this.Controls.Add(this.IncrementVal);
            this.Controls.Add(this.ModulusVal);
            this.Controls.Add(this.MultiplierVal);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.CycleLengthVal);
            this.Controls.Add(this.CycleLength);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LCGform";
            this.Text = "Linear Congruential Generator";
            this.Load += new System.EventHandler(this.LCG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearCongruentialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearCongruentialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label Multiplier;
        private System.Windows.Forms.Label Seed;
        private System.Windows.Forms.Label Increment;
        private System.Windows.Forms.Label Modulus;
        private System.Windows.Forms.Label CycleLength;
        private System.Windows.Forms.Label CycleLengthVal;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.BindingSource linearCongruentialBindingSource;
        private System.Windows.Forms.TextBox MultiplierVal;
        private System.Windows.Forms.TextBox ModulusVal;
        private System.Windows.Forms.TextBox IncrementVal;
        private System.Windows.Forms.TextBox SeedVal;
        private System.Windows.Forms.BindingSource linearCongruentialBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label MethodName;
        private System.Windows.Forms.Label NumOfIteration;
        private System.Windows.Forms.TextBox NunOfIterVal;
        private System.Windows.Forms.Button ClearBtn;
    }
}

