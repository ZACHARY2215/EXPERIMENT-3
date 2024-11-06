using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BAUTISTA_DAMALERIO_JIMENEZ_IT201_CRUD_DEMO_08
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bautistadamaleriojimenez_database;Integrated Security=True;Trust Server Certificate=True");
        private Theme currentTheme;


        public Form1()
        {

            currentTheme = LightTheme;
            InitializeComponent();
            LoadVehicles();
            ApplyTheme(currentTheme);



            ToggleTheme1.Click += (s, e) => ToggleTheme();
        }

        private void InitializeThemetoggleButton()
        {
            ToggleTheme1.Text = "Toggle Theme";
            ToggleTheme1.BackColor = Color.LightGray;
            ToggleTheme1.ForeColor = Color.Black;
            ToggleTheme1.Location = new Point(842, 16);
            ToggleTheme1.Click += (s, e) => ToggleTheme();
            this.Controls.Add(ToggleTheme1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void LoadVehicles()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Vehicles", connection);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;

        //    DataGridViewImageColumn dGVImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
        //    dGVImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        //}

        private void LoadVehicles()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Vehicles", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (dataGridView1.Columns.Contains("Image"))
                    {
                        DataGridViewImageColumn dGVImageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
                        dGVImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles (Make, Model, Year, Price, IsElectric, Color, CreatedDate) VALUES (@Make, @Model, @Year, @Price, @IsElectric, @Color, @CreatedDate)", connection);

                cmd.Parameters.Add("@Make", SqlDbType.NVarChar).Value = txtMake.Text;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = txtModel.Text;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = int.Parse(txtYear.Text);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = decimal.Parse(txtPrice.Text);
                cmd.Parameters.Add("@IsElectric", SqlDbType.Bit).Value = chkIsElectric.Checked;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = txtColor.Text;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadVehicles();

                MessageBox.Show("New vehicle created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message);
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

                // Populate the textboxes with the selected row data, handling DBNull values
                txtMake.Text = row.Cells["Make"].Value?.ToString() ?? string.Empty;
                txtModel.Text = row.Cells["Model"].Value?.ToString() ?? string.Empty;
                txtYear.Text = row.Cells["Year"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;

                // Check if "IsElectric" cell has a value and set the checkbox accordingly
                chkIsElectric.Checked = row.Cells["IsElectric"].Value != DBNull.Value && (bool)row.Cells["IsElectric"].Value;

                txtColor.Text = row.Cells["Color"].Value?.ToString() ?? string.Empty;

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

                // Set the CreatedDate TextBox, handling DBNull values
                if (row.Cells["CreatedDate"].Value != DBNull.Value && row.Cells["CreatedDate"].Value != null)
                {
                    DateTime createdDate = (DateTime)row.Cells["CreatedDate"].Value;
                    dateTimePicker1.Text = createdDate.ToString("yyyy-MM-dd HH:mm:ss"); // Format as needed
                }
                else
                {
                    dateTimePicker1.Text = string.Empty; // Clear the DateTimePicker if no date is present
                }
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
        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        //private void btnDelete_Click_1(object sender, EventArgs e)
        //{
        //    // Ensure a row is selected in the DataGridView
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        // Get the VehicleID of the selected row
        //        int vehicleId = (int)dataGridView1.SelectedRows[0].Cells["VehicleID"].Value;

        //        // Prepare the SQL command to delete the vehicle
        //        string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            // Add parameter to the command
        //            cmd.Parameters.AddWithValue("@VehicleID", vehicleId);

        //            try
        //            {
        //                // Open connection and execute the command
        //                connection.Open();
        //                cmd.ExecuteNonQuery();
        //                MessageBox.Show("Vehicle deleted successfully!");
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error deleting vehicle: " + ex.Message);
        //            }
        //            finally
        //            {
        //                connection.Close(); // Ensure the connection is closed
        //            }
        //        }

        //        // Reload the data to reflect changes
        //        LoadVehicles();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a vehicle to delete.");
        //    }
        //}

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this vehicle?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int vehicleId = (int)dataGridView1.SelectedRows[0].Cells["VehicleID"].Value;

                    string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleId);

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Vehicle deleted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error delete vehicle: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                    LoadVehicles();
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete. ");
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

        private void picVehicleImage_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            chkIsElectric.Checked = false;
            txtColor.Clear();
            dateTimePicker1.Value = DateTime.Now;
            picVehicleImage.Image = null;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public class Theme
        {
            public Color BackGroundColor { get; set; }
            public Color ButtonBackColor { get; set; }
            public Color ButtonTextColor { get; set; }
            public Color TextColor { get; set; }
        }

        public Theme LightTheme = new Theme()
        {
            BackGroundColor = Color.White,
            ButtonBackColor = Color.LightGray,
            ButtonTextColor = Color.Black,
            TextColor = Color.Black,
        };

        public Theme DarkTheme = new Theme()
        {
            BackGroundColor = Color.FromArgb(30, 30, 30),
            ButtonBackColor = Color.Gray,
            ButtonTextColor = Color.White,
            TextColor = Color.White,
        };

        public void ApplyTheme(Theme theme)
        {
            this.BackColor = theme.BackGroundColor;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = theme.ButtonBackColor;
                    button.ForeColor = theme.ButtonTextColor;
                }
                else if (control is Label || control is TextBox || control is DataGridView)
                {
                    control.ForeColor = theme.TextColor;
                    control.BackColor = theme.BackGroundColor;
                }
            }

            dataGridView1.BackgroundColor = theme.BackGroundColor;
            dataGridView1.DefaultCellStyle.BackColor = theme.BackGroundColor;
            dataGridView1.DefaultCellStyle.ForeColor = theme.TextColor;
        }

        private void ToggleTheme()
        {
            currentTheme = currentTheme == LightTheme ? DarkTheme : LightTheme;
            ApplyTheme(currentTheme);
        }


    }
}
