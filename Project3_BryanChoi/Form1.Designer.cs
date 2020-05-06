namespace Project3_BryanChoi
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.rbOneScoop = new System.Windows.Forms.RadioButton();
            this.rbTwoScoops = new System.Windows.Forms.RadioButton();
            this.rbThreeScoops = new System.Windows.Forms.RadioButton();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFlavors = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGummyWorms = new System.Windows.Forms.CheckBox();
            this.cbCherrySyrup = new System.Windows.Forms.CheckBox();
            this.cbChocolateChips = new System.Windows.Forms.CheckBox();
            this.cbOreos = new System.Windows.Forms.CheckBox();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(288, 250);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // rbOneScoop
            // 
            this.rbOneScoop.AutoSize = true;
            this.rbOneScoop.Checked = true;
            this.rbOneScoop.Location = new System.Drawing.Point(21, 32);
            this.rbOneScoop.Name = "rbOneScoop";
            this.rbOneScoop.Size = new System.Drawing.Size(65, 17);
            this.rbOneScoop.TabIndex = 0;
            this.rbOneScoop.TabStop = true;
            this.rbOneScoop.Text = "1 Scoop";
            this.rbOneScoop.UseVisualStyleBackColor = true;
            this.rbOneScoop.CheckedChanged += new System.EventHandler(this.rbOneScoop_CheckedChanged);
            // 
            // rbTwoScoops
            // 
            this.rbTwoScoops.AutoSize = true;
            this.rbTwoScoops.Location = new System.Drawing.Point(21, 55);
            this.rbTwoScoops.Name = "rbTwoScoops";
            this.rbTwoScoops.Size = new System.Drawing.Size(70, 17);
            this.rbTwoScoops.TabIndex = 1;
            this.rbTwoScoops.Text = "2 Scoops";
            this.rbTwoScoops.UseVisualStyleBackColor = true;
            this.rbTwoScoops.CheckedChanged += new System.EventHandler(this.rbTwoScoops_CheckedChanged);
            // 
            // rbThreeScoops
            // 
            this.rbThreeScoops.AutoSize = true;
            this.rbThreeScoops.Location = new System.Drawing.Point(21, 78);
            this.rbThreeScoops.Name = "rbThreeScoops";
            this.rbThreeScoops.Size = new System.Drawing.Size(70, 17);
            this.rbThreeScoops.TabIndex = 2;
            this.rbThreeScoops.Text = "3 Scoops";
            this.rbThreeScoops.UseVisualStyleBackColor = true;
            this.rbThreeScoops.CheckedChanged += new System.EventHandler(this.rbThreeScoops_CheckedChanged);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(99, 292);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPrintOrder.TabIndex = 7;
            this.btnPrintOrder.Text = "Print Order";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flavors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scoops:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Topping:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "$1.00/scoop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "$.50/topping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // lbFlavors
            // 
            this.lbFlavors.FormattingEnabled = true;
            this.lbFlavors.Items.AddRange(new object[] {
            "Chocolate",
            "Vanilla",
            "Cookie Dough",
            "Strawberry",
            "Mint Chip",
            "Mocha",
            "Cookies n Cream"});
            this.lbFlavors.Location = new System.Drawing.Point(22, 70);
            this.lbFlavors.Name = "lbFlavors";
            this.lbFlavors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFlavors.Size = new System.Drawing.Size(104, 134);
            this.lbFlavors.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOneScoop);
            this.groupBox1.Controls.Add(this.rbTwoScoops);
            this.groupBox1.Controls.Add(this.rbThreeScoops);
            this.groupBox1.Location = new System.Drawing.Point(143, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGummyWorms);
            this.groupBox2.Controls.Add(this.cbCherrySyrup);
            this.groupBox2.Controls.Add(this.cbChocolateChips);
            this.groupBox2.Controls.Add(this.cbOreos);
            this.groupBox2.Controls.Add(this.cbSprinkles);
            this.groupBox2.Location = new System.Drawing.Point(258, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cbGummyWorms
            // 
            this.cbGummyWorms.AutoSize = true;
            this.cbGummyWorms.Location = new System.Drawing.Point(20, 110);
            this.cbGummyWorms.Name = "cbGummyWorms";
            this.cbGummyWorms.Size = new System.Drawing.Size(97, 17);
            this.cbGummyWorms.TabIndex = 4;
            this.cbGummyWorms.Text = "Gummy Worms";
            this.cbGummyWorms.UseVisualStyleBackColor = true;
            this.cbGummyWorms.CheckedChanged += new System.EventHandler(this.cbGummyWorms_CheckedChanged);
            // 
            // cbCherrySyrup
            // 
            this.cbCherrySyrup.AutoSize = true;
            this.cbCherrySyrup.Location = new System.Drawing.Point(20, 87);
            this.cbCherrySyrup.Name = "cbCherrySyrup";
            this.cbCherrySyrup.Size = new System.Drawing.Size(86, 17);
            this.cbCherrySyrup.TabIndex = 3;
            this.cbCherrySyrup.Text = "Cherry Syrup";
            this.cbCherrySyrup.UseVisualStyleBackColor = true;
            this.cbCherrySyrup.CheckedChanged += new System.EventHandler(this.cbCherrySyrup_CheckedChanged);
            // 
            // cbChocolateChips
            // 
            this.cbChocolateChips.AutoSize = true;
            this.cbChocolateChips.Location = new System.Drawing.Point(20, 64);
            this.cbChocolateChips.Name = "cbChocolateChips";
            this.cbChocolateChips.Size = new System.Drawing.Size(103, 17);
            this.cbChocolateChips.TabIndex = 2;
            this.cbChocolateChips.Text = "Chocolate Chips";
            this.cbChocolateChips.UseVisualStyleBackColor = true;
            this.cbChocolateChips.CheckedChanged += new System.EventHandler(this.cbChocolateChips_CheckedChanged);
            // 
            // cbOreos
            // 
            this.cbOreos.AutoSize = true;
            this.cbOreos.Location = new System.Drawing.Point(20, 41);
            this.cbOreos.Name = "cbOreos";
            this.cbOreos.Size = new System.Drawing.Size(54, 17);
            this.cbOreos.TabIndex = 1;
            this.cbOreos.Text = "Oreos";
            this.cbOreos.UseVisualStyleBackColor = true;
            this.cbOreos.CheckedChanged += new System.EventHandler(this.cbOreos_CheckedChanged);
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(20, 19);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(69, 17);
            this.cbSprinkles.TabIndex = 0;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            this.cbSprinkles.CheckedChanged += new System.EventHandler(this.cbSprinkles_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFlavors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.txtTotal);
            this.Name = "Form1";
            this.Text = "Ice Cream Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rbOneScoop;
        private System.Windows.Forms.RadioButton rbTwoScoops;
        private System.Windows.Forms.RadioButton rbThreeScoops;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbFlavors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbGummyWorms;
        private System.Windows.Forms.CheckBox cbCherrySyrup;
        private System.Windows.Forms.CheckBox cbChocolateChips;
        private System.Windows.Forms.CheckBox cbOreos;
        private System.Windows.Forms.CheckBox cbSprinkles;
    }
}

