namespace FoodOrderingApp
{
    partial class MainUI
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
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showMainCourseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iceCreamCheckBox = new System.Windows.Forms.CheckBox();
            this.faludaCheckBox = new System.Windows.Forms.CheckBox();
            this.mixedFruitCheckBox = new System.Windows.Forms.CheckBox();
            this.cakeCheckBox = new System.Windows.Forms.CheckBox();
            this.showDessertButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cokeRadioButton = new System.Windows.Forms.RadioButton();
            this.spriteRadioButton = new System.Windows.Forms.RadioButton();
            this.mountainDewRadioButton = new System.Windows.Forms.RadioButton();
            this.fantaRadioButton = new System.Windows.Forms.RadioButton();
            this.showBeverageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainCourseComboBox);
            this.groupBox1.Controls.Add(this.showMainCourseButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Hydrabadi Biriyani",
            "Pasta",
            "Broast",
            "Chicken Tandoori"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(128, 35);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(234, 21);
            this.mainCourseComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items";
            // 
            // showMainCourseButton
            // 
            this.showMainCourseButton.Location = new System.Drawing.Point(400, 37);
            this.showMainCourseButton.Name = "showMainCourseButton";
            this.showMainCourseButton.Size = new System.Drawing.Size(93, 23);
            this.showMainCourseButton.TabIndex = 2;
            this.showMainCourseButton.Text = "Show Items";
            this.showMainCourseButton.UseVisualStyleBackColor = true;
            this.showMainCourseButton.Click += new System.EventHandler(this.showMainCourseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showDessertButton);
            this.groupBox2.Controls.Add(this.cakeCheckBox);
            this.groupBox2.Controls.Add(this.mixedFruitCheckBox);
            this.groupBox2.Controls.Add(this.faludaCheckBox);
            this.groupBox2.Controls.Add(this.iceCreamCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dessert";
            // 
            // iceCreamCheckBox
            // 
            this.iceCreamCheckBox.AutoSize = true;
            this.iceCreamCheckBox.Location = new System.Drawing.Point(44, 30);
            this.iceCreamCheckBox.Name = "iceCreamCheckBox";
            this.iceCreamCheckBox.Size = new System.Drawing.Size(74, 17);
            this.iceCreamCheckBox.TabIndex = 0;
            this.iceCreamCheckBox.Text = "Ice Cream";
            this.iceCreamCheckBox.UseVisualStyleBackColor = true;
            // 
            // faludaCheckBox
            // 
            this.faludaCheckBox.AutoSize = true;
            this.faludaCheckBox.Location = new System.Drawing.Point(253, 30);
            this.faludaCheckBox.Name = "faludaCheckBox";
            this.faludaCheckBox.Size = new System.Drawing.Size(58, 17);
            this.faludaCheckBox.TabIndex = 0;
            this.faludaCheckBox.Text = "Faluda";
            this.faludaCheckBox.UseVisualStyleBackColor = true;
            // 
            // mixedFruitCheckBox
            // 
            this.mixedFruitCheckBox.AutoSize = true;
            this.mixedFruitCheckBox.Location = new System.Drawing.Point(44, 68);
            this.mixedFruitCheckBox.Name = "mixedFruitCheckBox";
            this.mixedFruitCheckBox.Size = new System.Drawing.Size(77, 17);
            this.mixedFruitCheckBox.TabIndex = 0;
            this.mixedFruitCheckBox.Text = "Mixed Fruit";
            this.mixedFruitCheckBox.UseVisualStyleBackColor = true;
            // 
            // cakeCheckBox
            // 
            this.cakeCheckBox.AutoSize = true;
            this.cakeCheckBox.Location = new System.Drawing.Point(253, 68);
            this.cakeCheckBox.Name = "cakeCheckBox";
            this.cakeCheckBox.Size = new System.Drawing.Size(51, 17);
            this.cakeCheckBox.TabIndex = 0;
            this.cakeCheckBox.Text = "Cake";
            this.cakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // showDessertButton
            // 
            this.showDessertButton.Location = new System.Drawing.Point(400, 44);
            this.showDessertButton.Name = "showDessertButton";
            this.showDessertButton.Size = new System.Drawing.Size(93, 23);
            this.showDessertButton.TabIndex = 1;
            this.showDessertButton.Text = "Show Items";
            this.showDessertButton.UseVisualStyleBackColor = true;
            this.showDessertButton.Click += new System.EventHandler(this.showDessertButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showBeverageButton);
            this.groupBox3.Controls.Add(this.fantaRadioButton);
            this.groupBox3.Controls.Add(this.mountainDewRadioButton);
            this.groupBox3.Controls.Add(this.spriteRadioButton);
            this.groupBox3.Controls.Add(this.cokeRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 110);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Beverage";
            // 
            // cokeRadioButton
            // 
            this.cokeRadioButton.AutoSize = true;
            this.cokeRadioButton.Location = new System.Drawing.Point(38, 28);
            this.cokeRadioButton.Name = "cokeRadioButton";
            this.cokeRadioButton.Size = new System.Drawing.Size(50, 17);
            this.cokeRadioButton.TabIndex = 0;
            this.cokeRadioButton.TabStop = true;
            this.cokeRadioButton.Text = "Coke";
            this.cokeRadioButton.UseVisualStyleBackColor = true;
            // 
            // spriteRadioButton
            // 
            this.spriteRadioButton.AutoSize = true;
            this.spriteRadioButton.Location = new System.Drawing.Point(204, 28);
            this.spriteRadioButton.Name = "spriteRadioButton";
            this.spriteRadioButton.Size = new System.Drawing.Size(52, 17);
            this.spriteRadioButton.TabIndex = 0;
            this.spriteRadioButton.TabStop = true;
            this.spriteRadioButton.Text = "Sprite";
            this.spriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // mountainDewRadioButton
            // 
            this.mountainDewRadioButton.AutoSize = true;
            this.mountainDewRadioButton.Location = new System.Drawing.Point(38, 75);
            this.mountainDewRadioButton.Name = "mountainDewRadioButton";
            this.mountainDewRadioButton.Size = new System.Drawing.Size(94, 17);
            this.mountainDewRadioButton.TabIndex = 0;
            this.mountainDewRadioButton.TabStop = true;
            this.mountainDewRadioButton.Text = "Mountain Dew";
            this.mountainDewRadioButton.UseVisualStyleBackColor = true;
            // 
            // fantaRadioButton
            // 
            this.fantaRadioButton.AutoSize = true;
            this.fantaRadioButton.Location = new System.Drawing.Point(204, 75);
            this.fantaRadioButton.Name = "fantaRadioButton";
            this.fantaRadioButton.Size = new System.Drawing.Size(52, 17);
            this.fantaRadioButton.TabIndex = 0;
            this.fantaRadioButton.TabStop = true;
            this.fantaRadioButton.Text = "Fanta";
            this.fantaRadioButton.UseVisualStyleBackColor = true;
            // 
            // showBeverageButton
            // 
            this.showBeverageButton.Location = new System.Drawing.Point(400, 45);
            this.showBeverageButton.Name = "showBeverageButton";
            this.showBeverageButton.Size = new System.Drawing.Size(93, 23);
            this.showBeverageButton.TabIndex = 1;
            this.showBeverageButton.Text = "Show Item";
            this.showBeverageButton.UseVisualStyleBackColor = true;
            this.showBeverageButton.Click += new System.EventHandler(this.showBeverageButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "Food Ordering Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.Button showMainCourseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showDessertButton;
        private System.Windows.Forms.CheckBox cakeCheckBox;
        private System.Windows.Forms.CheckBox mixedFruitCheckBox;
        private System.Windows.Forms.CheckBox faludaCheckBox;
        private System.Windows.Forms.CheckBox iceCreamCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton fantaRadioButton;
        private System.Windows.Forms.RadioButton mountainDewRadioButton;
        private System.Windows.Forms.RadioButton spriteRadioButton;
        private System.Windows.Forms.RadioButton cokeRadioButton;
        private System.Windows.Forms.Button showBeverageButton;
    }
}

