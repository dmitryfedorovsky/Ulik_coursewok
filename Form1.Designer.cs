namespace Ulik_coursewok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buildbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildbutton
            // 
            this.buildbutton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buildbutton.Location = new System.Drawing.Point(53, 44);
            this.buildbutton.Name = "buildbutton";
            this.buildbutton.Size = new System.Drawing.Size(204, 126);
            this.buildbutton.TabIndex = 0;
            this.buildbutton.Text = "Построить";
            this.buildbutton.UseVisualStyleBackColor = true;
            this.buildbutton.UseWaitCursor = true;
            this.buildbutton.Click += new System.EventHandler(this.Buildbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 226);
            this.Controls.Add(this.buildbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Труба";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildbutton;
    }
}

