
namespace Grupo02_Moanso
{
    partial class AsignarMateriaPrima
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
            this.dgvDetalleRequisicion = new System.Windows.Forms.DataGridView();
            this.lblOrden = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleRequisicion
            // 
            this.dgvDetalleRequisicion.AllowUserToResizeColumns = false;
            this.dgvDetalleRequisicion.AllowUserToResizeRows = false;
            this.dgvDetalleRequisicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleRequisicion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalleRequisicion.Location = new System.Drawing.Point(44, 79);
            this.dgvDetalleRequisicion.MultiSelect = false;
            this.dgvDetalleRequisicion.Name = "dgvDetalleRequisicion";
            this.dgvDetalleRequisicion.RowHeadersVisible = false;
            this.dgvDetalleRequisicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleRequisicion.Size = new System.Drawing.Size(451, 333);
            this.dgvDetalleRequisicion.TabIndex = 29;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(431, 42);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(267, 34);
            this.lblOrden.TabIndex = 28;
            this.lblOrden.Text = "ASIGNAR MATERIA PRIMA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(525, 359);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 40);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(525, 302);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(132, 40);
            this.btnRetirar.TabIndex = 26;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(525, 244);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(132, 40);
            this.btnAnadir.TabIndex = 25;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(511, 192);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(169, 29);
            this.txtCantidad.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Materia Prima";
            // 
            // cbxMateria
            // 
            this.cbxMateria.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(511, 116);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(169, 32);
            this.cbxMateria.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "ASIGNAR MATERIA PRIMA";
            // 
            // AsignarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 431);
            this.Controls.Add(this.dgvDetalleRequisicion);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.label1);
            this.Name = "AsignarMateriaPrima";
            this.Text = "AsignarMateriaPrima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleRequisicion;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Label label1;
    }
}