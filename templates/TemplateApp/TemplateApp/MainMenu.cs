using System.Data;

namespace TemplateApp
{
    public partial class MainMenu : Form
    {
        private readonly DbContext dbContext;
        private readonly Form parent;
        private string tableName;
        private int indexRow = -1;
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(DbContext dbContext, Form parent)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.parent = parent;


        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //Сборка для отрисовки DataGrid
        {
            tableName = "users";    //Название таблицы базы данных
            DataTable table = dbContext.GetTable(tableName);

            Data1.Rows.Clear();

            Data1.RowCount = table.Rows.Count;
            Data1.ColumnCount = table.Columns.Count;

            for (int i = 0; i < Data1.ColumnCount; i++)
                Data1.Columns[i].HeaderText = table.Columns[i].ColumnName;

            for (int row = 0; row < table.Rows.Count; row++)
            {
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    Data1[column, row].Value = table.Rows[row][column].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Кнопка добавления записи
        {
            if (tableName == null)
            {
                MessageBox.Show("Сначала нужно вывести записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddPage addPage = new AddPage(dbContext, tableName);
            addPage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // Кнопка удаления записи
        {
            if (indexRow == -1)
            {
                MessageBox.Show("Выберите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable table = dbContext.GetTable(tableName);
            DataRow row = table.NewRow();
            for (int column = 0; column < Data1.ColumnCount; column++)
            {
                row[column] = Data1[column, indexRow].Value;
            }

            dbContext.DeleteRow(row, tableName);
            indexRow = -1;
            button1_Click(null, null);
        }

        private void Data1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Режим редактирования записи
        {
            DataTable table = dbContext.GetTable(tableName);
            DataRow row = table.NewRow();
            for (int column = 0; column < Data1.ColumnCount; column++)
            {
                row[column] = Data1[column, e.RowIndex].Value;
            }

            AddPage addPage = new AddPage(dbContext, tableName, row);
            addPage.ShowDialog();
        }

        private void Data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
