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

        private List<Object> toys = new List<Object>();

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

        private void addToy(string toy)
        {
            Object newToy = null;
            switch(toy)
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
    }
}
