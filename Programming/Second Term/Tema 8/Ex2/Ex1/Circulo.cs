﻿using Ex2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class AddCircle : Form
    {
        List<Shape> figures;
        public AddCircle(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void AddCircleBtn_Click(object sender, EventArgs e)
        {
            int x, y, radius;
            string color;

            
            x = int.Parse(txtPositionX.Text);
            y = int.Parse(txtPositionY.Text);
            radius = int.Parse(txtRadius.Text);
            color = txtColor.Text;

            if (radius > 0)
            {
                if (color != "")
                {
                    Circle circle = new Circle(x, y, color, radius);
                    figures.Add(circle);
                    ClearTxts();
                    MessageBox.Show("Circle added!");
                }
                    
            } else
            {
                MessageBox.Show("El radio no puede ser negativo.");
            }
            
        }
        public void ClearTxts()
        {
            txtColor.Text = string.Empty;
            txtPositionX.Text = string.Empty;
            txtPositionY.Text = string.Empty;
            txtRadius.Text = string.Empty;
        }
    }
}
