using System.Windows.Forms;

namespace _Library_GUI_.Forms
{
    using System.Data;
    using _Library_GUI_.ServiceReference1;

    public partial class Datas_FromService : Form
    {
        ServiceClient client;
        public Datas_FromService()
        {
            InitializeComponent();
            client = new ServiceClient();
        }

        void Show_All_Books()
        {
            DataSet table = new DataSet();
            table = client.Read_Book();
            dataGridView1.DataSource = table.Tables[0];
            dataGridView1.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void show_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                Show_All_Books();
                this.Text = "Welcome to Library!";
            }
            catch { this.Text = "Попробуйте поднять сервер WCF!"; }
        }

        private void insert_btn_Click(object sender, System.EventArgs e)
        {
            Add_Book add_book = new Add_Book("ServiceWCF", client);
            add_book.ShowDialog();
        }

        private void dit_btn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
