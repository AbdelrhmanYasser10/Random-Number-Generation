
namespace Task4
{
    partial class LCG_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplierField = new System.Windows.Forms.TextBox();
            this.seedField = new System.Windows.Forms.TextBox();
            this.incrementField = new System.Windows.Forms.TextBox();
            this.cycleLengthField = new System.Windows.Forms.TextBox();
            this.modulusField = new System.Windows.Forms.TextBox();
            this.numberIterationField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed(X0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Increment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modulus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of iterations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Random Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Actual Period Length";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(627, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(178, 467);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Random Numbers";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // multiplierField
            // 
            this.multiplierField.Location = new System.Drawing.Point(189, 76);
            this.multiplierField.Name = "multiplierField";
            this.multiplierField.Size = new System.Drawing.Size(125, 27);
            this.multiplierField.TabIndex = 8;
            // 
            // seedField
            // 
            this.seedField.Location = new System.Drawing.Point(189, 120);
            this.seedField.Name = "seedField";
            this.seedField.Size = new System.Drawing.Size(125, 27);
            this.seedField.TabIndex = 9;
            // 
            // incrementField
            // 
            this.incrementField.Location = new System.Drawing.Point(189, 163);
            this.incrementField.Name = "incrementField";
            this.incrementField.Size = new System.Drawing.Size(125, 27);
            this.incrementField.TabIndex = 10;
            // 
            // cycleLengthField
            // 
            this.cycleLengthField.Location = new System.Drawing.Point(320, 432);
            this.cycleLengthField.Name = "cycleLengthField";
            this.cycleLengthField.Size = new System.Drawing.Size(125, 27);
            this.cycleLengthField.TabIndex = 11;
            // 
            // modulusField
            // 
            this.modulusField.Location = new System.Drawing.Point(189, 206);
            this.modulusField.Name = "modulusField";
            this.modulusField.Size = new System.Drawing.Size(125, 27);
            this.modulusField.TabIndex = 12;
            // 
            // numberIterationField
            // 
            this.numberIterationField.Location = new System.Drawing.Point(249, 249);
            this.numberIterationField.Name = "numberIterationField";
            this.numberIterationField.Size = new System.Drawing.Size(125, 27);
            this.numberIterationField.TabIndex = 13;
            // 
            // LCG_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 491);
            this.Controls.Add(this.numberIterationField);
            this.Controls.Add(this.modulusField);
            this.Controls.Add(this.cycleLengthField);
            this.Controls.Add(this.incrementField);
            this.Controls.Add(this.seedField);
            this.Controls.Add(this.multiplierField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LCG_Form";
            this.Text = "LCG";
            this.Load += new System.EventHandler(this.LCG_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox multiplierField;
        private System.Windows.Forms.TextBox seedField;
        private System.Windows.Forms.TextBox incrementField;
        private System.Windows.Forms.TextBox cycleLengthField;
        private System.Windows.Forms.TextBox modulusField;
        private System.Windows.Forms.TextBox numberIterationField;
    }
}

