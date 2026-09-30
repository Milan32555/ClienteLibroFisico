using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>
    /// Pantalla de inicio: a la izquierda la información de la aplicación y a la derecha
    /// una ilustración sobria de repisas con libros. Al abrirse, el texto aparece con un fundido corto.
    /// </summary>
    [DesignerCategory("Code")]
    internal class EscenaLibreria : Control
    {
        private const float DURACION_MS = 420f;
        private const int ANCHO_TEXTO = 470;

        private static readonly Color SUPERFICIE = Color.White;
        private static readonly Color PARED = Color.FromArgb(226, 230, 228);
        private static readonly Color TEXTO = Color.FromArgb(27, 27, 27);
        private static readonly Color TEXTO_SECUNDARIO = Color.FromArgb(88, 88, 88);
        private static readonly Color TEXTO_TERCIARIO = Color.FromArgb(128, 128, 128);
        private static readonly Color DIVISOR = Color.FromArgb(229, 229, 229);
        private static readonly Color ROBLE_CARA = Color.FromArgb(214, 180, 138);
        private static readonly Color ROBLE_FRENTE = Color.FromArgb(184, 146, 104);

        // Colores de lomos apagados, como los de una biblioteca real.
        private static readonly Color[] LOMOS =
        {
            Color.FromArgb(47, 62, 85), Color.FromArgb(122, 46, 46), Color.FromArgb(63, 94, 74),
            Color.FromArgb(196, 154, 69), Color.FromArgb(91, 103, 112), Color.FromArgb(232, 226, 214),
            Color.FromArgb(205, 184, 148), Color.FromArgb(166, 95, 70), Color.FromArgb(58, 58, 60),
            Color.FromArgb(126, 149, 168), Color.FromArgb(124, 122, 78), Color.FromArgb(240, 236, 228)
        };

        private enum Postura { DePie, Inclinado, Acostado }

        private class Libro
        {
            public Rectangle Area;
            public Color Color;
            public Postura Postura;
            public int Detalle;
        }

        private readonly Timer reloj = new Timer { Interval = 15 };
        private readonly Stopwatch cronometro = new Stopwatch();
        private readonly List<Libro> libros = new List<Libro>();
        private readonly List<Rectangle> repisas = new List<Rectangle>();
        private Rectangle planta;
        private Size tamanoCalculado;
        private float progreso = 1f;

        public EscenaLibreria()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            reloj.Tick += (s, e) =>
            {
                progreso = Math.Min(1f, cronometro.ElapsedMilliseconds / DURACION_MS);
                if (progreso >= 1f) reloj.Stop();
                Invalidate(new Rectangle(0, 0, ANCHO_TEXTO, Height));
            };
        }

        /// <summary>Reproduce el fundido de entrada del texto.</summary>
        public void Animar()
        {
            progreso = 0f;
            cronometro.Restart();
            reloj.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) reloj.Dispose();
            base.Dispose(disposing);
        }

        // ---------------------------------------------------------------- distribución

        private void Distribuir()
        {
            tamanoCalculado = ClientSize;
            libros.Clear();
            repisas.Clear();

            int ancho = 360;
            int x0 = ANCHO_TEXTO + (ClientSize.Width - ANCHO_TEXTO - ancho) / 2;
            int separacion = (ClientSize.Height - 120) / 3;
            for (int i = 0; i < 3; i++)
            {
                repisas.Add(new Rectangle(x0, 60 + separacion * (i + 1) - 14, ancho, 14));
            }

            Random azar = new Random(24);
            int color = 0;
            Func<Color> siguiente = () => LOMOS[(color++ * 7) % LOMOS.Length];

            // Repisa 1: libros y una planta a la derecha.
            Rectangle r1 = repisas[0];
            LlenarDePie(r1, r1.X + 14, r1.Right - 84, azar, siguiente);
            planta = new Rectangle(r1.Right - 70, r1.Y - 92, 56, 92);

            // Repisa 2: una pila de libros acostados y luego libros de pie.
            Rectangle r2 = repisas[1];
            int[] anchosPila = { 96, 88, 92, 80 };
            int[] altosPila = { 16, 13, 15, 12 };
            int y = r2.Y;
            for (int i = 0; i < anchosPila.Length; i++)
            {
                y -= altosPila[i];
                libros.Add(new Libro
                {
                    Area = new Rectangle(r2.X + 10 + (i % 2) * 5, y, anchosPila[i], altosPila[i]),
                    Color = siguiente(), Postura = Postura.Acostado
                });
            }
            LlenarDePie(r2, r2.X + 122, r2.Right - 12, azar, siguiente);

            // Repisa 3: libros de pie y uno inclinado sobre el último.
            Rectangle r3 = repisas[2];
            int x = LlenarDePie(r3, r3.X + 14, r3.Right - 70, azar, siguiente);
            libros.Add(new Libro
            {
                Area = new Rectangle(x + 17, r3.Y, 24, 100),
                Color = siguiente(), Postura = Postura.Inclinado, Detalle = 1
            });
        }

        private int LlenarDePie(Rectangle repisa, int x, int limite, Random azar, Func<Color> color)
        {
            while (true)
            {
                int ancho = azar.Next(15, 31);
                if (x + ancho > limite) break;
                int alto = azar.Next(78, 118);
                libros.Add(new Libro
                {
                    Area = new Rectangle(x, repisa.Y - alto, ancho, alto),
                    Color = color(), Postura = Postura.DePie, Detalle = azar.Next(4)
                });
                x += ancho + (azar.Next(5) == 0 ? 2 : 0);
            }
            return x;
        }

        // ---------------------------------------------------------------- dibujo

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ClientSize != tamanoCalculado) Distribuir();

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle texto = new Rectangle(0, 0, ANCHO_TEXTO, Height);
            Rectangle ilustracion = new Rectangle(ANCHO_TEXTO, 0, Width - ANCHO_TEXTO, Height);

            using (SolidBrush fondo = new SolidBrush(SUPERFICIE)) g.FillRectangle(fondo, texto);
            using (SolidBrush pared = new SolidBrush(PARED)) g.FillRectangle(pared, ilustracion);

            DibujarIlustracion(g);
            DibujarTexto(g, texto);
        }

        private void DibujarIlustracion(Graphics g)
        {
            foreach (Rectangle repisa in repisas)
            {
                // Sombra suave de la repisa sobre la pared.
                Rectangle sombra = new Rectangle(repisa.X + 4, repisa.Bottom, repisa.Width - 8, 14);
                using (LinearGradientBrush pincel = new LinearGradientBrush(sombra,
                    Color.FromArgb(46, 0, 0, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Vertical))
                {
                    g.FillRectangle(pincel, sombra);
                }
            }

            foreach (Libro libro in libros)
            {
                switch (libro.Postura)
                {
                    case Postura.DePie:
                        DibujarLomo(g, libro.Area, libro.Color, libro.Detalle);
                        break;
                    case Postura.Acostado:
                        DibujarAcostado(g, libro.Area, libro.Color);
                        break;
                    default:
                        GraphicsState estado = g.Save();
                        g.TranslateTransform(libro.Area.X, libro.Area.Y);
                        g.RotateTransform(-12f);
                        DibujarLomo(g, new Rectangle(0, -libro.Area.Height, libro.Area.Width, libro.Area.Height), libro.Color, libro.Detalle);
                        g.Restore(estado);
                        break;
                }
            }

            foreach (Rectangle repisa in repisas)
            {
                using (SolidBrush frente = new SolidBrush(ROBLE_FRENTE)) g.FillRectangle(frente, repisa);
                using (SolidBrush cara = new SolidBrush(ROBLE_CARA)) g.FillRectangle(cara, repisa.X, repisa.Y, repisa.Width, 4);
            }

            DibujarPlanta(g);
        }

        private static void DibujarLomo(Graphics g, Rectangle r, Color color, int detalle)
        {
            bool claro = color.GetBrightness() > 0.7f;
            Color linea = claro ? Color.FromArgb(150, 60, 55, 50) : Color.FromArgb(110, 255, 255, 255);

            using (SolidBrush fondo = new SolidBrush(color)) g.FillRectangle(fondo, r);
            // Borde derecho un poco más oscuro para separar un libro del otro.
            using (SolidBrush canto = new SolidBrush(Color.FromArgb(40, 0, 0, 0))) g.FillRectangle(canto, r.Right - 2, r.Y, 2, r.Height);

            using (Pen pluma = new Pen(linea, 1f))
            using (SolidBrush etiqueta = new SolidBrush(linea))
            {
                switch (detalle)
                {
                    case 0: // dos filetes arriba y abajo
                        g.DrawLine(pluma, r.X + 3, r.Y + 9, r.Right - 5, r.Y + 9);
                        g.DrawLine(pluma, r.X + 3, r.Bottom - 9, r.Right - 5, r.Bottom - 9);
                        break;
                    case 1: // título simulado en vertical
                        g.FillRectangle(etiqueta, r.X + r.Width / 2 - 2, r.Y + 16, 3, r.Height / 2);
                        break;
                    case 2: // etiqueta rectangular
                        if (r.Width > 20) g.FillRectangle(etiqueta, r.X + 4, r.Y + 14, r.Width - 10, 12);
                        break;
                    default: // banda ancha al pie
                        g.FillRectangle(etiqueta, r.X, r.Bottom - 22, r.Width - 2, 8);
                        break;
                }
            }
        }

        private static void DibujarAcostado(Graphics g, Rectangle r, Color color)
        {
            using (SolidBrush fondo = new SolidBrush(color)) g.FillRectangle(fondo, r);
            using (SolidBrush canto = new SolidBrush(Color.FromArgb(40, 0, 0, 0))) g.FillRectangle(canto, r.X, r.Bottom - 2, r.Width, 2);
            bool claro = color.GetBrightness() > 0.7f;
            using (Pen pluma = new Pen(claro ? Color.FromArgb(150, 60, 55, 50) : Color.FromArgb(110, 255, 255, 255)))
            {
                g.DrawLine(pluma, r.X + 12, r.Y + r.Height / 2, r.X + 12 + r.Width / 3, r.Y + r.Height / 2);
            }
        }

        private void DibujarPlanta(Graphics g)
        {
            Rectangle z = planta;
            PointF baseHojas = new PointF(z.X + z.Width / 2f, z.Bottom - 30);
            float[] angulos = { -58, -32, -10, 12, 36, 60, -80, 80 };
            float[] largos = { 46, 56, 60, 58, 52, 42, 30, 30 };
            for (int i = 0; i < angulos.Length; i++)
            {
                GraphicsState estado = g.Save();
                g.TranslateTransform(baseHojas.X, baseHojas.Y);
                g.RotateTransform(angulos[i]);
                using (SolidBrush hoja = new SolidBrush(i % 2 == 0 ? Color.FromArgb(86, 122, 88) : Color.FromArgb(112, 146, 104)))
                {
                    g.FillEllipse(hoja, -5.5f, -largos[i], 11, largos[i]);
                }
                g.Restore(estado);
            }

            PointF[] maceta =
            {
                new PointF(z.X + 12, z.Bottom - 32), new PointF(z.Right - 12, z.Bottom - 32),
                new PointF(z.Right - 17, z.Bottom), new PointF(z.X + 17, z.Bottom)
            };
            using (SolidBrush barro = new SolidBrush(Color.FromArgb(236, 233, 227))) g.FillPolygon(barro, maceta);
            using (SolidBrush sombra = new SolidBrush(Color.FromArgb(24, 0, 0, 0)))
            {
                g.FillPolygon(sombra, new[] { maceta[1], maceta[2], new PointF(z.Right - 24, z.Bottom), new PointF(z.Right - 19, z.Bottom - 32) });
            }
        }

        private void DibujarTexto(Graphics g, Rectangle area)
        {
            float t = progreso;
            float p = 1f - (1f - t) * (1f - t);
            int a = (int)(255 * p);
            int dy = (int)((1f - p) * 10);
            int x = 56;
            int ancho = area.Width - x - 48;

            using (Font fEtiqueta = new Font("Segoe UI Semibold", 9f))
            using (Font fTitulo = new Font("Segoe UI Semibold", 26f))
            using (Font fCuerpo = new Font("Segoe UI", 11f))
            using (Font fSeccion = new Font("Segoe UI Semibold", 10.5f))
            using (Font fPie = new Font("Segoe UI", 8.75f))
            using (SolidBrush principal = new SolidBrush(Color.FromArgb(a, TEXTO)))
            using (SolidBrush secundario = new SolidBrush(Color.FromArgb(a, TEXTO_SECUNDARIO)))
            using (SolidBrush terciario = new SolidBrush(Color.FromArgb(a, TEXTO_TERCIARIO)))
            using (Pen divisor = new Pen(Color.FromArgb(a, DIVISOR)))
            {
                int y = 72 + dy;
                g.DrawString("Universidad de Ibagué  ·  Diseño de Soluciones", fEtiqueta, terciario, x, y);

                y += 28;
                RectangleF titulo = new RectangleF(x - 2, y, ancho, 90);
                g.DrawString("Gestión de\nLibros Físicos", fTitulo, principal, titulo);

                y += 102;
                string descripcion = "Cliente de escritorio para administrar el catálogo de libros impresos: " +
                                     "registrar, consultar, actualizar, eliminar y listar.";
                g.DrawString(descripcion, fCuerpo, secundario, new RectangleF(x, y, ancho, 60));

                y += 84;
                g.DrawLine(divisor, x, y, x + ancho, y);

                y += 20;
                g.DrawString("Para empezar", fSeccion, principal, x, y);
                y += 26;
                g.DrawString("Abre el menú Libro físico y elige la operación que necesitas.", fCuerpo, secundario,
                    new RectangleF(x, y, ancho, 50));

                // Pie: versión e integrantes.
                Version v = typeof(EscenaLibreria).Assembly.GetName().Version;
                int yPie = area.Bottom - 90;
                g.DrawLine(divisor, x, yPie, x + ancho, yPie);
                g.DrawString("Versión " + v.Major + "." + v.Minor + "." + v.Build, fPie, terciario, x, yPie + 14);
                g.DrawString("Equipo: Sara Zambrano, Alejandra González,\nMisael Gallo y Santiago Guimel", fPie, terciario, x, yPie + 34);
            }
        }
    }
}
