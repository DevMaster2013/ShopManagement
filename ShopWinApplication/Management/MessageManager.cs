using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinApplication.Management
{
    public static class MessageManager
    {
        public static void SaveDataSuccessMessage(string message)
        {
            MessageBox.Show(message, "محلات الأمانة للوازم المعمار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
        public static void SaveDataFailureMessage(string message)
        {
            MessageBox.Show(message, "محلات الأمانة للوازم المعمار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public static void ValidationMessage(string message, Control validationControl)
        {
            MessageBox.Show(message, "محلات الأمانة للوازم المعمار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            validationControl.Focus();
        }

        public static bool YesNoMessage(string message)
        {
            if (MessageBox.Show(message, "محلات الأمانة للوازم المعمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
