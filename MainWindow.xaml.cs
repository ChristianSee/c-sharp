//*****************************************************
//**                                                 **
//** By: Christian Seepold,                          **
//** Thema: Verschiedene WPF-Elemente                **
//** Version 1.0                                     **
//** Datum: 12.01.2021                               **
//** Status: ready                                   **
//**                                                 **
//*****************************************************


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
using System.IO;
using System.Collections.ObjectModel;



namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Einträge fuer die ComboBox einfuegen mit "Code-Behind"
            this.Combobox.Items.Add("Eintrag1");
            this.Combobox.Items.Add("Eintrag2");
            this.Combobox.Items.Add("Eintrag3");

        }

        //noch unbenutzt
        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TreeViewItem eineWurzel = new TreeViewItem();
            eineWurzel.Header = "Eine Wurzel";
                        
            TreeViewItem einBlatt1 = new TreeViewItem();
            einBlatt1.Header = "Erstes Blatt";
            
            eineWurzel.Items.Add(einBlatt1);
            TreeView.Items.Add(eineWurzel);
        }*/
       
        //Ausgabe bei Klick auf den linken Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ein Klick auf den Button ist erfolgt");
            Button1.Content = "Button gedrückt !";
        }
        
        //Ausgabe bei Klick auf einen Radiobutton und/oder auf den/die Chekcboxen
        private void Absenden1_Click(object sender, RoutedEventArgs e)
        {
            string ausgabeText;

            //Radiobuttons
            if (this.Test1.IsChecked == true)
                ausgabeText = "Test1 gedrückt";
            else 
                ausgabeText = "Test2 gedrückt";

            //Checkboxen
            if (this.Check1.IsChecked == true)
                ausgabeText += " und Option 1 gewählt";

            if (this.Check2.IsChecked == true)
                ausgabeText += " und Option 2 gewählt";

            if (this.Check3.IsChecked == true)
                ausgabeText += " und Option 3 gewählt";

            //Ausgabe
            MessageBox.Show(ausgabeText);
            
        }

        //Ausgabe bei Klick auf den 1.Listboxeintrag
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string boxText1 = "Ausgewaehlter Index: ";

            boxText1 += this.Listbox.SelectedIndex;
            boxText1 += "\n Ausgewaehlter Text: ";
            boxText1 += this.Listbox.SelectedItem;

            MessageBox.Show(boxText1);
        }

        //Ausgabe bei Klick auf den 2.Listboxeintrag
        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
                string boxText2 = "Ausgewaehlter Index: ";

                boxText2 += this.Listbox.SelectedIndex;
                boxText2 += "\nAusgewaehlter Text: ";
                boxText2 += this.Listbox.SelectedItem;

                MessageBox.Show(boxText2);
        }

        //Ausgabe bei Klick auf den 3.Listboxeintrag
        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
                string boxText3 = "Ausgewaehlter Index: ";

                boxText3 += this.Listbox.SelectedIndex;
                boxText3 += "\nAusgewaehlter Text: ";
                boxText3 += this.Listbox.SelectedItem;

                MessageBox.Show(boxText3);
        }

        //Ausgabe bei Klick auf die ComboBox
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string comboText = "Ausgewahlter Index: ";

            comboText += this.Combobox.SelectedIndex;
            comboText += "\nAusgewaehlter Text: ";
            comboText += this.Combobox.SelectedItem;

            MessageBox.Show(comboText);

        }

        //Methoden fuer die Baumstruktur
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem knoten = (TreeViewItem)TreeView.SelectedItem;

            MessageBox.Show(knoten.Header.ToString());
        }

        //Knoten einfuegen
        private void baumEinf_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem newChild = new TreeViewItem();
            newChild.Header = TextBox1.Text;
            var parent = TreeView.SelectedItem as TreeViewItem;  // Checking for selected element
            parent.Items.Add(newChild);
        }
        
        //Baum loeschen
        private void baumEntf_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Remove(TreeView.SelectedItem);

        }

    }
}
