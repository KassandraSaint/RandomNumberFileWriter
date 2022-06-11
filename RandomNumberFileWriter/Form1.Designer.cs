
namespace RandomNumberFileWriter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.closeBtn = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify How Many Random \r\nNumbers You Want to Generate";
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(269, 116);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(280, 43);
            this.numberBox.TabIndex = 1;
            // 
            // genBtn
            // 
            this.genBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBtn.Location = new System.Drawing.Point(177, 558);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(200, 80);
            this.genBtn.TabIndex = 3;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(426, 558);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(200, 80);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.ItemHeight = 36;
            this.numberListBox.Location = new System.Drawing.Point(177, 192);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(449, 328);
            this.numberListBox.TabIndex = 2;
            this.numberListBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.genBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox numberListBox;
    }
}

