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
            }
