namespace FaceDetection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startCamBtn = new System.Windows.Forms.Button();
            this.stopCamBtn = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopCamBtn);
            this.groupBox1.Controls.Add(this.startCamBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgBox);
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // startCamBtn
            // 
            this.startCamBtn.Location = new System.Drawing.Point(37, 38);
            this.startCamBtn.Name = "startCamBtn";
            this.startCamBtn.Size = new System.Drawing.Size(119, 23);
            this.startCamBtn.TabIndex = 0;
            this.startCamBtn.Text = "Start Camera";
            this.startCamBtn.UseVisualStyleBackColor = true;
            this.startCamBtn.Click += new System.EventHandler(this.startCamBtn_Click);
            // 
            // stopCamBtn
            // 
            this.stopCamBtn.Location = new System.Drawing.Point(37, 67);
            this.stopCamBtn.Name = "stopCamBtn";
            this.stopCamBtn.Size = new System.Drawing.Size(119, 23);
            this.stopCamBtn.TabIndex = 1;
            this.stopCamBtn.Text = "Stop Camera";
            this.stopCamBtn.UseVisualStyleBackColor = true;
            this.stopCamBtn.Click += new System.EventHandler(this.stopCamBtn_Click);
            // 
            // imgBox
            // 
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBox.Location = new System.Drawing.Point(40, 41);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(320, 240);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(640, 380);
            this.MinimumSize = new System.Drawing.Size(640, 380);
            this.Name = "Form1";
            this.Text = "Face Detection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopCamBtn;
        private System.Windows.Forms.Button startCamBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

