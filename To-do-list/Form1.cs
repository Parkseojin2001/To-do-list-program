namespace To_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            dgv.Rows.Add(txtTask.Text, txtClassification.Text, txtStart.Text, txtDeadLine.Text, txtImportance.Text, txtStartTime.Text);
            txtTask.Text = null;
            txtStart.Text = null;
            txtDeadLine.Text = null;
            txtImportance.Text = null;
            txtClassification.Text = null;
            txtStartTime.Text = null;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            if (dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells["task"].Value = txtTask.Text;
                dgv.CurrentRow.Cells["startdate"].Value = txtStart.Text;
                dgv.CurrentRow.Cells["deadline"].Value = txtDeadLine.Text;
                dgv.CurrentRow.Cells["importance"].Value = txtImportance.Text;
                dgv.CurrentRow.Cells["classification"].Value = txtClassification.Text;
                dgv.CurrentRow.Cells["startTime"].Value = txtStartTime.Text;
                txtTask.Text = null;
                txtStart.Text = null;
                txtDeadLine.Text = null;
                txtImportance.Text = null;
                txtClassification.Text = null;
                txtStartTime.Text = null;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                if (dgv.CurrentRow == null)
                {
                    txtTask.Text = null;
                    txtStart.Text = null;
                    txtDeadLine.Text = null;
                    txtImportance.Text = null;
                    txtClassification.Text = null;
                    txtStartTime.Text = null;

                }
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                txtTask.Text = dgv.CurrentRow.Cells["task"].Value.ToString();
                txtStart.Text = dgv.CurrentRow.Cells["startdate"].Value.ToString();
                txtDeadLine.Text = dgv.CurrentRow.Cells["deadline"].Value.ToString();
                txtImportance.Text = dgv.CurrentRow.Cells["importance"].Value.ToString();
                txtClassification.Text = dgv.CurrentRow.Cells["classification"].Value.ToString();
                txtStartTime.Text = dgv.CurrentRow.Cells["startTime"].Value.ToString();
            }
        }
    }
}