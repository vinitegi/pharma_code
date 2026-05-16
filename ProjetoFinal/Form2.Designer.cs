namespace ProjetoFinal
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCateg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(281, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PharmaCode";
            // 
            // btnCateg
            // 
            this.btnCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCateg.Location = new System.Drawing.Point(245, 123);
            this.btnCateg.Name = "btnCateg";
            this.btnCateg.Size = new System.Drawing.Size(298, 58);
            this.btnCateg.TabIndex = 1;
            this.btnCateg.Text = "Cadastro de categoria";
            this.btnCateg.UseVisualStyleBackColor = true;
            this.btnCateg.Click += new System.EventHandler(this.btnCateg_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(245, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cadastro de remédio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCateg);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "PharmaCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCateg;
        private System.Windows.Forms.Button button2;
    }
}