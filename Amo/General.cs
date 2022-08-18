using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amo
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        protected Sim _simSelect;

        private void SelectSim(Sim sim)
        {
            _simSelect = sim;

            DensityTrack.Value = sim.Density;
            PointSizeTrack.Value = sim.PointSize;

            DensityTrack.Enabled = !sim.Running;
            PointSizeTrack.Enabled = !sim.Running;

            startSimBtn.Enabled = !sim.Running;

            SimIdLabel.Text = sim.GuId;

            // Activated Form;

            sim.DisplayForm.Activate();

            var index = SimulationList.Items.IndexOf(sim);
            if (index > -1)
            {
                SimulationList.SelectedIndex = index;
            }
        }

        private void AddSimBtn_Click(object sender, EventArgs e)
        {
            var sim = new Sim();

            sim.DisplayForm.MdiParent = this;
            sim.DisplayForm.Show();

            sim.DisplayForm.Activated += (s, e) => 
            {
                SelectSim(sim);
            };

            sim.Droped += delegate (Sim s)
            {
                SimulationList.Items.Remove(s);

                if (SimulationList.Items.Count > 0)
                {
                    SelectSim(SimulationList.Items[0] as Sim);
                }

                return true;
            };

            sim.Resumed += s => 
            { 
                if (s == _simSelect)
                {
                    startSimBtn.Enabled = false;
                }
            };

            sim.Paused += s =>
            {
                if (s == _simSelect)
                {
                    startSimBtn.Enabled = true;
                }
            };

            SimulationList.Items.Add(sim);

            SelectSim(sim);

            // TODO
            // Создать новую симуляцию.
        }

        private void ResumeAllSimBtn_Click(object sender, EventArgs e)
        {
            // TODO
            // Продолжить все симуляции.

            foreach (var sim in SimulationList.Items)
            {
                var s = ((Sim)sim);

                if (!s.Running)
                {
                    s.Resume();
                }
            }
        }

        private void PauseAllSimBtn_Click(object sender, EventArgs e)
        {
            // TODO
            // Приостановить все симуляции.

            foreach (var sim in SimulationList.Items)
            {
                var s = ((Sim)sim);

                if (s.Running)
                {
                    s.Pause();
                }
            }
        }

        private void SimulationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = (sender as ListBox);
            var index = list.SelectedIndex;

            if (index < 0)
                return;

            var sim = list.Items[index] as Sim;

            SelectSim(sim);

            // TODO
            // Ставим выбранную симуляцию как управляемую.
        }

        private void DensityTrack_Scroll(object sender, EventArgs e)
        {
            if (_simSelect != null)
            {
                _simSelect.Init(DensityTrack.Value, PointSizeTrack.Value);
            }
        }

        private void PointSizeTrack_Scroll(object sender, EventArgs e)
        {
            if (_simSelect != null)
            {
                _simSelect.Init(DensityTrack.Value, PointSizeTrack.Value);
            }
        }

        private void startSimBtn_Click(object sender, EventArgs e)
        {
            if (_simSelect == null)
            {
                return;
            }

            _simSelect.Start();
        }

        private void stopSimBtn_Click(object sender, EventArgs e)
        {
            if (_simSelect == null)
            {
                return;
            }

            _simSelect.Stop();
        }
    }
}
