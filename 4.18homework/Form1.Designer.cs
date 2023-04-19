
namespace _4._18homework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtk1 = new System.Windows.Forms.Button();
            this.btnDef1 = new System.Windows.Forms.Button();
            this.btnAtk2 = new System.Windows.Forms.Button();
            this.btnDef2 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtk1
            // 
            this.btnAtk1.Location = new System.Drawing.Point(155, 192);
            this.btnAtk1.Name = "btnAtk1";
            this.btnAtk1.Size = new System.Drawing.Size(196, 63);
            this.btnAtk1.TabIndex = 0;
            this.btnAtk1.Text = "Player1攻撃";
            this.btnAtk1.UseVisualStyleBackColor = true;
            this.btnAtk1.Click += new System.EventHandler(this.btnAtk1_Click);
            // 
            // btnDef1
            // 
            this.btnDef1.Location = new System.Drawing.Point(395, 192);
            this.btnDef1.Name = "btnDef1";
            this.btnDef1.Size = new System.Drawing.Size(196, 63);
            this.btnDef1.TabIndex = 1;
            this.btnDef1.Text = "Player1防御";
            this.btnDef1.UseVisualStyleBackColor = true;
            this.btnDef1.Click += new System.EventHandler(this.btnDef1_Click);
            // 
            // btnAtk2
            // 
            this.btnAtk2.Location = new System.Drawing.Point(155, 300);
            this.btnAtk2.Name = "btnAtk2";
            this.btnAtk2.Size = new System.Drawing.Size(196, 63);
            this.btnAtk2.TabIndex = 2;
            this.btnAtk2.Text = "Player2攻撃";
            this.btnAtk2.UseVisualStyleBackColor = true;
            this.btnAtk2.Click += new System.EventHandler(this.btnAtk2_Click);
            // 
            // btnDef2
            // 
            this.btnDef2.Location = new System.Drawing.Point(395, 300);
            this.btnDef2.Name = "btnDef2";
            this.btnDef2.Size = new System.Drawing.Size(196, 63);
            this.btnDef2.TabIndex = 3;
            this.btnDef2.Text = "Player2防御";
            this.btnDef2.UseVisualStyleBackColor = true;
            this.btnDef2.Click += new System.EventHandler(this.btnDef2_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(155, 107);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(445, 31);
            this.txtResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDef2);
            this.Controls.Add(this.btnAtk2);
            this.Controls.Add(this.btnDef1);
            this.Controls.Add(this.btnAtk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtk1;
        private System.Windows.Forms.Button btnDef1;
        private System.Windows.Forms.Button btnAtk2;
        private System.Windows.Forms.Button btnDef2;
        private System.Windows.Forms.TextBox txtResult;
    }
}

