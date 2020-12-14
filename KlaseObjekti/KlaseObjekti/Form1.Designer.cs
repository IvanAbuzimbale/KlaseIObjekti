namespace KlaseObjekti
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
            this.Unos_String = new System.Windows.Forms.TextBox();
            this.UnosInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UnesiBtn = new System.Windows.Forms.Button();
            this.Ispišibtn = new System.Windows.Forms.Button();
            this.rtxIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Unos_String
            // 
            this.Unos_String.Location = new System.Drawing.Point(27, 36);
            this.Unos_String.Name = "Unos_String";
            this.Unos_String.Size = new System.Drawing.Size(100, 20);
            this.Unos_String.TabIndex = 0;
            // 
            // UnosInt
            // 
            this.UnosInt.Location = new System.Drawing.Point(27, 90);
            this.UnosInt.Name = "UnosInt";
            this.UnosInt.Size = new System.Drawing.Size(100, 20);
            this.UnosInt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unos Int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unos string";
            // 
            // UnesiBtn
            // 
            this.UnesiBtn.Location = new System.Drawing.Point(194, 32);
            this.UnesiBtn.Name = "UnesiBtn";
            this.UnesiBtn.Size = new System.Drawing.Size(75, 23);
            this.UnesiBtn.TabIndex = 4;
            this.UnesiBtn.Text = "Unesi";
            this.UnesiBtn.UseVisualStyleBackColor = true;
            this.UnesiBtn.Click += new System.EventHandler(this.UnesiBtn_Click);
            // 
            // Ispišibtn
            // 
            this.Ispišibtn.Location = new System.Drawing.Point(194, 86);
            this.Ispišibtn.Name = "Ispišibtn";
            this.Ispišibtn.Size = new System.Drawing.Size(75, 23);
            this.Ispišibtn.TabIndex = 5;
            this.Ispišibtn.Text = "Ispiši";
            this.Ispišibtn.UseVisualStyleBackColor = true;
            // 
            // rtxIspis
            // 
            this.rtxIspis.Location = new System.Drawing.Point(30, 144);
            this.rtxIspis.Name = "rtxIspis";
            this.rtxIspis.Size = new System.Drawing.Size(239, 182);
            this.rtxIspis.TabIndex = 6;
            this.rtxIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxIspis);
            this.Controls.Add(this.Ispišibtn);
            this.Controls.Add(this.UnesiBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosInt);
            this.Controls.Add(this.Unos_String);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Unos_String;
        private System.Windows.Forms.TextBox UnosInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UnesiBtn;
        private System.Windows.Forms.Button Ispišibtn;
        private System.Windows.Forms.RichTextBox rtxIspis;
    }
}

