
namespace lesson_9
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
            this.textBoxOne = new System.Windows.Forms.TextBox();
            this.textBoxTwo = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxArithmetic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOne
            // 
            this.textBoxOne.Location = new System.Drawing.Point(106, 89);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(100, 20);
            this.textBoxOne.TabIndex = 0;
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.Location = new System.Drawing.Point(339, 90);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(464, 91);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // comboBoxArithmetic
            // 
            this.comboBoxArithmetic.FormattingEnabled = true;
            this.comboBoxArithmetic.Items.AddRange(new object[] {
            "Сложить",
            "Вычесть",
            "Умножить",
            "Разделить"});
            this.comboBoxArithmetic.Location = new System.Drawing.Point(228, 89);
            this.comboBoxArithmetic.Name = "comboBoxArithmetic";
            this.comboBoxArithmetic.Size = new System.Drawing.Size(94, 21);
            this.comboBoxArithmetic.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(464, 138);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 27);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 254);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArithmetic);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOne;
        private System.Windows.Forms.TextBox textBoxTwo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxArithmetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
    }
}

