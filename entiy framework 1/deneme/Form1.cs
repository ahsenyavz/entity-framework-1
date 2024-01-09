using Microsoft.EntityFrameworkCore;

namespace deneme
{
    public partial class Form1 : Form
    {
        Vtcontext veriler = new Vtcontext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.ogrenciler.Load();
            dataGridView1.DataSource = veriler.ogrenciler.Local.ToBindingList();

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Silme";
            btn1.Text = "Sil";
            btn1.Name = "sil";
            btn1.UseColumnTextForButtonValue = true;
            btn1.DefaultCellStyle.BackColor = Color.DarkCyan;
            btn1.Width = 50;

            dataGridView1.Columns.Add(btn1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ogrenci yeni_ogrenci = new ogrenci();
            yeni_ogrenci.OkulNo = Int32.Parse(textBox3.Text);
            yeni_ogrenci.Ad = textBox1.Text;
            yeni_ogrenci.SoyAd = textBox2.Text;

            veriler.ogrenciler.Add(yeni_ogrenci);
            veriler.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            veriler.SaveChanges();
        }
    }
}