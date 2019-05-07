using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ControleFinanceiro.Componente.DockPanel.Docking
{
	internal static class ResourceHelper
	{
        private static ResourceManager _resourceManager = null;

        private static ResourceManager ResourceManager
        {
            get
            {
                if (_resourceManager == null)
                    _resourceManager = new ResourceManager("ControleFinanceiro.Componente.DockPanel.Docking.Strings", typeof(ResourceHelper).Assembly);
                return _resourceManager;
            }

        }

		public static string GetString(string name)
		{
			return ResourceManager.GetString(name);
		}
	}
}
