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

namespace Janecek_20231025
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

        private void Generate_Grid(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(rowTextbox.Text, out int numRows)&&int.TryParse(rowTextbox.Text, out int numColumns)&&int.TryParse(colorTextbox.Text, out int color))
            {
                dynamicGrid.Children.Clear();
                dynamicGrid.RowDefinitions.Clear();
                dynamicGrid.ColumnDefinitions.Clear();
                for(int row = 0; row < numRows; row++)
                {
                   dynamicGrid.RowDefinitions.Add(new RowDefinition {Height = new GridLength(25) });
                   for (int col = 0; col < numColumns; col++)
                   {
                      if(row==0)
                      {
                      dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition {Width = new GridLength(25)});
                      }
                        var textBox = new TextBox();
                        textBox.Text = $"Row{row},Column{col}";
                        Grid.SetRow(textBox, row);
                        Grid.SetColumn(textBox, col);
                        dynamicGrid.Children.Add(textBox);
                        if((row) == color-1 )
                        {
                            textBox.Background= Brushes.Green ;
                        }
                        else if(col == color-1)
                        {
                            textBox.Background = Brushes.Green;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Zadejte platná čísla pro počet řádků a sloupců");
            }

        }
    }
}
