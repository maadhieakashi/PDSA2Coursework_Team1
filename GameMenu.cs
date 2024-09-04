using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSA2Coursework_Team1
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              TowerofHanoi toverofHonaiForm = new TowerofHanoi();
              toverofHonaiForm.Show();
              this.Hide();
            
        }
         private void button2_Click(object sender, EventArgs e)
        {
              SixteenQueen_Puzzle SixteenQueen_PuzzleForm = new SixteenQueen_Puzzle();
              SixteenQueen_PuzzleForm.Show();
              this.Hide();
            
        }
         private void button3_Click(object sender, EventArgs e)
        {
              MinimumCost MinimumCostForm = new MinimumCost();
              MinimumCostForm.Show();
              this.Hide();
            
        }
         private void button4_Click(object sender, EventArgs e)
        {
              ShortestPath ShortestPathForm = new ShortestPath();
              ShortestPathForm.Show();
              this.Hide();
            
        }
               private void button5_Click(object sender, EventArgs e)
        {
              PredictValueIndex PredictValueIndexForm = new PredictValueIndex();
              PredictValueIndexForm.Show();
              this.Hide();
            
        }
    }
}
