using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

namespace Prüfung1819
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICollectionView collectionView;
        bahnEntities entities = new bahnEntities();


        public MainWindow()
        {
            InitializeComponent();

            entities.Bahnhoefe.Load();
            collectionView = CollectionViewSource.GetDefaultView(entities.Bahnhoefe.Local);
            parent.DataContext = collectionView;

        }

        private void vor_Click(object sender, RoutedEventArgs e)
        {
            collectionView.MoveCurrentToNext();

            if (collectionView.IsCurrentAfterLast)
            {
                collectionView.MoveCurrentToLast();
            }
        }

        private void zur_Click(object sender, RoutedEventArgs e)
        {
            collectionView.MoveCurrentToPrevious();

            if (collectionView.IsCurrentBeforeFirst)
            {
                collectionView.MoveCurrentToFirst();
            }
        }

        private void spei_Click(object sender, RoutedEventArgs e)
        {
            entities.SaveChanges();
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_search.Text != "")
            {
                int searchStr = Convert.ToInt32(tb_search.Text);

                collectionView.Filter = null;

                var list = collectionView.Cast<Bahnhoefe>();
                Bahnhoefe n = list.FirstOrDefault(x => x.Bahnhofsnummer.Equals(searchStr));
                collectionView.MoveCurrentTo(n);
            }
            else
            {
                collectionView.Filter = null;
                collectionView.MoveCurrentToFirst();
            }
        }
    }
}
