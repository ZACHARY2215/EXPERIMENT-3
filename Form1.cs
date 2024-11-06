using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BALAMAN_IT201_CRUD_DEMO_08
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;  //= new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BALAMAN_IT201_CRUD_DEMO_08;Integrated Security=True;Trust Server Certificate=True");


        public Form1()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadVehicles()
        {
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Vehicles", connection);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;

            //DataGridViewImageColumn dGVImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
            //dGVImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMake.Text.Length == 0 || txtModel.Text.Length == 0)
                {
                    throw new Exception();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles (Make, Model, Year, Price, IsElectric, Color, CreatedDate) VALUES (@Make, @Model, @Year, @Price, @IsElectric, @Color, @CreatedDate)", connection);

                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@IsElectric", chkIsElectric.Checked);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadVehicles();

                MessageBox.Show("New vehicle created!");
            }
            catch (Exception)
            {
                MessageBox.Show("Fill out the forms properly!");
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with the selected row data
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                chkIsElectric.Checked = (bool)row.Cells["IsElectric"].Value;
                txtColor.Text = row.Cells["Color"].Value.ToString();

                // Set the PictureBox Image Placeholder
                if (row.Cells["Image"].Value != DBNull.Value && row.Cells["Image"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["Image"].Value;
                    picVehicleImage.Image = ByteArrayToImage(imageBytes);
                }
                else
                {
                    picVehicleImage.Image = null; // Clear the PictureBox
                }

                // Set the CreatedDate TextBox
                DateTime createdDate = (DateTime)row.Cells["CreatedDate"].Value;
                dateTimePicker1.Text = createdDate.ToString("yyyy-MM-dd HH:mm:ss"); // Format as needed

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the VehicleID of the selected row
                int vehicleId = (int)dataGridView1.SelectedRows[0].Cells["VehicleID"].Value;

                using (MemoryStream ms = new MemoryStream())
                {

                    picVehicleImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();

                    // Prepare the SQL command to update the vehicle
                    string query = "UPDATE Vehicles SET Make = @Make, Model = @Model, Year = @Year, " +
                               "Price = @Price, IsElectric = @IsElectric, Color = @Color, CreatedDate = @CreatedDate, Image = @Image " +
                               "WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@IsElectric", chkIsElectric.Checked);
                        cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                        cmd.Parameters.AddWithValue("@CreatedDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleId);

                        try
                        {
                            // Open connection and execute the command
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Vehicle updated successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating vehicle: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close(); // Ensure the connection is closed
                        }
                    }

                    // Reload the data to reflect changes
                    LoadVehicles();
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to update.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.OKCancel)
                == DialogResult.Cancel
               )
            {
                return;
            }

            // Ensure a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the VehicleID of the selected row
                int vehicleId = (int)dataGridView1.SelectedRows[0].Cells["VehicleID"].Value;

                // Prepare the SQL command to delete the vehicle
                string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameter to the command
                    cmd.Parameters.AddWithValue("@VehicleID", vehicleId);

                    try
                    {
                        // Open connection and execute the command
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting vehicle: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Ensure the connection is closed
                    }
                }

                // Reload the data to reflect changes
                LoadVehicles();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Prepare the SQL command to search for vehicles
            string query = "SELECT * FROM Vehicles WHERE Make LIKE @SearchTerm OR Model LIKE @SearchTerm";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Add parameter for search term
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Use wildcards for partial matching

                try
                {
                    // Open connection
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Bind the results to the DataGridView
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching vehicles: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Ensure the connection is closed
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Vehicle Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    picVehicleImage.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void txtYear_Click(object sender, EventArgs e)
        {
            txtYear.SelectionStart = 0;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutUs ab = new())
            {
                ab.ShowDialog();
            }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.SelectionStart = 0;
        }
    }
}
