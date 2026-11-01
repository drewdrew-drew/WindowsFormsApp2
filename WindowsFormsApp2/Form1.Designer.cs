namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.userControl12 = new WindowsFormsApp2.FolderforModel.UserControl1();
            this.userControl11 = new WindowsFormsApp2.FolderforModel.UserControl1();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(24, 12);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 74);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(1246, 56);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 74);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click_1);
            // 
            // userControl12
            // 
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.userControl12.Location = new System.Drawing.Point(653, 22);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(587, 518);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.userControl11.Location = new System.Drawing.Point(105, 22);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(629, 518);
            this.userControl11.TabIndex = 0;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(532, 621);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrand.TabIndex = 4;
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(782, 671);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceMin.TabIndex = 5;
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(952, 671);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceMax.TabIndex = 6;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(500, 722);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 7;
            this.buttonFilter.Text = "fl";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(659, 722);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "r";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 786);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMin);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderforModel.UserControl1 userControl11;
        private FolderforModel.UserControl1 userControl12;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonReset;
    }
}

