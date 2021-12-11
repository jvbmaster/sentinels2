using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Views
{
    public class RigthContextMenu
    {
        private ContextMenuStrip _menu = null;
        private Form _form = null;

        public List<string> Items { get; set; }


        public RigthContextMenu(Form form)
        {
            _menu = new ContextMenuStrip();
            _form = form;
            _form.ContextMenuStrip = _menu;
        }

        public void RightClick()
        {
            foreach (var item in Items)
            {
                _menu.Items.Add(item);
            }
        }
    }
}
