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
    public class TextBoxVerificador : TextBox
    {
        private Timer timerAlerta;
        private IContainer components;
        private Color BackColorBackup = Color.Empty;

        private object valorOriginal = null;
        protected object ValorOriginal
        {
            get { return valorOriginal; }
            set { valorOriginal = value; }
        }

        private bool aoEditarRemoverFormatacao = false;
        [DefaultValue(false)]
        public bool AoEditarRemoverFormatacao
        {
            get { return aoEditarRemoverFormatacao; }
            set { aoEditarRemoverFormatacao = value; }
        }

        private bool aoSairAplicarTrim = true;
        [DefaultValue(true)]
        public bool AoSairAplicarTrim
        {
            get { return aoSairAplicarTrim; }
            set { aoSairAplicarTrim = value; }
        }

        private bool aoSairRemoverEnter = true;
        [DefaultValue(true)]
        public bool AoSairRemoverEnter
        {
            get { return aoSairRemoverEnter; }
            set { aoSairRemoverEnter = value; }
        }

        private Color corDoAlerta = Color.Red;
        public Color CorDoAlerta
        {
            get { return corDoAlerta; }
            set { corDoAlerta = value; }
        }

        public TextBoxVerificador()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAlerta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerAlerta
            // 
            this.timerAlerta.Interval = 100;
            this.timerAlerta.Tick += new System.EventHandler(this.timerAlerta_Tick);
            // 
            // TextBoxMoeda
            // 
            this.Leave += new System.EventHandler(this.evento_Leave);
            this.Enter += new System.EventHandler(this.evento_Enter);
            this.ResumeLayout(false);

        }

        private void evento_Enter(object sender, EventArgs e)
        {
            if (AoEditarRemoverFormatacao && !string.IsNullOrEmpty(Text))
            {
                base.Text = this.ValorOriginal.ToString();
            }
        }

        private void evento_Leave(object sender, EventArgs e)
        {
            if (!VerificarTextoOk(base.Text))
            {
                Sinalizar();
            }
            if (AoSairAplicarTrim)
            {
                base.Text = base.Text.Trim();
            }
            if (AoSairRemoverEnter)
            {
                base.Text = base.Text.Replace("\n\r", " ").Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ");
            }
        }

        protected virtual bool VerificarTextoOk(string texto)
        {
            return true;
        }

        private void Sinalizar()
        {
            timerAlerta.Tag = 4;
            timerAlerta.Enabled = true;
        }

        private void timerAlerta_Tick(object sender, EventArgs e)
        {
            if (BackColorBackup == Color.Empty)
            {
                BackColorBackup = base.BackColor;
            }

            if (base.BackColor == BackColorBackup)
            {
                base.BackColor = CorDoAlerta;
            }
            else
            {
                base.BackColor = BackColorBackup;
            }

            timerAlerta.Tag = ((int)timerAlerta.Tag) - 1;
            if ((int)timerAlerta.Tag == 0)
            {
                timerAlerta.Enabled = false;
            }
        }
    }
}
