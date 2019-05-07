using System;
using System.Windows.Forms;

namespace ControleFinanceiro.Componente.DockPanel.Docking
{
	internal class DummyControl : Control
	{
		public DummyControl()
		{
			SetStyle(ControlStyles.Selectable, false);
		}
	}
}
