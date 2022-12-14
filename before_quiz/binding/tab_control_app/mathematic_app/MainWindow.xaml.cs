using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace mathematic_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> StringCollection { get; set; }
        public ObservableCollection<Film> AllFilms { get; set; }

        public Film CheckedFilm { get; set; }
        public bool Watched { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            StringCollection = "Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world! Hello world!".Split(' ').ToList();
            DataContext = this;
            prepareFilms();
            CheckedFilm = AllFilms[0];
        }

        private void prepareFilms()
        {
            AllFilms = new ObservableCollection<Film>();
            AllFilms.Add(new Film("Notorious", "About Conor McGregor", 10, "Sport/Biography"));
            AllFilms.Add(new Film("Black Adam", "Men who wanted a beer", 2, "Comedy"));
            AllFilms.Add(new Film("Football Match", "World Cup 2022", 11, "Sport"));
            AllFilms.Add(new Film("How to start with programming?", "Much about programming", 100, "Educational"));
            AllFilms.Add(new Film("Come From Away", "Come from Away sifts through the wreckage of tragedy to find hope", 5, "Comedy"));
        }

        private void show_message(object sender, RoutedEventArgs e)
        {
            if (CheckedFilm.Name.Equals("Notorious"))
                MessageBox.Show("Fuck this is really good film!");

            MessageBox.Show("Title: " + CheckedFilm.Name + " description: " + CheckedFilm.Description + "\nrating: " + CheckedFilm.Rating + " type: " + CheckedFilm.Type);
        }

        private void add_film_to_collection(object sender, RoutedEventArgs e)
        {
            string title = tit.Text.ToString();
            string description = dsc.Text.ToString();
            string rating = rat.Text.ToString();
            double r;
            string type = tp.Text.ToString();

            if (double.TryParse(rating, out r))
            {
                if (r > 0 && r < 100 && !string.IsNullOrEmpty(title))
                {
                    AllFilms.Add(new Film(title, description, Int32.Parse(rating), type));
                }
            }
            else
                MessageBox.Show("Rating should be a number!");
        }
    }
}
