﻿using System;
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

namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Lógica interna para Relatorio_vendedor_valor.xaml
    /// </summary>
    public partial class Relatorio_vendedor_valor : Window
    {
        public Relatorio_vendedor_valor()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void tela_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Btn_mes_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_destaque_mes Relatorio_destaque_mes = new Relatorio_destaque_mes();
            Relatorio_destaque_mes.Show();
        }

        private void Btnvendedor_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_vendedor_produto Relatorio_vendedor_produto = new Relatorio_vendedor_produto();
            Relatorio_vendedor_produto.Show();
        }

        private void BtnValor_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        
    }
}
