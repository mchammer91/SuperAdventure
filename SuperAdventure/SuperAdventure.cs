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
    using System.Media;

    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            this._player = new Player()
                               {
                                   CurrentHitPoints = 10,
                                   MaximumHitPoints = 10,
                                   Gold = 20,
                                   ExperiencePoints = 0,
                                   Level = 1
                               };

            this.lblHitPoints.Text = this._player.CurrentHitPoints.ToString();
            this.lblGold.Text = this._player.Gold.ToString();
            this.lblExperience.Text = this._player.ExperiencePoints.ToString();
            this.lblLevel.Text = this._player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
        
    }
}
