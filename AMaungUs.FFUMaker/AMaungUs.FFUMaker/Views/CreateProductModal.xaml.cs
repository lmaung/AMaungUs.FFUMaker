﻿using AMaungUs.FFUMaker.ViewModels;
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
using System.Windows.Shapes;

namespace AMaungUs.FFUMaker.Views
{
    /// <summary>
    /// Interaction logic for CreateProductModal.xaml
    /// </summary>
    public partial class CreateProductModal
    {
        public CreateProductModal()
        {
            InitializeComponent();
            ((CreateProductViewModel)this.DataContext).Create += CreateWorkspaceModal_Create;
        }

        private void CreateWorkspaceModal_Create(object sender, EventArgs e)
        {
            DialogResult = true;
        }
    }
}
