using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace harun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=tblmezar;Uid=root;Pwd='';");

        void olustur()
        {

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT UID FROM tblmezar as m left join tbluye as u on u.UMID=m.MID ORDER BY m.MID", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            panel.Children.Clear();
            panel2.Children.Clear();
            panel3.Children.Clear();
            panel4.Children.Clear();
            panel5.Children.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + (i + 1).ToString();
                btn.Tag = i + 1;
                if (dt.Rows[i]["UID"].ToString() != "")
                {
                    btn.Background = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    btn.Background = new SolidColorBrush(Colors.Green);

                }
                btn.Width = 100;
                btn.Height = 50;
                btn.Content = "Mezar " + (i + 1).ToString();
                btn.Click += new RoutedEventHandler(bnt_Click);
                if (i >= 0 && i <= 10)
                {
                    panel.Children.Add(btn);
                }
                else if (i >= 11 && i <= 20)
                { panel2.Children.Add(btn); }
                else if (i >= 21 && i <= 30)
                { panel3.Children.Add(btn); }
                else if (i >= 31 && i <= 40)
                { panel4.Children.Add(btn); }
                else if (i >= 41 && i <= 50)
                { panel5.Children.Add(btn); }


            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            olustur();
        }

        void bnt_Click(object sender, RoutedEventArgs e)
        {
            string id;
            Button btnn = (Button)sender;
            id = btnn.Tag.ToString();

            txtmezar.Text = id;
            //MessageBox.Show("Button pressed " + buttonThatWasClicked.Tag.ToString());



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            baglanti.Close();
            baglanti.Open();
            string komut = "insert into tbluye(UMID,UAD,UDOGUMTAR,UOLUMTAR) values('" + txtmezar.Text + "', '" + txtad.Text + "', '" + dtp.DisplayDate + "', '" + dtp2.DisplayDate + "')";
            MySqlCommand kmt = new MySqlCommand(komut, baglanti);
            kmt.ExecuteNonQuery();
            olustur();



        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            string komut = "delete from tbluye where UMID='" + txtmezar.Text + "' ";
            MySqlCommand kmt = new MySqlCommand(komut, baglanti);
            kmt.ExecuteNonQuery();
            olustur();
        }
    }
}
