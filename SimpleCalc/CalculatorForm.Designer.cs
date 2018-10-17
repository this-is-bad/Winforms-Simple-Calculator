namespace WinForms_SimpleCalculator
{
    partial class CalculatorForm
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
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_dec_point = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.txt_value1 = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_num1
            // 
            this.btn_num1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num1.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num1.Location = new System.Drawing.Point(38, 165);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(30, 30);
            this.btn_num1.TabIndex = 0;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = false;
            this.btn_num1.Click += new System.EventHandler(this.btn_num1_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num2.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num2.Location = new System.Drawing.Point(74, 165);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(30, 30);
            this.btn_num2.TabIndex = 1;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = false;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num3.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num3.Location = new System.Drawing.Point(110, 165);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(30, 30);
            this.btn_num3.TabIndex = 2;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = false;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num0.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num0.Location = new System.Drawing.Point(38, 201);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(66, 30);
            this.btn_num0.TabIndex = 3;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = false;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_dec_point
            // 
            this.btn_dec_point.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_dec_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dec_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dec_point.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_dec_point.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dec_point.Location = new System.Drawing.Point(110, 201);
            this.btn_dec_point.Name = "btn_dec_point";
            this.btn_dec_point.Size = new System.Drawing.Size(30, 30);
            this.btn_dec_point.TabIndex = 4;
            this.btn_dec_point.Text = ".";
            this.btn_dec_point.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dec_point.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_dec_point.UseVisualStyleBackColor = false;
            this.btn_dec_point.Click += new System.EventHandler(this.btn_dec_point_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num4.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num4.Location = new System.Drawing.Point(38, 129);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(30, 30);
            this.btn_num4.TabIndex = 5;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = false;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num5.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num5.Location = new System.Drawing.Point(74, 129);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(30, 30);
            this.btn_num5.TabIndex = 6;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = false;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num6.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num6.Location = new System.Drawing.Point(110, 129);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(30, 30);
            this.btn_num6.TabIndex = 7;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = false;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num7.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num7.Location = new System.Drawing.Point(38, 93);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(30, 30);
            this.btn_num7.TabIndex = 8;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = false;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num8.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num8.Location = new System.Drawing.Point(74, 93);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(30, 30);
            this.btn_num8.TabIndex = 9;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = false;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num9.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_num9.Location = new System.Drawing.Point(110, 93);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(30, 30);
            this.btn_num9.TabIndex = 10;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = false;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_add.Location = new System.Drawing.Point(156, 201);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_subtract.Location = new System.Drawing.Point(156, 165);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(30, 30);
            this.btn_subtract.TabIndex = 12;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = false;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_multiply.Location = new System.Drawing.Point(156, 129);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(30, 30);
            this.btn_multiply.TabIndex = 13;
            this.btn_multiply.Text = "X";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_divide.Location = new System.Drawing.Point(156, 93);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(30, 30);
            this.btn_divide.TabIndex = 14;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // txt_value1
            // 
            this.txt_value1.BackColor = System.Drawing.Color.Black;
            this.txt_value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value1.ForeColor = System.Drawing.Color.Chartreuse;
            this.txt_value1.Location = new System.Drawing.Point(38, 46);
            this.txt_value1.MaxLength = 10;
            this.txt_value1.Name = "txt_value1";
            this.txt_value1.Size = new System.Drawing.Size(148, 30);
            this.txt_value1.TabIndex = 15;
            this.txt_value1.TextChanged += new System.EventHandler(this.txt_value1_TextChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Close.Location = new System.Drawing.Point(210, 201);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 30);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Clear.Location = new System.Drawing.Point(210, 165);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(57, 30);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Calculate.Location = new System.Drawing.Point(210, 129);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(80, 30);
            this.btn_Calculate.TabIndex = 18;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Help.Location = new System.Drawing.Point(210, 93);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(57, 30);
            this.btn_Help.TabIndex = 19;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(298, 270);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_value1);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_num9);
            this.Controls.Add(this.btn_num8);
            this.Controls.Add(this.btn_num7);
            this.Controls.Add(this.btn_num6);
            this.Controls.Add(this.btn_num5);
            this.Controls.Add(this.btn_num4);
            this.Controls.Add(this.btn_dec_point);
            this.Controls.Add(this.btn_num0);
            this.Controls.Add(this.btn_num3);
            this.Controls.Add(this.btn_num2);
            this.Controls.Add(this.btn_num1);
            this.Name = "CalculatorForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_dec_point;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox txt_value1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Help;
    }
}

