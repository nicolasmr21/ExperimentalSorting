using ExperimentalSorting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentalSorting
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Treatment t = new Treatment(new Experiment().generate(comboState.SelectedIndex, comboSize.SelectedIndex), comboAlgorithm.SelectedItem.Equals("Counting Sort"));
            t.orderArray();
        }

        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
