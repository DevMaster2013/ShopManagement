using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinApplication.Management
{
    public static class OpenForms
    {
        private static Dictionary<string, Form> _openForms = new Dictionary<string, Form>();
        public static void AddOpenedForm(Form frm)
        {
            if (!_openForms.ContainsKey(frm.Name))
            {
                _openForms.Add(frm.Name, frm);
                //if (frm.Name != "frmMain")
                //{
                //    frm.MdiParent = GetForm("frmMain");
                //    frm.TopMost = true;
                //}
            }
        }
        public static Form GetForm(string name)
        {
            if (_openForms.ContainsKey(name))
                return _openForms[name];
            return null;
        }
        public static void RemoveForm(Form frm)
        {
            if (_openForms.ContainsKey(frm.Name))
                _openForms.Remove(frm.Name);
        }
    }
}
