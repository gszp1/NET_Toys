using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {

        private string[] availableToys = { "Car", "Plane", "Submarine", "Computer" };

        private List<Toy> toys = new List<Toy>();

        public Form1()
        {
            InitializeComponent();
            foreach (string toy in availableToys)
            {
                availableToysList.Items.Add(toy);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addToy(availableToysList.SelectedItem.ToString());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeToy(toysList.SelectedItem.ToString());
        }

        private void addToy(string toyName)
        {
            Toy newToy = null;
            switch(toyName)
            {
                case "Car":
                    newToy = new Car();
                    toys.Add(newToy);
                    toysList.Items.Add(newToy);
                    break;
                case "Plane":
                    newToy = new Plane();
                    toys.Add(newToy);
                    toysList.Items.Add(newToy);
                    break;
                case "Computer":
                    newToy = new Computer();
                    toys.Add(newToy);
                    toysList.Items.Add(newToy);
                    break;
                case "Submarine":
                    newToy = new Submarine();
                    toys.Add(newToy);
                    toysList.Items.Add(newToy);
                    break;
                default:
                    break;
            }
        }

        private void removeToy(string toyName)
        {
            foreach (Toy toy in toys)
            {
                if (toy.ToString().Equals(toyName) == true) {
                    toys.Remove(toy);
                    Console.WriteLine(toy.ToString());
                    toysList.Items.Remove(toy);
                    return;
                }
            }
        }

    }
}
