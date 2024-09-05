using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Pizza_opgave101
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        List<Pizza> pizzaer = new List<Pizza>();

        public MainWindow()
        {
            InitializeComponent();
            pizzaer.Add(new Pizza() { ID = 0, Navn = "Margurite" });
            pizzaer.Add(new Pizza() { ID = 1, Navn = "Meat Lover" });
            pizzaer.Add(new Pizza() { ID = 2, Navn = "Vulgar Vegan" });
            pizzaer.Add(new Pizza() { ID = 3, Navn = "Chilli Heat" });

            //Lav om til json text
            string json = JsonConvert.SerializeObject(pizzaer, Formatting.Indented);
            File.WriteAllText(AppContext.BaseDirectory + "data.json", json);

            //Hent fra json
            string jsonFromTextFile = File.ReadAllText(AppContext.BaseDirectory + "data.json");
            List<Pizza> pizzasFromFile = JsonConvert.DeserializeObject<List<Pizza>>(jsonFromTextFile);
        }

         
    }
}

