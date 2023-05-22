
namespace LABA_24_OOP
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
            this.StartM1 = new System.Windows.Forms.Button();
            this.StopM1 = new System.Windows.Forms.Button();
            this.txtEncryptedNumbers = new System.Windows.Forms.TextBox();
            this.StartM2 = new System.Windows.Forms.Button();
            this.StopM2 = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.StartM3 = new System.Windows.Forms.Button();
            this.txtGenerateNumbers = new System.Windows.Forms.TextBox();
            this.StopM3 = new System.Windows.Forms.Button();
            this.StartAll = new System.Windows.Forms.Button();
            this.StopAll = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartM1
            // 
            this.StartM1.Location = new System.Drawing.Point(42, 233);
            this.StartM1.Name = "StartM1";
            this.StartM1.Size = new System.Drawing.Size(233, 45);
            this.StartM1.TabIndex = 1;
            this.StartM1.Text = "Запустити метод 1";
            this.StartM1.UseVisualStyleBackColor = true;
            this.StartM1.Click += new System.EventHandler(this.StartM1_Click);
            // 
            // StopM1
            // 
            this.StopM1.Location = new System.Drawing.Point(42, 284);
            this.StopM1.Name = "StopM1";
            this.StopM1.Size = new System.Drawing.Size(233, 45);
            this.StopM1.TabIndex = 2;
            this.StopM1.Text = "Зупинити метод 1";
            this.StopM1.UseVisualStyleBackColor = true;
            this.StopM1.Click += new System.EventHandler(this.StopM1_Click);
            // 
            // txtEncryptedNumbers
            // 
            this.txtEncryptedNumbers.Location = new System.Drawing.Point(42, 48);
            this.txtEncryptedNumbers.Name = "txtEncryptedNumbers";
            this.txtEncryptedNumbers.Size = new System.Drawing.Size(233, 22);
            this.txtEncryptedNumbers.TabIndex = 3;
            // 
            // StartM2
            // 
            this.StartM2.Location = new System.Drawing.Point(394, 233);
            this.StartM2.Name = "StartM2";
            this.StartM2.Size = new System.Drawing.Size(321, 45);
            this.StartM2.TabIndex = 4;
            this.StartM2.Text = "Запустити метод 2";
            this.StartM2.UseVisualStyleBackColor = true;
            this.StartM2.Click += new System.EventHandler(this.StartM2_Click);
            // 
            // StopM2
            // 
            this.StopM2.Location = new System.Drawing.Point(394, 284);
            this.StopM2.Name = "StopM2";
            this.StopM2.Size = new System.Drawing.Size(321, 45);
            this.StopM2.TabIndex = 5;
            this.StopM2.Text = "Зупинити метод 2";
            this.StopM2.UseVisualStyleBackColor = true;
            this.StopM2.Click += new System.EventHandler(this.StopM2_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(394, 48);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(321, 22);
            this.txtHash.TabIndex = 6;
            // 
            // StartM3
            // 
            this.StartM3.Location = new System.Drawing.Point(829, 233);
            this.StartM3.Name = "StartM3";
            this.StartM3.Size = new System.Drawing.Size(324, 45);
            this.StartM3.TabIndex = 7;
            this.StartM3.Text = "Запустити метод 3";
            this.StartM3.UseVisualStyleBackColor = true;
            this.StartM3.Click += new System.EventHandler(this.StartM3_Click);
            // 
            // txtGenerateNumbers
            // 
            this.txtGenerateNumbers.Location = new System.Drawing.Point(829, 48);
            this.txtGenerateNumbers.Name = "txtGenerateNumbers";
            this.txtGenerateNumbers.Size = new System.Drawing.Size(324, 22);
            this.txtGenerateNumbers.TabIndex = 8;
            // 
            // StopM3
            // 
            this.StopM3.Location = new System.Drawing.Point(829, 284);
            this.StopM3.Name = "StopM3";
            this.StopM3.Size = new System.Drawing.Size(324, 45);
            this.StopM3.TabIndex = 9;
            this.StopM3.Text = "Зупинити метод 3";
            this.StopM3.UseVisualStyleBackColor = true;
            this.StopM3.Click += new System.EventHandler(this.StopM3_Click);
            // 
            // StartAll
            // 
            this.StartAll.Location = new System.Drawing.Point(394, 445);
            this.StartAll.Name = "StartAll";
            this.StartAll.Size = new System.Drawing.Size(321, 60);
            this.StartAll.TabIndex = 10;
            this.StartAll.Text = "Запустити всі методи";
            this.StartAll.UseVisualStyleBackColor = true;
            this.StartAll.Click += new System.EventHandler(this.StartAll_Click);
            // 
            // StopAll
            // 
            this.StopAll.Location = new System.Drawing.Point(394, 511);
            this.StopAll.Name = "StopAll";
            this.StopAll.Size = new System.Drawing.Size(321, 70);
            this.StopAll.TabIndex = 11;
            this.StopAll.Text = "Зупинити всі методи";
            this.StopAll.UseVisualStyleBackColor = true;
            this.StopAll.Click += new System.EventHandler(this.StopAll_Click);
            // 
            // Task
            // 
            this.Task.Location = new System.Drawing.Point(1334, 0);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(128, 70);
            this.Task.TabIndex = 12;
            this.Task.Text = "Завдання";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 623);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.StopAll);
            this.Controls.Add(this.StartAll);
            this.Controls.Add(this.StopM3);
            this.Controls.Add(this.txtGenerateNumbers);
            this.Controls.Add(this.StartM3);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.StopM2);
            this.Controls.Add(this.StartM2);
            this.Controls.Add(this.txtEncryptedNumbers);
            this.Controls.Add(this.StopM1);
            this.Controls.Add(this.StartM1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartM1;
        private System.Windows.Forms.Button StopM1;
        private System.Windows.Forms.TextBox txtEncryptedNumbers;
        private System.Windows.Forms.Button StartM2;
        private System.Windows.Forms.Button StopM2;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button StartM3;
        private System.Windows.Forms.TextBox txtGenerateNumbers;
        private System.Windows.Forms.Button StopM3;
        private System.Windows.Forms.Button StartAll;
        private System.Windows.Forms.Button StopAll;
        private System.Windows.Forms.Button Task;
    }
}

