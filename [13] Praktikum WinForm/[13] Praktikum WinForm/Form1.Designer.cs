
namespace _13__Praktikum_WinForm
{
    partial class FormPengaturanWarna
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
            this.labelInputData = new System.Windows.Forms.Label();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelProses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(79, 43);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(89, 20);
            this.labelInputData.TabIndex = 0;
            this.labelInputData.Text = "Input Data:";
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Location = new System.Drawing.Point(83, 83);
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(420, 26);
            this.textBoxInputData.TabIndex = 1;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(83, 126);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(85, 27);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelProses
            // 
            this.labelProses.AutoSize = true;
            this.labelProses.Location = new System.Drawing.Point(83, 242);
            this.labelProses.Name = "labelProses";
            this.labelProses.Size = new System.Drawing.Size(71, 20);
            this.labelProses.TabIndex = 3;
            this.labelProses.Text = "[EMPTY]";
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProses);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxInputData);
            this.Controls.Add(this.labelInputData);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelProses;
    }
}

