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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace encapsulationExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bankAccount b = new bankAccount("123456");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            double amount;
            double.TryParse(txtDollarAmount.Text, out amount);
            if ((bool)rbDeposit.IsChecked)
            {
                if (b.Deposit(amount, txtPassword.Password))
                {
                    lblOutput.Content = b.ToString();
                }
                else
                {
                    lblOutput.Content = "Deposit did not go through.  Balance is: " + b.ToString();
                }
            }
            else if ((bool)rbWithdraw.IsChecked)
            {
                if (b.Withdrawal(amount, txtPassword.Password))
                {
                    lblOutput.Content = b.ToString();
                }
                else
                {
                    lblOutput.Content = "Withdrawal did not go through.  Balance is: " + b.ToString();
                }
            }
        }
    }
}
