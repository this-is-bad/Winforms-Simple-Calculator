namespace WinForms_SimpleCalculator
{
    partial class HelpForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Close.Location = new System.Drawing.Point(240, 408);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.btn_Close);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
    }
}