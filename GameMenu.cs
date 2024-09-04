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
            SixteenQueen_Puzzle SixtnQnsForm = new SixteenQueen_Puzzle();
            SixtnQnsForm.Show();
            this.Hide();
        }
    }
}
