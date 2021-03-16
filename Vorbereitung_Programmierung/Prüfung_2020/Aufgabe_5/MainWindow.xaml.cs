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

namespace Aufgabe_5
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICollectionView CollectionView;

        mondialEntities entities = new mondialEntities();

        public MainWindow()
        {
            InitializeComponent();

            entities.City.Load();
            CollectionView = CollectionViewSource.GetDefaultView(entities.City.Local);
            parent.DataContext = CollectionView;
        }

        private void vor_Click(object sender, RoutedEventArgs e)
        {
            CollectionView.MoveCurrentToNext();
            if (CollectionView.IsCurrentAfterLast)
            {
                CollectionView.MoveCurrentToLast();
            }
        }

        private void zur_Click(object sender, RoutedEventArgs e)
        {
            CollectionView.MoveCurrentToPrevious();
            if (CollectionView.IsCurrentBeforeFirst)
            {
                CollectionView.MoveCurrentToFirst();
            }
        }

        private void spe_Click(object sender, RoutedEventArgs e)
        {
            entities.SaveChanges();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            string filter = TbSearchFilter.Text.ToLower();
            CollectionView.Filter = (x => ((City)x).Name.ToLower().Contains(filter));
            foreach (var item in entities.City)
            {
                if (item.Name.ToLower().Contains(filter))
                {
                    count++;
                }
            }
            anzahl.Text = count.ToString();
        }
    }
}
