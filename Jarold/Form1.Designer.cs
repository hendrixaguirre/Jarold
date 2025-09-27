namespace Jarold
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBfriends = new System.Windows.Forms.Label();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbJaños = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(61, 78);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 13);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "Sexo:";
            // 
            // lblBfriends
            // 
            this.lblBfriends.AutoSize = true;
            this.lblBfriends.Location = new System.Drawing.Point(64, 112);
            this.lblBfriends.Name = "lblBfriends";
            this.lblBfriends.Size = new System.Drawing.Size(38, 13);
            this.lblBfriends.TabIndex = 1;
            this.lblBfriends.Text = "Jaños:";
            // 
            // tbSex
            // 
            this.tbSex.BackColor = System.Drawing.SystemColors.Window;
            this.tbSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSex.Location = new System.Drawing.Point(101, 75);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(139, 20);
            this.tbSex.TabIndex = 2;
            this.tbSex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbJaños
            // 
            this.tbJaños.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbJaños.Location = new System.Drawing.Point(101, 109);
            this.tbJaños.Name = "tbJaños";
            this.tbJaños.Size = new System.Drawing.Size(139, 20);
            this.tbJaños.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(168, 149);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(97, 34);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbJaños);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.lblBfriends);
            this.Controls.Add(this.lblSex);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jarold";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBfriends;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbJaños;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}

