namespace practicaR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dvgPrincipal = new DataGridView();
            lbl_Nombre = new Label();
            lbl_Precio = new Label();
            lbl_Peso = new Label();
            txt_Nombre = new TextBox();
            txt_Precio = new TextBox();
            btn_Guardar = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            lbl_Stock = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_Peso = new TextBox();
            txt_Stock = new TextBox();
            txt_TamanoMB = new TextBox();
            txt_Licencia = new TextBox();
            lbl_TamanoMB = new Label();
            lbl_Licencia = new Label();
            Panel = new Panel();
            lbl_TipoProducto = new Label();
            cmb_TipoProd = new ComboBox();
            btn_Calcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dvgPrincipal
            // 
            dvgPrincipal.BackgroundColor = SystemColors.Control;
            dvgPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPrincipal.Location = new Point(151, 37);
            dvgPrincipal.Name = "dvgPrincipal";
            dvgPrincipal.ReadOnly = true;
            dvgPrincipal.Size = new Size(556, 219);
            dvgPrincipal.TabIndex = 0;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.ForeColor = SystemColors.ControlText;
            lbl_Nombre.Location = new Point(177, 341);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(73, 24);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "Nombre";
            lbl_Nombre.Click += lbl_Nombre_Click;
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Precio.ForeColor = SystemColors.ControlText;
            lbl_Precio.Location = new Point(465, 341);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(61, 24);
            lbl_Precio.TabIndex = 2;
            lbl_Precio.Text = "Precio";
            // 
            // lbl_Peso
            // 
            lbl_Peso.AutoSize = true;
            lbl_Peso.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Peso.ForeColor = SystemColors.ControlText;
            lbl_Peso.Location = new Point(199, 437);
            lbl_Peso.Name = "lbl_Peso";
            lbl_Peso.Size = new Size(51, 24);
            lbl_Peso.TabIndex = 3;
            lbl_Peso.Text = "Peso";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Cursor = Cursors.IBeam;
            txt_Nombre.Location = new Point(256, 342);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(161, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // txt_Precio
            // 
            txt_Precio.Cursor = Cursors.IBeam;
            txt_Precio.Location = new Point(532, 342);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(161, 23);
            txt_Precio.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Cursor = Cursors.Hand;
            btn_Guardar.FlatAppearance.BorderColor = Color.White;
            btn_Guardar.FlatAppearance.BorderSize = 4;
            btn_Guardar.FlatAppearance.MouseOverBackColor = Color.DarkSalmon;
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Guardar.Location = new Point(225, 271);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(93, 42);
            btn_Guardar.TabIndex = 6;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.FlatAppearance.BorderColor = Color.White;
            btn_Editar.FlatAppearance.BorderSize = 4;
            btn_Editar.FlatAppearance.MouseOverBackColor = Color.DarkSalmon;
            btn_Editar.FlatStyle = FlatStyle.Flat;
            btn_Editar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar.Location = new Point(386, 271);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(93, 42);
            btn_Editar.TabIndex = 11;
            btn_Editar.Text = "Editar";
            btn_Editar.TextAlign = ContentAlignment.TopCenter;
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatAppearance.BorderColor = Color.White;
            btn_Eliminar.FlatAppearance.BorderSize = 4;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = Color.DarkSalmon;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar.ImageAlign = ContentAlignment.TopCenter;
            btn_Eliminar.Location = new Point(546, 271);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(93, 42);
            btn_Eliminar.TabIndex = 12;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.TextAlign = ContentAlignment.TopCenter;
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // lbl_Stock
            // 
            lbl_Stock.AutoSize = true;
            lbl_Stock.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Stock.ForeColor = SystemColors.ControlText;
            lbl_Stock.Location = new Point(195, 481);
            lbl_Stock.Name = "lbl_Stock";
            lbl_Stock.Size = new Size(55, 24);
            lbl_Stock.TabIndex = 13;
            lbl_Stock.Text = "Stock";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(753, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(706, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_Peso
            // 
            txt_Peso.Cursor = Cursors.IBeam;
            txt_Peso.Location = new Point(256, 437);
            txt_Peso.Name = "txt_Peso";
            txt_Peso.Size = new Size(161, 23);
            txt_Peso.TabIndex = 16;
            // 
            // txt_Stock
            // 
            txt_Stock.Cursor = Cursors.IBeam;
            txt_Stock.Location = new Point(256, 482);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(161, 23);
            txt_Stock.TabIndex = 17;
            // 
            // txt_TamanoMB
            // 
            txt_TamanoMB.Cursor = Cursors.IBeam;
            txt_TamanoMB.Location = new Point(532, 437);
            txt_TamanoMB.Name = "txt_TamanoMB";
            txt_TamanoMB.Size = new Size(161, 23);
            txt_TamanoMB.TabIndex = 21;
            // 
            // txt_Licencia
            // 
            txt_Licencia.Cursor = Cursors.IBeam;
            txt_Licencia.Location = new Point(532, 392);
            txt_Licencia.Name = "txt_Licencia";
            txt_Licencia.Size = new Size(161, 23);
            txt_Licencia.TabIndex = 20;
            // 
            // lbl_TamanoMB
            // 
            lbl_TamanoMB.AutoSize = true;
            lbl_TamanoMB.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TamanoMB.ForeColor = SystemColors.ControlText;
            lbl_TamanoMB.Location = new Point(424, 437);
            lbl_TamanoMB.Name = "lbl_TamanoMB";
            lbl_TamanoMB.Size = new Size(102, 24);
            lbl_TamanoMB.TabIndex = 19;
            lbl_TamanoMB.Text = "TamanoMB";
            // 
            // lbl_Licencia
            // 
            lbl_Licencia.AutoSize = true;
            lbl_Licencia.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Licencia.ForeColor = SystemColors.ControlText;
            lbl_Licencia.Location = new Point(450, 391);
            lbl_Licencia.Name = "lbl_Licencia";
            lbl_Licencia.Size = new Size(76, 24);
            lbl_Licencia.TabIndex = 18;
            lbl_Licencia.Text = "Licencia";
            // 
            // Panel
            // 
            Panel.Location = new Point(4, -2);
            Panel.Name = "Panel";
            Panel.Size = new Size(689, 33);
            Panel.TabIndex = 22;
            Panel.MouseDown += Panel_MouseDown;
            // 
            // lbl_TipoProducto
            // 
            lbl_TipoProducto.AutoSize = true;
            lbl_TipoProducto.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TipoProducto.ForeColor = SystemColors.ControlText;
            lbl_TipoProducto.Location = new Point(137, 390);
            lbl_TipoProducto.Name = "lbl_TipoProducto";
            lbl_TipoProducto.Size = new Size(118, 24);
            lbl_TipoProducto.TabIndex = 23;
            lbl_TipoProducto.Text = "TipoProducto";
            // 
            // cmb_TipoProd
            // 
            cmb_TipoProd.Cursor = Cursors.Hand;
            cmb_TipoProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipoProd.FormattingEnabled = true;
            cmb_TipoProd.Location = new Point(256, 391);
            cmb_TipoProd.Name = "cmb_TipoProd";
            cmb_TipoProd.Size = new Size(161, 23);
            cmb_TipoProd.TabIndex = 26;
            cmb_TipoProd.SelectedIndexChanged += cmb_TipoProd_SelectedIndexChanged;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Cursor = Cursors.Hand;
            btn_Calcular.FlatAppearance.BorderColor = Color.White;
            btn_Calcular.FlatAppearance.BorderSize = 4;
            btn_Calcular.FlatAppearance.MouseOverBackColor = Color.DarkSalmon;
            btn_Calcular.FlatStyle = FlatStyle.Flat;
            btn_Calcular.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Calcular.ImageAlign = ContentAlignment.TopCenter;
            btn_Calcular.Location = new Point(33, 126);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(93, 42);
            btn_Calcular.TabIndex = 27;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.TextAlign = ContentAlignment.TopCenter;
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 525);
            Controls.Add(btn_Calcular);
            Controls.Add(cmb_TipoProd);
            Controls.Add(lbl_TipoProducto);
            Controls.Add(Panel);
            Controls.Add(txt_TamanoMB);
            Controls.Add(txt_Licencia);
            Controls.Add(lbl_TamanoMB);
            Controls.Add(lbl_Licencia);
            Controls.Add(txt_Stock);
            Controls.Add(txt_Peso);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Stock);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Guardar);
            Controls.Add(txt_Precio);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Peso);
            Controls.Add(lbl_Precio);
            Controls.Add(lbl_Nombre);
            Controls.Add(dvgPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgPrincipal;
        private Label lbl_Nombre;
        private Label lbl_Precio;
        private Label lbl_Peso;
        private TextBox txt_Nombre;
        private TextBox txt_Precio;
        private Button btn_Guardar;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Label lbl_Stock;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_Peso;
        private TextBox txt_Stock;
        private TextBox txt_TamanoMB;
        private TextBox txt_Licencia;
        private Label lbl_TamanoMB;
        private Label lbl_Licencia;
        private Panel Panel;
        private Label lbl_TipoProducto;
        private ComboBox cmb_TipoProd;
        private Button btn_Calcular;
    }
}
