
namespace Grupo02_Moanso
{
    partial class OrdenRequisicion
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
            this.btnFinalizado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvOrdenRequisicion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizado
            // 
            this.btnFinalizado.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizado.Location = new System.Drawing.Point(516, 323);
            this.btnFinalizado.Name = "btnFinalizado";
            this.btnFinalizado.Size = new System.Drawing.Size(155, 40);
            this.btnFinalizado.TabIndex = 26;
            this.btnFinalizado.Text = "Marcar Finalizado";
            this.btnFinalizado.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(516, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 40);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnMateriales
            // 
            this.btnMateriales.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.Location = new System.Drawing.Point(516, 266);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(155, 40);
            this.btnMateriales.TabIndex = 24;
            this.btnMateriales.Text = "Añadir Materia";
            this.btnMateriales.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(516, 209);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(155, 40);
            this.btnAnular.TabIndex = 23;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(516, 152);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 40);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(516, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 40);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Orden";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(516, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 29);
            this.txtId.TabIndex = 19;
            // 
            // dgvOrdenRequisicion
            // 
            this.dgvOrdenRequisicion.AllowUserToResizeColumns = false;
            this.dgvOrdenRequisicion.AllowUserToResizeRows = false;
            this.dgvOrdenRequisicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenRequisicion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrdenRequisicion.Location = new System.Drawing.Point(34, 88);
            this.dgvOrdenRequisicion.MultiSelect = false;
            this.dgvOrdenRequisicion.Name = "dgvOrdenRequisicion";
            this.dgvOrdenRequisicion.RowHeadersVisible = false;
            this.dgvOrdenRequisicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenRequisicion.Size = new System.Drawing.Size(451, 333);
            this.dgvOrdenRequisicion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "ORDEN DE REQUISICION";
            // 
            // OrdenRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.btnFinalizado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvOrdenRequisicion);
            this.Controls.Add(this.label1);
            this.Name = "OrdenRequisicion";
            this.Text = "OrdenRequisicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenRequisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvOrdenRequisicion;
        private System.Windows.Forms.Label label1;
    }
}