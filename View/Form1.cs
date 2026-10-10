using ApplicationService.Dtos;
using ApplicationService.Services;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly PersonApplicationService _PersonApplicationService;
        private int? _SelectedPersonId=null;
        public Form1()
        {
            InitializeComponent();
            _PersonApplicationService = new PersonApplicationService();
        }
        private void RefreshForm()
        {
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = _PersonApplicationService.GetAll();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            _SelectedPersonId = null;
            txtFirstName.Focus();
            btnRefresh.Enabled = true;
            btnPost.Enabled = true;
            btnUpdate.Enabled = false;

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var postPersonDto = new PostPersonDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };

            _PersonApplicationService.Post(postPersonDto);
            MessageBox.Show($"your register {postPersonDto.FirstName},{postPersonDto.LastName}is sucssesfully registered");
            RefreshForm();
        }

        private void dgvPersonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPerson.Rows[e.RowIndex];
                _SelectedPersonId=Convert.ToInt32(row.Cells["Id"].Value);
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                btnRefresh.Enabled = false;
                btnPost.Enabled= false;
                btnUpdate.Enabled = true;

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(_SelectedPersonId.HasValue)
            {
                var updateDto = new UpdatePersonDto()
                {
                    Id = _SelectedPersonId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                };
                _PersonApplicationService.Update(updateDto);
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد.");
                RefreshForm();
            }
            else
            {
                MessageBox.Show("لطفاً ابتدا یک سطر را از جدول انتخاب کنید.");
            }


        }
    }
}
