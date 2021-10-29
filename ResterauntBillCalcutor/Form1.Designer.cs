
namespace ResterauntBillCalcutor
{
    partial class RestaurantBillCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.nudTip = new System.Windows.Forms.NumericUpDown();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTipValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Location = new System.Drawing.Point(79, 93);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(121, 23);
            this.mainCourseComboBox.TabIndex = 24;
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.mainCourseComboBox_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(393, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 17);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Location = new System.Drawing.Point(79, 55);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(121, 23);
            this.appetizerComboBox.TabIndex = 2;
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizerComboBox_SelectedIndexChanged);
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Location = new System.Drawing.Point(79, 22);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(121, 23);
            this.beverageComboBox.TabIndex = 1;
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.beverageComboBox_SelectedIndexChanged);
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Location = new System.Drawing.Point(79, 131);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 23);
            this.dessertComboBox.TabIndex = 4;
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(393, 271);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(36, 17);
            this.lblTax.TabIndex = 30;
            this.lblTax.Text = "$0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Location = new System.Drawing.Point(393, 238);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(36, 17);
            this.lblSubTotal.TabIndex = 29;
            this.lblSubTotal.Text = "$0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tax:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Subtotal:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(393, 383);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear Bill";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.beverageComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.appetizerComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dessertComboBox);
            this.groupBox2.Controls.Add(this.mainCourseComboBox);
            this.groupBox2.Location = new System.Drawing.Point(39, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 160);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dessert:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Main Course:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Appetizer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "&Beverage:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(322, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 95);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiter Information";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Johnny Flash",
            "Rosy Mitchell",
            "Jacki Johnson",
            "Jake Summers"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRestaurantName.Location = new System.Drawing.Point(206, 23);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(166, 21);
            this.lblRestaurantName.TabIndex = 22;
            this.lblRestaurantName.Text = "Roadside Restaurant";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(26, 237);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(253, 184);
            this.rtxtOutput.TabIndex = 32;
            this.rtxtOutput.Text = "";
            // 
            // nudTip
            // 
            this.nudTip.Location = new System.Drawing.Point(504, 306);
            this.nudTip.Name = "nudTip";
            this.nudTip.Size = new System.Drawing.Size(50, 23);
            this.nudTip.TabIndex = 34;
            this.nudTip.ValueChanged += new System.EventHandler(this.nudTip_ValueChanged);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(349, 307);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(26, 15);
            this.lblTip.TabIndex = 35;
            this.lblTip.Text = "Tip:";
            // 
            // lblTipValue
            // 
            this.lblTipValue.AutoSize = true;
            this.lblTipValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipValue.Location = new System.Drawing.Point(393, 304);
            this.lblTipValue.Name = "lblTipValue";
            this.lblTipValue.Size = new System.Drawing.Size(36, 17);
            this.lblTipValue.TabIndex = 36;
            this.lblTipValue.Text = "$0.00";
            this.lblTipValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RestaurantBillCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 559);
            this.Controls.Add(this.lblTipValue);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.nudTip);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Name = "RestaurantBillCalculatorForm";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.RestaurantBillCalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.NumericUpDown nudTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTipValue;
        private System.Windows.Forms.ComboBox dessertComboBox;
    }
}

