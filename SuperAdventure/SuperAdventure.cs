using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            Location loc = new Location(1, "Home", "This is your house.");

            _player = new Player
            {
                CurHitPoints = 10,
                MaxHitPoints = 10,
                ExperiencePoints = 0,
                Gold = 20,
                Level = 1
            };

            lblHitPoints.Text = _player.CurHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text = "123";
        }
    }
}
