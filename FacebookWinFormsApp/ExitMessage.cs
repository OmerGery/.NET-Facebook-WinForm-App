using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
namespace BasicFacebookFeatures
{
    public class ExitMessage : IExitObserver
    {
        public void UpdateExited()
        {
            MessageBox.Show("Bye Bye :)");
        }
    }
}
