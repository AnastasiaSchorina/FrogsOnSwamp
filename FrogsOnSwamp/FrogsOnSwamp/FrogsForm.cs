namespace FrogsOnSwamp
{
    public partial class FrogsForm : Form
    {
        private int emptyLocationX = 417;
        private int pointStartX = 1;
        private int pointStartY = 38;
        private int pictureWidth = 104;
        private int stepMax = 2;
        private int minStepCount = 24;

        private int textStepLabelPointX = 36;
        private int textStepLabelPointY = 176;

        private int numberStepLabelPointX = 219;
        private int numberStepLabelPointY = 176;

        private int formWidth = 976;
        private int formHieght = 271;

        public FrogsForm()
        {
            InitializeComponent();           
        }

        private void ShowMessageBox()
        {
            if (numberStepLabel.Text == Convert.ToString(minStepCount))
            {
                MessageBox.Show("Ура, Вы выиграли за min кол-во шагов!");
            }
            else
            {
                IsRepeat();
            }
        }

        private void IsRepeat()
        {
            DialogResult dialogResult = MessageBox.Show("Ура, Вы выиграли, но не за min кол-во шагов!\r\n" +
                "Желаете сыграть еще?", "Сообщение",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            Application.Exit();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if (IsEndGame())
            {
                ShowMessageBox();
            }
        }

        private bool IsEndGame()
        {
            return rightPictureBox1.Location.X > emptyPictureBox5.Location.X && 
                   rightPictureBox2.Location.X > emptyPictureBox5.Location.X && 
                   rightPictureBox3.Location.X > emptyPictureBox5.Location.X && 
                   rightPictureBox4.Location.X > emptyPictureBox5.Location.X && 
                   emptyPictureBox5.Location.X == emptyLocationX;
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox5.Location.X) / emptyPictureBox5.Size.Width;

            if (distance > stepMax || distance == 0)
            {
                MessageBox.Show("Так нельзя!");
                return;
            }
            var location = clickedPicture.Location;
            clickedPicture.Location = emptyPictureBox5.Location;
            emptyPictureBox5.Location = location;
            numberStepLabel.Text = Convert.ToString(Convert.ToInt32(numberStepLabel.Text) + 1);
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void показатьПравилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void FrogsForm_Load(object sender, EventArgs e)
        {          
            this.Size = new Size(formWidth, formHieght);
           
            leftPictureBox6.Location = new Point(pictureWidth * 8 + pointStartX, pointStartY);
            leftPictureBox7.Location = new Point(pictureWidth * 7 + pointStartX, pointStartY);
            leftPictureBox8.Location = new Point(pictureWidth * 6 + pointStartX, pointStartY);
            leftPictureBox9.Location = new Point(pictureWidth * 5 + pointStartX, pointStartY);
            emptyPictureBox5.Location = new Point(pictureWidth * 4 + pointStartX, pointStartY);
            rightPictureBox4.Location = new Point(pictureWidth * 3 + pointStartX, pointStartY);
            rightPictureBox3.Location = new Point(pictureWidth * 2 + pointStartX, pointStartY);
            rightPictureBox2.Location = new Point(pointStartX + pictureWidth, pointStartY);
            rightPictureBox1.Location = new Point(pointStartX, pointStartY);

            textStepLabel.Location = new Point(textStepLabelPointX, textStepLabelPointY);
            numberStepLabel.Location = new Point(numberStepLabelPointX, numberStepLabelPointY);
        }
    }
}
