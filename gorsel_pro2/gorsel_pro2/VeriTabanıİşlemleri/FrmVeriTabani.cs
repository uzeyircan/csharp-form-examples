using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Policy;


namespace gorsel_pro2.VeriTabanı_İşlemleri
{
    public partial class FrmVeriTabani : Form
    {
        public FrmVeriTabani()
        {
            InitializeComponent();
        }

        //SqlConnection Baglan = new SqlConnection("Data Source=(local); Initial Catalog = GorselProg; Integrated Security=True");
        //SqlConnection Baglan = new SqlConnection("Data Source=(local); Initial Catalog =GorselProg; Persist Security Info=true; User ID=sa; Password=1");
        SqlConnection Baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriTabaniBaglanti"].ToString());

        private void FrmVeriTabani_Load(object sender, EventArgs e)
        {
            try
            {
                Baglan.Open();
                MessageBox.Show("VeriTabanı Bağlantısı açıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VeriTabanı Bağlantısı açılamadı. Hata: " + ex.Message);
            }
            string Sql = "select * from Kullanici";
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);
            SqlDataReader oku = Yonet.ExecuteReader();
            ////tek Kayıt getirmede kullanılır 
            //if (oku.Read())
            //{
            //    LstBoxBilgi.Items.Add(oku["Tc"].ToString() + " " + oku["Ad"].ToString() + " " + oku["SoyAd"].ToString());
            //}
            //tüm kayıtları getirmede kullanılır
            while (oku.Read())
            {
                LstBoxBilgi1.Items.Add(oku["Tc"].ToString() + " " + oku["Ad"].ToString() + " " + oku["SoyAd"].ToString());
            }
            oku.Close();
            Yonet.Dispose();
            Baglan.Close();

            ////DataTable ile listbox doldurma
            ////datatable nesnesi. Verileri sanal bir tablo şeklinde içinde barındıran yapı.
            //DataTable Tablo = new DataTable();
            //Sql = "select Id,Ad+space(1)+Soyad AdSoyad from Kullanici";
            //Yonet = new SqlCommand(Sql, Baglan);
            //Baglan.Open();
            ////SqlDataAdapter nesnesi, veritabanından okunan veriler üzerinde daha fazla işlem yapmayı sağlayan yapıdır.
            ////Örn:Verileri kolon işlemleri ile birlikte datatable nesnesine doldurur.
            //SqlDataAdapter VeriAdaptoru= new SqlDataAdapter(Yonet);
            //VeriAdaptoru.Fill(Tablo);
            //Yonet.Dispose();
            //Baglan.Close();
            //LstBoxBilgi2.DataSource = Tablo;
            //LstBoxBilgi2.DisplayMember = "AdSoyad";
            //LstBoxBilgi2.ValueMember = "Id";
            Guncelle();


        }
        private void BtnAc_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            MessageBox.Show("VeriTabanı Bağlantısı açıldı");

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Baglan.Close();
            MessageBox.Show("VeriTabanı Bağlantısı kapatıldı");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Baglan.State == ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı Açık");
            }
            else
            {
                MessageBox.Show("Bağlantı Kapalı");

            }

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            string Sql = "insert into Kullanici(Tc,Ad,Soyad) values('" + txtTc.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "')";
            //SqlCommand Sınıfı. Sql Sorgularını veritabanına bağlanarak yürüten sınıftır.
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);
            //ExecuteNonQuery() Metodu. Sql Sorgularını yürütür. geriye etkilenen satır sayısını int türünden çevirir.
            Yonet.ExecuteNonQuery();
            Yonet.Dispose (); 
            Baglan.Close();
            MessageBox.Show("Kayıtlı başarılı....");
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            Guncelle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            // string Sql = "update Kullanici set Tc='" + txtTc.Text + "',Ad='" + txtAd.Text+ "',Soyad='" + txtSoyad.Text + "' + LstBoxBilgi2.SelectedValue+ "'";

            //Parametreli güncelleme
            string Sql = "update Kullanici set Tc=@Tc,Ad=@Ad,SoyAd=@SoyAd where Id=@Id";
            SqlCommand yonet = new SqlCommand(Sql, Baglan);
            yonet.Parameters.AddWithValue("Tc", txtTc.Text);
            yonet.Parameters.AddWithValue("Ad", txtAd.Text);
            yonet.Parameters.AddWithValue("SoyAd", txtSoyad.Text);
            yonet.Parameters.AddWithValue("Id", '1');
            Baglan.Open();
            yonet.ExecuteNonQuery();
            yonet.Dispose ();
            Baglan.Close();
            MessageBox.Show("Güncelleme başarılı...");

            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            Guncelle();
        }
        void Guncelle()
        {
            //DataTable ile listbox doldurma
            //datatable nesnesi. Verileri sanal bir tablo şeklinde içinde barındıran yapı.
            DataTable Tablo = new DataTable();
            string Sql = "select Id,Ad+space(1)+Soyad AdSoyad from Kullanici";
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);
            Baglan.Open();
            //SqlDataAdapter nesnesi, veritabanından okunan veriler üzerinde daha fazla işlem yapmayı sağlayan yapıdır.
            //Örn:Verileri kolon işlemleri ile birlikte datatable nesnesine doldurur.
            SqlDataAdapter VeriAdaptoru = new SqlDataAdapter(Yonet);
            VeriAdaptoru.Fill(Tablo);
            Yonet.Dispose();
            Baglan.Close();
            LstBoxBilgi2.DataSource = Tablo;
            LstBoxBilgi2.DisplayMember = "AdSoyad";
            LstBoxBilgi2.ValueMember = "Id";
        }

        private void BtnBilgiSil_Click(object sender, EventArgs e)
        {
            string Sql = "delete from Kullanici where Id=@Id";
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);
            Baglan.Open();
            Yonet.Parameters.AddWithValue("Id", LstBoxBilgi2.SelectedValue);
            Yonet.ExecuteNonQuery();
            Yonet.Dispose();
            Baglan.Close();

            Guncelle();

        }

        private void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
            string Sql = "Select Tc,Ad,Soyad from Kullanici where Id='" + LstBoxBilgi2.SelectedValue + "'";
            SqlCommand Yonet = new SqlCommand (Sql, Baglan);
            Baglan.Open();
            SqlDataReader oku = Yonet.ExecuteReader();
            if (oku.Read())
            {
                txtTc.Text = oku["Tc"].ToString();
                txtAd.Text = oku["Ad"].ToString();
                txtSoyad.Text = oku["Soyad"].ToString();
            }
            Yonet.Dispose ();
            Baglan.Close ();


        }
    }
}
