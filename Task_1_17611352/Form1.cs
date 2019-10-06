using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_17611352
{
    public partial class Form1 : Form
    {

        Map map = new Map(20, 20);
        GameEngine game = new GameEngine();



        public Form1()
        {
            InitializeComponent();

            map.GenerateMap();
            Display();
        }


        public void Display()
        {
            Round_Display_Label.Text = "Round : " + game.numOfRound.ToString();
            Unit_Display_Label.Text = "Units In Game : " + map.units.Count().ToString();

            //For Testing
            Test_Label.Text = "Death Test : " + map.unitAt5Health.ToString();

            Display_Group_Box.Controls.Clear();

            foreach (Unit uN in map.units)
            {
                Label newLabel = new Label();
                newLabel.Width = 20;
                newLabel.Height = 20;
                newLabel.Location = new Point(uN.xPos * 20, uN.yPos * 15);
                newLabel.Text = uN.symbol;

                //groupBox1.Controls.Add(newLabel);
                Display_Group_Box.Controls.Add(newLabel);
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            //Display();
            timer1.Enabled = true;
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Display_Group_Box_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //map.RealTimeMovement();
            game.GameLogic();

            if (map.units.Count() <= 1)
            {

            }
            else
            {
                map.RealTimeMovement();
            }
            
            Display();
        }

    }
}
