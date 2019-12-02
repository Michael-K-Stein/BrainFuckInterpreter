namespace BrainFuckInterpreter
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
            this.pRegistry = new System.Windows.Forms.Panel();
            this.rtbBrainFuckCode = new System.Windows.Forms.RichTextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bRun = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pRegistry
            // 
            this.pRegistry.AutoScroll = true;
            this.pRegistry.Location = new System.Drawing.Point(12, 12);
            this.pRegistry.Name = "pRegistry";
            this.pRegistry.Size = new System.Drawing.Size(776, 103);
            this.pRegistry.TabIndex = 0;
            // 
            // rtbBrainFuckCode
            // 
            this.rtbBrainFuckCode.Location = new System.Drawing.Point(12, 148);
            this.rtbBrainFuckCode.Name = "rtbBrainFuckCode";
            this.rtbBrainFuckCode.Size = new System.Drawing.Size(776, 290);
            this.rtbBrainFuckCode.TabIndex = 1;
            this.rtbBrainFuckCode.Text = "";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 121);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(695, 20);
            this.tbInput.TabIndex = 2;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(713, 119);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(75, 23);
            this.bRun.TabIndex = 3;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 444);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(776, 100);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.rtbBrainFuckCode);
            this.Controls.Add(this.pRegistry);
            this.Name = "Form1";
            this.Text = "BrainFuck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pRegistry;
        private System.Windows.Forms.RichTextBox rtbBrainFuckCode;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

