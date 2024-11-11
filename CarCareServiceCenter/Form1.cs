using CarCareServiceDB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarCareServiceCenter
{
    public partial class Form1 : Form
    {
        private int mechanicID = 1; // Замените 1 на фактический ID механика или задайте его после входа в систему

        public Form1()
        {
            InitializeComponent();

            // Стилизация кнопок и компонентов
            StyleButton(btnRefresh);
            StyleButton(btnSaveProgress);
            StyleButton(btnRequestPart);
            StyleButton(btnSaveProfile);

            // События для кнопок
            btnRefresh.Click += BtnRefresh_Click;
            btnSaveProgress.Click += BtnSaveProgress_Click;
            btnRequestPart.Click += BtnRequestPart_Click;
            btnSaveProfile.Click += BtnSaveProfile_Click;

            // Загрузка начальных данных
            LoadServiceTasks();
        }

        private void StyleButton(Button button)
        {
            button.BackColor = Color.Teal;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadServiceTasks();
        }

        private void LoadServiceTasks()
        {
            using (var connection = new Database().GetConnection())
            {
                var query = "SELECT TaskID, RealTaskDescriptionColumn, RealStatusColumn, RealCollectionTimeColumn, RealAdditionalRepairsColumn FROM ServiceTasks WHERE MechanicID = @MechanicID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MechanicID", mechanicID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridViewTasks.DataSource = dataTable;
                }
            }
        }

        private void BtnSaveProgress_Click(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem == null || string.IsNullOrEmpty(textBoxAdditionalRepairs.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (dataGridViewTasks.SelectedRows.Count == 0 || !int.TryParse(dataGridViewTasks.SelectedRows[0].Cells["TaskID"].Value.ToString(), out int taskId))
            {
                MessageBox.Show("Please select a valid task.");
                return;
            }

            string status = comboBoxStatus.SelectedItem.ToString();
            DateTime collectionTime = dateTimePickerCollectionTime.Value;
            string additionalRepairs = textBoxAdditionalRepairs.Text;

            UpdateServiceProgress(taskId, status, collectionTime, additionalRepairs);
        }

        private void UpdateServiceProgress(int taskId, string status, DateTime collectionTime, string additionalRepairs)
        {
            using (var connection = new Database().GetConnection())
            {
                var query = "UPDATE ServiceTasks SET Status = @Status, CollectionTime = @CollectionTime, AdditionalRepairs = @AdditionalRepairs WHERE TaskID = @TaskID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@CollectionTime", collectionTime);
                    cmd.Parameters.AddWithValue("@AdditionalRepairs", additionalRepairs);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating progress: " + ex.Message);
                    }
                }
            }
        }

        private void BtnRequestPart_Click(object sender, EventArgs e)
        {
            if (comboBoxPartName.SelectedItem == null || !int.TryParse(textBoxPartQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please fill all fields with valid data.");
                return;
            }

            string partName = comboBoxPartName.SelectedItem.ToString();
            RequestPart(partName, quantity);
        }

        private void RequestPart(string partName, int quantity)
        {
            using (var connection = new Database().GetConnection())
            {
                var query = "UPDATE Inventory SET RequestedQuantity = RequestedQuantity + @Quantity WHERE PartName = @PartName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@PartName", partName);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error requesting part: " + ex.Message);
                    }
                }
            }
        }

        private void BtnSaveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            UpdateProfile(name, email, phone);
        }

        private void UpdateProfile(string name, string email, string phone)
        {
            using (var connection = new Database().GetConnection())
            {
                var query = "UPDATE Mechanic SET Name = @Name, Email = @Email, Phone = @Phone WHERE MechanicID = @MechanicID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@MechanicID", mechanicID);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating profile: " + ex.Message);
                    }
                }
            }
        }
    }
}
