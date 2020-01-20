namespace Project1_CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDefinition = new System.Windows.Forms.Button();
            this.btnDispose = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnCircumf = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.rdoCylinder = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadus = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 197);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 36);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDefinition
            // 
            this.btnDefinition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinition.Location = new System.Drawing.Point(279, 197);
            this.btnDefinition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDefinition.Name = "btnDefinition";
            this.btnDefinition.Size = new System.Drawing.Size(118, 36);
            this.btnDefinition.TabIndex = 37;
            this.btnDefinition.Text = "Definition";
            this.btnDefinition.UseVisualStyleBackColor = false;
            this.btnDefinition.Click += new System.EventHandler(this.BtnDefinition_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDispose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispose.Location = new System.Drawing.Point(163, 237);
            this.btnDispose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(103, 36);
            this.btnDispose.TabIndex = 36;
            this.btnDispose.Text = "Dispose";
            this.btnDispose.UseVisualStyleBackColor = false;
            this.btnDispose.Click += new System.EventHandler(this.BtnDispose_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(413, 277);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(151, 36);
            this.btnVolume.TabIndex = 40;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(413, 237);
            this.btnArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(151, 36);
            this.btnArea.TabIndex = 39;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnCircumf
            // 
            this.btnCircumf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCircumf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircumf.Location = new System.Drawing.Point(413, 197);
            this.btnCircumf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCircumf.Name = "btnCircumf";
            this.btnCircumf.Size = new System.Drawing.Size(151, 36);
            this.btnCircumf.TabIndex = 38;
            this.btnCircumf.Text = "Circumference";
            this.btnCircumf.UseVisualStyleBackColor = false;
            this.btnCircumf.Click += new System.EventHandler(this.BtnCircumf_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(163, 197);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 36);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(412, 135);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(349, 30);
            this.txtVolume.TabIndex = 34;
            this.txtVolume.TabStop = false;
            this.txtVolume.Text = "0";
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(247, 139);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(162, 23);
            this.lblVolume.TabIndex = 33;
            this.lblVolume.Text = "Volume:";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(412, 106);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(349, 30);
            this.txtArea.TabIndex = 32;
            this.txtArea.TabStop = false;
            this.txtArea.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Area:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCircumference
            // 
            this.txtCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircumference.Location = new System.Drawing.Point(412, 76);
            this.txtCircumference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.ReadOnly = true;
            this.txtCircumference.Size = new System.Drawing.Size(349, 30);
            this.txtCircumference.TabIndex = 30;
            this.txtCircumference.TabStop = false;
            this.txtCircumference.Text = "0";
            // 
            // lblCircumference
            // 
            this.lblCircumference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(247, 76);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(162, 23);
            this.lblCircumference.TabIndex = 29;
            this.lblCircumference.Text = "Circumference:";
            this.lblCircumference.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoCylinder
            // 
            this.rdoCylinder.AutoSize = true;
            this.rdoCylinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdoCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCylinder.Location = new System.Drawing.Point(375, 11);
            this.rdoCylinder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoCylinder.Name = "rdoCylinder";
            this.rdoCylinder.Size = new System.Drawing.Size(113, 29);
            this.rdoCylinder.TabIndex = 22;
            this.rdoCylinder.Text = "Cylinder";
            this.rdoCylinder.UseVisualStyleBackColor = false;
            this.rdoCylinder.CheckedChanged += new System.EventHandler(this.RdoCylinder_CheckedChanged);
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdoCircle.Checked = true;
            this.rdoCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCircle.Location = new System.Drawing.Point(252, 11);
            this.rdoCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(89, 29);
            this.rdoCircle.TabIndex = 21;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = false;
            this.rdoCircle.CheckedChanged += new System.EventHandler(this.RdoCircle_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(134, 127);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 30);
            this.txtHeight.TabIndex = 28;
            this.txtHeight.Text = "0";
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(29, 127);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 23);
            this.lblHeight.TabIndex = 27;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.Location = new System.Drawing.Point(134, 92);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 30);
            this.txtRadius.TabIndex = 24;
            this.txtRadius.Text = "0";
            // 
            // lblRadus
            // 
            this.lblRadus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRadus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadus.Location = new System.Drawing.Point(29, 92);
            this.lblRadus.Name = "lblRadus";
            this.lblRadus.Size = new System.Drawing.Size(100, 23);
            this.lblRadus.TabIndex = 23;
            this.lblRadus.Text = "Radius:";
            this.lblRadus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.Info;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(152, 321);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(472, 20);
            this.txtError.TabIndex = 42;
            this.txtError.TabStop = false;
            this.txtError.Text = "(error)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 441);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefinition);
            this.Controls.Add(this.btnDispose);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnCircumf);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCircumference);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.rdoCylinder);
            this.Controls.Add(this.rdoCircle);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadus);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDefinition;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnCircumf;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.RadioButton rdoCylinder;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadus;
        internal System.Windows.Forms.TextBox txtError;
    }
}

