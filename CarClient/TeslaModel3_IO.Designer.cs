namespace CarClient
{
    partial class TeslaModel3_IO
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
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnSteer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIsRainy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBreak);
            this.groupBox1.Controls.Add(this.btnSteer);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Control";
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(7, 50);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 23);
            this.btnBreak.TabIndex = 1;
            this.btnBreak.Text = "break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnSteer
            // 
            this.btnSteer.Location = new System.Drawing.Point(7, 20);
            this.btnSteer.Name = "btnSteer";
            this.btnSteer.Size = new System.Drawing.Size(75, 23);
            this.btnSteer.TabIndex = 0;
            this.btnSteer.Text = "steer";
            this.btnSteer.UseVisualStyleBackColor = true;
            this.btnSteer.Click += new System.EventHandler(this.btnSteer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIsRainy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownSpeed);
            this.groupBox2.Location = new System.Drawing.Point(125, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current State";
            // 
            // cbIsRainy
            // 
            this.cbIsRainy.AutoSize = true;
            this.cbIsRainy.Location = new System.Drawing.Point(48, 54);
            this.cbIsRainy.Name = "cbIsRainy";
            this.cbIsRainy.Size = new System.Drawing.Size(15, 14);
            this.cbIsRainy.TabIndex = 5;
            this.cbIsRainy.UseVisualStyleBackColor = true;
            this.cbIsRainy.CheckedChanged += new System.EventHandler(this.cbIsRainy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "rainy?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "speed";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(48, 27);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Leave += new System.EventHandler(this.numericUpDownSpeed_Leave);
            // 
            // TeslaModel3_IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 124);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeslaModel3_IO";
            this.Text = "Tesla Model 3 IO Envirnoment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnSteer;
        private System.Windows.Forms.CheckBox cbIsRainy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
    }
}

