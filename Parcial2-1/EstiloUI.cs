using System.Drawing;
using System.Windows.Forms;

namespace Parcial2_1
{
    internal static class EstiloUI
    {
        // Paleta Verde Esmeralda / Teal Oscuro Corporativo (diferente al azul estándar)
        public static readonly Color ColorEncabezado = Color.FromArgb(17, 75, 95);
        public static readonly Color ColorAcento = Color.FromArgb(2, 128, 144);
        public static readonly Color ColorSecundario = Color.FromArgb(69, 105, 144);
        public static readonly Color ColorPeligro = Color.FromArgb(214, 64, 69);
        public static readonly Color FondoVentana = Color.FromArgb(242, 247, 246);
        public static readonly Color FilaAlterna = Color.FromArgb(234, 244, 244);
        public static readonly Color SeleccionGrilla = Color.FromArgb(199, 232, 235);
        public static readonly Color BordeGrilla = Color.FromArgb(210, 226, 226);

        public static void AplicarFormulario(Form form)
        {
            form.BackColor = FondoVentana;

            foreach (Control ctrl in form.Controls)
            {
                EstilizarControl(ctrl);
            }
        }

        private static void EstilizarControl(Control ctrl)
        {
            if (ctrl is Panel pnl && pnl.Dock == DockStyle.Top)
            {
                pnl.BackColor = ColorEncabezado;

                // Barra inferior decorativa color turquesa en el encabezado
                bool tieneBarra = false;
                foreach (Control c in pnl.Controls)
                {
                    if (c.Name == "pnlBarraAcento") { tieneBarra = true; break; }
                }
                if (!tieneBarra)
                {
                    Panel barra = new Panel
                    {
                        Name = "pnlBarraAcento",
                        Dock = DockStyle.Bottom,
                        Height = 4,
                        BackColor = Color.FromArgb(0, 180, 160)
                    };
                    pnl.Controls.Add(barra);
                }
            }
            else if (ctrl is DataGridView dgv)
            {
                AplicarTabla(dgv);
            }
            else if (ctrl is Button btn)
            {
                AplicarBoton(btn);
            }
            else if (ctrl is GroupBox grp)
            {
                grp.BackColor = Color.White;
                grp.ForeColor = ColorEncabezado;
                grp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
                foreach (Control child in grp.Controls)
                {
                    if (child is Label lbl && lbl.BorderStyle == BorderStyle.None)
                    {
                        lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                        lbl.ForeColor = Color.FromArgb(40, 55, 60);
                    }
                    else if (child is TextBox txt)
                    {
                        txt.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    }
                    EstilizarControl(child);
                }
                return;
            }

            foreach (Control child in ctrl.Controls)
            {
                EstilizarControl(child);
            }
        }

        public static void AplicarTabla(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = BordeGrilla;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorEncabezado;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorEncabezado;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            dgv.RowTemplate.Height = 32;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 45, 50);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = SeleccionGrilla;
            dgv.DefaultCellStyle.SelectionForeColor = ColorEncabezado;
            dgv.DefaultCellStyle.Padding = new Padding(6, 2, 6, 2);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = FilaAlterna;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 45, 50);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = SeleccionGrilla;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = ColorEncabezado;
        }

        public static void AplicarBoton(Button btn)
        {
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;

            string t = (btn.Text ?? "").Trim();
            if (t == "|<" || t == "<" || t == ">" || t == ">|" || t == "<<" || t == ">>")
            {
                btn.BackColor = Color.FromArgb(234, 244, 244);
                btn.ForeColor = ColorEncabezado;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.FromArgb(165, 200, 205);
                btn.FlatAppearance.MouseOverBackColor = SeleccionGrilla;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
            else if (t == "Nuevo" || t == "Guardar")
            {
                btn.BackColor = ColorAcento;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = ColorEncabezado;
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
            }
            else if (t == "Modificar" || t == "Cancelar")
            {
                btn.BackColor = ColorSecundario;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 80, 115);
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
            }
            else if (t == "Eliminar")
            {
                btn.BackColor = ColorPeligro;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 45, 50);
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
            }
            else if (t == "Cerrar")
            {
                btn.BackColor = Color.FromArgb(218, 228, 228);
                btn.ForeColor = Color.FromArgb(40, 55, 60);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 210, 210);
                btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
            }
        }
    }
}

