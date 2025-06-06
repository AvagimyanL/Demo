using System.Data;

namespace TemplateApp
{
    public partial class Register : Form
    {
        private readonly DbContext dbContext;
        private readonly Form parent;
        public Register()
        {
            InitializeComponent();
        }
        public Register(DbContext dbContext, Form parent)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка регистрации
        {
            DataTable table = dbContext.GetTable("users");

            DataRow row = table.NewRow();
            row["id"] = table.Rows.Count + 1;
            row["fio"] = Bio1.Text;
            row["email"] = Email1.Text;
            row["login"] = Login1.Text;
            row["password"] = Password1.Text;

            dbContext.AddRow(row, "users");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
