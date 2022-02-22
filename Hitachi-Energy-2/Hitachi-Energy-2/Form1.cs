using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_Energy_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.TempStatistics' table. You can move, or remove it, as needed.
            this.tempStatisticsTableAdapter.Fill(this.appData.TempStatistics);
            // TODO: This line of code loads data into the 'database1.TemperatureStats' table. You can move, or remove it, as needed.
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                tempStatisticsBindingSource.EndEdit();
                tempStatisticsTableAdapter.Update(this.appData.TempStatistics);
                MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Temperature"].XValueMember = "City";
            chart1.Series["Temperature"].YValueMembers = "Temperature";
            chart1.DataSource = this.appData.TempStatistics;
            chart1.DataBind();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
