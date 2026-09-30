using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Aspecto de la barra de menú: claro y sobrio, al estilo de las aplicaciones de Windows 11.</summary>
    internal class EstiloMenu : ToolStripProfessionalRenderer
    {
        private static readonly Color FONDO_BARRA = Color.FromArgb(249, 249, 249);
        private static readonly Color TEXTO_BARRA = Color.FromArgb(27, 27, 27);
        private static readonly Color RESALTE_BARRA = Color.FromArgb(234, 234, 234);
        private static readonly Color TEXTO_MENU = Color.FromArgb(27, 27, 27);
        private static readonly Color RESALTE_MENU = Color.FromArgb(240, 240, 240);
        private static readonly Color BORDE_MENU = Color.FromArgb(218, 218, 218);
        public EstiloMenu() : base(new ColoresMenu())
        {
            RoundedEdges = false;
        }

        /// <summary>Aplica el estilo a la barra de menú y a sus submenús.</summary>
        public static void Aplicar(MenuStrip menu)
        {
            menu.Renderer = new EstiloMenu();
            menu.BackColor = FONDO_BARRA;
            menu.Padding = new Padding(14, 6, 0, 6);

            foreach (ToolStripItem superior in menu.Items)
            {
                superior.Padding = new Padding(10, 3, 10, 3);
                ToolStripMenuItem item = superior as ToolStripMenuItem;
                if (item == null) continue;

                // Sin columna de íconos: el texto arranca pegado al margen.
                ((ToolStripDropDownMenu)item.DropDown).ShowImageMargin = false;
                item.DropDown.Padding = new Padding(2, 6, 2, 6);
                foreach (ToolStripItem hijo in item.DropDownItems)
                {
                    hijo.Font = new Font("Segoe UI", 10f);
                    hijo.Padding = new Padding(10, 5, 24, 5);
                }
            }
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Color fondo = e.ToolStrip is MenuStrip ? FONDO_BARRA : Color.White;
            using (SolidBrush pincel = new SolidBrush(fondo))
            {
                e.Graphics.FillRectangle(pincel, e.AffectedBounds);
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is MenuStrip)
            {
                // Línea fina que separa la barra del contenido.
                using (Pen linea = new Pen(Color.FromArgb(229, 229, 229)))
                {
                    e.Graphics.DrawLine(linea, 0, e.ToolStrip.Height - 1, e.ToolStrip.Width, e.ToolStrip.Height - 1);
                }
                return;
            }
            using (Pen borde = new Pen(BORDE_MENU))
            {
                Rectangle r = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
                e.Graphics.DrawRectangle(borde, r);
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            // Sin franja gris detrás de los íconos.
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)e.Item;
            bool activo = item.Selected || item.Pressed;
            if (!activo || !item.Enabled) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            bool superior = item.Owner is MenuStrip;
            Rectangle r = superior
                ? new Rectangle(0, 1, item.Width - 1, item.Height - 3)
                : new Rectangle(4, 1, item.Width - 9, item.Height - 3);

            using (GraphicsPath ruta = Redondeado(r, 6))
            using (SolidBrush pincel = new SolidBrush(superior ? RESALTE_BARRA : RESALTE_MENU))
            {
                g.FillPath(pincel, ruta);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            bool superior = e.Item.Owner is MenuStrip;
            if (superior)
            {
                e.TextColor = TEXTO_BARRA;
            }
            else
            {
                e.TextColor = TEXTO_MENU;
            }
            base.OnRenderItemText(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            int y = e.Item.Height / 2;
            using (Pen linea = new Pen(Color.FromArgb(236, 226, 211)))
            {
                e.Graphics.DrawLine(linea, 12, y, e.Item.Width - 12, y);
            }
        }

        private static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            GraphicsPath ruta = new GraphicsPath();
            ruta.AddArc(r.X, r.Y, d, d, 180, 90);
            ruta.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            ruta.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            ruta.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            ruta.CloseFigure();
            return ruta;
        }

        /// <summary>Colores base para lo que el renderizador no dibuja a mano.</summary>
        private class ColoresMenu : ProfessionalColorTable
        {
            public override Color MenuBorder { get { return BORDE_MENU; } }
            public override Color ToolStripDropDownBackground { get { return Color.White; } }
            public override Color ImageMarginGradientBegin { get { return Color.White; } }
            public override Color ImageMarginGradientMiddle { get { return Color.White; } }
            public override Color ImageMarginGradientEnd { get { return Color.White; } }
        }
    }
}
