
namespace Grupo02_Moanso
{
    partial class AsignarProductos
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
            this.btnAsignarVencimiento = new System.Windows.Forms.Button();
            this.mtbFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.btnFechaProduccion = new System.Windows.Forms.Button();
            this.lblIdProduccion = new System.Windows.Forms.Label();
            this.dgvDetalleProduccion = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignarVencimiento);
            this.groupBox1.Controls.Add(this.mtbFechaVencimiento);
            this.groupBox1.Location = new System.Drawing.Point(782, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // btnAsignarVencimiento
            // 
            this.btnAsignarVencimiento.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarVencimiento.Location = new System.Drawing.Point(41, 14);
            this.btnAsignarVencimiento.Name = "btnAsignarVencimiento";
            this.btnAsignarVencimiento.Size = new System.Drawing.Size(132, 53);
            this.btnAsignarVencimiento.TabIndex = 31;
            this.btnAsignarVencimiento.Text = "Asignar Fecha Vencimiento";
            this.btnAsignarVencimiento.UseVisualStyleBackColor = true;
            // 
            // mtbFechaVencimiento
            // 
            this.mtbFechaVencimiento.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.mtbFechaVencimiento.Location = new System.Drawing.Point(52, 85);
            this.mtbFechaVencimiento.Mask = "00/00/0000";
            this.mtbFechaVencimiento.Name = "mtbFechaVencimiento";
            this.mtbFechaVencimiento.Size = new System.Drawing.Size(108, 29);
            this.mtbFechaVencimiento.TabIndex = 32;
            // 
            // btnFechaProduccion
            // 
            this.btnFechaProduccion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaProduccion.Location = new System.Drawing.Point(635, 329);
            this.btnFechaProduccion.Name = "btnFechaProduccion";
            this.btnFechaProduccion.Size = new System.Drawing.Size(132, 53);
            this.btnFechaProduccion.TabIndex = 45;
            this.btnFechaProduccion.Text = "Marcar fecha Produccion";
            this.btnFechaProduccion.UseVisualStyleBackColor = true;
            // 
            // lblIdProduccion
            // 
            this.lblIdProduccion.AutoSize = true;
            this.lblIdProduccion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduccion.Location = new System.Drawing.Point(708, 25);
            this.lblIdProduccion.Name = "lblIdProduccion";
            this.lblIdProduccion.Size = new System.Drawing.Size(36, 34);
            this.lblIdProduccion.TabIndex = 44;
            this.lblIdProduccion.Text = "ID";
            // 
            // dgvDetalleProduccion
            // 
            this.dgvDetalleProduccion.AllowUserToResizeColumns = false;
            this.dgvDetalleProduccion.AllowUserToResizeRows = false;
            this.dgvDetalleProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleProduccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalleProduccion.Location = new System.Drawing.Point(31, 62);
            this.dgvDetalleProduccion.MultiSelect = false;
            this.dgvDetalleProduccion.Name = "dgvDetalleProduccion";
            this.dgvDetalleProduccion.RowHeadersVisible = false;
            this.dgvDetalleProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleProduccion.Size = new System.Drawing.Size(951, 240);
            this.dgvDetalleProduccion.TabIndex = 43;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(334, 329);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 53);
            this.btnNuevo.TabIndex = 42;
            this.btnNuevo.Text = "Nuevo Producto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(486, 390);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 53);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(486, 331);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(132, 53);
            this.btnRetirar.TabIndex = 40;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(334, 390);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(132, 53);
            this.btnAnadir.TabIndex = 39;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(31, 413);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(274, 29);
            this.txtCantidad.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Producto";
            // 
            // cbxProducto
            // 
            this.cbxProducto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(31, 342);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(274, 32);
            this.cbxProducto.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "ASIGNAR PRODUCTOS";
            // 
            // AsignarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechaProduccion);
            this.Controls.Add(this.lblIdProduccion);
            this.Controls.Add(this.dgvDetalleProduccion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.label1);
            this.Name = "AsignarProductos";
            this.Text = "DetalleProduccion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignarVencimiento;
        private System.Windows.Forms.MaskedTextBox mtbFechaVencimiento;
        private System.Windows.Forms.Button btnFechaProduccion;
        private System.Windows.Forms.Label lblIdProduccion;
        private System.Windows.Forms.DataGridView dgvDetalleProduccion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label label1;
    }
}