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
        int Count = 0;
        int one;
        int two;
        public To_do_List()
        {
            InitializeComponent();
        }

        public object GetField(int i, int j)
        {
            return dataGridView1.Rows[i].Cells[j].Value;
        }

        public string Fields
        {
            get
            {
                return dataGridView1.Rows[one].Cells[two].Value.ToString();
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

        }
    }
}
