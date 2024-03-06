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
            AddToy(availableToysList.SelectedItem.ToString());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            toysList.Items.Remove(toysList.SelectedItem);
        }

        private void toysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSpeedGroupFieldContent((Toy)toysList.SelectedItem);
            SetHeightGroupFieldContent((Toy)toysList.SelectedItem);
            SetDepthGroupFieldContent((Toy)toysList.SelectedItem);
        }

        private void AddToy(string toyName)
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

        private void SetSpeedGroupFieldContent(Toy toy)
        {
            if ((toy is ISpeed) == false)
            {
                DisableGroupBoxContents(speedGroupBox);
                return;
            }
            speedGroupBox.Enabled = true;
            speedTextBox.Text = ((ISpeed)toy).Speed.ToString();
        }

        private void SetHeightGroupFieldContent(Toy toy)
        {
            if ((toy is IHeight) == false)
            {
                DisableGroupBoxContents(heightGroupBox);
                return;
            }
            heightGroupBox.Enabled = true;
            heightTextBox.Text = ((IHeight)toy).Height.ToString();
        }

        private void SetDepthGroupFieldContent(Toy toy)
        {
            if ((toy is IDepth) == false)
            {
                DisableGroupBoxContents(depthGroupBox);
                return;
            }
            depthGroupBox.Enabled = true;
            depthTextBox.Text = ((IDepth)toy).Depth.ToString();
        }

        private void DisableGroupBoxContents(GroupBox groupBox)
        {
            foreach (Control controlElement in groupBox.Controls)
            {
                if (controlElement is TextBox)
                {
                    ((TextBox)controlElement).Text = "";
                }
            }
            groupBox.Enabled = false;
        }

    }
}
