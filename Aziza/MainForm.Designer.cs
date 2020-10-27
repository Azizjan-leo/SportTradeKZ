namespace Aziza
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddContractorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddContractorBtn
            // 
            this.AddContractorBtn.Location = new System.Drawing.Point(669, 13);
            this.AddContractorBtn.Name = "AddContractorBtn";
            this.AddContractorBtn.Size = new System.Drawing.Size(112, 23);
            this.AddContractorBtn.TabIndex = 0;
            this.AddContractorBtn.Text = "Новый контрагент";
            this.AddContractorBtn.UseVisualStyleBackColor = true;
            this.AddContractorBtn.Click += new System.EventHandler(this.AddContractorBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddContractorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Aziza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddContractorBtn;
    }
}

