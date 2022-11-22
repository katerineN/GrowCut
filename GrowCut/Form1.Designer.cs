namespace GrowCut
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.growCutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.Window;
            this.imageBox.Location = new System.Drawing.Point(202, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(300, 300);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.SystemColors.Window;
            this.drawBox.Location = new System.Drawing.Point(202, 12);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(300, 300);
            this.drawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawBox.TabIndex = 1;
            this.drawBox.TabStop = false;
            this.drawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseDown);
            this.drawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseMove);
            this.drawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseUp);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(12, 12);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(164, 48);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Загрузить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 66);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(164, 50);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // growCutButton
            // 
            this.growCutButton.Location = new System.Drawing.Point(14, 163);
            this.growCutButton.Name = "growCutButton";
            this.growCutButton.Size = new System.Drawing.Size(164, 50);
            this.growCutButton.TabIndex = 5;
            this.growCutButton.Text = "Начать алгоритм";
            this.growCutButton.UseVisualStyleBackColor = true;
            this.growCutButton.Click += new System.EventHandler(this.growCutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 343);
            this.Controls.Add(this.growCutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.imageBox);
            this.Name = "Form1";
            this.Text = "GrowCut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button growCutButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.PictureBox drawBox;

        private System.Windows.Forms.PictureBox imageBox;

        #endregion
    }
}