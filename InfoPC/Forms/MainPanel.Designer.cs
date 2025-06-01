namespace InfoPC
{
    partial class MainPanel
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
            this.collectButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // collectButton
            // 
            this.collectButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.collectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collectButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.collectButton.Location = new System.Drawing.Point(88, 19);
            this.collectButton.Name = "collectButton";
            this.collectButton.Size = new System.Drawing.Size(244, 54);
            this.collectButton.TabIndex = 0;
            this.collectButton.Text = "СОБРАТЬ ИНФОРМАЦИЮ";
            this.collectButton.UseVisualStyleBackColor = false;
            this.collectButton.Click += new System.EventHandler(this.collectButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(88, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 53);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "СОХРАНИТЬ В ФАЙЛ";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.collectButton);
            this.panel1.Location = new System.Drawing.Point(833, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 178);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Системный сборщик";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(833, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "ГРАФИК ДОСТУПНОЙ ПАМЯТИ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(833, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(446, 73);
            this.button3.TabIndex = 6;
            this.button3.Text = "ГРАФИК ЗАГРУЖЕННОСТИ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextBox.Location = new System.Drawing.Point(12, 49);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(791, 695);
            this.InfoTextBox.TabIndex = 7;
            this.InfoTextBox.Text = "";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1367, 775);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сбор информации";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button collectButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox InfoTextBox;
    }
}

