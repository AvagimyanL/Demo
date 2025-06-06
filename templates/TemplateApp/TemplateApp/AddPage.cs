using System.Data;

namespace TemplateApp
{
    public partial class AddPage : Form
    {
        private readonly DbContext dbContext;
        private readonly string tableName;
        private readonly DataRow row;
        public AddPage()
        {
            InitializeComponent();
            Main1.Controls.Clear();
        }

        public AddPage(DbContext dbContext, string tableName) //Режим добавления записи
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.tableName = tableName;
            Main1.Controls.Clear();

            DataTable table = dbContext.GetTable(tableName);

            foreach (DataColumn column in table.Columns)
            {
                Main1.Controls.Add(
                    renderBox(column.ColumnName)
                    );
            }
        }

        public AddPage(DbContext dbContext, string tableName, DataRow row) //Режим редактировния записи
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.tableName = tableName;
            this.row = row;
            Main1.Controls.Clear();

            DataTable table = dbContext.GetTable(tableName);
            int index = 0;
            foreach (DataColumn column in table.Columns)
            {
                GroupBox box = renderBox(column.ColumnName);
                TextBox text = box.Controls[0] as TextBox;

                if (text == null) continue;

                text.Text = row[index].ToString();
                Main1.Controls.Add(box);
                index++;
            }
        }

        private GroupBox renderBox(string param) //Шаблонизатор полей
        {
            GroupBox box = new GroupBox()
            {
                Text = param,
                Top = tempBox1.Top,
                Left = tempBox1.Left,
                Dock = tempBox1.Dock,
                Width = tempBox1.Width,
                Height = tempBox1.Height
            };

            TextBox textBox = new TextBox()
            {
                Top = tempText1.Top,
                Left = tempText1.Left,
                Dock = tempText1.Dock,
                Width = tempText1.Width,
                Height = tempText1.Height
            };

            box.Controls.Add(textBox);
            return box;
        }

        private void Save1_Click(object sender, EventArgs e) //Сохранение изменений
        {
            DataTable table = dbContext.GetTable(tableName);
            DataRow rowAfter = null;
            rowAfter = table.NewRow();

            int index = 0;

            foreach (Control control in Main1.Controls)
            {
                GroupBox box = control as GroupBox;

                if (box.Controls[0] is TextBox text)
                {
                    rowAfter[index] = text.Text;
                    index++;
                }
            }

            if(row == null)
            {
                if (dbContext.GetByKey(rowAfter[0], tableName) != null)
                {
                    MessageBox.Show("Пользователь с таким идентификатором уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbContext.AddRow(rowAfter, tableName);
            }
            else
            {
                dbContext.Update(row, rowAfter, tableName);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
