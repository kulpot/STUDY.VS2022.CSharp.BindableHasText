using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindableHasText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.DataBindings.Add("Enabled", exTextbox1, "HasText");
        }
    }
}
