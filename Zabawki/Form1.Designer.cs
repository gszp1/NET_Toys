﻿namespace Zabawki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.availableToysList = new System.Windows.Forms.ListBox();
            this.toysList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.speedIncreaseButton = new System.Windows.Forms.Button();
            this.speedDecreaseButton = new System.Windows.Forms.Button();
            this.speedGroupField = new System.Windows.Forms.GroupBox();
            this.heightGroupField = new System.Windows.Forms.GroupBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightIncreaseButton = new System.Windows.Forms.Button();
            this.heightDecreaseButton = new System.Windows.Forms.Button();
            this.depthGroupField = new System.Windows.Forms.GroupBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.depthIncreaseButton = new System.Windows.Forms.Button();
            this.depthDecreaseButton = new System.Windows.Forms.Button();
            this.speedGroupField.SuspendLayout();
            this.heightGroupField.SuspendLayout();
            this.depthGroupField.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableToysList
            // 
            this.availableToysList.FormattingEnabled = true;
            this.availableToysList.Location = new System.Drawing.Point(12, 133);
            this.availableToysList.Name = "availableToysList";
            this.availableToysList.Size = new System.Drawing.Size(117, 173);
            this.availableToysList.TabIndex = 0;
            // 
            // toysList
            // 
            this.toysList.FormattingEnabled = true;
            this.toysList.Location = new System.Drawing.Point(268, 133);
            this.toysList.Name = "toysList";
            this.toysList.Size = new System.Drawing.Size(118, 173);
            this.toysList.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(144, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(144, 219);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(105, 31);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(78, 19);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 4;
            // 
            // speedIncreaseButton
            // 
            this.speedIncreaseButton.Location = new System.Drawing.Point(184, 19);
            this.speedIncreaseButton.Name = "speedIncreaseButton";
            this.speedIncreaseButton.Size = new System.Drawing.Size(58, 21);
            this.speedIncreaseButton.TabIndex = 5;
            this.speedIncreaseButton.Text = "+";
            this.speedIncreaseButton.UseVisualStyleBackColor = true;
            // 
            // speedDecreaseButton
            // 
            this.speedDecreaseButton.Location = new System.Drawing.Point(14, 19);
            this.speedDecreaseButton.Name = "speedDecreaseButton";
            this.speedDecreaseButton.Size = new System.Drawing.Size(58, 21);
            this.speedDecreaseButton.TabIndex = 6;
            this.speedDecreaseButton.Text = "-";
            this.speedDecreaseButton.UseVisualStyleBackColor = true;
            // 
            // speedGroupField
            // 
            this.speedGroupField.Controls.Add(this.speedTextBox);
            this.speedGroupField.Controls.Add(this.speedIncreaseButton);
            this.speedGroupField.Controls.Add(this.speedDecreaseButton);
            this.speedGroupField.Location = new System.Drawing.Point(452, 112);
            this.speedGroupField.Name = "speedGroupField";
            this.speedGroupField.Size = new System.Drawing.Size(270, 52);
            this.speedGroupField.TabIndex = 13;
            this.speedGroupField.TabStop = false;
            this.speedGroupField.Text = "Speed";
            // 
            // heightGroupField
            // 
            this.heightGroupField.Controls.Add(this.heightTextBox);
            this.heightGroupField.Controls.Add(this.heightIncreaseButton);
            this.heightGroupField.Controls.Add(this.heightDecreaseButton);
            this.heightGroupField.Location = new System.Drawing.Point(452, 265);
            this.heightGroupField.Name = "heightGroupField";
            this.heightGroupField.Size = new System.Drawing.Size(270, 52);
            this.heightGroupField.TabIndex = 14;
            this.heightGroupField.TabStop = false;
            this.heightGroupField.Text = "Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(78, 19);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // heightIncreaseButton
            // 
            this.heightIncreaseButton.Location = new System.Drawing.Point(184, 19);
            this.heightIncreaseButton.Name = "heightIncreaseButton";
            this.heightIncreaseButton.Size = new System.Drawing.Size(58, 21);
            this.heightIncreaseButton.TabIndex = 5;
            this.heightIncreaseButton.Text = "+";
            this.heightIncreaseButton.UseVisualStyleBackColor = true;
            // 
            // heightDecreaseButton
            // 
            this.heightDecreaseButton.Location = new System.Drawing.Point(14, 19);
            this.heightDecreaseButton.Name = "heightDecreaseButton";
            this.heightDecreaseButton.Size = new System.Drawing.Size(58, 21);
            this.heightDecreaseButton.TabIndex = 6;
            this.heightDecreaseButton.Text = "-";
            this.heightDecreaseButton.UseVisualStyleBackColor = true;
            // 
            // depthGroupField
            // 
            this.depthGroupField.Controls.Add(this.depthTextBox);
            this.depthGroupField.Controls.Add(this.depthIncreaseButton);
            this.depthGroupField.Controls.Add(this.depthDecreaseButton);
            this.depthGroupField.Location = new System.Drawing.Point(452, 186);
            this.depthGroupField.Name = "depthGroupField";
            this.depthGroupField.Size = new System.Drawing.Size(270, 52);
            this.depthGroupField.TabIndex = 15;
            this.depthGroupField.TabStop = false;
            this.depthGroupField.Text = "Depth";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(78, 19);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.ReadOnly = true;
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 4;
            // 
            // depthIncreaseButton
            // 
            this.depthIncreaseButton.Location = new System.Drawing.Point(184, 19);
            this.depthIncreaseButton.Name = "depthIncreaseButton";
            this.depthIncreaseButton.Size = new System.Drawing.Size(58, 21);
            this.depthIncreaseButton.TabIndex = 5;
            this.depthIncreaseButton.Text = "+";
            this.depthIncreaseButton.UseVisualStyleBackColor = true;
            // 
            // depthDecreaseButton
            // 
            this.depthDecreaseButton.Location = new System.Drawing.Point(14, 19);
            this.depthDecreaseButton.Name = "depthDecreaseButton";
            this.depthDecreaseButton.Size = new System.Drawing.Size(58, 21);
            this.depthDecreaseButton.TabIndex = 6;
            this.depthDecreaseButton.Text = "-";
            this.depthDecreaseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 482);
            this.Controls.Add(this.depthGroupField);
            this.Controls.Add(this.heightGroupField);
            this.Controls.Add(this.speedGroupField);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toysList);
            this.Controls.Add(this.availableToysList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.speedGroupField.ResumeLayout(false);
            this.speedGroupField.PerformLayout();
            this.heightGroupField.ResumeLayout(false);
            this.heightGroupField.PerformLayout();
            this.depthGroupField.ResumeLayout(false);
            this.depthGroupField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox availableToysList;
        private System.Windows.Forms.ListBox toysList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button speedIncreaseButton;
        private System.Windows.Forms.Button speedDecreaseButton;
        private System.Windows.Forms.GroupBox speedGroupField;
        private System.Windows.Forms.GroupBox heightGroupField;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button heightIncreaseButton;
        private System.Windows.Forms.Button heightDecreaseButton;
        private System.Windows.Forms.GroupBox depthGroupField;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Button depthIncreaseButton;
        private System.Windows.Forms.Button depthDecreaseButton;
    }
}

