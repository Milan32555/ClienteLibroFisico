using System.Drawing;
using System.Windows.Forms;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>
    /// Aplica a las ventanas de los casos de uso el mismo estilo sobrio de la ventana principal:
    /// superficies claras, tipografía del sistema y los colores de acción de Windows 11.
    /// </summary>
    internal static class EstiloVentana
    {
        public static readonly Color SUPERFICIE = Color.White;
        public static readonly Color TEXTO = Color.FromArgb(27, 27, 27);
        public static readonly Color TEXTO_SECUNDARIO = Color.FromArgb(90, 90, 90);
        public static readonly Color TEXTO_TERCIARIO = Color.FromArgb(128, 128, 128);
        public static readonly Color DIVISOR = Color.FromArgb(229, 229, 229);
        public static readonly Color SOLO_LECTURA = Color.FromArgb(247, 247, 247);

        // Colores de acción de Windows 11.
        public static readonly Color ACENTO = Color.FromArgb(0, 95, 184);
        public static readonly Color ACENTO_HOVER = Color.FromArgb(25, 117, 197);
        public static readonly Color ACENTO_PRESIONADO = Color.FromArgb(0, 74, 143);
        public static readonly Color PELIGRO = Color.FromArgb(196, 43, 28);
        public static readonly Color PELIGRO_HOVER = Color.FromArgb(210, 64, 50);
        public static readonly Color PELIGRO_PRESIONADO = Color.FromArgb(160, 34, 22);

        private const int ALTO_ENCABEZADO = 78;

        /// <summary>Reemplaza la etiqueta de título por un encabezado claro y estiliza los controles.</summary>
        public static void Aplicar(Form ventana, Label lblEncabezado)
        {
            ventana.BackColor = SUPERFICIE;

            // El contenido original arranca debajo del título (y = 50); se desplaza bajo el nuevo encabezado.
            int desplazamiento = ALTO_ENCABEZADO + 14 - 50;
            ventana.ClientSize = new Size(ventana.ClientSize.Width, ventana.ClientSize.Height + desplazamiento);
            foreach (Control c in ventana.Controls)
            {
                if (c == lblEncabezado) continue;
                bool arriba = (c.Anchor & AnchorStyles.Top) != 0;
                bool abajo = (c.Anchor & AnchorStyles.Bottom) != 0;
                if (arriba && abajo)
                {
                    c.Top += desplazamiento;
                    c.Height -= desplazamiento;
                }
                else if (arriba)
                {
                    c.Top += desplazamiento;
                }
            }

            lblEncabezado.Visible = false;
            Panel encabezado = new Panel { Dock = DockStyle.Top, Height = ALTO_ENCABEZADO };
            string titulo = lblEncabezado.Text;
            encabezado.Paint += (s, e) => PintarEncabezado(e.Graphics, encabezado.ClientRectangle, "Libro físico", titulo);
            ventana.Controls.Add(encabezado);

            Estilizar(ventana.Controls);
        }

        /// <summary>Encabezado claro: una línea de contexto, el título y un divisor fino.</summary>
        public static void PintarEncabezado(Graphics g, Rectangle area, string contexto, string titulo)
        {
            g.Clear(SUPERFICIE);
            using (Font fContexto = new Font("Segoe UI", 9f))
            using (Font fTitulo = new Font("Segoe UI Semibold", 16f))
            {
                TextRenderer.DrawText(g, contexto, fContexto, new Point(22, 16), TEXTO_TERCIARIO, SUPERFICIE);
                TextRenderer.DrawText(g, titulo, fTitulo, new Point(19, 34), TEXTO, SUPERFICIE);
            }
            using (Pen divisor = new Pen(DIVISOR))
            {
                g.DrawLine(divisor, 0, area.Bottom - 1, area.Right, area.Bottom - 1);
            }
        }

        private static void Estilizar(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is GroupBox)
                {
                    EstilizarGrupo((GroupBox)c);
                }
                else if (c is Button)
                {
                    EstilizarBoton((Button)c);
                }
                else if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.BorderStyle = BorderStyle.FixedSingle;
                    t.ForeColor = TEXTO;
                    t.BackColor = t.ReadOnly ? SOLO_LECTURA : SUPERFICIE;
                }
                else if (c is ComboBox || c is NumericUpDown)
                {
                    c.ForeColor = TEXTO;
                }
                else if (c is DataGridView)
                {
                    EstilizarTabla((DataGridView)c);
                }
                else if (c is Label)
                {
                    c.ForeColor = TEXTO_SECUNDARIO;
                }

                if (c.HasChildren && !(c is DataGridView))
                {
                    Estilizar(c.Controls);
                }
            }
        }

        /// <summary>Los grupos se muestran como secciones: solo su título, sin marco.</summary>
        private static void EstilizarGrupo(GroupBox grupo)
        {
            grupo.BackColor = SUPERFICIE;
            grupo.ForeColor = TEXTO;
            grupo.Paint += (s, e) =>
            {
                e.Graphics.Clear(SUPERFICIE);
                using (Font fuente = new Font("Segoe UI Semibold", 10f))
                {
                    TextRenderer.DrawText(e.Graphics, grupo.Text, fuente, new Point(18, 4), TEXTO, SUPERFICIE);
                }
            };
        }

        public static void EstilizarBoton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.Cursor = Cursors.Hand;
            b.Font = new Font("Segoe UI", 9f);
            b.UseVisualStyleBackColor = false;

            switch (b.Name)
            {
                case "btnGuardar":
                case "btnBuscar":
                case "btnFiltrar":
                case "btnAceptar":
                    b.BackColor = ACENTO;
                    b.ForeColor = Color.White;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseOverBackColor = ACENTO_HOVER;
                    b.FlatAppearance.MouseDownBackColor = ACENTO_PRESIONADO;
                    b.Paint += PintarDeshabilitado;
                    break;
                case "btnEliminar":
                    b.BackColor = PELIGRO;
                    b.ForeColor = Color.White;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseOverBackColor = PELIGRO_HOVER;
                    b.FlatAppearance.MouseDownBackColor = PELIGRO_PRESIONADO;
                    b.Paint += PintarDeshabilitado;
                    break;
                default:
                    b.BackColor = SUPERFICIE;
                    b.ForeColor = TEXTO;
                    b.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
                    b.FlatAppearance.BorderSize = 1;
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
                    break;
            }
        }

        /// <summary>
        /// Un botón de color deshabilitado se ve gris con texto blanco, como en Windows 11;
        /// sin esto, Windows lo deja con su color y el texto en gris, y parece activo.
        /// </summary>
        private static void PintarDeshabilitado(object sender, PaintEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled) return;
            e.Graphics.Clear(Color.FromArgb(200, 200, 200));
            TextRenderer.DrawText(e.Graphics, b.Text, b.Font, b.ClientRectangle, Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static void EstilizarTabla(DataGridView tabla)
        {
            tabla.BorderStyle = BorderStyle.FixedSingle;
            tabla.BackgroundColor = SUPERFICIE;
            tabla.GridColor = Color.FromArgb(237, 237, 237);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla.ColumnHeadersHeight = 34;
            DataGridViewCellStyle encabezado = tabla.ColumnHeadersDefaultCellStyle;
            encabezado.BackColor = Color.FromArgb(249, 249, 249);
            encabezado.ForeColor = TEXTO_SECUNDARIO;
            encabezado.SelectionBackColor = encabezado.BackColor;
            encabezado.SelectionForeColor = encabezado.ForeColor;
            encabezado.Font = new Font("Segoe UI Semibold", 9f);
            encabezado.Padding = new Padding(4, 0, 0, 0);
            encabezado.WrapMode = DataGridViewTriState.False;

            tabla.RowTemplate.Height = 30;
            DataGridViewCellStyle celdas = tabla.DefaultCellStyle;
            celdas.ForeColor = TEXTO;
            celdas.SelectionBackColor = Color.FromArgb(229, 241, 251);
            celdas.SelectionForeColor = TEXTO;
            celdas.Padding = new Padding(4, 0, 4, 0);
            tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            // Que ningún título de columna quede cortado con "...".
            foreach (DataGridViewColumn columna in tabla.Columns)
            {
                columna.MinimumWidth = columna.GetPreferredWidth(DataGridViewAutoSizeColumnMode.ColumnHeader, true);
            }
        }
    }
}
