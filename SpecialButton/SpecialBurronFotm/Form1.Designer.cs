namespace SpecialBurronFotm
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
            this.MyButton1 = new SpecialButton.SpecialButton();
            this.SuspendLayout();
            // 
            // MyButton1
            // 
            this.MyButton1.BackColor = System.Drawing.Color.Gray;
            this.MyButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MyButton1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.MyButton1.ForeColor = System.Drawing.Color.White;
            this.MyButton1.Location = new System.Drawing.Point(280, 209);
            this.MyButton1.Margin = new System.Windows.Forms.Padding(4, 1, 1, 0);
            this.MyButton1.MinimumSize = new System.Drawing.Size(150, 35);
            this.MyButton1.Name = "MyButton1";
            this.MyButton1.Padding = new System.Windows.Forms.Padding(4);
            this.MyButton1.Size = new System.Drawing.Size(195, 74);
            this.MyButton1.TabIndex = 0;
            this.MyButton1.Text = "Кнопка";
            this.MyButton1.UseVisualStyleBackColor = false;
            this.MyButton1.Click += new System.EventHandler(this.MyButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 492);
            this.Controls.Add(this.MyButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SpecialButton.SpecialButton MyButton1;
    }
}

