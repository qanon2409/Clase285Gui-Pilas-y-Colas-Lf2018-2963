
namespace Clase285Gui
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.bCola = new System.Windows.Forms.Button();
            this.bPila = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.listado = new System.Windows.Forms.ListBox();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bCola);
            this.splitContainer1.Panel1.Controls.Add(this.bPila);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.bEliminar);
            this.splitContainer1.Panel2.Controls.Add(this.bAgregar);
            this.splitContainer1.Panel2.Controls.Add(this.listado);
            this.splitContainer1.Panel2.Controls.Add(this.txtAgregar);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 99);
            this.label1.TabIndex = 7;
            this.label1.Text = "SELECCIONE METODO DE ALMACENAMIENTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCola
            // 
            this.bCola.Location = new System.Drawing.Point(76, 234);
            this.bCola.Name = "bCola";
            this.bCola.Size = new System.Drawing.Size(116, 33);
            this.bCola.TabIndex = 6;
            this.bCola.Text = "Cola";
            this.bCola.UseVisualStyleBackColor = true;
            this.bCola.Click += new System.EventHandler(this.bCola_Click);
            // 
            // bPila
            // 
            this.bPila.Location = new System.Drawing.Point(76, 161);
            this.bPila.Name = "bPila";
            this.bPila.Size = new System.Drawing.Size(116, 33);
            this.bPila.TabIndex = 5;
            this.bPila.Text = "Pila";
            this.bPila.UseVisualStyleBackColor = true;
            this.bPila.Click += new System.EventHandler(this.bPila_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(384, 104);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(116, 33);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // listado
            // 
            this.listado.FormattingEnabled = true;
            this.listado.Location = new System.Drawing.Point(81, 161);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(279, 199);
            this.listado.TabIndex = 2;
            this.listado.SelectedIndexChanged += new System.EventHandler(this.listado_SelectedIndexChanged);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(81, 104);
            this.txtAgregar.Multiline = true;
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(279, 33);
            this.txtAgregar.TabIndex = 0;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(384, 161);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(116, 33);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ultimo elemento eliminado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCola;
        private System.Windows.Forms.Button bPila;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox listado;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Label label2;
    }
}

