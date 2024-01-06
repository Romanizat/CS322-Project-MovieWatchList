using CS322_PZ_MarkoJosifovic4494.Forms;
using CS322_PZ_MarkoJosifovic4494.Repo;
using CS322_PZ_MarkoJosifovic4494.Service;
using CS322_PZ_MarkoJosifovic4494.Util;

namespace CS322_PZ_MarkoJosifovic4494
{

    public partial class Form1 : Form
    {
        private readonly UserService _userService;

        public Form1()
        {
            InitializeComponent();
            var dbContext = new MovieDbContext();
            var userRepository = new UserRepository(dbContext);
            _userService = new UserService(userRepository);

            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;

            form2.Location = this.Location;

            this.Hide();

            form2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            bool loginSuccessful = _userService.LoginUser(username, password);

            if (loginSuccessful)
            {
                MessageBox.Show("Login successful!");

                UserContext.CurrentUser = _userService.GetByUsername(username);

                MainMenu mainMenu = new MainMenu();
                mainMenu.StartPosition = FormStartPosition.Manual;

                mainMenu.Location = this.Location;

                this.Hide();

                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }
    }
}
