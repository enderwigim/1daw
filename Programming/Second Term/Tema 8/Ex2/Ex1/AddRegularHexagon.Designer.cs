﻿namespace Ex2
{
    partial class AddRegularHexagon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTriangleSide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPositionY = new System.Windows.Forms.TextBox();
            this.txtPositionX = new System.Windows.Forms.TextBox();
            this.btnAddHexagon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddHexagon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTriangleSide);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPositionY);
            this.groupBox1.Controls.Add(this.txtPositionX);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca datos del Hexagono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lado 1 triangulo:";
            // 
            // txtTriangleSide
            // 
            this.txtTriangleSide.Location = new System.Drawing.Point(116, 189);
            this.txtTriangleSide.Margin = new System.Windows.Forms.Padding(2);
            this.txtTriangleSide.Name = "txtTriangleSide";
            this.txtTriangleSide.Size = new System.Drawing.Size(71, 20);
            this.txtTriangleSide.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posición X:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(116, 144);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(71, 20);
            this.txtColor.TabIndex = 2;
            // 
            // txtPositionY
            // 
            this.txtPositionY.Location = new System.Drawing.Point(116, 94);
            this.txtPositionY.Margin = new System.Windows.Forms.Padding(2);
            this.txtPositionY.Name = "txtPositionY";
            this.txtPositionY.Size = new System.Drawing.Size(71, 20);
            this.txtPositionY.TabIndex = 1;
            // 
            // txtPositionX
            // 
            this.txtPositionX.Location = new System.Drawing.Point(116, 46);
            this.txtPositionX.Margin = new System.Windows.Forms.Padding(2);
            this.txtPositionX.Name = "txtPositionX";
            this.txtPositionX.Size = new System.Drawing.Size(71, 20);
            this.txtPositionX.TabIndex = 0;
            // 
            // btnAddHexagon
            // 
            this.btnAddHexagon.Location = new System.Drawing.Point(43, 240);
            this.btnAddHexagon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddHexagon.Name = "btnAddHexagon";
            this.btnAddHexagon.Size = new System.Drawing.Size(133, 41);
            this.btnAddHexagon.TabIndex = 12;
            this.btnAddHexagon.Text = "Añadir Hexagono";
            this.btnAddHexagon.UseVisualStyleBackColor = true;
            this.btnAddHexagon.Click += new System.EventHandler(this.btnAddHexagon_Click);
            // 
            // AddRegularHexagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRegularHexagon";
            this.Text = "AddRegularHexagon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTriangleSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPositionY;
        private System.Windows.Forms.TextBox txtPositionX;
        private System.Windows.Forms.Button btnAddHexagon;
    }
}