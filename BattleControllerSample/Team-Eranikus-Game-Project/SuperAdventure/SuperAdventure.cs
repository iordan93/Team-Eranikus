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

            Location location = new Location(1,"Home", "This is your house."); 
            location.ID = 1; 
            location.Name = "Home"; 
            location.Description = "This is your house.";
            Location test1 = new Location(1, "Your House", "This is your house");

            Location test2 = new Location(1, "Your House", "This is your house", null, null, null);

            _player = new Player(10,10,20,0,1);

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPoints_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
