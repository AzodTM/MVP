namespace MVP
{
    partial class View
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
            this.buttonShowCountObject = new System.Windows.Forms.Button();
            this.buttonShowCoordinateX = new System.Windows.Forms.Button();
            this.buttonShowCoordinateY = new System.Windows.Forms.Button();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonShowCountObject
            // 
            this.buttonShowCountObject.Location = new System.Drawing.Point(697, 28);
            this.buttonShowCountObject.Name = "buttonShowCountObject";
            this.buttonShowCountObject.Size = new System.Drawing.Size(81, 57);
            this.buttonShowCountObject.TabIndex = 0;
            this.buttonShowCountObject.Text = "Count Object";
            this.buttonShowCountObject.UseVisualStyleBackColor = true;
            this.buttonShowCountObject.Click += new System.EventHandler(this.buttonShowCountObject_Click);
            // 
            // buttonShowCoordinateX
            // 
            this.buttonShowCoordinateX.Location = new System.Drawing.Point(31, 28);
            this.buttonShowCoordinateX.Name = "buttonShowCoordinateX";
            this.buttonShowCoordinateX.Size = new System.Drawing.Size(109, 47);
            this.buttonShowCoordinateX.TabIndex = 1;
            this.buttonShowCoordinateX.Text = "Show Coordinate X";
            this.buttonShowCoordinateX.UseVisualStyleBackColor = true;
            this.buttonShowCoordinateX.Click += new System.EventHandler(this.buttonShowCoordinateX_Click);
            // 
            // buttonShowCoordinateY
            // 
            this.buttonShowCoordinateY.Location = new System.Drawing.Point(31, 90);
            this.buttonShowCoordinateY.Name = "buttonShowCoordinateY";
            this.buttonShowCoordinateY.Size = new System.Drawing.Size(109, 43);
            this.buttonShowCoordinateY.TabIndex = 2;
            this.buttonShowCoordinateY.Text = "Show Coordinate Y";
            this.buttonShowCoordinateY.UseVisualStyleBackColor = true;
            this.buttonShowCoordinateY.Click += new System.EventHandler(this.buttonShowCoordinateY_Click);
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Location = new System.Drawing.Point(189, 28);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.ReadOnly = true;
            this.richTextBoxMain.Size = new System.Drawing.Size(269, 105);
            this.richTextBoxMain.TabIndex = 3;
            this.richTextBoxMain.Text = "";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.buttonShowCoordinateY);
            this.Controls.Add(this.buttonShowCoordinateX);
            this.Controls.Add(this.buttonShowCountObject);
            this.Name = "View";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowCountObject;
        private System.Windows.Forms.Button buttonShowCoordinateX;
        private System.Windows.Forms.Button buttonShowCoordinateY;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
    }
}

