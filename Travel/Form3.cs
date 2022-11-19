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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Панель навигации
        private void маршрутBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.dataSet1.Маршрут);

        }
        // Возвращение на форму поездки
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
        //Переход на форму лечение
        private void лечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Hide();
        }
        // Поиск
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.Filter = "КодМаршрута=\'" + toolStripTextBox1.Text + "\'";
        }
        //Очистка
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.Filter = null;
        }
    }
}
