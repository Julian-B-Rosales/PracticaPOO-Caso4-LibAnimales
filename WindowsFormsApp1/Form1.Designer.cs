namespace WindowsFormsApp1
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
            this.btnAgregarLeon = new System.Windows.Forms.Button();
            this.btnAgregarConejo = new System.Windows.Forms.Button();
            this.btnAgregarLoro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarLeon
            // 
            this.btnAgregarLeon.Location = new System.Drawing.Point(297, 67);
            this.btnAgregarLeon.Name = "btnAgregarLeon";
            this.btnAgregarLeon.Size = new System.Drawing.Size(136, 62);
            this.btnAgregarLeon.TabIndex = 0;
            this.btnAgregarLeon.Text = "Agregar Leon";
            this.btnAgregarLeon.UseVisualStyleBackColor = true;
            this.btnAgregarLeon.Click += new System.EventHandler(this.btnAgregarLeon_Click);
            // 
            // btnAgregarConejo
            // 
            this.btnAgregarConejo.Location = new System.Drawing.Point(305, 171);
            this.btnAgregarConejo.Name = "btnAgregarConejo";
            this.btnAgregarConejo.Size = new System.Drawing.Size(127, 61);
            this.btnAgregarConejo.TabIndex = 1;
            this.btnAgregarConejo.Text = "Agregar Conejo";
            this.btnAgregarConejo.UseVisualStyleBackColor = true;
            this.btnAgregarConejo.Click += new System.EventHandler(this.btnAgregarConejo_Click);
            // 
            // btnAgregarLoro
            // 
            this.btnAgregarLoro.Location = new System.Drawing.Point(295, 277);
            this.btnAgregarLoro.Name = "btnAgregarLoro";
            this.btnAgregarLoro.Size = new System.Drawing.Size(137, 61);
            this.btnAgregarLoro.TabIndex = 2;
            this.btnAgregarLoro.Text = "Agregar Loro";
            this.btnAgregarLoro.UseVisualStyleBackColor = true;
            this.btnAgregarLoro.Click += new System.EventHandler(this.btnAgregarLoro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarLoro);
            this.Controls.Add(this.btnAgregarConejo);
            this.Controls.Add(this.btnAgregarLeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLeon;
        private System.Windows.Forms.Button btnAgregarConejo;
        private System.Windows.Forms.Button btnAgregarLoro;
    }
}

