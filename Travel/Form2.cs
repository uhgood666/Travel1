using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Панель навигации
        private void поездкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поездкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поездки". При необходимости она может быть перемещена или удалена.
            this.поездкиTableAdapter.Fill(this.dataSet1.Поездки);

        }
        // Возврат на форму клиенты
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }
        // Переход на форму маршрут
        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Hide();
        }
        // Поиск по Коду Поездки
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            поездкиBindingSource.Filter = "КодПоездки=\'" + toolStripTextBox1.Text + "\'";
        }
        // Очистка запроса
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            поездкиBindingSource.Filter = null;
        }
    }
}
