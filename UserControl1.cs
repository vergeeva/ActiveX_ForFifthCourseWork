using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveX_ForFifthCourseWork
{
    public partial class To_do_List: UserControl
    {
        private int Count = 0;
        private int one = 0;
        private int two = 0;

        public To_do_List()
        {
            InitializeComponent();
        }

        public int Row
        {
            get
            {
                return one;
            }

            set
            {
                one = value;
            }
        } //Задать индекс строки

        public int Column
        {
            get
            {
                return two;
            }

            set
            {
                two = value;
            }
        } //Задать индекс столбца

        public string Fields //Получить поле 
        {
            get
            {
                if (dataGridView1.Rows[one].Cells[two].Value != null)
                    return dataGridView1.Rows[one].Cells[two].Value.ToString();
                else
                    return "";
            }

            set
            {
                dataGridView1.Rows[one].Cells[two].Value= value;
            }
        }
        
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Событие, происходящее при добавлении строки
            Count = dataGridView1.RowCount;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = Count;
            удалитьMenuItem.Enabled = true;
            отложитьMenuItem.Enabled = true;
            отметитьMenuItem.Enabled = true;
        }

        private void To_do_List_Load(object sender, EventArgs e)
        {
            //Загрузка элемента управления
            this.dataGridView1.BackgroundColor = Color.Beige;
        }

        private void удалитьMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void отложитьMenuItem_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.SelectedRows.Count;
            try
            {
                dataGridView1.SelectedRows[0].Visible = false;
            }
            catch 
            {
                MessageBox.Show("Поле не заполнено", "Ошибка");
            }

        }

        private void отметитьMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }
    }
}
