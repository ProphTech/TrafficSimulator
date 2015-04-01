using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace Traffic_Light_Simulation
{
   //[Serializable()]
    public partial class TrafficSimulationGui : Form
    {
        Graphics _ourgr;
         Traffic _ourtraffic;
        
        Point _ptclicked; //to select a point clicked
        Point _pointselected;
        Rectangle _workingrect;
        bool _rectangleisselected;  // for painting purpose
        bool _simulationRunning;  //to know either simulation is running or not

        int _index;
        readonly Stopwatch _stopwatch=new Stopwatch();
        private const float ScaleFactor = 1.5f; // Scale factor for the zooming.
       

      
        
        private readonly PrintDocument _printDocument = new PrintDocument();
        private StringReader _myReader;


        
        public TrafficSimulationGui()
        {
            InitializeComponent();
            _ourtraffic = new Traffic("CSharp City");

            // Calculate size of zoom box.
            zoomPB.Height = (int)(OurTrafficPBox.Height * ScaleFactor);
            zoomPB.Width = (int)(OurTrafficPBox.Width * ScaleFactor);
            gapTimer.Enabled = false;
            _printDocument.PrintPage += _printDocument_PrintPage;
            
        }
        private void TrafficSimulationGui_Load(object sender, EventArgs e)
        {
            richTextBox_Statistics.AppendText(@"Simulation report: " + DateTime.Now + "\n");
        }
       
       

        private void withPedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_simulationRunning)
            {
                if (_rectangleisselected)
                {

                    Crossing mycrossing = new CrossingWithPedestarian(_workingrect, OurtrafficImages.Images[1],"with-pedestrian");

                    if (_ourtraffic.AddCrossing(mycrossing, _pointselected))

                        OurTrafficPBox.Invalidate();
                    else
                        MessageBox.Show(@"the selected area have crossing, please select other place");
                    // OurTrafficPBox.Refresh();
                }



                else
                    MessageBox.Show(@"select a place first");
            }
            else
            {
                MessageBox.Show(@"Simulation is Running,Stop it First");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(txt_set_Car_number.Text);
                if (a > 0)
                {
                    if (combo_TrafficLight.Text != "")
                    {
                        foreach (var cCrossing in _ourtraffic.Traficsrossings)
                        {
                            cCrossing.AdjustNrOfCars(Convert.ToInt32(combo_TrafficLight.SelectedItem),
                                Convert.ToInt32(txt_set_Car_number.Text));
                        }


                        OurTrafficPBox.Invalidate();
                    }
                    else
                        MessageBox.Show(@"Please fill in the number of cars you want to adjust to");
                }
                else
                {
                    MessageBox.Show(@"non-negative number only");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(@"Only positive Integer.");
            }
           
        }

        private void OurTrafficPBox_MouseClick(object sender, MouseEventArgs e)
        {
            _ptclicked.X = e.X;
            _ptclicked.Y = e.Y;
            _pointselected = Findpos();
            _workingrect = _ourtraffic.GetRectangle(_pointselected);
            _rectangleisselected = true;

            OurTrafficPBox.Invalidate();
            // OurTrafficPBox.Refresh();
            int x = 1;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (_workingrect.Location == new Point(200*i + 5, 200*j + 5))
                    {
                        label_info.Text = @"Cell  " + x + @"  selected";
                    }
                    x++;
                }
            }
        }

        /// <summary>
        /// return the rectangle position
        /// </summary>
        /// <returns>pointer</returns>
        public Point Findpos()
        {
            var pt = new Point {X = ((_ptclicked.X/200)*200) + 5, Y = ((_ptclicked.Y/200)*200) + 5};
            return pt;

        }

        private void withoutPedestrianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_simulationRunning)
            {
                if (_rectangleisselected)
                {

                    Crossing mycrossing = new CrossingWithoutPedestarian(_workingrect, OurtrafficImages.Images[0],"without-pedestrian");

                    if (_ourtraffic.AddCrossing(mycrossing, _pointselected))

                        OurTrafficPBox.Invalidate();
                    else
                        MessageBox.Show(@"the selected area have crossing, please select other place");
                    // OurTrafficPBox.Refresh();

                }

                else
                    MessageBox.Show(@"select a place first");

            }
            else
            {
                MessageBox.Show(@"Simulation is Running,Stop it First");
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (!_simulationRunning)
            {
                if (_rectangleisselected)
                {
                    for (var x = 0; x < _ourtraffic.Traficsrossings.Count; x++)
                    {
                        if (_ourtraffic.RemoveCrossing(_workingrect.Location))
                        {

                            OurTrafficPBox.Invalidate();
                        }
                        else
                            MessageBox.Show(@"there is no crossing in this area!");
                    }
                }
                else
                    MessageBox.Show(@"select a crossing first!!");

            }
            else
            {
                MessageBox.Show(@"Simulation is Running,Stop it First");
        }
        
       }


 #region Timer


        private void timertraffic_Tick(object sender, EventArgs e)
        {
            if (gapTimer.Enabled)
            {
                _ourtraffic.StartSimulation(_index, "keepmove");
            }
            else if (!gapTimer.Enabled)
            {

                _ourtraffic.StartSimulation(_index, "move");

            }



            OurTrafficPBox.Invalidate();
            zoomPB.Invalidate();

        }

        private void GroupTimer_Tick(object sender, EventArgs e)
        {
            gapTimer.Enabled = false;

            foreach (var crossing in _ourtraffic.Traficsrossings)
            {
                if (_index + 1 <= crossing.MyGroup.Count)
                {
                    GroupTimer.Interval = crossing.MyGroup[_index].Getinterval();
                }
            }

           
            gapTimer.Enabled = true;
            GroupTimer.Enabled = false;
            foreach (var crossing in _ourtraffic.Traficsrossings)
            {
                foreach (var group in crossing.MyGroup)
                {
                    foreach (var lane in group.ListOfLanes)
                    {
                        if (lane.ListOfCars.Count > lane.Maximumcapacity)
                        {
                            richTextBox_Statistics.AppendText("in" + crossing.Type +"in lane " + lane.MyNumber + "have traffice jam");
                        }
                    }
                }
            }
          
        }

        private void gapTimer_Tick(object sender, EventArgs e)
        {
            gapTimer.Enabled = false;
            //MessageBox.Show(@"timer ticked");
            _index = (++_index) % 5;
            GroupTimer.Enabled = true;
            
            

        }
 #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a =Convert.ToInt16(txt_Green.Text);

                if (a > 0)
                {
                    for (int i = 0; i < _ourtraffic.Traficsrossings.Count - 1; i++)
                    {
                        _ourtraffic.Traficsrossings[i].AdjustTime(Convert.ToString(combolane.SelectedItem),
                            Convert.ToInt32(txt_Green.Text));
                    }
                }
                else MessageBox.Show(@"provide non-negative number");
            }
            catch (Exception)
            {

                MessageBox.Show(@"only number allowed");
            }
            
        }

        private void combolane_TextChanged(object sender, EventArgs e)
        {
            ShowTimeForGroup(Convert.ToString(combolane.SelectedItem));
            switch (Convert.ToString(combolane.SelectedItem))
            {
                case "Group1":
                    combo_TrafficLight.Items.Clear();
                    combo_TrafficLight.Items.Add("1");
                    combo_TrafficLight.Items.Add("2");
                    combo_TrafficLight.Items.Add("8");
                    combo_TrafficLight.Items.Add("9");
                    break;
                case "Group2":
                    combo_TrafficLight.Items.Clear();
                    combo_TrafficLight.Items.Add("5");
                    combo_TrafficLight.Items.Add("6");
                    combo_TrafficLight.Items.Add("10");
                    combo_TrafficLight.Items.Add("11");
                    break;
                case "Group3":
                    combo_TrafficLight.Items.Clear();
                    combo_TrafficLight.Items.Add("4");
                    combo_TrafficLight.Items.Add("1");
                    combo_TrafficLight.Items.Add("12");
                    break;
                case "Group4":
                    combo_TrafficLight.Items.Clear();
                    combo_TrafficLight.Items.Add("3");
                    combo_TrafficLight.Items.Add("7");
                    combo_TrafficLight.Items.Add("6");
                    break;
            }
        }

#region Save Open New
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < _ourtraffic.Traficsrossings.Count; x++)
            {

                _ourtraffic.Traficsrossings.Remove(_ourtraffic.Traficsrossings[x]);
                    
                
            }
            OurTrafficPBox.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = @"Simulation (*.sim)|*.sim",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            //  this.ourtraffic = new Traffic("abc");
            _ourgr = OurTrafficPBox.CreateGraphics();
           // _ourgr.Clear(Color.White);


            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fs = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    var bf = new BinaryFormatter();
                    _ourtraffic = (Traffic) bf.Deserialize(fs);

                    _ourtraffic.PaintAllCrossing(_ourgr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void saveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = @"Simulation (*.sim)|*.sim",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                var bf = new BinaryFormatter();

                bf.Serialize(fs, _ourtraffic);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                MessageBox.Show(@"Saving Failed", @"error");
            }
        }

#endregion
#region Paint
        private void OurTrafficPBox_Paint(object sender, PaintEventArgs e)
        {
            _ourgr = e.Graphics;
            var myblackpen = new Pen(Color.Black) {Width = 3};


            // ReSharper disable once UnusedVariable
            foreach (var rectangle in _ourtraffic.Myrectangles)
            {
                _ourgr.DrawRectangles(myblackpen, _ourtraffic.Myrectangles);
            }

            //to paint the seletion

            if (_rectangleisselected)
            {
                var myselctionpen = new Pen(Color.Aqua) {Width = 3};
                _ourgr.DrawRectangle(myselctionpen, _workingrect);
            }

            // to paint the crossing
            _ourtraffic.PaintAllCrossing(_ourgr);
            //ourgr.DrawImage(OurtrafficImages.Images[0], workingrect.Location);

        }

 #endregion
#region Start Stop Simulation
        private void btn_Start_Simulation_Click(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            
            timer1.Start();
            _stopwatch.Start();


            _simulationRunning = true;
            timertraffic.Enabled = true;
            //gapTimer.Enabled = true;
            GroupTimer.Enabled = true;


            btn_ADD.Enabled = false;
            btn_remove.Enabled = false;
            //btn_Maximize_Tool.Enabled = false;
            btn_Start_Simulation.Enabled = false;
            btn_Stop_simulation.Enabled = true;
            btn_Show_statistics.Enabled = false;
            menuStrip1.Enabled = false;
            tab_Edit.Enabled = false;

            //OurTrafficPBox.Enabled = false;
            labelShow.Text = @"Simulation is running";
            richTextBox_Statistics.AppendText("Simulation was started at: ( " + DateTime.Now.TimeOfDay 
                            +" ) with "+_ourtraffic.Traficsrossings.Count +" Crossing. \n");
          
           
           
           // richTextBox_Statistics.AppendText();
            
            
            
        }
        private void btn_Stop_simulation_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            btn_remove.Enabled = true;
            // btn_Maximize_Tool.Enabled = true;
            btn_Start_Simulation.Enabled = true;
            btn_Stop_simulation.Enabled = false;
            btn_Show_statistics.Enabled = true;
            menuStrip1.Enabled = true;
            tab_Edit.Enabled = true;
            //OurTrafficPBox.Enabled = true;
            labelShow.Text = @"Simulation is stopped";
            richTextBox_Statistics.AppendText("Simulation was stopped at: " + DateTime.Now.TimeOfDay + "\n");

            _simulationRunning = false;
            timertraffic.Enabled = false;
            timer1.Stop();
            _stopwatch.Stop();
        }

#endregion

 #region Maximize
        private void zoomPB_Paint(object sender, PaintEventArgs e)
        {
            // Grab teh graphicz.
            var ourzoomgr = e.Graphics;

            // Draw teh traffic light at scalez.
            _ourtraffic.DrawZoom(ourzoomgr, _pointselected, ScaleFactor);


            // Reposition teh box to show teh traffic light.
            zoomPB.Location = new Point((int)(-_pointselected.X * ScaleFactor), (int)(-_pointselected.Y * ScaleFactor));

            // Dehbugz
            //Text = _pointselected.ToString();
        }

        private void btn_Maximize_Tool_Click(object sender, EventArgs e)
        {
            panel_maximize.Visible = true;
            OurTrafficPBox.Enabled = false;
        }

        private void btn_maximize_Close_Click(object sender, EventArgs e)
        {
            panel_maximize.Visible = false;
            OurTrafficPBox.Enabled = true;
        }
#endregion

#region print Statistic
        private void btn_Show_statistics_Click(object sender, EventArgs e)
        {
            if (btn_Show_statistics.Text == @"Show Statistic")
            {
                panel_statisctics.Visible = true;
                btn_Start_Simulation.Enabled = false;
                OurTrafficPBox.Enabled = false;
                btn_Show_statistics.Text = @"Hide Statistics";
            }
            else
            {
                panel_statisctics.Visible = false;
                btn_Show_statistics.Text = @"Show Statistic";
                btn_Start_Simulation.Enabled = true;
                OurTrafficPBox.Enabled = false;
            }



        }

        private void previewStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var strText = richTextBox_Statistics.Text;
                _myReader = new StringReader(strText);
                printPreviewDialog.Document = _printDocument;
                printPreviewDialog.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.Document = _printDocument;
            var strText = richTextBox_Statistics.Text;
            _myReader= new StringReader(strText);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _printDocument.Print();
            }
        }
        void _printDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            var count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            var printFont = richTextBox_Statistics.Font;
            var myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            var linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = _myReader.ReadLine()) != null))
            {
                // calculate the next line position based on 
                // the height of the font according to the printing device
                var yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                // draw the next line in the rich edit control

                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            // If there are more lines, print another page.
            ev.HasMorePages = line != null;

            myBrush.Dispose();
        }
#endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStopWatch.Text = @"Time   "  + _stopwatch.Elapsed.Minutes + @":" +
                                _stopwatch.Elapsed.Seconds + @":"+ _stopwatch.Elapsed.Milliseconds ;

        }

        private void combolane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OurTrafficPBox_Click(object sender, EventArgs e)
        {

        }

        private void tab_page_Selected(object sender, TabControlEventArgs e)
        {
            if (_rectangleisselected)
            {
                foreach (var cCrossing in _ourtraffic.Traficsrossings)
                {
                    if (_workingrect.Location == cCrossing.Position)
                    {
                        if (cCrossing.Type == "with-pedestrian")
                        {
                            combolane.Items.Clear();
                            combolane.Items.Add("Group1");
                            combolane.Items.Add("Group2");
                            combolane.Items.Add("Group3");
                            combolane.Items.Add("Group4");
                            combolane.Items.Add("Group5");

                        }
                        else
                        {
                            combolane.Items.Clear();
                            combolane.Items.Add("Group1");
                            combolane.Items.Add("Group2");
                            combolane.Items.Add("Group3");
                            combolane.Items.Add("Group4");

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please select the crossing to be edited first");
                
            }

        }

        public void ShowTimeForGroup(string groupName)
        {
            if (_rectangleisselected)
            {
                foreach (var cCrossing in _ourtraffic.Traficsrossings)
                {
                    if (cCrossing.Position != _workingrect.Location) continue;
                    foreach (var gGroup in cCrossing.MyGroup)
                    {
                        if (gGroup.Name == groupName)
                        {
                            txt_Green.Text = Convert.ToString(gGroup.Getinterval());
                        }
                    }
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
