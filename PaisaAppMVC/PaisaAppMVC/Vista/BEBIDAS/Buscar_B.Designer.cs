﻿/*
 * Creado por SharpDevelop.
 * Usuario: Miriam
 * Fecha: 26/04/2017
 * Hora: 02:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
//namespace WindowsFormsApplication1
namespace PaisaAppMVC.Vista.BEBIDAS
{
	partial class Buscar_B
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.dgvBuscar = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblIngresarId = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(369, 266);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 31);
			this.btnCancelar.TabIndex = 60;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(19, 266);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(85, 31);
			this.btnAceptar.TabIndex = 59;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// dgvBuscar
			// 
			this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuscar.Location = new System.Drawing.Point(19, 100);
			this.dgvBuscar.Name = "dgvBuscar";
			this.dgvBuscar.ReadOnly = true;
			this.dgvBuscar.Size = new System.Drawing.Size(432, 150);
			this.dgvBuscar.TabIndex = 58;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(184, 71);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 57;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// lblIngresarId
			// 
			this.lblIngresarId.AutoSize = true;
			this.lblIngresarId.BackColor = System.Drawing.Color.LightSeaGreen;
			this.lblIngresarId.Location = new System.Drawing.Point(184, 29);
			this.lblIngresarId.Name = "lblIngresarId";
			this.lblIngresarId.Size = new System.Drawing.Size(59, 13);
			this.lblIngresarId.TabIndex = 56;
			this.lblIngresarId.Text = "Ingresar id:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(163, 45);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(118, 20);
			this.txtBuscar.TabIndex = 55;
			// 
			// Buscar_B
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 312);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.dgvBuscar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.lblIngresarId);
			this.Controls.Add(this.txtBuscar);
			this.Name = "Buscar_B";
			this.Text = "Buscar_B";
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblIngresarId;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dgvBuscar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}
