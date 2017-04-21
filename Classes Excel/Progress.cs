using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importer.Classes_Excel
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }
        public void setProgressbarMax(int max)
        {
            progressBar1.Maximum = max;
        }
        public void progressBarAdd()
        {
            progressBar1.PerformStep();/////////////
        }
        public void progressBarStop()
        {
            progressBar1.Value = progressBar1.Maximum;
        }
    }
}
