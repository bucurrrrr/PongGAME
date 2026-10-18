using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

           private void ApplyCharacterToOwner(string path)
        {
            var owner = this.Owner as Form1;
            if (owner == null) return;

            owner.ball.BackgroundImage = null;
            owner.ball.Image = Image.FromFile(path);
            owner.ball.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void WhiteBird_Click(object sender, EventArgs e)
        {
            ApplyCharacterToOwner(@"Resources\CaracterAlbPong.png");
            this.Close();
        }

        private void BlueBird_Click(object sender, EventArgs e)
        {
            ApplyCharacterToOwner(@"Resources\CaracterAlbastruPong.png");
            this.Close();
        }

        private void RedBird_Click(object sender, EventArgs e)
        {
            ApplyCharacterToOwner(@"Resources\CaracterRosuPong.png");
            this.Close();
        }

        private void YellowBird_Click(object sender, EventArgs e)
        {
            ApplyCharacterToOwner(@"Resources\CaracterGalbenPong.png");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var owner = this.Owner as Form1;
            if (owner == null) return;

            owner.StartGame();
            this.Close();
        }
    }
}
