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
            this.components = new System.ComponentModel.Container();
            this.btn_Num1 = new System.Windows.Forms.Button();
            this.btn_Num2 = new System.Windows.Forms.Button();
            this.btn_Num3 = new System.Windows.Forms.Button();
            this.btn_Num0 = new System.Windows.Forms.Button();
            this.btn_DecPoint = new System.Windows.Forms.Button();
            this.btn_Num4 = new System.Windows.Forms.Button();
            this.btn_Num5 = new System.Windows.Forms.Button();
            this.btn_Num6 = new System.Windows.Forms.Button();
            this.btn_Num7 = new System.Windows.Forms.Button();
            this.btn_Num8 = new System.Windows.Forms.Button();
            this.btn_Num9 = new System.Windows.Forms.Button();
            this.txt_Value1 = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Error = new System.Windows.Forms.Label();
            this.cmb_UnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.rb_CalcAreaFromRadius = new System.Windows.Forms.RadioButton();
            this.grp_CalcOptions = new System.Windows.Forms.GroupBox();
            this.lbl_UoM = new System.Windows.Forms.Label();
            this.rb_CalcIntToBinary = new System.Windows.Forms.RadioButton();
            this.rb_CalcIntToHex = new System.Windows.Forms.RadioButton();
            this.rb_CalcAreaFromSide = new System.Windows.Forms.RadioButton();
            this.cmb_CalcType = new System.Windows.Forms.ComboBox();
            this.lbl_CalcType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grp_CalcOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Num1
            // 
            this.btn_Num1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num1.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num1.Location = new System.Drawing.Point(38, 342);
            this.btn_Num1.Name = "btn_Num1";
            this.btn_Num1.Size = new System.Drawing.Size(30, 30);
            this.btn_Num1.TabIndex = 9;
            this.btn_Num1.Text = "1";
            this.btn_Num1.UseVisualStyleBackColor = false;
            this.btn_Num1.Click += new System.EventHandler(this.Btn_Num1_Click);
            // 
            // btn_Num2
            // 
            this.btn_Num2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num2.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num2.Location = new System.Drawing.Point(74, 342);
            this.btn_Num2.Name = "btn_Num2";
            this.btn_Num2.Size = new System.Drawing.Size(30, 30);
            this.btn_Num2.TabIndex = 10;
            this.btn_Num2.Text = "2";
            this.btn_Num2.UseVisualStyleBackColor = false;
            this.btn_Num2.Click += new System.EventHandler(this.Btn_Num2_Click);
            // 
            // btn_Num3
            // 
            this.btn_Num3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num3.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num3.Location = new System.Drawing.Point(110, 342);
            this.btn_Num3.Name = "btn_Num3";
            this.btn_Num3.Size = new System.Drawing.Size(30, 30);
            this.btn_Num3.TabIndex = 11;
            this.btn_Num3.Text = "3";
            this.btn_Num3.UseVisualStyleBackColor = false;
            this.btn_Num3.Click += new System.EventHandler(this.Btn_Num3_Click);
            // 
            // btn_Num0
            // 
            this.btn_Num0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num0.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num0.Location = new System.Drawing.Point(38, 378);
            this.btn_Num0.Name = "btn_Num0";
            this.btn_Num0.Size = new System.Drawing.Size(66, 30);
            this.btn_Num0.TabIndex = 7;
            this.btn_Num0.Text = "0";
            this.btn_Num0.UseVisualStyleBackColor = false;
            this.btn_Num0.Click += new System.EventHandler(this.Btn_Num0_Click);
            // 
            // btn_DecPoint
            // 
            this.btn_DecPoint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DecPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DecPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DecPoint.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_DecPoint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DecPoint.Location = new System.Drawing.Point(110, 378);
            this.btn_DecPoint.Name = "btn_DecPoint";
            this.btn_DecPoint.Size = new System.Drawing.Size(30, 30);
            this.btn_DecPoint.TabIndex = 8;
            this.btn_DecPoint.Text = ".";
            this.btn_DecPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DecPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_DecPoint.UseVisualStyleBackColor = false;
            this.btn_DecPoint.Click += new System.EventHandler(this.Btn_DecPoint_Click);
            // 
            // btn_Num4
            // 
            this.btn_Num4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num4.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num4.Location = new System.Drawing.Point(38, 306);
            this.btn_Num4.Name = "btn_Num4";
            this.btn_Num4.Size = new System.Drawing.Size(30, 30);
            this.btn_Num4.TabIndex = 12;
            this.btn_Num4.Text = "4";
            this.btn_Num4.UseVisualStyleBackColor = false;
            this.btn_Num4.Click += new System.EventHandler(this.Btn_Num4_Click);
            // 
            // btn_Num5
            // 
            this.btn_Num5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num5.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num5.Location = new System.Drawing.Point(74, 306);
            this.btn_Num5.Name = "btn_Num5";
            this.btn_Num5.Size = new System.Drawing.Size(30, 30);
            this.btn_Num5.TabIndex = 13;
            this.btn_Num5.Text = "5";
            this.btn_Num5.UseVisualStyleBackColor = false;
            this.btn_Num5.Click += new System.EventHandler(this.Btn_Num5_Click);
            // 
            // btn_Num6
            // 
            this.btn_Num6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num6.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num6.Location = new System.Drawing.Point(110, 306);
            this.btn_Num6.Name = "btn_Num6";
            this.btn_Num6.Size = new System.Drawing.Size(30, 30);
            this.btn_Num6.TabIndex = 14;
            this.btn_Num6.Text = "6";
            this.btn_Num6.UseVisualStyleBackColor = false;
            this.btn_Num6.Click += new System.EventHandler(this.Btn_Num6_Click);
            // 
            // btn_Num7
            // 
            this.btn_Num7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num7.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num7.Location = new System.Drawing.Point(38, 270);
            this.btn_Num7.Name = "btn_Num7";
            this.btn_Num7.Size = new System.Drawing.Size(30, 30);
            this.btn_Num7.TabIndex = 15;
            this.btn_Num7.Text = "7";
            this.btn_Num7.UseVisualStyleBackColor = false;
            this.btn_Num7.Click += new System.EventHandler(this.Btn_Num7_Click);
            // 
            // btn_Num8
            // 
            this.btn_Num8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num8.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num8.Location = new System.Drawing.Point(74, 270);
            this.btn_Num8.Name = "btn_Num8";
            this.btn_Num8.Size = new System.Drawing.Size(30, 30);
            this.btn_Num8.TabIndex = 16;
            this.btn_Num8.Text = "8";
            this.btn_Num8.UseVisualStyleBackColor = false;
            this.btn_Num8.Click += new System.EventHandler(this.Btn_Num8_Click);
            // 
            // btn_Num9
            // 
            this.btn_Num9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num9.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Num9.Location = new System.Drawing.Point(110, 270);
            this.btn_Num9.Name = "btn_Num9";
            this.btn_Num9.Size = new System.Drawing.Size(30, 30);
            this.btn_Num9.TabIndex = 17;
            this.btn_Num9.Text = "9";
            this.btn_Num9.UseVisualStyleBackColor = false;
            this.btn_Num9.Click += new System.EventHandler(this.Btn_Num9_Click);
            // 
            // txt_Value1
            // 
            this.txt_Value1.BackColor = System.Drawing.Color.Black;
            this.txt_Value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Value1.ForeColor = System.Drawing.Color.Chartreuse;
            this.txt_Value1.Location = new System.Drawing.Point(24, 46);
            this.txt_Value1.MaximumSize = new System.Drawing.Size(189, 30);
            this.txt_Value1.MaxLength = 10;
            this.txt_Value1.Name = "txt_Value1";
            this.txt_Value1.Size = new System.Drawing.Size(189, 30);
            this.txt_Value1.TabIndex = 0;
            this.txt_Value1.TextChanged += new System.EventHandler(this.txt_Value1_TextChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Close.Location = new System.Drawing.Point(147, 433);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 30);
            this.btn_Close.TabIndex = 4;
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
            this.btn_Clear.Location = new System.Drawing.Point(147, 378);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(57, 30);
            this.btn_Clear.TabIndex = 6;
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
            this.btn_Calculate.Location = new System.Drawing.Point(147, 270);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(57, 30);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Calc";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Help.Location = new System.Drawing.Point(38, 433);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(57, 30);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_Error.Location = new System.Drawing.Point(12, 9);
            this.lbl_Error.MaximumSize = new System.Drawing.Size(215, 34);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(215, 34);
            this.lbl_Error.TabIndex = 20;
            this.lbl_Error.Visible = false;
            // 
            // cmb_UnitOfMeasure
            // 
            this.cmb_UnitOfMeasure.BackColor = System.Drawing.Color.Black;
            this.cmb_UnitOfMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_UnitOfMeasure.ForeColor = System.Drawing.Color.Chartreuse;
            this.cmb_UnitOfMeasure.FormattingEnabled = true;
            this.cmb_UnitOfMeasure.Location = new System.Drawing.Point(6, 88);
            this.cmb_UnitOfMeasure.Name = "cmb_UnitOfMeasure";
            this.cmb_UnitOfMeasure.Size = new System.Drawing.Size(82, 24);
            this.cmb_UnitOfMeasure.TabIndex = 4;
            // 
            // rb_CalcAreaFromRadius
            // 
            this.rb_CalcAreaFromRadius.AutoSize = true;
            this.rb_CalcAreaFromRadius.ForeColor = System.Drawing.Color.Chartreuse;
            this.rb_CalcAreaFromRadius.Location = new System.Drawing.Point(6, 19);
            this.rb_CalcAreaFromRadius.Name = "rb_CalcAreaFromRadius";
            this.rb_CalcAreaFromRadius.Size = new System.Drawing.Size(173, 20);
            this.rb_CalcAreaFromRadius.TabIndex = 2;
            this.rb_CalcAreaFromRadius.TabStop = true;
            this.rb_CalcAreaFromRadius.Text = "Area from radius of circle";
            this.rb_CalcAreaFromRadius.UseVisualStyleBackColor = true;
            this.rb_CalcAreaFromRadius.Visible = false;
            // 
            // grp_CalcOptions
            // 
            this.grp_CalcOptions.Controls.Add(this.lbl_UoM);
            this.grp_CalcOptions.Controls.Add(this.rb_CalcIntToBinary);
            this.grp_CalcOptions.Controls.Add(this.cmb_UnitOfMeasure);
            this.grp_CalcOptions.Controls.Add(this.rb_CalcIntToHex);
            this.grp_CalcOptions.Controls.Add(this.rb_CalcAreaFromSide);
            this.grp_CalcOptions.Controls.Add(this.rb_CalcAreaFromRadius);
            this.grp_CalcOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_CalcOptions.ForeColor = System.Drawing.Color.Chartreuse;
            this.grp_CalcOptions.Location = new System.Drawing.Point(24, 139);
            this.grp_CalcOptions.Name = "grp_CalcOptions";
            this.grp_CalcOptions.Size = new System.Drawing.Size(189, 115);
            this.grp_CalcOptions.TabIndex = 2;
            this.grp_CalcOptions.TabStop = false;
            this.grp_CalcOptions.Text = "Calculation Choices";
            // 
            // lbl_UoM
            // 
            this.lbl_UoM.AutoSize = true;
            this.lbl_UoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UoM.Location = new System.Drawing.Point(3, 69);
            this.lbl_UoM.Name = "lbl_UoM";
            this.lbl_UoM.Size = new System.Drawing.Size(101, 16);
            this.lbl_UoM.TabIndex = 26;
            this.lbl_UoM.Text = "Unit of measure";
            // 
            // rb_CalcIntToBinary
            // 
            this.rb_CalcIntToBinary.AutoSize = true;
            this.rb_CalcIntToBinary.Location = new System.Drawing.Point(6, 19);
            this.rb_CalcIntToBinary.Name = "rb_CalcIntToBinary";
            this.rb_CalcIntToBinary.Size = new System.Drawing.Size(158, 20);
            this.rb_CalcIntToBinary.TabIndex = 0;
            this.rb_CalcIntToBinary.TabStop = true;
            this.rb_CalcIntToBinary.Text = "Binary value of integer";
            this.rb_CalcIntToBinary.UseVisualStyleBackColor = true;
            this.rb_CalcIntToBinary.Visible = false;
            // 
            // rb_CalcIntToHex
            // 
            this.rb_CalcIntToHex.AutoSize = true;
            this.rb_CalcIntToHex.Location = new System.Drawing.Point(6, 42);
            this.rb_CalcIntToHex.Name = "rb_CalcIntToHex";
            this.rb_CalcIntToHex.Size = new System.Drawing.Size(144, 20);
            this.rb_CalcIntToHex.TabIndex = 1;
            this.rb_CalcIntToHex.TabStop = true;
            this.rb_CalcIntToHex.Text = "Hex value of integer";
            this.rb_CalcIntToHex.UseVisualStyleBackColor = true;
            this.rb_CalcIntToHex.Visible = false;
            // 
            // rb_CalcAreaFromSide
            // 
            this.rb_CalcAreaFromSide.AutoSize = true;
            this.rb_CalcAreaFromSide.Location = new System.Drawing.Point(6, 42);
            this.rb_CalcAreaFromSide.Name = "rb_CalcAreaFromSide";
            this.rb_CalcAreaFromSide.Size = new System.Drawing.Size(172, 20);
            this.rb_CalcAreaFromSide.TabIndex = 23;
            this.rb_CalcAreaFromSide.TabStop = true;
            this.rb_CalcAreaFromSide.Text = "Area from side of square";
            this.rb_CalcAreaFromSide.UseVisualStyleBackColor = true;
            this.rb_CalcAreaFromSide.Visible = false;
            // 
            // cmb_CalcType
            // 
            this.cmb_CalcType.BackColor = System.Drawing.Color.Black;
            this.cmb_CalcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CalcType.ForeColor = System.Drawing.Color.Chartreuse;
            this.cmb_CalcType.FormattingEnabled = true;
            this.cmb_CalcType.Location = new System.Drawing.Point(24, 109);
            this.cmb_CalcType.Name = "cmb_CalcType";
            this.cmb_CalcType.Size = new System.Drawing.Size(90, 21);
            this.cmb_CalcType.TabIndex = 1;
            this.cmb_CalcType.SelectedIndexChanged += new System.EventHandler(this.cmb_CalcType_SelectedIndexChanged);
            // 
            // lbl_CalcType
            // 
            this.lbl_CalcType.AutoSize = true;
            this.lbl_CalcType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CalcType.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_CalcType.Location = new System.Drawing.Point(21, 90);
            this.lbl_CalcType.Name = "lbl_CalcType";
            this.lbl_CalcType.Size = new System.Drawing.Size(109, 16);
            this.lbl_CalcType.TabIndex = 25;
            this.lbl_CalcType.Text = "Calculation Type";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(242, 475);
            this.Controls.Add(this.lbl_CalcType);
            this.Controls.Add(this.cmb_CalcType);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Value1);
            this.Controls.Add(this.btn_Num9);
            this.Controls.Add(this.btn_Num8);
            this.Controls.Add(this.btn_Num7);
            this.Controls.Add(this.btn_Num6);
            this.Controls.Add(this.btn_Num5);
            this.Controls.Add(this.btn_Num4);
            this.Controls.Add(this.btn_DecPoint);
            this.Controls.Add(this.btn_Num0);
            this.Controls.Add(this.btn_Num3);
            this.Controls.Add(this.btn_Num2);
            this.Controls.Add(this.btn_Num1);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.grp_CalcOptions);
            this.Name = "CalculatorForm";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grp_CalcOptions.ResumeLayout(false);
            this.grp_CalcOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Num1;
        private System.Windows.Forms.Button btn_Num2;
        private System.Windows.Forms.Button btn_Num3;
        private System.Windows.Forms.Button btn_Num0;
        private System.Windows.Forms.Button btn_DecPoint;
        private System.Windows.Forms.Button btn_Num4;
        private System.Windows.Forms.Button btn_Num5;
        private System.Windows.Forms.Button btn_Num6;
        private System.Windows.Forms.Button btn_Num7;
        private System.Windows.Forms.Button btn_Num8;
        private System.Windows.Forms.Button btn_Num9;
        private System.Windows.Forms.TextBox txt_Value1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.ComboBox cmb_UnitOfMeasure;
        private System.Windows.Forms.RadioButton rb_CalcAreaFromRadius;
        private System.Windows.Forms.GroupBox grp_CalcOptions;
        private System.Windows.Forms.RadioButton rb_CalcIntToHex;
        private System.Windows.Forms.RadioButton rb_CalcAreaFromSide;
        private System.Windows.Forms.RadioButton rb_CalcIntToBinary;
        private System.Windows.Forms.ComboBox cmb_CalcType;
        private System.Windows.Forms.Label lbl_CalcType;
        private System.Windows.Forms.Label lbl_UoM;
    }
}

