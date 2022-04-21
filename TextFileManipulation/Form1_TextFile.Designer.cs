namespace TextFileManipulation
{
    partial class Form1_TextFile
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
            this.richTextBoxWrite = new System.Windows.Forms.RichTextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.richTextBoxRead = new System.Windows.Forms.RichTextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelFilePathWrite = new System.Windows.Forms.Label();
            this.labelFilePathRead = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxWrite
            // 
            this.richTextBoxWrite.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxWrite.Location = new System.Drawing.Point(38, 47);
            this.richTextBoxWrite.Name = "richTextBoxWrite";
            this.richTextBoxWrite.Size = new System.Drawing.Size(481, 317);
            this.richTextBoxWrite.TabIndex = 0;
            this.richTextBoxWrite.Text = "";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWrite.Location = new System.Drawing.Point(38, 384);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(149, 51);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonAppend
            // 
            this.buttonAppend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAppend.Location = new System.Drawing.Point(370, 384);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(149, 51);
            this.buttonAppend.TabIndex = 2;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // richTextBoxRead
            // 
            this.richTextBoxRead.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxRead.Location = new System.Drawing.Point(632, 47);
            this.richTextBoxRead.Name = "richTextBoxRead";
            this.richTextBoxRead.Size = new System.Drawing.Size(481, 317);
            this.richTextBoxRead.TabIndex = 3;
            this.richTextBoxRead.Text = "";
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRead.Location = new System.Drawing.Point(632, 384);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(149, 51);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelFilePathWrite
            // 
            this.labelFilePathWrite.AutoSize = true;
            this.labelFilePathWrite.Location = new System.Drawing.Point(41, 15);
            this.labelFilePathWrite.Name = "labelFilePathWrite";
            this.labelFilePathWrite.Size = new System.Drawing.Size(130, 25);
            this.labelFilePathWrite.TabIndex = 5;
            this.labelFilePathWrite.Text = "File Path (W): ...";
            // 
            // labelFilePathRead
            // 
            this.labelFilePathRead.AutoSize = true;
            this.labelFilePathRead.Location = new System.Drawing.Point(632, 15);
            this.labelFilePathRead.Name = "labelFilePathRead";
            this.labelFilePathRead.Size = new System.Drawing.Size(124, 25);
            this.labelFilePathRead.TabIndex = 6;
            this.labelFilePathRead.Text = "File Path (R): ...";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProcess.Location = new System.Drawing.Point(964, 384);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(149, 51);
            this.buttonProcess.TabIndex = 7;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // Form1_TextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 469);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.labelFilePathRead);
            this.Controls.Add(this.labelFilePathWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.richTextBoxRead);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.richTextBoxWrite);
            this.Name = "Form1_TextFile";
            this.Text = "WriteTextFile";
            this.Load += new System.EventHandler(this.Form1_TextFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxWrite;
        private Button buttonWrite;
        private Button buttonAppend;
        private RichTextBox richTextBoxRead;
        private Button buttonRead;
        private Label labelFilePathWrite;
        private Label labelFilePathRead;
        private Button buttonProcess;
    }
}