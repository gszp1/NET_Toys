﻿using System;
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

        enum UpdateType
        {
            Increase,
            Decrease
        }

        private string[] availableToys = { "Car", "Plane", "Submarine", "Computer" };

        public Form1()
        {
            InitializeComponent();
            foreach (string toy in availableToys)
            {
                availableToysList.Items.Add(toy);
            }
            SetGroupBoxes(null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddToy(availableToysList.SelectedItem.ToString());
        }

        private void AddToy(string toyName)
        {
            switch (toyName)
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            toysList.Items.Remove(toysList.SelectedItem);
        }

        private void ToysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGroupBoxes((Toy)toysList.SelectedItem);
        }

        private void SetGroupBoxes(Toy selectedToy)
        {
            SetSpeedGroupFieldContent(selectedToy);
            SetHeightGroupFieldContent(selectedToy);
            SetDepthGroupFieldContent(selectedToy);
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

        private void SpeedDecreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToySpeed((Toy)toysList.SelectedItem, UpdateType.Decrease);
        }

        private void SpeedIncreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToySpeed((Toy)toysList.SelectedItem, UpdateType.Increase);
        }

        private void DepthDecreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToyDepth((Toy)toysList.SelectedItem, UpdateType.Decrease);
        }

        private void DepthIncreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToyDepth((Toy)toysList.SelectedItem, UpdateType.Increase);
        }

        private void HeightDecreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToyHeight((Toy)toysList.SelectedItem, UpdateType.Decrease);
        }

        private void HeightIncreaseButton_Click(object sender, EventArgs e)
        {
            UpdateToyHeight((Toy)toysList.SelectedItem, UpdateType.Increase);
        }

        private void UpdateToySpeed(Toy toy, UpdateType type)
        {
            if ((toy is ISpeed) == false)
            {
                return;
            }
            ISpeed selectedToy = (ISpeed)toy;
            switch (type)
            {
                case UpdateType.Increase:
                    selectedToy.IncreaseSpeed();
                    break;
                case UpdateType.Decrease:
                    selectedToy.DecreaseSpeed();
                    break;
                default:
                    return;
            }
            speedTextBox.Text = selectedToy.Speed.ToString();
        }

        private void UpdateToyDepth(Toy toy, UpdateType type)
        {
            if ((toysList.SelectedItem is IDepth) == false)
            {
                return;
            }
            IDepth selectedToy = (IDepth)toysList.SelectedItem;
            switch (type)
            {
                case UpdateType.Increase:
                    selectedToy.IncreaseDepth();
                    break;
                case UpdateType.Decrease:
                    selectedToy.DecreaseDepth();
                    break;
                default:
                    return;
            }
            depthTextBox.Text = selectedToy.Depth.ToString();
        }

        private void UpdateToyHeight(Toy toy, UpdateType type)
        {
            if ((toysList.SelectedItem is IHeight) == false)
            {
                return;
            }
            IHeight selectedToy = (IHeight)toysList.SelectedItem;
            switch (type)
            {
                case UpdateType.Increase:
                    selectedToy.IncreaseHeight();
                    break;
                case UpdateType.Decrease:
                    selectedToy.DecreaseHeight();
                    break;
                default:
                    return;
            }
            heightTextBox.Text = selectedToy.Height.ToString();
        }
    }
}
