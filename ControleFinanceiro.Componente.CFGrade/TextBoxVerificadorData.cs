using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace ControleFinanceiro.Componente.CFGrade
{
    public class TextBoxVerificadorData : TextBoxVerificador
    {
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public bool CalendarioExibido
        {
            get { return this.dateTimePicker.Visible; }
            set
            {
                this.dateTimePicker.Visible = value;
                if (this.dateTimePicker.Visible)
                {
                    try
                    {
                        this.dateTimePicker.Value = FormatarData(this.Text);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            this.dateTimePicker.Value = (DateTime)ValorOriginal;
                        }
                        catch (Exception)
                        {
                            this.dateTimePicker.Value = DateTime.Now;
                        }
                    }
                    this.Text = FormatarData(this.dateTimePicker.Value);
                    
                    int x = 1;
                    int y = 1;
                    int lParam = x + y * 0x00010000;
                    
                    PostMessage(dateTimePicker.Handle, WM_LBUTTONDOWN, 1, lParam);
                    PostMessage(dateTimePicker.Handle, WM_LBUTTONUP, 1, lParam);
                }
            }
        }

        private DateTimePicker dateTimePicker;

        public TextBoxVerificadorData()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        private void InitializeComponent2()
        {
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.Parent = this;
            this.dateTimePicker.Left = 0;
            this.dateTimePicker.Top = 0;
            this.dateTimePicker.Width = 8;
            this.dateTimePicker.Height = 5;
            this.dateTimePicker.Left = -8;
            this.dateTimePicker.Top = 0;
        }

        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            this.dateTimePicker.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            this.dateTimePicker.CloseUp += new System.EventHandler(this.dateTimePicker_CloseUp);
            // 
            // TextBoxVerificadorData
            // 
            this.MaxLength = 10;
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.evento_MouseDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evento_KeyPress);
            this.ResumeLayout(false);

        }

        protected override bool VerificarTextoOk(string texto)
        {
            texto = texto == null ? null : texto.Trim();
            if (!string.IsNullOrEmpty(texto))
            {
                try
                {
                    ValorOriginal = FormatarData(texto);
                    base.Text = FormatarData((DateTime)ValorOriginal);
                }
                catch (FormatException)
                {
                    base.Text = "";
                    return false;
                }
            }
            else
            {
                ValorOriginal = null;
            }
            return true;
        }

        private void evento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar == 13)
            {
                CalendarioExibido = true;
                e.Handled = true;
            }
            if ((byte)e.KeyChar >= 32)
            {
                if ((Regex.Replace(e.KeyChar.ToString(), "[^0-9,/]", string.Empty) == string.Empty) ||
                    (e.KeyChar == '/' && this.Text.Substring(this.SelectionStart - 1, 1) == "/") ||
                    (e.KeyChar == '/' && Regex.Matches(this.Text, "/").Count >= 2))
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar != '/') &&
                         (Regex.Matches(this.Text, "/").Count < 2) &&
                         ((this.SelectionStart - 2 >= 0 && Regex.Match(this.Text.Substring(this.SelectionStart - 2, 2), "(/[0-9]{2}|^[0-9]{2})").Success) ||
                          (this.SelectionStart - 2 < 0 && Regex.Match(this.Text.Substring(0, this.SelectionStart), "(/[0-9]{2}|^[0-9]{2})").Success)))
                {
                    int backupSelectionStart = this.SelectionStart;
                    this.Text = this.Text.Insert(this.SelectionStart, "/");
                    this.SelectionStart = backupSelectionStart + 1;
                }
            }
        }

        private string FormatarData(DateTime valor)
        {
            string data = valor.ToShortDateString();
            if (data.IndexOf("/") == 1)
            {
                data = data.Insert(0, "0");
            }
            if (data.LastIndexOf("/") == 4)
            {
                data = data.Insert(3, "0");
            }
            if (data.LastIndexOf("/") == 6)
            {
                data = data.Insert(5, "0");
            }
            if (data.LastIndexOf("/") == data.Length - 2)
            {
                data = data.Insert(data.Length - 1, "0");
            }
            return data;
        }

        private DateTime FormatarData(string valor)
        {
            return Convert.ToDateTime(valor);
        }

        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            this.dateTimePicker.Visible = false;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.Text = FormatarData(this.dateTimePicker.Value);
        }

        private void dateTimePicker_CloseUp(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void evento_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks >= 2)
            {
                CalendarioExibido = true;
            }
        }
    }
}
