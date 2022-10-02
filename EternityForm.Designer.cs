namespace CleanSlateProtocol
{
    partial class EternityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EternityForm));
            this.labelCodePhrase = new System.Windows.Forms.Label();
            this.codesGroup = new System.Windows.Forms.GroupBox();
            this.codePhraseTextBox = new System.Windows.Forms.TextBox();
            this.labelCodePhraseApocalypse = new System.Windows.Forms.Label();
            this.codePhraseApocalypse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodePhrase
            // 
            this.labelCodePhrase.AutoSize = true;
            this.labelCodePhrase.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelCodePhrase.Location = new System.Drawing.Point(6, 19);
            this.labelCodePhrase.Name = "labelCodePhrase";
            this.labelCodePhrase.Size = new System.Drawing.Size(333, 21);
            this.labelCodePhrase.TabIndex = 0;
            this.labelCodePhrase.Text = "Кодовая фраза для вывода окна настроек";
            // 
            // codesGroup
            // 
            this.codesGroup.Controls.Add(this.label1);
            this.codesGroup.Controls.Add(this.codePhraseApocalypse);
            this.codesGroup.Controls.Add(this.labelCodePhraseApocalypse);
            this.codesGroup.Controls.Add(this.codePhraseTextBox);
            this.codesGroup.Controls.Add(this.labelCodePhrase);
            this.codesGroup.Location = new System.Drawing.Point(16, 12);
            this.codesGroup.Name = "codesGroup";
            this.codesGroup.Size = new System.Drawing.Size(398, 267);
            this.codesGroup.TabIndex = 1;
            this.codesGroup.TabStop = false;
            this.codesGroup.Text = "Кодификация";
            // 
            // codePhraseTextBox
            // 
            this.codePhraseTextBox.Location = new System.Drawing.Point(10, 47);
            this.codePhraseTextBox.Name = "codePhraseTextBox";
            this.codePhraseTextBox.Size = new System.Drawing.Size(325, 20);
            this.codePhraseTextBox.TabIndex = 1;
            // 
            // labelCodePhraseApocalypse
            // 
            this.labelCodePhraseApocalypse.AutoSize = true;
            this.labelCodePhraseApocalypse.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelCodePhraseApocalypse.Location = new System.Drawing.Point(6, 82);
            this.labelCodePhraseApocalypse.Name = "labelCodePhraseApocalypse";
            this.labelCodePhraseApocalypse.Size = new System.Drawing.Size(385, 21);
            this.labelCodePhraseApocalypse.TabIndex = 2;
            this.labelCodePhraseApocalypse.Text = "Кодовая фраза для выполнения скрипта очистки";
            // 
            // codePhraseApocalypse
            // 
            this.codePhraseApocalypse.Location = new System.Drawing.Point(10, 135);
            this.codePhraseApocalypse.Name = "codePhraseApocalypse";
            this.codePhraseApocalypse.Size = new System.Drawing.Size(325, 20);
            this.codePhraseApocalypse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Временно поддерживается только английский язык";
            // 
            // EternityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codesGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EternityForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EternityForm_FormClosing);
            this.Load += new System.EventHandler(this.EternityForm_Load);
            this.codesGroup.ResumeLayout(false);
            this.codesGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCodePhrase;
        private System.Windows.Forms.GroupBox codesGroup;
        private System.Windows.Forms.TextBox codePhraseTextBox;
        private System.Windows.Forms.TextBox codePhraseApocalypse;
        private System.Windows.Forms.Label labelCodePhraseApocalypse;
        private System.Windows.Forms.Label label1;
    }
}