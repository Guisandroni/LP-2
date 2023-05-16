namespace Pontuacao
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
            this.btnExec = new System.Windows.Forms.Button();
            this.lbxsaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(170, 71);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(206, 168);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbxsaida
            // 
            this.lbxsaida.FormattingEnabled = true;
            this.lbxsaida.Location = new System.Drawing.Point(462, 56);
            this.lbxsaida.Name = "lbxsaida";
            this.lbxsaida.Size = new System.Drawing.Size(298, 251);
            this.lbxsaida.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxsaida);
            this.Controls.Add(this.btnExec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ListBox lbxsaida;
    }
}

