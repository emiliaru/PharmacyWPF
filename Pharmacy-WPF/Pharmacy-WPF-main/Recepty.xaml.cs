using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Pharmacy
{
    /// <summary>
    /// Interaction logic for Recepty.xaml
    /// </summary>
    public partial class Recepty : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=Emilia;Initial Catalog=ReceptyNew;Integrated Security=True");

        public Recepty()
        {
            InitializeComponent();
        }
        
        private void Select()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReceptyNew", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            Data.ItemsSource = dt.DefaultView;
        }

        private void Clear()
        {
            ReceptyNew_Name.Clear();
            ReceptyNew_Surname.Clear();
            ReceptyNew_Birth.Clear();
            ReceptyNew_Delete.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ReceptyNew set Imie = '" + ReceptyNew_Name.Text + "', Nazwisko = '" + ReceptyNew_Surname.Text + "', Data_Urodzenia = '" + ReceptyNew_Birth.Text  + "' WHERE ReceptaID = '" + ReceptyNew_Delete.Text + "' ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been updated successfully", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                Clear();
                Select();
            }
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ReceptyNew WHERE ReceptaID = " + ReceptyNew_Delete.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                con.Close();
                Clear();
                Select();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not Deleted" + " " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public bool Check()
        {
            if (ReceptyNew_Name.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Filed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (ReceptyNew_Surname.Text == String.Empty)
            {
                MessageBox.Show("Surname is required", "Filed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (ReceptyNew_Birth.Text == String.Empty)
            {
                MessageBox.Show("Birth Date is required", "Filed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
           
            return true;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Check())
                {
                    string sql = string.Empty;
                    sql = "INSERT INTO ReceptyNew ([ReceptaID], [Nazwisko], [Imie], [Data_Urodzenia]) values(@ID,@Nazwisko,@Imie,@DataUr)";
                    var rnd = new Random();
                    int id = rnd.Next();
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
                            cmd.Parameters.Add("@Nazwisko", SqlDbType.NVarChar).Value = ReceptyNew_Surname.Text;
                            cmd.Parameters.Add("@Imie", SqlDbType.NVarChar).Value = ReceptyNew_Name.Text;
                            cmd.Parameters.Add("@DataUr", SqlDbType.NVarChar).Value = ReceptyNew_Birth.Text;
                            int rowsAdded = cmd.ExecuteNonQuery();
                            if (rowsAdded > 0)
                                MessageBox.Show("Row inserted");
                            else
                                MessageBox.Show("No row inserted");
                            con.Close();
                            Clear();
                            Select();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR" + ex.Message);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}