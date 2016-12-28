namespace CardGame21
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
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCards
            // 
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Location = new System.Drawing.Point(12, 12);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.Size = new System.Drawing.Size(144, 225);
            this.dgvCards.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(54, 280);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Value";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(239, 23);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(12, 13);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "x";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(158, 280);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "OldValue";
            // 
            // lblOldValue
            // 
            this.lblOldValue.AutoSize = true;
            this.lblOldValue.Location = new System.Drawing.Point(238, 66);
            this.lblOldValue.Name = "lblOldValue";
            this.lblOldValue.Size = new System.Drawing.Size(12, 13);
            this.lblOldValue.TabIndex = 6;
            this.lblOldValue.Text = "x";
            this.lblOldValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 346);
            this.Controls.Add(this.lblOldValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.dgvCards);
            this.Name = "Form1";
            this.Text = "21";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldValue;
    }
}

