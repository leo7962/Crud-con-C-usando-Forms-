namespace TBConexionBD
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.lb_country = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.datagr_query = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_NID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_name_update = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagr_query)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(57, 28);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(270, 52);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Conectarse";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.Btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(57, 96);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(270, 51);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Desconectarse";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.Btn_disconnect_Click);
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(57, 167);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(270, 52);
            this.btn_query.TabIndex = 2;
            this.btn_query.Text = "Consultar";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.Btn_query_Click);
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Location = new System.Drawing.Point(54, 259);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(27, 13);
            this.lb_country.TabIndex = 3;
            this.lb_country.Text = "Pais";
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(57, 290);
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(270, 20);
            this.txt_query.TabIndex = 4;
            // 
            // datagr_query
            // 
            this.datagr_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagr_query.Location = new System.Drawing.Point(361, 28);
            this.datagr_query.Name = "datagr_query";
            this.datagr_query.Size = new System.Drawing.Size(708, 445);
            this.datagr_query.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(47, 507);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(270, 48);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(562, 535);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(707, 535);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 8;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(832, 535);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(100, 20);
            this.txt_country.TabIndex = 9;
            // 
            // txt_NID
            // 
            this.txt_NID.Location = new System.Drawing.Point(969, 535);
            this.txt_NID.Name = "txt_NID";
            this.txt_NID.Size = new System.Drawing.Size(100, 20);
            this.txt_NID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(966, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "NID";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(57, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(260, 48);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(57, 431);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(260, 42);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Borrar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // txt_name_update
            // 
            this.txt_name_update.Location = new System.Drawing.Point(361, 535);
            this.txt_name_update.Name = "txt_name_update";
            this.txt_name_update.Size = new System.Drawing.Size(126, 20);
            this.txt_name_update.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre a actualizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NID);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.datagr_query);
            this.Controls.Add(this.txt_query);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagr_query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.DataGridView datagr_query;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_NID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_name_update;
        private System.Windows.Forms.Label label5;
    }
}

