using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNotes_v2
{
    public partial class StartCall : Form
    {
        public StartCall()
        {
            InitializeComponent();
        }

        public string CallerName
        {
            get { return txt_CallerName.Text; }
        }
        public string CallerNumber
        {
            get { return txt_CallerNumber.Text; }
        }
        public string CallerReason
        {
            get { return txt_CallerReason.Text; }
        }

    }
}
