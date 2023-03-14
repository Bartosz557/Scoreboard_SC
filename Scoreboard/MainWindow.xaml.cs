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
using System.IO;
using System.Windows.Shapes;
using System.Diagnostics.Metrics;

namespace Scoreboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int homepts;
        int homesets;
        int home2ndpts;
        int homescore;
        int awaypts;
        int awaysets;
        int away2ndpts;
        int away2ndsets;
        int home2ndsets;
        int awayscore;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemPeriod)
            {
                int.TryParse(homept.Text, out homepts);
                homepts++;
                homept.Text = homepts.ToString();
                using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                    sw.WriteLine(homepts.ToString());
            }
            else if (e.Key == Key.OemOpenBrackets)
            {
                int.TryParse(homept.Text, out homepts);
                homepts--;
                homept.Text = homepts.ToString();
                using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                    sw.WriteLine(homepts.ToString());
            }
            else if (e.Key == Key.OemQuestion)
            {
                int.TryParse(awaypt.Text, out awaypts);
                awaypts++;
                awaypt.Text = awaypts.ToString();
                using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                    sw.WriteLine(awaypts.ToString());
            }
            else if (e.Key == Key.OemCloseBrackets)
            {
                int.TryParse(awaypt.Text, out awaypts);
                awaypts--;
                awaypt.Text = awaypts.ToString();
                using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                    sw.WriteLine(awaypts.ToString());
            }


            if (e.Key == Key.OemSemicolon)
            {
                int.TryParse(ndhomepts.Text, out home2ndpts);
                home2ndpts++;
                ndhomepts.Text = home2ndpts.ToString();
                using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                    sw.WriteLine(home2ndpts.ToString());
            }
            else if (e.Key == Key.OemMinus)
            {
                int.TryParse(ndhomepts.Text, out home2ndpts);
                home2ndpts--;
                ndhomepts.Text = home2ndpts.ToString();
                using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                    sw.WriteLine(home2ndpts.ToString());
            }
            else if (e.Key == Key.OemQuotes)
            {
                int.TryParse(ndawaypts.Text, out away2ndpts);
                away2ndpts++;
                ndawaypts.Text = away2ndpts.ToString();
                using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                    sw.WriteLine(away2ndpts.ToString());
            }
            else if (e.Key == Key.OemPlus)
            {
                int.TryParse(ndawaypts.Text, out away2ndpts);
                away2ndpts--;
                ndawaypts.Text = away2ndpts.ToString();
                using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                    sw.WriteLine(away2ndpts.ToString());
            }
        }


        //gospodarze
        private void Haddpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(homept.Text, out homepts);
            homepts++;
            homept.Text = homepts.ToString();
            using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                sw.WriteLine(homepts.ToString());
        }
        private void Hminuspts(object sender, RoutedEventArgs e)
        {
            int.TryParse(homept.Text, out homepts);
            homepts--;
            homept.Text = homepts.ToString();
            using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                sw.WriteLine(homepts.ToString());
        }
        private void Haddsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(homeset.Text, out homesets);
            homesets++;
            homeset.Text = homesets.ToString();
            using (StreamWriter sw = new StreamWriter("homesets.txt"))
                sw.WriteLine(homesets.ToString());
        }
        private void Hminussets(object sender, RoutedEventArgs e)
        {
            int.TryParse(homeset.Text, out homesets);
            homesets--;
            homeset.Text = homesets.ToString();
            using (StreamWriter sw = new StreamWriter("homesets.txt"))
                sw.WriteLine(homesets.ToString());
        }
        //goscie
        private void Aaddpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(awaypt.Text, out awaypts);
            awaypts++;
            awaypt.Text = awaypts.ToString();
            using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                sw.WriteLine(awaypts.ToString());
        }
        private void Aminuspts(object sender, RoutedEventArgs e)
        {
            int.TryParse(awaypt.Text, out awaypts);
            awaypts--;
            awaypt.Text = awaypts.ToString();
            using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                sw.WriteLine(awaypts.ToString());
        }
        private void Adeletepts(object sender, RoutedEventArgs e)
        {
            homepts = 0;
            homept.Text = "0";
            using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                sw.WriteLine(homepts.ToString());
            awaypts = 0;
            awaypt.Text = "0";
            using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                sw.WriteLine(awaypts.ToString());
        }
        private void Aaddsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(awayset.Text, out awaysets);
            awaysets++;
            awayset.Text = awaysets.ToString();
            using (StreamWriter sw = new StreamWriter("awaysets.txt"))
                sw.WriteLine(awaysets.ToString());
        }
        private void Aminussets(object sender, RoutedEventArgs e)
        {
            int.TryParse(awayset.Text, out awaysets);
            awaysets--;
            awayset.Text = awaysets.ToString();
            using (StreamWriter sw = new StreamWriter("awaysets.txt"))
                sw.WriteLine(awaysets.ToString());
        }

        private void Adeletesets(object sender, RoutedEventArgs e)
        {
            homesets = 0;
            homeset.Text = "0";
            using (StreamWriter sw = new StreamWriter("homesets.txt"))
                sw.WriteLine(homesets.ToString());
            awaysets = 0;
            awayset.Text = "0";
            using (StreamWriter sw = new StreamWriter("awaysets.txt"))
                sw.WriteLine(awaysets.ToString());
        }
        // drugi stol
        private void Addhomendpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndhomepts.Text, out home2ndpts);
            home2ndpts++;
            ndhomepts.Text = home2ndpts.ToString();
            using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                sw.WriteLine(home2ndpts.ToString());
        }
        private void Minhomendpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndhomepts.Text, out home2ndpts);
            home2ndpts--;
            ndhomepts.Text = home2ndpts.ToString();
            using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                sw.WriteLine(home2ndpts.ToString());
        }
        private void Addawayndpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndawaypts.Text, out away2ndpts);
            away2ndpts++;
            ndawaypts.Text = away2ndpts.ToString();
            using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                sw.WriteLine(away2ndpts.ToString());
        }
        private void Minawayndpts(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndawaypts.Text, out away2ndpts);
            away2ndpts--;
            ndawaypts.Text = away2ndpts.ToString();
            using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                sw.WriteLine(away2ndpts.ToString());
        }
        private void Delawayndpts(object sender, RoutedEventArgs e)
        {
            home2ndpts = 0;
            ndhomepts.Text = "0";
            using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                sw.WriteLine(home2ndpts.ToString());
            away2ndpts = 0;
            ndawaypts.Text = "0";
            using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                sw.WriteLine(away2ndpts.ToString());
        }

        private void Addhomendsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndhomeset.Text, out home2ndsets);
            home2ndsets++;
            ndhomeset.Text = home2ndsets.ToString();
            using (StreamWriter sw = new StreamWriter("2ndhomesets.txt"))
                sw.WriteLine(home2ndsets.ToString());
        }
        private void Minhomendsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndhomeset.Text, out home2ndsets);
            home2ndsets--;
            ndhomeset.Text = home2ndsets.ToString();
            using (StreamWriter sw = new StreamWriter("2ndhomesets.txt"))
                sw.WriteLine(home2ndsets.ToString());
        }
        private void Addawayndsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndawayset.Text, out away2ndsets);
            away2ndsets++;
            ndawayset.Text = away2ndsets.ToString();
            using (StreamWriter sw = new StreamWriter("2ndawaysets.txt"))
                sw.WriteLine(away2ndsets.ToString());
        }
        private void Minawayndsets(object sender, RoutedEventArgs e)
        {
            int.TryParse(ndawayset.Text, out away2ndsets);
            away2ndsets--;
            ndawayset.Text = away2ndsets.ToString();
            using (StreamWriter sw = new StreamWriter("2ndawaysets.txt"))
                sw.WriteLine(away2ndsets.ToString());
        }
        private void Delawayndsets(object sender, RoutedEventArgs e)
        {
            home2ndpts = 0;
            ndhomeset.Text = "0";
            using (StreamWriter sw = new StreamWriter("2ndhomesets.txt"))
                sw.WriteLine(home2ndpts.ToString());
            away2ndpts = 0;
            ndawayset.Text = "0";
            using (StreamWriter sw = new StreamWriter("2ndawaysets.txt"))
                sw.WriteLine(away2ndpts.ToString());
        }
        //wynik meczu
        private void Addhomescore(object sender, RoutedEventArgs e)
        {
            int.TryParse(homescored.Text, out homescore);
            homescore++;
            homescored.Text = homescore.ToString();
            using (StreamWriter sw = new StreamWriter("homescore.txt"))
                sw.WriteLine(homescore.ToString());
        }
        private void Minhomescore(object sender, RoutedEventArgs e)
        {
            int.TryParse(homescored.Text, out homescore);
            homescore--;
            homescored.Text = homescore.ToString();
            using (StreamWriter sw = new StreamWriter("homescore.txt"))
                sw.WriteLine(homescore.ToString());
        }
        private void Addawayscore(object sender, RoutedEventArgs e)
        {
            int.TryParse(awayscored.Text, out awayscore);
            awayscore++;
            awayscored.Text = awayscore.ToString();
            using (StreamWriter sw = new StreamWriter("awayscore.txt"))
                sw.WriteLine(awayscore.ToString());
        }
        private void Minawayscore(object sender, RoutedEventArgs e)
        {
            int.TryParse(awayscored.Text, out awayscore);
            awayscore--;
            awayscored.Text = awayscore.ToString();
            using (StreamWriter sw = new StreamWriter("awayscore.txt"))
                sw.WriteLine(awayscore.ToString());
        }
        private void Delscore(object sender, RoutedEventArgs e)
        {
            awayscore = 0;
            homescore = 0;
            homescored.Text = "0";
            awayscored.Text = "0";
            awayclub.Text = "";
            string a = "";
            using (StreamWriter sw = new StreamWriter("homescore.txt"))
                sw.WriteLine(homescore.ToString());
            using (StreamWriter sw = new StreamWriter("awayscore.txt"))
                sw.WriteLine(awayscore.ToString());
            using (StreamWriter sw = new StreamWriter("awayclub.txt"))
                sw.WriteLine(a.ToString());
        }

        private void Scoresave(object sender, RoutedEventArgs e)
        {
            string a;
            //score
            a = homescored.Text;
            using (StreamWriter sw = new StreamWriter("homescore.txt"))
                sw.WriteLine(a.ToString());

            a = awayscored.Text;
            using (StreamWriter sw = new StreamWriter("awayscore.txt"))
                sw.WriteLine(a.ToString());

            //pierwszy stol
            a = homept.Text;
            using (StreamWriter sw = new StreamWriter("homepoints.txt"))
                sw.WriteLine(a.ToString());

            a = homeset.Text;
            using (StreamWriter sw = new StreamWriter("homesets.txt"))
                sw.WriteLine(a.ToString());

            a = awaypt.Text;
            using (StreamWriter sw = new StreamWriter("awaypoints.txt"))
                sw.WriteLine(a.ToString());

            a = awayset.Text;
            using (StreamWriter sw = new StreamWriter("awaysets.txt"))
                sw.WriteLine(a.ToString());

            // drugi stol
            a = ndawaypts.Text;
            using (StreamWriter sw = new StreamWriter("2ndawaypoints.txt"))
                sw.WriteLine(a.ToString());

            a = ndhomepts.Text;
            using (StreamWriter sw = new StreamWriter("2ndhomepoints.txt"))
                sw.WriteLine(a.ToString());

            a = ndhomeset.Text;
            using (StreamWriter sw = new StreamWriter("2ndhomesets.txt"))
                sw.WriteLine(a.ToString());

            a = ndawayset.Text;
            using (StreamWriter sw = new StreamWriter("2ndawaysets.txt"))
                sw.WriteLine(a.ToString());

            // nazwy
            a = homenames.Text;
            using (StreamWriter sw = new StreamWriter("homename.txt"))
                sw.WriteLine(a.ToString());

            a = awaynames.Text;
            using (StreamWriter sw = new StreamWriter("awayname.txt"))
                sw.WriteLine(a.ToString());

            a = ndhomenames.Text;
            using (StreamWriter sw = new StreamWriter("2ndhomename.txt"))
                sw.WriteLine(a.ToString());

            a = ndawaynames.Text;
            using (StreamWriter sw = new StreamWriter("2ndawayname.txt"))
                sw.WriteLine(a.ToString());

            a = awayclub.Text;
            using (StreamWriter sw = new StreamWriter("awayclub.txt"))
                sw.WriteLine(a.ToString());

            a = homeclub.Text;
            using (StreamWriter sw = new StreamWriter("homeclub.txt"))
                sw.WriteLine(a.ToString());

        }

        private void Delndnames(object sender, RoutedEventArgs e)
        {
            string a = "";
            using (StreamWriter sw = new StreamWriter("homename.txt"))
                sw.WriteLine(a.ToString());
            homenames.Text = "";
            using (StreamWriter sw = new StreamWriter("awayname.txt"))
                sw.WriteLine(a.ToString());
            awaynames.Text = "";
            
        }

        private void Delnames(object sender, RoutedEventArgs e)
        {
            string a = "";
            using (StreamWriter sw = new StreamWriter("2ndhomename.txt"))
                sw.WriteLine(a.ToString());
            ndhomenames.Text="";
            using (StreamWriter sw = new StreamWriter("2ndawayname.txt"))
                sw.WriteLine(a.ToString());
            ndawaynames.Text="";
        }

    }
}
