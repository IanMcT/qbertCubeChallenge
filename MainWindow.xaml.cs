/*Ian McTavish
 * April 24
 * Practice techniques for qBert video game
 */
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

namespace u4qbertPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variables - available in all methods
        int[,] cubes = new int[7,13];

        public MainWindow()
        {
            InitializeComponent();
            for (int x = 0; x < cubes.GetLength(0); x++)
            {
                for (int y = 0; y < cubes.GetLength(1); y++)
                {
                    cubes[x, y] = 0;
                }
            }
            //MessageBox.Show(cubes.GetLength(0).ToString());
            //loop through each row
            for (int x = 0; x < cubes.GetLength(0); x++)
            {
                int numberOfCubes = x + 1;
                int midPoint = cubes.GetLength(1) / 2;
                int offset = 1;
                if (numberOfCubes % 2 == 1)
                {
                    cubes[x, midPoint] = 1;
                    offset = 2;
                }
                for (int i = 0; i < numberOfCubes/2; i++)
                {
                    cubes[x, midPoint - offset] = 1;
                    cubes[x, midPoint + offset] = 1;
                    offset += 2;
                }

            }


            string output = "";

            for (int x = 0; x < cubes.GetLength(0); x++)
                {
                for (int y = 0; y < cubes.GetLength(1); y++)
                {
                    Console.Write(cubes[x, y]);
                    output += cubes[x, y].ToString();
                }
                Console.WriteLine();
                output += Environment.NewLine;
            }
            MessageBox.Show(output);
            Clipboard.SetText(output);
            /*
            MessageBox.Show("Total: " + total.ToString());
            average = total / myMarks.Length;
            MessageBox.Show("Average: " + average.ToString());
            */
        }
    }
}
