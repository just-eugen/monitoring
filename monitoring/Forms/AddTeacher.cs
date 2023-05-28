using Microsoft.EntityFrameworkCore;
using monitoring.Data;
using monitoring.Models;
using System.ComponentModel;

namespace monitoring.Forms
{
    public partial class AddTeacher : Form
    {
        //private MonitoringContext? dbContext;

        public AddTeacher()
        {
            InitializeComponent();
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    this.dbContext = new MonitoringContext();
        //}

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //    this.dbContext?.Dispose();
        //    this.dbContext = null;
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text != "" ||
                this.comboBoxPos.Text != "" ||
                this.comboBoxCathedra.Text != "" ||
                this.textBoxRate.Text != "" ||
                this.textBoxStudyLoad.Text != "")
            {
                MessageBox.Show("Не заполнены все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBoxUniver_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.dbContext != null && comboBoxUniver.Text != null)
            //{
            //    var univer = (Univer)this.comboBoxUniver.SelectedValue;

            //    if (univer != null)
            //    {
            //        this.dbContext.Entry(univer).Collection(e => e.Cathedras).Load();

            //        this.comboBoxCathedra.DataSource = univer.Cathedras.ToList();
            //        this.comboBoxCathedra.DisplayMember = "Name";
            //        this.comboBoxCathedra.Invalidate();
            //    }
            //}
        }

        private void textBoxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
