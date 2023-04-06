using Apex.Scales.Protocols;
using Nikora.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikora.Forms
{
    public partial class ScalesForm : Form
    {
        IAdvancedScale scaleFromType = null;
        BizerbaES10_TCP_SeriesTransmit bizerbaES10_SeriesTransmit;
        ScalesFormHelper Helper;
        public ScalesForm()
        {
            Helper = new ScalesFormHelper();
            bizerbaES10_SeriesTransmit = new BizerbaES10_TCP_SeriesTransmit()
            {
                IP = "192.168.7.161",
                Port = 1365,
            };
            scaleFromType = bizerbaES10_SeriesTransmit;
            InitializeComponent();
            sclaesComboBox.Items.Add("BizerbaES10_TCP_SeriesTransmit");
        }

        private void displayScaleButton_Click(object sender, EventArgs e)
        {
            if (sclaesComboBox.Text != String.Empty)
            {
                if (this.scaleFromType is IWeightInfoSender currentScale2)
                    currentScale2.StartListener();
                ((IWeightInfoSender)scaleFromType).NewWeight += ScaleDisplay_NewWeight;
            }
            else
            {
                MessageBox.Show("აირჩიეთ სასწორი");
            }
        }
        private void ScaleDisplay_NewWeight(object sender, WeightInfoEventArgs e)
        {
            if (weightTextBox.InvokeRequired)
            {
                label1.Invoke(new Action(() => weightTextBox.Text = e.Weight.GrossWeight.ToString()));
            }
            else
            {
                weightTextBox.Text = e.Weight.GrossWeight.ToString();
            }
        }

        private void removeDisplay_Click(object sender, EventArgs e)
        {
            
            if (this.scaleFromType is IWeightInfoSender currentScale2)
            {
                Helper.ClearControls(this.Controls);
                currentScale2.StopListener();
                
            }
        }

        private void sclaesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scaleIPTextBox.Text = scaleFromType.IP;
            scalePortTextBox.Text = scaleFromType.Port.ToString();
            scaleNameTextBox.Text = sclaesComboBox.Text;
        }


        
    }
}
