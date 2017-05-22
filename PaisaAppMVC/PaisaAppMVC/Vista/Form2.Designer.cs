namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comidaCorridaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comidaRapidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
      //      this.archivoToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492544454_Archive_box_data_file_storage;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo ";
            // 
            // salirToolStripMenuItem
            // 
          //  this.salirToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492544241_exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comidaCorridaToolStripMenuItem,
            this.comidaRapidaToolStripMenuItem,
            this.postresToolStripMenuItem,
            this.bebidasToolStripMenuItem});
       //     this.verToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492544552_Eye_view_views_enable_watch;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // comidaCorridaToolStripMenuItem
            // 
          //  this.comidaCorridaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492546353_Dish_food_Dome_dish_kitchen_restaurant;
            this.comidaCorridaToolStripMenuItem.Name = "comidaCorridaToolStripMenuItem";
            this.comidaCorridaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.comidaCorridaToolStripMenuItem.Text = "Comida Corrida";
            this.comidaCorridaToolStripMenuItem.Click += new System.EventHandler(this.comidaCorridaToolStripMenuItem_Click);
            // 
            // comidaRapidaToolStripMenuItem
            // 
          //  this.comidaRapidaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492544610_pizza;
            this.comidaRapidaToolStripMenuItem.Name = "comidaRapidaToolStripMenuItem";
            this.comidaRapidaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.comidaRapidaToolStripMenuItem.Text = "Comida Rapida ";
            this.comidaRapidaToolStripMenuItem.Click += new System.EventHandler(this.comidaRapidaToolStripMenuItem_Click);
            // 
            // postresToolStripMenuItem
            // 
         // this.postresToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492544616_cupcake;
            this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
            this.postresToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.postresToolStripMenuItem.Text = "Postres";
            this.postresToolStripMenuItem.Click += new System.EventHandler(this.postresToolStripMenuItem_Click);
            // 
            // bebidasToolStripMenuItem
            // 
          //  this.bebidasToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1492546315_coffee_cup_package_d_free_13;
            this.bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            this.bebidasToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bebidasToolStripMenuItem.Text = "Bebidas";
            this.bebidasToolStripMenuItem.Click += new System.EventHandler(this.bebidasToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeLaEmpresaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // datosDeLaEmpresaToolStripMenuItem
            // 
            this.datosDeLaEmpresaToolStripMenuItem.Name = "datosDeLaEmpresaToolStripMenuItem";
            this.datosDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosDeLaEmpresaToolStripMenuItem.Text = "Datos de la empresa";
            this.datosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaEmpresaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
           // this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.logo_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(534, 308);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "PaisaAPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comidaCorridaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comidaRapidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaEmpresaToolStripMenuItem;
    }
}