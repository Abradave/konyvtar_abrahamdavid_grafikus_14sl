namespace KonyvtarGrafikus
{
    partial class FormKonyvtar
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
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.numPublished = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPageCount = new System.Windows.Forms.NumericUpDown();
            this.btnCommand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(133, 69);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(212, 20);
            this.tbAuthor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(133, 114);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(212, 20);
            this.tbTitle.TabIndex = 5;
            // 
            // numPublished
            // 
            this.numPublished.Location = new System.Drawing.Point(407, 69);
            this.numPublished.Maximum = new decimal(new int[] {
            -1511769059,
            0,
            0,
            0});
            this.numPublished.Name = "numPublished";
            this.numPublished.Size = new System.Drawing.Size(212, 20);
            this.numPublished.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Published";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Page Count";
            // 
            // numPageCount
            // 
            this.numPageCount.Location = new System.Drawing.Point(407, 115);
            this.numPageCount.Maximum = new decimal(new int[] {
            593579475,
            10,
            0,
            0});
            this.numPageCount.Name = "numPageCount";
            this.numPageCount.Size = new System.Drawing.Size(212, 20);
            this.numPageCount.TabIndex = 9;
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(112, 172);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(517, 250);
            this.btnCommand.TabIndex = 11;
            this.btnCommand.Text = "button1";
            this.btnCommand.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(272, 30);
            this.numId.Maximum = new decimal(new int[] {
            -1511769059,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(212, 20);
            this.numId.TabIndex = 14;
            // 
            // FormKonyvtar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPageCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPublished);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAuthor);
            this.Name = "FormKonyvtar";
            this.Text = "FormKonyvtar";
            this.Load += new System.EventHandler(this.FormKonyvtar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.NumericUpDown numPublished;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPageCount;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numId;
    }
}