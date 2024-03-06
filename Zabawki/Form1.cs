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
            toysList.Items.Remove(toysList.SelectedItem);
        }

        private void addToy(string toyName)
        {
            switch(toyName)
            {
                case "Car":
                    toysList.Items.Add(new Car());
                    break;
                case "Plane":
                    toysList.Items.Add(new Plane());
                    break;
                case "Computer":
                    toysList.Items.Add(new Computer());
                    break;
                case "Submarine":
                    toysList.Items.Add(new Submarine());
                    break;
                default:
                    break;
            }
        }
    }
}
