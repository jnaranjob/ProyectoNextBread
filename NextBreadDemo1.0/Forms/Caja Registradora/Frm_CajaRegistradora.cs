using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Forms.Proveedor;
using NextBreadDemo1._0.Forms.Seguridad;
using NextBreadDemo1._0.Interfaces;
using NextBreadDemo1._0.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Caja_Registradora
{
    public partial class Frm_CajaRegistradora : Form
    {
        private IntUsuario moduloSeguridad;

        private Dictionary<string, string> tiposPago = new Dictionary<string, string>
        {
            { "01", "Efectivo" },
            { "02", "Tarjeta" },
            { "03", "Sinpe Móvil" },
            { "04", "Otro" }
        };

        private SqlConnection connection;

        public Frm_CajaRegistradora()
        {
            InitializeComponent();
            moduloSeguridad = new ModuloSeguridad();
            this.StartPosition = FormStartPosition.CenterScreen;
            ConexionBD dbConnection = ConexionBD.Instancia;
            connection = dbConnection.GetConnection();
            Cb_TipoPago.DataSource = new BindingSource(tiposPago, null);
            Cb_TipoPago.DisplayMember = "Value";
            Cb_TipoPago.ValueMember = "Key";
            Txt_Cantidad.KeyDown += new KeyEventHandler(Txt_Cantidad_KeyDown);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Inventario.Show();
                this.Hide();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Proveedor.Show();
                this.Hide();
            }
        }
        private void administrarAgregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CredencialesSeguridad newForm = new Frm_CredencialesSeguridad();
            newForm.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            CerrarTodosLosFormularios();

            Frm_Login login = new Frm_Login();
            login.Show();
        }

        private void Txt_Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                AgregarProductoAlGrid();
                e.Handled = true;  // Evita el beep de la tecla Enter
                e.SuppressKeyPress = true;
                Txt_CodigoProducto.Clear();
                Txt_CodigoProducto.Focus();
            }
        }

        private void AgregarProductoAlGrid()
        {
            if (string.IsNullOrEmpty(Txt_CodigoProducto.Text) ||
                string.IsNullOrEmpty(Txt_PrecioProducto.Text) ||
                string.IsNullOrEmpty(Txt_Cantidad.Text))
            {
                MessageBox.Show("Debe completar los campos de producto, precio y cantidad.");
                return;
            }

            string texto = Txt_PrecioProducto.Text.Trim();
            string numeroTexto = Regex.Match(texto, @"\d+").Value;


            string codigoProducto = Txt_CodigoProducto.Text.Trim();
            string descripcionProducto = Txt_Descripcion.Text.Trim();
            decimal precio = string.IsNullOrEmpty(numeroTexto) ? 0 : Convert.ToDecimal(numeroTexto);
            int cantidad = Convert.ToInt32(Txt_Cantidad.Text.Trim());

            if (!VerificarDisponibilidadProducto(codigoProducto, cantidad))
            {
                MessageBox.Show("Cantidad insuficiente en inventario.");
                return;
            }

            decimal subtotal = precio * cantidad;

            Dgv_ProveedoresRegistrados.Rows.Add(codigoProducto, descripcionProducto, precio, cantidad, subtotal);

            CalcularTotales();

            Txt_Cantidad.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioProducto.Clear();
            Txt_Cantidad.Focus();
        }

        private bool VerificarDisponibilidadProducto(string codigoProducto, int cantidadRequerida)
        {
            string query = @"SELECT Cantidad FROM Inventario WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    int cantidadDisponible = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidadDisponible >= cantidadRequerida;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar disponibilidad del producto: " + ex.Message);
                    return false;
                }
            }
        }
        private decimal CalcularTotales()
        {
            decimal total = 0;
            decimal subtotal = 0;

            foreach (DataGridViewRow row in Dgv_ProveedoresRegistrados.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }
            total = subtotal;
            Txt_SubTotal.Text = subtotal.ToString("0.00");
            Txt_TotalPagar.Text = total.ToString("0.00");

            return total;
        }

        private void Frm_CajaRegistradora_Load(object sender, EventArgs e)
        {
            Dgv_ProveedoresRegistrados.Columns.Add("CodigoProducto", "Código Producto");
            Dgv_ProveedoresRegistrados.Columns.Add("Descripcion", "Descripción de Producto");
            Dgv_ProveedoresRegistrados.Columns.Add("Precio", "Precio");
            Dgv_ProveedoresRegistrados.Columns.Add("Cantidad", "Cantidad");
            Dgv_ProveedoresRegistrados.Columns.Add("SubTotal", "SubTotal");

            Dgv_ProveedoresRegistrados.Columns["CodigoProducto"].ReadOnly = true;
            Dgv_ProveedoresRegistrados.Columns["Descripcion"].ReadOnly = true;
            Dgv_ProveedoresRegistrados.Columns["Precio"].ReadOnly = true;
            Dgv_ProveedoresRegistrados.Columns["Cantidad"].ReadOnly = false;
            Dgv_ProveedoresRegistrados.Columns["SubTotal"].ReadOnly = true;



            Cb_TipoPago.DataSource = new BindingSource(tiposPago, null);
            Cb_TipoPago.DisplayMember = "Value";
            Cb_TipoPago.ValueMember = "Key";
            Txt_CodigoProducto.Focus();
            permisos();
        }
        private void BuscarProducto(string codigoProducto)
        {
            string query = @"SELECT Precio,Nombre FROM Inventario WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Txt_PrecioProducto.Text = reader["Precio"].ToString();
                        Txt_Descripcion.Text = reader["Nombre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                        Txt_PrecioProducto.Clear();
                        Txt_Descripcion.Clear();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
        }

        private void permisos()
        {
            int tipoPermiso = moduloSeguridad.validarPermiso(Lbl_Usuario.Text);
            if (tipoPermiso == 1)
            {
                Cb_TipoPago.Enabled = false;
                Txt_Descripcion.Enabled = false;
                Txt_CodigoProducto.Enabled = false;
                Txt_PrecioProducto.Enabled = false;
                Txt_Cantidad.Enabled = false;
                Txt_SubTotal.Enabled = false;
                Txt_TotalPagar.Enabled = false;
                Btn_Facturar.Enabled = false;
                Btn_QuitarProducto.Enabled = false;
                Btn_CancelarCompra.Enabled = false;
            }
        }

        private void CerrarTodosLosFormularios()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                formsToClose.Add(form);
            }
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
        private void Btn_Facturar_Click(object sender, EventArgs e)
        {
            DateTime fechaCompra = DateTime.Now;
            string idTipoPago = Cb_TipoPago.SelectedValue?.ToString();
            int idUsuario = 1;

            if (string.IsNullOrEmpty(idTipoPago))
            {
                MessageBox.Show("Seleccione un tipo de pago.");
                return;
            }

            decimal compraFinal = CalcularTotales();
            string codigoVenta = InsertarEncabezadoFactura(fechaCompra, idTipoPago, compraFinal, idUsuario);

            if (string.IsNullOrEmpty(codigoVenta))
            {
                MessageBox.Show("Error al generar el código de venta.");
                return;
            }

            Txt_CodigoVenta.Text = codigoVenta;

            foreach (DataGridViewRow row in Dgv_ProveedoresRegistrados.Rows)
            {
                if (row.Cells["CodigoProducto"].Value != null)
                {
                    string codigoProducto = row.Cells["CodigoProducto"].Value.ToString();
                    string descripcion = row.Cells["Descripcion"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);


                    InsertarDetalleFactura(codigoVenta, codigoProducto, precio, cantidad, subtotal, descripcion);
                }
            }

            MessageBox.Show("Factura registrada exitosamente.");
            Dgv_ProveedoresRegistrados.Rows.Clear();
            Txt_SubTotal.Clear();
            Txt_TotalPagar.Clear();
            Txt_CodigoProducto.Clear();
            Txt_CodigoProducto.Focus();
            Txt_CodigoVenta.Clear();
            Txt_Descripcion.Clear();
        }

        private void InsertarDetalleFactura(string codigoVenta, string codigoProducto, decimal precio, int cantidad, decimal subtotal, string descripcion)
        {
            string query = @"
                INSERT INTO DetalleFactura (CodigoVenta, CodigoProducto, Precio, Cantidad, SubTotal, Descripcion)
                VALUES (@CodigoVenta, @CodigoProducto, @Precio, @Cantidad, @SubTotal, @Descripcion);

                UPDATE Inventario
                SET Cantidad = Cantidad - @Cantidad
                WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoVenta", codigoVenta);
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", subtotal);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el detalle de la factura y actualizar inventario: " + ex.Message);
                }
            }
        }

        private string InsertarEncabezadoFactura(DateTime fechaCompra, string idTipoPago, decimal compraFinal, int idUsuario)
        {
            string codigoVenta = string.Empty;

            string insertQuery = @"
                    INSERT INTO CajaRegistradora (FechaCompra, IdTipoPago, CompraFinal, IdUsuario)
                    VALUES (@FechaCompra, @IdTipoPago, @CompraFinal, @IdUsuario);";

            string selectQuery = @"
                    SELECT TOP 1 CodigoVenta 
                    FROM CajaRegistradora
                    ORDER BY CodigoVenta DESC;";

            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
            {
                insertCmd.Parameters.AddWithValue("@FechaCompra", fechaCompra);
                insertCmd.Parameters.AddWithValue("@IdTipoPago", idTipoPago);
                insertCmd.Parameters.AddWithValue("@CompraFinal", compraFinal);
                insertCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    insertCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el encabezado de la factura: " + ex.Message);
                    return codigoVenta; 
                }
            }

            using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
            {
                try
                {
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoVenta = reader["CodigoVenta"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el código de venta: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return codigoVenta;
        }
        private void txtCodigoproducto_Leave(object sender, EventArgs e)
        {
            BuscarProducto(Txt_CodigoProducto.Text.Trim());
        }

        private void inventarioProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Btn_QuitarProducto_Click(object sender, EventArgs e)
        {
            if (Dgv_ProveedoresRegistrados.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el artículo seleccionado?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in Dgv_ProveedoresRegistrados.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            Dgv_ProveedoresRegistrados.Rows.Remove(row);
                        }
                    }
                    CalcularTotales();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void Btn_CancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la compra?",
                                                  "Confirmar Cancelación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Dgv_ProveedoresRegistrados.Rows.Clear();
                Txt_SubTotal.Clear();
                Txt_TotalPagar.Clear();
                Txt_CodigoProducto.Clear();
                Txt_Descripcion.Clear();
                Txt_CodigoVenta.Clear();

                Txt_CodigoProducto.Focus();

                MessageBox.Show("Compra cancelada exitosamente.", "Operación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_CodigoProducto_TextChanged(object sender, EventArgs e)
        {
            string codigoProducto = Txt_CodigoProducto.Text.Trim();
            if (!string.IsNullOrEmpty(codigoProducto))
            {
                BuscarProducto(codigoProducto);
            }
        }

        private void Dgv_ProveedoresRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Dgv_ProveedoresRegistrados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_ProveedoresRegistrados.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                Dgv_ProveedoresRegistrados.EndEdit();  

                if (Dgv_ProveedoresRegistrados.Rows[e.RowIndex].Cells["Cantidad"].Value != null)
                {
                    int cantidad = Convert.ToInt32(Dgv_ProveedoresRegistrados.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(Dgv_ProveedoresRegistrados.Rows[e.RowIndex].Cells["Precio"].Value);

                    decimal subtotal = precio * cantidad;
                    Dgv_ProveedoresRegistrados.Rows[e.RowIndex].Cells["SubTotal"].Value = subtotal;

                    CalcularTotales();
                }
            }
        }
    }
}
