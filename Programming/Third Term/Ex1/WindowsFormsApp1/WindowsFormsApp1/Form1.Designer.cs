﻿namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowLastTeacher = new System.Windows.Forms.Button();
            this.btnShowNextTeacher = new System.Windows.Forms.Button();
            this.btnShowPreviousTeacher = new System.Windows.Forms.Button();
            this.btnShowFirstTeacher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEntryNumber = new System.Windows.Forms.Label();
            this.btnLookBySurname = new System.Windows.Forms.Button();
            this.btnShowEveryTeacher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tlf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowLastTeacher);
            this.groupBox1.Controls.Add(this.btnShowNextTeacher);
            this.groupBox1.Controls.Add(this.btnShowPreviousTeacher);
            this.groupBox1.Controls.Add(this.btnShowFirstTeacher);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // btnShowLastTeacher
            // 
            this.btnShowLastTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowLastTeacher.Location = new System.Drawing.Point(572, 19);
            this.btnShowLastTeacher.Name = "btnShowLastTeacher";
            this.btnShowLastTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowLastTeacher.TabIndex = 3;
            this.btnShowLastTeacher.Text = "Ultimo";
            this.btnShowLastTeacher.UseVisualStyleBackColor = true;
            this.btnShowLastTeacher.Click += new System.EventHandler(this.btnShowLastTeacher_Click);
            // 
            // btnShowNextTeacher
            // 
            this.btnShowNextTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowNextTeacher.Location = new System.Drawing.Point(400, 19);
            this.btnShowNextTeacher.Name = "btnShowNextTeacher";
            this.btnShowNextTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowNextTeacher.TabIndex = 2;
            this.btnShowNextTeacher.Text = "Siguiente";
            this.btnShowNextTeacher.UseVisualStyleBackColor = true;
            this.btnShowNextTeacher.Click += new System.EventHandler(this.btnShowNextTeacher_Click);
            // 
            // btnShowPreviousTeacher
            // 
            this.btnShowPreviousTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowPreviousTeacher.Location = new System.Drawing.Point(214, 19);
            this.btnShowPreviousTeacher.Name = "btnShowPreviousTeacher";
            this.btnShowPreviousTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowPreviousTeacher.TabIndex = 1;
            this.btnShowPreviousTeacher.Text = "Anterior";
            this.btnShowPreviousTeacher.UseVisualStyleBackColor = true;
            this.btnShowPreviousTeacher.Click += new System.EventHandler(this.btnShowPreviousTeacher_Click);
            // 
            // btnShowFirstTeacher
            // 
            this.btnShowFirstTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowFirstTeacher.Location = new System.Drawing.Point(18, 19);
            this.btnShowFirstTeacher.Name = "btnShowFirstTeacher";
            this.btnShowFirstTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowFirstTeacher.TabIndex = 0;
            this.btnShowFirstTeacher.Text = "Primero";
            this.btnShowFirstTeacher.UseVisualStyleBackColor = true;
            this.btnShowFirstTeacher.Click += new System.EventHandler(this.btnShowFirstTeacher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveNew);
            this.groupBox2.Controls.Add(this.btnAddTeacher);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(29, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 87);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Registro";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSaveNew.Location = new System.Drawing.Point(185, 19);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(161, 44);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "Guardar Nuevo";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddTeacher.Location = new System.Drawing.Point(18, 19);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Añadir";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(429, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar y Eliminar";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDelete.Location = new System.Drawing.Point(172, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdate.Location = new System.Drawing.Point(6, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(79, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(170, 20);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // txteMail
            // 
            this.txteMail.Location = new System.Drawing.Point(330, 186);
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(170, 20);
            this.txteMail.TabIndex = 9;
            this.txteMail.TextChanged += new System.EventHandler(this.txteMail_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(330, 122);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(170, 20);
            this.txtApellidos.TabIndex = 10;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(79, 186);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(170, 20);
            this.txtTlf.TabIndex = 11;
            this.txtTlf.TextChanged += new System.EventHandler(this.txtTlf_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registro: ";
            // 
            // lblEntryNumber
            // 
            this.lblEntryNumber.AutoSize = true;
            this.lblEntryNumber.Location = new System.Drawing.Point(669, 41);
            this.lblEntryNumber.Name = "lblEntryNumber";
            this.lblEntryNumber.Size = new System.Drawing.Size(0, 13);
            this.lblEntryNumber.TabIndex = 14;
            // 
            // btnLookBySurname
            // 
            this.btnLookBySurname.Location = new System.Drawing.Point(601, 82);
            this.btnLookBySurname.Name = "btnLookBySurname";
            this.btnLookBySurname.Size = new System.Drawing.Size(172, 56);
            this.btnLookBySurname.TabIndex = 15;
            this.btnLookBySurname.Text = "Buscar Apellido";
            this.btnLookBySurname.UseVisualStyleBackColor = true;
            this.btnLookBySurname.Click += new System.EventHandler(this.btnLookBySurname_Click);
            // 
            // btnShowEveryTeacher
            // 
            this.btnShowEveryTeacher.Location = new System.Drawing.Point(601, 167);
            this.btnShowEveryTeacher.Name = "btnShowEveryTeacher";
            this.btnShowEveryTeacher.Size = new System.Drawing.Size(172, 56);
            this.btnShowEveryTeacher.TabIndex = 16;
            this.btnShowEveryTeacher.Text = "Mostrar Profesores";
            this.btnShowEveryTeacher.UseVisualStyleBackColor = true;
            this.btnShowEveryTeacher.Click += new System.EventHandler(this.btnShowEveryTeacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowEveryTeacher);
            this.Controls.Add(this.btnLookBySurname);
            this.Controls.Add(this.lblEntryNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txteMail);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowLastTeacher;
        private System.Windows.Forms.Button btnShowNextTeacher;
        private System.Windows.Forms.Button btnShowPreviousTeacher;
        private System.Windows.Forms.Button btnShowFirstTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txteMail;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntryNumber;
        private System.Windows.Forms.Button btnLookBySurname;
        private System.Windows.Forms.Button btnShowEveryTeacher;
    }
}

