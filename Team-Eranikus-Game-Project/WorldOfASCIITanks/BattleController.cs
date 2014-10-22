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
using WorldOfASCIITanks.Rendering;

namespace WorldOfAsciiTanksWForms
{
    public partial class BattleController : Form
    {
        private MainCharacter _player;
        // private Opponent _opponent;
        public BattleController()
        {
            InitializeComponent();

            // _player = new MainCharacter(new MatrixCoords(1, 1), new char[1, 1] { { '*' } }, 20, 80, 1, 10, 0, 1, null);
            _player = hero;
            // lblName.Text = _player.Name.ToString(); +Name??!?!
            lblLevel.Text = _player.Level.ToString();
            lblHitPoints.Text = _player.Health.ToString();
            lblManaPoints.Text = _player.ManaPoints.ToString();
            lblExperience.Text = _player.Experience.ToString();

            

        }
    }
}
