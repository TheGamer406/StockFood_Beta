using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Hola Mundo
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.button1, "My button1");
            InitializeComponent();
        
        }
    }
}
