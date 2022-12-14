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

namespace book_control_tab_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> StringCollection { get; set; }
        public ObservableCollection<Book> Books { get; set; }
        public Book CheckedBook { get; set; }
        public Book SelectedItem { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            StringCollection = "I found a love, for me\r\nDarling, just dive right in and follow my lead\r\nWell, I found a girl, beautiful and sweet\r\nOh, I never knew you were the someone waiting for me\r\n'Cause we were just kids when we fell in love\r\nNot knowing what it was\r\nI will not give you up this time\r\nBut darling, just kiss me slow\r\nYour heart is all I own\r\nAnd in your eyes, you're holding mine\r\nBaby, I'm dancing in the dark\r\nWith you between my arms\r\nBarefoot on the grass\r\nListening to our favourite song\r\nWhen you said you looked a mess\r\nI whispered underneath my breath\r\nBut you heard it\r\nDarling, you look perfect tonight\r\nWell, I found a woman, stronger than anyone I know\r\nShe shares my dreams, I hope that someday I'll share her home\r\nI found a lover, to carry more than just my secrets\r\nTo carry love, to carry children of our own\r\nWe are still kids, but we're so in love\r\nFighting against all odds\r\nI know we'll be alright this time\r\nDarling, just hold my hand\r\nBe my girl, I'll be your man\r\nI see my future in your eyes\r\nBaby, I'm dancing in the dark\r\nWith you between my arms\r\nBarefoot on the grass\r\nListening to our favorite song\r\nWhen I saw you in that dress, looking so beautiful\r\nI don't deserve this\r\nDarling, you look perfect tonight\r\nBaby, I'm dancing in the dark\r\nWith you between my arms\r\nBarefoot on the grass\r\nListening to our favorite song\r\nI have faith in what I see\r\nNow I know I have met an angel in person\r\nAnd she looks perfect\r\nI don't deserve this\r\nYou look perfect tonight".Split(' ').ToArray();
            DataContext= this;
            prepareBooks();
        }

        private void prepareBooks()
        {
            Books = new ObservableCollection<Book>();
            Books.Add(new Book("Pingwiny wodki nie pija", "Travelling", "Fazowski Daiwd", "13.12.2022"));
            Books.Add(new Book("Lessons in chemistry", "Science", "Hardcover", "12.12.2022"));
            Books.Add(new Book("It starts with us", "Novel", "Hardcover", "10.12.2022"));
            Books.Add(new Book("A world of curiosities", "Historical", "Hardcover", "09.12.2022"));
        }


        private void add_book_to_library(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(book_t.Text) && !string.IsNullOrEmpty(book_dsc.Text)
                && !string.IsNullOrEmpty(book_a.Text) && !string.IsNullOrEmpty(book_rd.Text))
            {
                MessageBox.Show("EVERY FIELD ARE FILLED :)), now we can add your book to us...");
                Books.Add(new Book(book_t.Text, book_dsc.Text, book_a.Text, book_rd.Text));
            }
            else
            {
                if (string.IsNullOrEmpty(book_t.Text)) { MessageBox.Show("TITLE is empty!"); }
                else if (string.IsNullOrEmpty(book_dsc.Text)) { MessageBox.Show("DESCRIPTION is empty!"); }
                else if (string.IsNullOrEmpty(book_a.Text)) { MessageBox.Show("AUTHOR is empty!"); }
                else if (string.IsNullOrEmpty(book_rd.Text)) { MessageBox.Show("DATE is empty!"); }
                else { MessageBox.Show("EVERYTHING IS WROOONG !!!"); }
            }
        }

        private void show_checked(object sender, RoutedEventArgs e)
        {
            if (CheckedBook != null)
            {
                MessageBox.Show("ID = " + CheckedBook.Id +
                                "\nTitle = " + CheckedBook.Title +
                                "\nAuthor = " + CheckedBook.Author +
                                "\nDescription = " + CheckedBook.Description +
                                "\nRealase Date = " + CheckedBook.ReleaseDate);
            }
            else
                MessageBox.Show("Nothing...");
        }

        private void delete_checked(object sender, RoutedEventArgs e)
        {
            if (CheckedBook != null)
            {
                Books.Remove(CheckedBook);
            }
            else
                MessageBox.Show("Nothing");
        }
    }
}
