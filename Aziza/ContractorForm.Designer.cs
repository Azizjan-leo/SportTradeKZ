namespace Aziza
{
    partial class ContractorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorForm));
            this.NameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsIndContrChBx = new System.Windows.Forms.CheckBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.CodeLbl = new System.Windows.Forms.Label();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.INNTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(15, 57);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(83, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код:";
            // 
            // IsIndContrChBx
            // 
            this.IsIndContrChBx.AutoSize = true;
            this.IsIndContrChBx.Checked = true;
            this.IsIndContrChBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsIndContrChBx.Location = new System.Drawing.Point(18, 31);
            this.IsIndContrChBx.Name = "IsIndContrChBx";
            this.IsIndContrChBx.Size = new System.Drawing.Size(79, 17);
            this.IsIndContrChBx.TabIndex = 4;
            this.IsIndContrChBx.Text = "Физ. лицо";
            this.IsIndContrChBx.UseVisualStyleBackColor = true;
            this.IsIndContrChBx.CheckedChanged += new System.EventHandler(this.IsIndContrChBx_CheckedChanged);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(15, 73);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(255, 20);
            this.NameTxt.TabIndex = 5;
            // 
            // CodeLbl
            // 
            this.CodeLbl.AutoSize = true;
            this.CodeLbl.Location = new System.Drawing.Point(47, 9);
            this.CodeLbl.Name = "CodeLbl";
            this.CodeLbl.Size = new System.Drawing.Size(0, 13);
            this.CodeLbl.TabIndex = 6;
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(15, 118);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(255, 20);
            this.FullNameTxt.TabIndex = 8;
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(15, 102);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(122, 13);
            this.FullNameLbl.TabIndex = 7;
            this.FullNameLbl.Text = "Полное наименование";
            // 
            // INNTxt
            // 
            this.INNTxt.Location = new System.Drawing.Point(15, 166);
            this.INNTxt.Name = "INNTxt";
            this.INNTxt.Size = new System.Drawing.Size(255, 20);
            this.INNTxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ИНН";
            // 
            // ContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.INNTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullNameTxt);
            this.Controls.Add(this.FullNameLbl);
            this.Controls.Add(this.CodeLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.IsIndContrChBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContractorForm";
            this.Text = "Contractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox IsIndContrChBx;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label CodeLbl;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.TextBox INNTxt;
        private System.Windows.Forms.Label label1;
    }
}