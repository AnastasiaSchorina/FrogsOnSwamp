
namespace FrogsOnSwamp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            CreateLabel();
        }

        private void CreateLabel()
        {
            textLabel.Text = "Игра очень проста в управлении.\r\n"+"Вам понадобится мышка.\r\n" +
                "Перед вами 8 лягушек. Четыре слева и четыре справа, \r\n" +
                "они занимают 8 болотных листиков, один листик по центру свободен.\r\n"+
                "Щелкая по лягушкам, сделайте так, чтобы лягушки поменялись местами,\r\n"+
                "левые перешли вправо, а правые влево. Лягушка может перепрыгивать только \r\n"+
                "через одну лягушку или на соседний листик.";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
