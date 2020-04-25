using System;
using System.Windows;

namespace WPF_Frection
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


        private void buttonRandom_Click(object sender, RoutedEventArgs e)
        {
            Drob[] drobs = new Drob[4];
            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                drobs[i] = new Drob(random.Next(1, (i + 3) * 4), random.Next(1, (i + 1) * 5));
                Drob.Down(drobs[i]);
            }

            textBoxFirstNum.Text = drobs[0].Num.ToString();
            textBoxFirstDenom.Text = drobs[0].Denom.ToString();

            textBoxSecondNum.Text = drobs[1].Num.ToString();
            textBoxSecondDenom.Text = drobs[1].Denom.ToString();

            textBoxThirdNum.Text = drobs[2].Num.ToString();
            textBoxThirdDenom.Text = drobs[2].Denom.ToString();

            textBoxFourthNum.Text = drobs[3].Num.ToString();
            textBoxFourthDenom.Text = drobs[3].Denom.ToString();

            labelResultFirst.FontSize = 16;
            labelResultFirst.Text = "Дробь№1\n" + drobs[0].ToString();
            labelResultSecond.FontSize = 16;
            labelResultSecond.Text = "Дробь№2\n" + drobs[1].ToString();
            labelResultThird.FontSize = 16;
            labelResultThird.Text = "Дробь№3\n" + drobs[2].ToString();
            labelResultFourth.FontSize = 16;
            labelResultFourth.Text = "Дробь№4\n" + drobs[3].ToString();
        }

        private void result1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Drob drob1 = new Drob(double.Parse(textBoxFirstNum.Text), double.Parse(textBoxFirstDenom.Text));
                Drob drob2 = new Drob(double.Parse(textBoxSecondNum.Text), double.Parse(textBoxSecondDenom.Text));
                Drob drob3 = new Drob(double.Parse(textBoxThirdNum.Text), double.Parse(textBoxThirdDenom.Text));
                Drob drob4 = new Drob(double.Parse(textBoxFourthNum.Text), double.Parse(textBoxFourthDenom.Text));

                Drob result = (drob1 + drob2) * (drob3 - drob4);
                textBlockResul.Text = Drob.Down(result).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void result2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Drob drob1 = new Drob(double.Parse(textBoxFirstNum.Text), double.Parse(textBoxFirstDenom.Text));
                Drob drob2 = new Drob(double.Parse(textBoxSecondNum.Text), double.Parse(textBoxSecondDenom.Text));
                Drob drob3 = new Drob(double.Parse(textBoxThirdNum.Text), double.Parse(textBoxThirdDenom.Text));
                Drob drob4 = new Drob(double.Parse(textBoxFourthNum.Text), double.Parse(textBoxFourthDenom.Text));

                Drob result = (drob4 + drob2) / (drob1 - drob3);
                textBlockResul.Text = Drob.Down(result).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void result3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Drob[] drobs = new Drob[4]
                {
            new Drob(double.Parse(textBoxFirstNum.Text), double.Parse(textBoxFirstDenom.Text)),
            new Drob(double.Parse(textBoxSecondNum.Text), double.Parse(textBoxSecondDenom.Text)),
            new Drob(double.Parse(textBoxThirdNum.Text), double.Parse(textBoxThirdDenom.Text)),
            new Drob(double.Parse(textBoxFourthNum.Text), double.Parse(textBoxFourthDenom.Text))
                };
                for (int i = 0; i < drobs.Length; i++)
                {
                    for (int j = i + 1; j < drobs.Length; j++)
                    {
                        if (drobs[j] < drobs[i])
                        {
                            Drob temp = drobs[j];
                            drobs[j] = drobs[i];
                            drobs[i] = temp;
                        }
                    }
                }
                textBlockResul.FontSize = 15;
                textBlockResul.Text = drobs[0].ToString() + "<" +
                    drobs[1].ToString() + "<" +
                    drobs[2].ToString() + "<" +
                    drobs[3].ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void own_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Drob drob1 = new Drob(double.Parse(textBoxFirstNum.Text), double.Parse(textBoxFirstDenom.Text));
                Drob drob2 = new Drob(double.Parse(textBoxSecondNum.Text), double.Parse(textBoxSecondDenom.Text));
                Drob drob3 = new Drob(double.Parse(textBoxThirdNum.Text), double.Parse(textBoxThirdDenom.Text));
                Drob drob4 = new Drob(double.Parse(textBoxFourthNum.Text), double.Parse(textBoxFourthDenom.Text));

                labelResultFirst.FontSize = 16;
                labelResultFirst.Text = "Дробь№1\n" + drob1.ToString();
                labelResultSecond.FontSize = 16;
                labelResultSecond.Text = "Дробь№2\n" + drob2.ToString();
                labelResultThird.FontSize = 16;
                labelResultThird.Text = "Дробь№3\n" + drob3.ToString();
                labelResultFourth.FontSize = 16;
                labelResultFourth.Text = "Дробь№4\n" + drob4.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
