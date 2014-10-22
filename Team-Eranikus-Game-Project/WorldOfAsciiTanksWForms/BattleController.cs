using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfAsciiTanksWForms
{
    public partial class BattleController : Form
    {
        private MainCharacter _player;
        private NPC _opponent;
        public BattleController()
        {
            InitializeComponent();

            _player = new MainCharacter();
            // lblName.Text = _player.Name.ToString(); +Name??!?!

            lblLevel.Text = _player.Level.ToString();
            lblHitPoints.Text = _player.Health.ToString();
            lblManaPoints.Text = _player.ManaPoints.ToString();
            lblExperience.Text = _player.Experience.ToString();
            
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

    }
}
