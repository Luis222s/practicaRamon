using CapaDatos;
using CapaNegocio;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practicaR
{
    public partial class Form1 : Form
    {
        CN_Producto ObjetoCN = new CN_Producto();
        public string IdProducto1;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();

            int radius = 20;
            GraphicsPath pathAgregar2 = new GraphicsPath();
            pathAgregar2.AddArc(0, 0, radius, radius, 180, 90);
            pathAgregar2.AddArc(btn_Guardar.Width - radius, 0, radius, radius, 270, 90);
            pathAgregar2.AddArc(btn_Guardar.Width - radius, btn_Guardar.Height - radius, radius, radius, 0, 90);
            pathAgregar2.AddArc(0, btn_Guardar.Height - radius, radius, radius, 90, 90);
            pathAgregar2.CloseFigure();
            btn_Guardar.Region = new Region(pathAgregar2);

            GraphicsPath pathEditar2 = new GraphicsPath();
            pathEditar2.AddArc(0, 0, radius, radius, 180, 90);
            pathEditar2.AddArc(btn_Editar.Width - radius, 0, radius, radius, 270, 90);
            pathEditar2.AddArc(btn_Editar.Width - radius, btn_Editar.Height - radius, radius, radius, 0, 90);
            pathEditar2.AddArc(0, btn_Editar.Height - radius, radius, radius, 90, 90);
            pathEditar2.CloseFigure();
            btn_Editar.Region = new Region(pathEditar2);

            GraphicsPath pathEliminar2 = new GraphicsPath();
            pathEliminar2.AddArc(0, 0, radius, radius, 180, 90);
            pathEliminar2.AddArc(btn_Eliminar.Width - radius, 0, radius, radius, 270, 90);
            pathEliminar2.AddArc(btn_Eliminar.Width - radius, btn_Eliminar.Height - radius, radius, radius, 0, 90);
            pathEliminar2.AddArc(0, btn_Eliminar.Height - radius, radius, radius, 90, 90);
            pathEliminar2.CloseFigure();
            btn_Eliminar.Region = new Region(pathEliminar2);

        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MostrarProducto()
        {
            CN_Producto Producto = new CN_Producto();
            dvgPrincipal.DataSource = Producto.MostrarProducto();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                cmb_TipoProd.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Precio, Tipo Producto).", "Campos vacíos");
                return;
            }

            // Validar conversiones numéricas
            if (!int.TryParse(txt_Precio.Text, out int precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error de formato");
                return;
            }

            double peso = 0;
            if (!string.IsNullOrWhiteSpace(txt_Peso.Text) && !double.TryParse(txt_Peso.Text, out peso))
            {
                MessageBox.Show("El peso debe ser un número válido.", "Error de formato");
                return;
            }

            int stock = 0;
            if (!string.IsNullOrWhiteSpace(txt_Stock.Text) && !int.TryParse(txt_Stock.Text, out stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error de formato");
                return;
            }

            double tamanoMB = 0;
            if (!string.IsNullOrWhiteSpace(txt_TamanoMB.Text) && !double.TryParse(txt_TamanoMB.Text, out tamanoMB))
            {
                MessageBox.Show("El tamaño (MB) debe ser un número válido.", "Error de formato");
                return;
            }

            string licencia = txt_Licencia.Text.Trim();

            try
            {
                if (Editar == true)
                {
                    ObjetoCN.EditarProd(
                        txt_Nombre.Text,
                        precio.ToString(),
                        cmb_TipoProd.SelectedItem.ToString(),
                        txt_Licencia.Text,
                        peso.ToString(),
                        stock.ToString(),
                        tamanoMB.ToString(),
                        IdProducto1
                    );

                    MessageBox.Show("Producto editado correctamente.");
                    Editar = false;
                }
                else
                {
                    ObjetoCN.InsertarProd(
                        txt_Nombre.Text,
                        precio.ToString(),
                        cmb_TipoProd.SelectedItem.ToString(),
                        peso.ToString(),
                        stock.ToString(),
                        txt_Licencia.Text,
                        tamanoMB.ToString()
                    );

                    MessageBox.Show("Producto agregado correctamente.");
                }

                LimpiarCampos();
                MostrarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            /*
            if (string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                cmb_TipoProd.SelectedItem == null ||
                string.IsNullOrWhiteSpace(cmb_TipoProd.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos");
                return;
            }
            if (Editar == false)
            {
                try
                {
                    ObjetoCN.InsertarProd(txt_Nombre.Text, txt_Precio.Text, cmb_TipoProd.SelectedItem.ToString(), txt_Peso.Text, txt_Stock.Text, txt_Licencia.Text, txt_TamanoMB.Text);
                    MessageBox.Show("Se agregó correctamente");
                    MostrarProducto();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar los datos por: " + ex.Message);
                }
            }
            if (Editar == true)
            {
                try
                {
                    ObjetoCN.EditarProd(txt_Nombre.Text, txt_Precio.Text, cmb_TipoProd.SelectedItem.ToString(), txt_Licencia.Text, txt_Peso.Text, txt_Stock.Text, txt_TamanoMB.Text, IdProducto1);
                    MessageBox.Show("Se editó correctamente");
                    MostrarProducto();
                    LimpiarCampos();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por " + ex);
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_TipoProd.Items.Add("Fisico");
            cmb_TipoProd.Items.Add("Digital");
            cmb_TipoProd.SelectedIndex = -1;
            txt_Peso.Enabled = false;
            txt_TamanoMB.Enabled = false;
            txt_Licencia.Enabled = false;
            txt_Stock.Enabled = false;
            MostrarProducto();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dvgPrincipal.SelectedRows.Count > 0)
            {
                Editar = true;
                // Obtener valores de la fila seleccionada
                txt_Nombre.Text = dvgPrincipal.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_Precio.Text = dvgPrincipal.CurrentRow.Cells["Precio"].Value.ToString();
                cmb_TipoProd.SelectedItem = dvgPrincipal.CurrentRow.Cells["TipoProducto"].Value.ToString();
                txt_Licencia.Text = dvgPrincipal.CurrentRow.Cells["Licencia"].Value.ToString();
                txt_Peso.Text = dvgPrincipal.CurrentRow.Cells["Peso"].Value.ToString();
                txt_Stock.Text = dvgPrincipal.CurrentRow.Cells["Stock"].Value.ToString();
                txt_TamanoMB.Text = dvgPrincipal.CurrentRow.Cells["TamanoMB"].Value.ToString();
                IdProducto1 = dvgPrincipal.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dvgPrincipal.SelectedRows.Count > 0)
            {
                IdProducto1 = dvgPrincipal.CurrentRow.Cells["Id"].Value.ToString();
                ObjetoCN.EliminarProd(IdProducto1);
                MessageBox.Show("Eliminado correctamente");
                LimpiarCampos();
                MostrarProducto();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }
        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Peso.Clear();
            txt_Licencia.Clear();
            txt_TamanoMB.Clear();
            txt_Stock.Clear();
            cmb_TipoProd.SelectedIndex = -1;
        }

        private void cmb_TipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TipoProd.SelectedItem == null)
                return;

            string tipo = cmb_TipoProd.SelectedItem.ToString();

            if (tipo == "Fisico")
            {
                txt_Peso.Enabled = true;
                txt_Stock.Enabled = true;
                txt_Licencia.Enabled = false;
                txt_TamanoMB.Enabled = false;

                txt_Licencia.Clear();
                txt_TamanoMB.Clear();
            }
            else if (tipo == "Digital")
            {
                txt_Peso.Enabled = false;
                txt_Stock.Enabled = false;
                txt_Licencia.Enabled = true;
                txt_TamanoMB.Enabled = true;

                txt_Peso.Clear();
                txt_Stock.Clear();
            }
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (dvgPrincipal.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dvgPrincipal.CurrentRow;

                string tipoProducto = fila.Cells["TipoProducto"].Value?.ToString() ?? "";
                string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";

                if (!int.TryParse(fila.Cells["Precio"].Value?.ToString(), out int precio))
                {
                    MessageBox.Show("Precio inválido.");
                    return;
                }

                if (tipoProducto == "Fisico")
                {
                    if (!double.TryParse(fila.Cells["Peso"].Value?.ToString(), out double peso) ||
                        !int.TryParse(fila.Cells["Stock"].Value?.ToString(), out int stock))
                    {
                        MessageBox.Show("Peso o Stock inválido.");
                        return;
                    }

                    ProductoFisico pf = new ProductoFisico(nombre, precio, peso, stock);
                    double precioFinal = pf.CalcularPrecioFinal();
                    MessageBox.Show($"Precio final físico: {precioFinal:C2}");
                }
                else if (tipoProducto == "Digital")
                {
                    string licencia = fila.Cells["Licencia"].Value?.ToString() ?? "";

                    if (!double.TryParse(fila.Cells["TamanoMB"].Value?.ToString(), out double tamanoMB))
                    {
                        MessageBox.Show("Tamaño (MB) inválido.");
                        return;
                    }

                    ProductoDigital pd = new ProductoDigital(nombre, precio, licencia, tamanoMB);
                    double precioFinal = pd.CalcularPrecioFinal();
                    MessageBox.Show($"Precio final digital: {precioFinal:C2}");
                }
                else
                {
                    MessageBox.Show("Tipo de producto desconocido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila.");
            }
        }
    }
}
