namespace UI
{
    partial class AdministracionProductos
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
            label1 = new Label();
            txtProducto = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            GridProductos = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción del producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(418, 23);
            txtProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 118);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(101, 23);
            txtCantidad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(126, 172);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(255, 172);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Anular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GridProductos
            // 
            GridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProductos.Location = new Point(12, 238);
            GridProductos.Name = "GridProductos";
            GridProductos.RowTemplate.Height = 25;
            GridProductos.Size = new Size(428, 223);
            GridProductos.TabIndex = 7;
            GridProductos.CellClick += GridProductos_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 8;
            label3.Text = "Listado de Productos:";
            // 
            // AdministracionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 473);
            Controls.Add(label3);
            Controls.Add(GridProductos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "AdministracionProductos";
            Text = "AdministracionProductos";
            Load += AdministracionProductos_Load;
            ((System.ComponentModel.ISupportInitialize)GridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Label label2;
        private TextBox txtCantidad;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView GridProductos;
        private Label label3;
    }
}