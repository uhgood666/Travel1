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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Панель навигации
        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.dataSet1.Клиенты);

        }
        // Переход на форму поездки
        private void поездкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
        // Кнопка выхода
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Поиск по коду клиента
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = "КодКлиента=\'" + toolStripTextBox1.Text + "\'";
        }
        // Очистка запроса
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = null;
        }
    }
}
