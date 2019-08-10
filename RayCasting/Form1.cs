using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace RayCasting
{
    public partial class MainWindow : Form
    {
        VideoMode[] videoModes;
        RenderView gameWindow;

        public MainWindow()
        {
            InitializeComponent();
            videoModes = VideoMode.FullscreenModes;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            for(int i=0; i<videoModes.Length; i++)
            {
                listBoxFulscreen.Items.Add(videoModes[i]);
            }

            gameWindow = new RenderView();
        }

        private void RadioButtonFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonFullscreen.Checked == true)
            {
                panelFullscreen.Enabled = true;
                panelCustom.Enabled = false;
            }
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCustom.Checked == true)
            {
                panelFullscreen.Enabled = false;
                panelCustom.Enabled = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            VideoMode videoMode;
            if(radioButtonFullscreen.Checked == true)
            {
                if(listBoxFulscreen.SelectedItem == null)
                    listBoxFulscreen.SelectedIndex = 0;
                videoMode = (VideoMode)listBoxFulscreen.SelectedItem;
                gameWindow.setParams(videoMode, Styles.Fullscreen);
            }
            if(radioButtonCustom.Checked == true)
            {
                videoMode = new VideoMode((uint)numericUpDownWidth.Value, (uint)numericUpDownHeight.Value);
                gameWindow.setParams(videoMode, Styles.Close);
            }
            gameWindow.play();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}
