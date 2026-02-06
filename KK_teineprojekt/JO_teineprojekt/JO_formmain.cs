using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JO_teineprojekt
{
    public partial class JO_formmain : Form
    {
        public JO_formmain()
        {
            InitializeComponent();
        }

        private void JO_button1_Click(object sender, EventArgs e)
        {
            JO_3 F1 = new JO_3();
            F1.JO_button3 = this.JO_button1;
            F1.Show();
            JO_button1.Enabled = false; 
        }

        private void JO_button2_Click(object sender, EventArgs e)
        {
            JO_form2_06_02_26 F2 = new JO_form2_06_02_26(); 
            F2.button4 = this.JO_button2;
            F2.Visible = true;
            F2.Show();  
            JO_button2.Enabled = false;  
        }
    }
    }
