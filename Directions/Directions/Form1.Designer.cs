namespace Directions
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.btnGetDirections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(13, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(16, 40);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(258, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(16, 74);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(16, 101);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(258, 20);
            this.txtTo.TabIndex = 3;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.ForeColor = System.Drawing.Color.White;
            this.lblDirections.Location = new System.Drawing.Point(17, 189);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(54, 13);
            this.lblDirections.TabIndex = 4;
            this.lblDirections.Text = "Directions";
            // 
            // txtDirections
            // 
            this.txtDirections.Location = new System.Drawing.Point(17, 206);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDirections.Size = new System.Drawing.Size(500, 250);
            this.txtDirections.TabIndex = 5;
            // 
            // btnGetDirections
            // 
            this.btnGetDirections.Location = new System.Drawing.Point(233, 145);
            this.btnGetDirections.Name = "btnGetDirections";
            this.btnGetDirections.Size = new System.Drawing.Size(85, 23);
            this.btnGetDirections.TabIndex = 6;
            this.btnGetDirections.Text = "Get Directions";
            this.btnGetDirections.UseVisualStyleBackColor = true;
            this.btnGetDirections.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGetDirections_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(544, 475);
            this.Controls.Add(this.btnGetDirections);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblFrom);
            this.Name = "Form1";
            this.Text = "Need Directions?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox txtDirections;
        private System.Windows.Forms.Button btnGetDirections;
    }
}

