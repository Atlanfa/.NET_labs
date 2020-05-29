namespace Library_GUI
{
    using System.Data;
    using System.Windows;
    using Library_GUI.ServiceReference1;

    public partial class Service_Window : Window
    {
        ServiceClient client;
        public Service_Window()
        {
            InitializeComponent();
            client = new ServiceClient();
        }

        private void show_books_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Show_All_Books();
                //this.Content = "Welcome to Library!";
            }
            catch { /*this.Content = "Попробуйте поднять сервер WCF!";*/ }
        }

        void Show_All_Books()
        {
            DataSet table = new DataSet();
            table = client.Read_Book();
            // dataGridView1.Source = table.Tables[0];
            //dataGridView1.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
