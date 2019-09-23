namespace TBDatos
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
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_direction = new System.Windows.Forms.TextBox();
            this.rxt_content = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(392, 236);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(91, 43);
            this.btn_write.TabIndex = 0;
            this.btn_write.Text = "Escribir";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.Btn_write_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(392, 294);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(91, 38);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Leer";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.Btn_read_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(392, 21);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 39);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Abrir";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(392, 81);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 39);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección";
            // 
            // txt_direction
            // 
            this.txt_direction.Location = new System.Drawing.Point(87, 43);
            this.txt_direction.Name = "txt_direction";
            this.txt_direction.Size = new System.Drawing.Size(210, 20);
            this.txt_direction.TabIndex = 5;
            // 
            // rxt_content
            // 
            this.rxt_content.Location = new System.Drawing.Point(32, 85);
            this.rxt_content.Name = "rxt_content";
            this.rxt_content.Size = new System.Drawing.Size(315, 194);
            this.rxt_content.TabIndex = 6;
            this.rxt_content.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 344);
            this.Controls.Add(this.rxt_content);
            this.Controls.Add(this.txt_direction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_direction;
        private System.Windows.Forms.RichTextBox rxt_content;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

