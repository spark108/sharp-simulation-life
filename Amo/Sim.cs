using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Amo
{
    public class Sim
    {
        public string GuId { get; private set; }

        public readonly Form DisplayForm;

        public readonly PlainDraw Plain;

        public bool Running { get; private set; }

        private bool Closed { get; set; }

        public int Density { get; private set; }

        public int PointSize { get; private set; }

        public delegate bool SimDropHandler(Sim s);
        public delegate void SimPauseHandler(Sim s);
        public delegate void SimResumeHandler(Sim s);

        public event SimDropHandler Droped;
        public event SimPauseHandler Paused;
        public event SimResumeHandler Resumed;

        public bool ViewGrid { get; set; } = false;

        private Cell[,] fdata;
        private int rows = 1;
        private int cols = 1;

        private int gen;

        private BackgroundWorker worker;

        public Sim()
        {
            GuId = Guid.NewGuid().ToString();
            Running = false;
            Closed = false;

            DisplayForm = new Form()
            {
                FormBorderStyle = FormBorderStyle.SizableToolWindow,
                Text = GuId,
                MaximizeBox = false,
                Size = new Size(500, 500)
            };

            DisplayForm.FormClosing += DisplayForm_FormClosing;
            DisplayForm.SizeChanged += DisplayForm_SizeChanged;

            Plain = new PlainDraw();
            Plain.Dock = DockStyle.Fill;

            DisplayForm.Controls.Add(Plain);

            Plain.MouseMove += Plain_MouseMoveOrClick;
            Plain.MouseClick += Plain_MouseMoveOrClick;

            Init(2, 1);
        }

        private void Plain_MouseMoveOrClick(object sender, MouseEventArgs e)
        {
            int x = (e.X / PointSize + rows) % rows;
            int y = (e.Y / PointSize + cols) % cols;

            if (e.Button == MouseButtons.Left)
            {
                fdata[x, y].Life = true;

                if (!Running)
                    Draw(true);
            }
            else if (e.Button == MouseButtons.Right)
            {
                fdata[x, y].Life = false;

                if (!Running)
                    Draw(true);
            }
        }

        private void DisplayForm_SizeChanged(object sender, EventArgs e)
        {
            Init(Density, PointSize);
        }

        private void DisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Running)
            {
                MessageBox.Show("Невозможно завершить симуляцию пока она активна.", "Ошибка", MessageBoxButtons.OK);
                e.Cancel = true;
            }

            if (!Closed)
            {
                e.Cancel = true;
                Drop();
            }
        }

        public void Init(int density, int pointSize)
        {
            if (Running)
            {
                return;
            }

            Plain.Image = new Bitmap(DisplayForm.Width, DisplayForm.Height);
            graphics = Graphics.FromImage(Plain.Image);

            Density = density;
            PointSize = pointSize;

            rows = Plain.Image.Width / PointSize;
            cols = Plain.Image.Height / PointSize;

            fdata = new Cell[rows, cols];

            var rand = new Random(DateTime.UtcNow.Second);
            var rand2 = new Random(DateTime.UtcNow.Second);

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (fdata[i, j] == null)
                    {
                        Brush brush;

                        switch (rand2.Next(6) % 5)
                        {
                            case 0:
                                brush = Brushes.SkyBlue;
                                break;
                            case 1:
                                brush = Brushes.Red;
                                break;
                            case 2:
                                brush = Brushes.Green;
                                break;
                            case 3:
                                brush = Brushes.Yellow;
                                break;
                            default:
                                brush = Brushes.White;
                                break;
                        }

                        fdata[i, j] = new Cell()
                        {
                            Brush = brush
                        };
                    }

                    fdata[i, j].Life = rand.Next(Density) == 0;
                }
            }

            gen = 0;

            Draw(true);
        }

        private Graphics graphics;

        private void Draw(bool init = false)
        {
            try
            {
                if (graphics == null || fdata == null)
                {
                    return;
                }

                if (ViewGrid)
                {
                    // TODO рисовать сетку.
                }

                graphics.Clear(Color.Black);

                if (init)
                {
                    for (var x = 0; x < rows; x++)
                    {
                        for (var y = 0; y < cols; y++)
                        {
                            if (fdata[x, y].Life)
                            {
                                graphics.FillEllipse(fdata[x, y].Brush, new Rectangle(PointSize * x, PointSize * y, PointSize, PointSize));
                            }
                        }
                    }
                }
                else
                {
                    var nfdata = new Cell[rows, cols];

                    for (var x = 0; x < rows; x++)
                    {
                        for (var y = 0; y < cols; y++)
                        {
                            var coutHeighbours = CoutHeighbours(x, y);
                            var hasLife = fdata[x, y].Life;


                            if (!hasLife && coutHeighbours == 3)
                            {
                                nfdata[x, y] = new Cell() { Life = true, Brush = fdata[x, y].Brush };
                            }
                            else if (hasLife && (coutHeighbours < 2 || coutHeighbours > 3))
                            {
                                nfdata[x, y] = new Cell() { Life = false, Brush = fdata[x, y].Brush };
                            }
                            else
                            {
                                nfdata[x, y] = fdata[x, y];
                            }

                            if (hasLife)
                            {
                                try
                                {
                                    graphics.FillEllipse(fdata[x, y].Brush, new Rectangle(PointSize * x, PointSize * y, PointSize, PointSize));
                                }
                                catch
                                {

                                }
                            }
                        }
                    }

                    fdata = nfdata;
                }



                if (Plain.InvokeRequired)
                {
                    Plain.BeginInvoke(new MethodInvoker(delegate
                    {
                        Plain.Refresh();

                        DisplayForm.Text = $"{GuId} Поколение {++gen}";
                    }));
                }
                else
                {
                    Plain.Refresh();
                }
            }
            catch
            {

            }
        }

        private int CoutHeighbours(int x, int y)
        {
            int count = 0;

            for (var i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    int col = (x + i + rows) % rows;
                    int row = (y + j + cols) % cols;

                    bool ifSelf = col == x && row == y;
                    bool hasLife = fdata[col, row].Life;

                    if (hasLife && !ifSelf)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void Drop()
        {
            if (Running)
            {
                return;
            }

            var issue = Droped?.Invoke(this);
            if (issue.HasValue)
            {
                Closed = true;
                DisplayForm.Close();
            }
        }

        public void Pause()
        {
            DisplayForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;

            Running = false;
            Paused?.Invoke(this);
        }

        public void Resume()
        {
            DisplayForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            Running = true;
            Resumed?.Invoke(this);
        }

        public void Start()
        {
            if (worker == null)
            {
                worker = new BackgroundWorker()
                {
                    WorkerSupportsCancellation = true
                };

                worker.DoWork += Worker_DoWork;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            }

            worker.RunWorkerAsync();

            Resume();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pause();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (worker.CancellationPending)
                {
                    break;
                }

                Draw();

                Thread.Sleep(10);
            }
        }

        public void Stop()
        {
            if (worker == null)
            {
                return;
            }

            worker.CancelAsync();
        }

        protected void ThreadMain()
        {
            for (; ; )
            {
                Draw();

                Thread.Sleep(100);
            }
        }

        public override string ToString()
        {
            return GuId;
        }
    }
}
