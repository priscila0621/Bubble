﻿namespace Bubble
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
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbSortedNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los numeros separados por coma:";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(33, 48);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(86, 20);
            this.tbNumbers.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(148, 48);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 20);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbSortedNumbers
            // 
            this.lbSortedNumbers.FormattingEnabled = true;
            this.lbSortedNumbers.Location = new System.Drawing.Point(33, 74);
            this.lbSortedNumbers.Name = "lbSortedNumbers";
            this.lbSortedNumbers.Size = new System.Drawing.Size(200, 134);
            this.lbSortedNumbers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 231);
            this.Controls.Add(this.lbSortedNumbers);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lbSortedNumbers;
    }
}

