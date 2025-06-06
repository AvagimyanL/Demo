using Npgsql;
using System.Data;
namespace TemplateApp
{
    public partial class Form1 : Form
    {
        DbContext dbContext;
        public Form1()
        {
            InitializeComponent();

            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "localhost";
            builder.Port = 5432;
            builder.Database = "office_soft";
            builder.Username = "postgres";
            builder.Password = "123456";

            dbContext = new DbContext(builder);
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка авторизации
        {
            DataTable table = dbContext.GetTable("users");
            bool isExit = false;
            foreach (DataRow i in table.Rows)
            {
                isExit = i["login"].ToString() == Login1.Text
                    && i["password"].ToString() == Password1.Text;

                if (isExit) break;
            }

            if (!isExit)
            {
                MessageBox.Show("Не верный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Успешно", "Система", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu menu = new MainMenu(dbContext, this);
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //Кнопка регистрации
        {
            new Register(dbContext, this).Show();
            this.Hide();
        }
    }
}
