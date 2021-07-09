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

namespace wechat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sendbtn_Click(object sender, RoutedEventArgs e)
        {
            if(messtxtb.Text != null)
            {
                Label label = new Label();
                Label label2 = new Label();
              
            //    Label label2 = new Label();
              //  Label[] labels = { label, label2 };
                //foreach (var item in labels)
                //{
                  //  if(item.Content == null)
                    //{
                        label.Content = messtxtb.Text ;
               label2 .Content = AnswersAndQuestiond.Answers(messtxtb.Text);
                //}
                //     }
                list.Items.Add(label.Content);
                list2.Items.Add(label2.Content);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window.Close();
        }

        private void list2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void list2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
