using Apex.Scales.Protocols;
using Nikora.Core.Models.DataLayer;
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
        
        ScalesFormHelper Helper;
        NikoraDBContext NikoraDBContext;
        public ScalesForm()
        {
            Helper = new ScalesFormHelper();
            NikoraDBContext = new NikoraDBContext();
            scaleFromType = null;
            InitializeComponent();
            
            var data = (from d in NikoraDBContext.ScaleModels select d);
            dataGridView1.DataSource = data.ToList();
            

        }

        private void displayScaleButton_Click(object sender, EventArgs e)
        {
            if (scaleIPTextBox.Text != String.Empty)
            {
                switch (scaleNameTextBox.Text)
                {
                    case "BizerbaES10_TCP_SeriesTransmit":
                        BizerbaES10_TCP_SeriesTransmit bizerbaES10_SeriesTransmit = new BizerbaES10_TCP_SeriesTransmit()
                        {
                            IP = scaleIPTextBox.Text,
                            Port = int.Parse(scalePortTextBox.Text),
                        };
                        scaleFromType = bizerbaES10_SeriesTransmit;
                        break;
                }
                if (scaleFromType != null)
                {
                    if (this.scaleFromType is IWeightInfoSender currentScale2)
                        currentScale2.StartListener();
                    ((IWeightInfoSender)scaleFromType).NewWeight += ScaleDisplay_NewWeight;
                }
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
            dataGridView1.DisplayedColumnCount(true);
            dataGridView1.DisplayedRowCount(true);
            dataGridView1.AutoResizeColumns();
            if (this.scaleFromType is IWeightInfoSender currentScale2)
            {
                Helper.ClearControls(this.Controls);
                currentScale2.StopListener();
                
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<Control> textboxList = new List<Control>();
            textboxList.Add(scaleIPTextBox);
            textboxList.Add(scalePortTextBox);
            textboxList.Add(scaleNameTextBox);
            if (Helper.Validation(textboxList))
            {
                NikoraDBContext.ScaleModels.Add(new ScaleModel
                {
                    ScaleIP = scaleIPTextBox.Text,
                    ScalePort = scalePortTextBox.Text,
                    ScaleName = scaleNameTextBox.Text,
                });
                NikoraDBContext.SaveChanges();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string scaleName = row.Cells["ScaleName"].Value.ToString();
                var scale = NikoraDBContext.ScaleModels.Where(x => x.ScaleName == scaleName).FirstOrDefault();
                if (scale != null)
                {
                    scaleIPTextBox.Text = scale.ScaleIP;
                    scalePortTextBox.Text = scale.ScalePort;
                    scaleNameTextBox.Text = scale.ScaleName;
                }
            }
            

        }
    }
}
