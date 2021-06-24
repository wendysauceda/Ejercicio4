
namespace Ejercicio4
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
            this.cb_ListaEst = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Ordenar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Mayor = new System.Windows.Forms.Button();
            this.btn_Menor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_ListaEst
            // 
            this.cb_ListaEst.FormattingEnabled = true;
            this.cb_ListaEst.Location = new System.Drawing.Point(153, 214);
            this.cb_ListaEst.Name = "cb_ListaEst";
            this.cb_ListaEst.Size = new System.Drawing.Size(162, 21);
            this.cb_ListaEst.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(467, 212);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(88, 111);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(227, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(467, 111);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(80, 20);
            this.txt_Edad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca el nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese la edad:";
            // 
            // cb_Ordenar
            // 
            this.cb_Ordenar.FormattingEnabled = true;
            this.cb_Ordenar.Location = new System.Drawing.Point(153, 341);
            this.cb_Ordenar.Name = "cb_Ordenar";
            this.cb_Ordenar.Size = new System.Drawing.Size(162, 21);
            this.cb_Ordenar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista Estudiantes:";
            // 
            // btn_Mayor
            // 
            this.btn_Mayor.Location = new System.Drawing.Point(467, 310);
            this.btn_Mayor.Name = "btn_Mayor";
            this.btn_Mayor.Size = new System.Drawing.Size(75, 23);
            this.btn_Mayor.TabIndex = 8;
            this.btn_Mayor.Text = "MAYOR";
            this.btn_Mayor.UseVisualStyleBackColor = true;
            // 
            // btn_Menor
            // 
            this.btn_Menor.Location = new System.Drawing.Point(467, 373);
            this.btn_Menor.Name = "btn_Menor";
            this.btn_Menor.Size = new System.Drawing.Size(75, 23);
            this.btn_Menor.TabIndex = 9;
            this.btn_Menor.Text = "MENOR";
            this.btn_Menor.UseVisualStyleBackColor = true;
            this.btn_Menor.Click += new System.EventHandler(this.btn_Menor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ordenar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Menor);
            this.Controls.Add(this.btn_Mayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Ordenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cb_ListaEst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ListaEst;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Ordenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Mayor;
        private System.Windows.Forms.Button btn_Menor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

