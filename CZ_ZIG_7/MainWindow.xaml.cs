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

using GameEngine;

namespace CZ_ZIG_7
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GalacticBusinessGame game;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisableAllControls()
        {
            Label_0_1_2.Content = "- KG";
            ComboBox_0_1_0.IsEnabled = false;
            ComboBox_0_1_0.Items.Clear();
            ComboBox_0_1_1.IsEnabled = false;
            ComboBox_0_1_1.Items.Clear();
            Label_0_1_4.Content = "- KG";
            ComboBox_0_1_2.IsEnabled = false;
            ComboBox_0_1_2.Items.Clear();
            ComboBox_0_1_3.IsEnabled = false;
            ComboBox_0_1_3.Items.Clear();

            Label_0_2_1.Content = "-";
            Button_0_2_0.IsEnabled = false;

            Label_1_0_1.Content = "-";

            Label_1_1_0.Content = "-";
            Label_1_1_1.Content = "-";
            Label_1_1_1.Visibility = Visibility.Hidden;
            Button_1_1_0.Content = "-";
            Button_1_1_0.IsEnabled = false;
            Button_1_1_0.Visibility = Visibility.Hidden;
            ComboBox_1_1_0.Items.Clear();
            ComboBox_1_1_0.IsEnabled = false;
            ComboBox_1_1_0.Visibility = Visibility.Hidden;
            Label_1_1_2.Content = "-";
            Label_1_1_2.Visibility = Visibility.Hidden;
            Button_1_1_1.Content = "-";
            Button_1_1_1.IsEnabled = false;
            Button_1_1_1.Visibility = Visibility.Hidden;
            ComboBox_1_1_1.Items.Clear();
            ComboBox_1_1_1.IsEnabled = false;
            ComboBox_1_1_1.Visibility = Visibility.Hidden;
            Button_1_1_2.Content = "-";
            Button_1_1_2.IsEnabled = false;
            Button_1_1_2.Visibility = Visibility.Hidden;

            Label_1_2_1.Content = "-";

            Label_2_0_1.Content = "1. -";
            Label_2_0_2.Content = "2. -";

            Label_2_1_1.Visibility = Visibility.Hidden;
            Grid.SetColumn(Label_2_1_1, 0);
            Label_2_1_2.Visibility = Visibility.Hidden;
            Grid.SetColumn(Label_2_1_2, 0);

            Label_2_2_1.Content = "1. -";
            Label_2_2_2.Content = "2. -";
        }

        private bool CheckIfMoreThan1ButtonIsEnabled()
        {
            int i = 0;
            if (Button_0_0_0.IsEnabled)
            {
                i++;
            }
            if (Button_0_2_0.IsEnabled)
            {
                i++;
            }
            if (Button_1_1_0.IsEnabled)
            {
                i++;
            }
            if (Button_1_1_1.IsEnabled)
            {
                i++;
            }
            if (Button_1_1_2.IsEnabled)
            {
                i++;
            }
            if (i > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RefreshWindow()
        {
            DisableAllControls();
            foreach (Player player in game.Players)
            {
                if (game.CheckIfPlayerHasHalfPossibleWealth(player))
                {
                    player.Status = 1;
                }
                if (player.Status == -1)
                {
                    Label_1_2_1.Content = "Przegrana...";
                    Label_1_0_1.Content = player.Name;
                    Label_1_1_0.Content = "Koniec gry";
                    return;
                }
                if (player.Status == 1)
                {
                    Label_1_2_1.Content = "Zwycięstwo!";
                    Label_1_0_1.Content = player.Name;
                    Label_1_1_0.Content = "Koniec gry";
                    return;
                }
            }
            if (game.Players[0].Position != 0)
            {
                Label_2_1_1.Visibility = Visibility.Visible;
                Grid.SetColumn(Label_2_1_1, game.Players[0].Position - 1);
            }
            if (game.Players[1].Position != 0)
            {
                Label_2_1_2.Visibility = Visibility.Visible;
                Grid.SetColumn(Label_2_1_2, game.Players[1].Position - 1);
            }
            if (game.Players[game.CurrentPlayer].CanSkip() && game.Players[game.CurrentPlayer].RealPlayer)
            {
                Button_0_2_0.IsEnabled = true;
                if (game.Players[game.CurrentPlayer].Position == 8)
                {
                    Button_0_2_0.IsEnabled = false;
                }
            }
            else if (!game.Players[game.CurrentPlayer].RealPlayer)
            {
                Button_0_2_0.IsEnabled = true;
            }
            if (game.Players[game.CurrentPlayer].LastDiceResult1 > 0)
            {
                Label_2_2_1.Content = "1. " + game.Players[game.CurrentPlayer].LastDiceResult1.ToString();
            }
            if (game.Players[game.CurrentPlayer].LastDiceResult2 > 0 && game.Players[game.CurrentPlayer].LastDiceResult2 < 3)
            {
                Label_2_2_2.Content = "2. " + game.Players[game.CurrentPlayer].LastDiceResult2.ToString();
            }
            if (game.GameInfo != "")
            {
                Label_1_2_1.Content = game.GameInfo;
            }
            switch (game.Players[game.CurrentPlayer].Position)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Label_1_1_0.Content = "Układ Planetarny";
                    Button_1_1_0.Content = "Wybuduj";
                    Button_1_1_0.Visibility = Visibility.Visible;
                    ComboBox_1_1_0.Visibility = Visibility.Visible;
                    Button_1_1_1.Content = "Rozbuduj";
                    Button_1_1_1.Visibility = Visibility.Visible;
                    ComboBox_1_1_1.Visibility = Visibility.Visible;
                    Planet _planet;
                    switch (game.Players[game.CurrentPlayer].Position)
                    {
                        case 1:
                            _planet = game.Systems[0].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 3:
                            _planet = game.Systems[1].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 5:
                            _planet = game.Systems[2].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 7:
                            _planet = game.Systems[3].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        default:
                            _planet = game.Systems[4].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                    }
                    string o;
                    if (_planet.Owner == null)
                    {
                        o = "Nikt";
                    }
                    else
                    {
                        o = _planet.Owner.Name;
                    }
                    Label_1_1_1.Content = "Układ: " + _planet.Parent.Name + "    Planeta: " + _planet.Name + "    Należy do: " + o;
                    Label_1_1_1.Visibility = Visibility.Visible;
                    Button_1_1_2.Content = "Zapłać za postój (" + (25 + (_planet.CalculatePlanetWorth() * 0.1)).ToString() +" KG)";
                    Button_1_1_2.Visibility = Visibility.Visible;
                    Label_2_0_1.Content = "1. " + _planet.Parent.Planets[0].Name;
                    Label_2_0_2.Content = "2. " + _planet.Parent.Planets[1].Name;
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        if (_planet.Owner == null)
                        {
                            if (game.Players[game.CurrentPlayer].CanPay(50))
                            {
                                ComboBox_1_1_0.Items.Add("Port kosmiczny (50 KG)");
                                ComboBox_1_1_0.SelectedIndex = 0;
                                ComboBox_1_1_0.IsEnabled = true;
                                Button_1_1_0.IsEnabled = true;
                            }
                        }
                        else if (_planet.Owner == game.Players[game.CurrentPlayer])
                        {
                            if (!_planet.Pledged)
                            {
                                if (_planet.Residential == 0 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_0.Items.Add("Posterunek (100 KG)");
                                }
                                else if (_planet.Residential == 1 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Posterunek -> Habitat mieszkalny (100 KG)");
                                }
                                else if (_planet.Residential == 2 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Habitat mieszkalny -> Kolonia (100 KG)");
                                }
                                else if (_planet.Residential == 3 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Kolonia -> Hotel galaktyczny (100 KG)");
                                }
                                else if (_planet.Residential == 4 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    bool flg = true;
                                    foreach (Planet p in _planet.Parent.Planets)
                                    {
                                        if (p.Residential < 4)
                                        {
                                            flg = false;
                                        }
                                    }
                                    if (!_planet.Parent.CheckIfPlayerIsSystemOwner(game.Players[game.CurrentPlayer]))
                                    {
                                        flg = false;
                                    }
                                    if (flg)
                                    {
                                        ComboBox_1_1_1.Items.Add("Hotele galaktyczne -> Sieć hoteli planetarnych (100 KG)");
                                    }
                                }

                                if (_planet.Mine == 0 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_0.Items.Add("Kopalnia (200 KG)");
                                }
                                else if (_planet.Mine == 1 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_1.Items.Add("Kopalnia: poz. 1 -> poz. 2 (200 KG)");
                                }
                                else if (_planet.Mine == 2 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_1.Items.Add("Kopalnia: poz. 2 -> poz. 3 (200 KG)");
                                }

                                if (_planet.Farm == 0 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_0.Items.Add("Farma żywności (300 KG)");
                                }
                                else if (_planet.Farm == 1 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 1 -> poz. 2 (300 KG)");
                                }
                                else if (_planet.Farm == 2 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 2 -> poz. 3 (300 KG)");
                                }
                                else if (_planet.Farm == 3 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 3 -> poz. 4 (300 KG)");
                                }
                                else if (_planet.Farm == 4 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 4 -> poz. 5 (300 KG)");
                                }

                                if (_planet.AsteoridMine == 0 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    if (_planet.Parent.CheckIfPlayerIsSystemOwner(_planet.Owner))
                                    {
                                        ComboBox_1_1_0.Items.Add("Asteroidalna kopalnia (400 KG)");
                                    }
                                }
                                else if (_planet.AsteoridMine == 1 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 1 -> poz. 2 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 2 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 2 -> poz. 3 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 3 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 3 -> poz. 4 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 4 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 4 -> poz. 5 (400 KG)");
                                }

                                if (_planet.Shipyard == 0 && game.Players[game.CurrentPlayer].CanPay(500))
                                {
                                    if (_planet.Parent.CheckIfPlayerIsSystemOwner(_planet.Owner))
                                    {
                                        ComboBox_1_1_0.Items.Add("Stocznia galaktyczna (500 KG)");
                                    }
                                }

                                Button_1_1_0.IsEnabled = true;
                                Button_1_1_1.IsEnabled = true;
                                Button_1_1_2.Content = "Zastaw (" + ((int)(_planet.CalculatePlanetWorth()*0.5)).ToString() + " KG)";
                                Button_1_1_2.IsEnabled = true;
                                ComboBox_1_1_0.IsEnabled = true;
                                ComboBox_1_1_1.IsEnabled = true;

                                if (ComboBox_1_1_0.Items.Count == 0)
                                {
                                    ComboBox_1_1_0.Items.Add("(brak)");
                                    Button_1_1_0.IsEnabled = false;
                                }
                                if (ComboBox_1_1_1.Items.Count == 0)
                                {
                                    ComboBox_1_1_1.Items.Add("(brak)");
                                    Button_1_1_1.IsEnabled = false;
                                }
                                ComboBox_1_1_0.SelectedIndex = 0;
                                ComboBox_1_1_1.SelectedIndex = 0;
                            }
                            else
                            {
                                Button_1_1_2.Content = "Wykup (" + ((int)(_planet.CalculatePlanetWorth() * 0.5)).ToString() + " KG)";
                                Button_1_1_2.IsEnabled = true;
                            }
                        }
                        else
                        {
                            if (!_planet.Pledged)
                            {
                                Button_1_1_2.IsEnabled = true;
                                Button_0_2_0.IsEnabled = false;
                            }
                            else
                            {
                                Label_1_2_1.Content = "Planeta zastawiona!";
                                Button_0_2_0.IsEnabled = true;
                            }
                        }
                    }
                    else
                    {
                        if (_planet.Owner == null)
                        {
                            if (game.Players[game.CurrentPlayer].CanPay(50))
                            {
                                ComboBox_1_1_0.Items.Add("Port kosmiczny (50 KG)");
                            }
                            int x = game.RandomPlanetChoice(ComboBox_1_1_0.Items.Cast<string>().ToList());
                            switch (x)
                            {
                                case -1:
                                    Label_1_2_1.Content = "Pominięto!";
                                    break;
                                default:
                                    ComboBox_1_1_0.SelectedIndex = x;
                                    Button_1_1_0_Click(null, null);
                                    Label_1_2_1.Content = "Dokonano transakcji!";
                                    break;
                            }
                        }
                        else if (_planet.Owner == game.Players[game.CurrentPlayer])
                        {
                            if (!_planet.Pledged)
                            {
                                if (_planet.Residential == 0 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_0.Items.Add("Posterunek (100 KG)");
                                }
                                else if (_planet.Residential == 1 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Posterunek -> Habitat mieszkalny (100 KG)");
                                }
                                else if (_planet.Residential == 2 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Habitat mieszkalny -> Kolonia (100 KG)");
                                }
                                else if (_planet.Residential == 3 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    ComboBox_1_1_1.Items.Add("Kolonia -> Hotel galaktyczny (100 KG)");
                                }
                                else if (_planet.Residential == 4 && game.Players[game.CurrentPlayer].CanPay(100))
                                {
                                    bool flg = true;
                                    foreach (Planet p in _planet.Parent.Planets)
                                    {
                                        if (p.Residential < 4)
                                        {
                                            flg = false;
                                        }
                                    }
                                    if (!_planet.Parent.CheckIfPlayerIsSystemOwner(game.Players[game.CurrentPlayer]))
                                    {
                                        flg = false;
                                    }
                                    if (flg)
                                    {
                                        ComboBox_1_1_1.Items.Add("Hotele galaktyczne -> Sieć hoteli planetarnych (100 KG)");
                                    }
                                }

                                if (_planet.Mine == 0 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_0.Items.Add("Kopalnia (200 KG)");
                                }
                                else if (_planet.Mine == 1 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_1.Items.Add("Kopalnia: poz. 1 -> poz. 2 (200 KG)");
                                }
                                else if (_planet.Mine == 2 && game.Players[game.CurrentPlayer].CanPay(200))
                                {
                                    ComboBox_1_1_1.Items.Add("Kopalnia: poz. 2 -> poz. 3 (200 KG)");
                                }

                                if (_planet.Farm == 0 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_0.Items.Add("Farma żywności (300 KG)");
                                }
                                else if (_planet.Farm == 1 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 1 -> poz. 2 (300 KG)");
                                }
                                else if (_planet.Farm == 2 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 2 -> poz. 3 (300 KG)");
                                }
                                else if (_planet.Farm == 3 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 3 -> poz. 4 (300 KG)");
                                }
                                else if (_planet.Farm == 4 && game.Players[game.CurrentPlayer].CanPay(300))
                                {
                                    ComboBox_1_1_1.Items.Add("Farma żywności: poz. 4 -> poz. 5 (300 KG)");
                                }

                                if (_planet.AsteoridMine == 0 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    if (_planet.Parent.CheckIfPlayerIsSystemOwner(_planet.Owner))
                                    {
                                        ComboBox_1_1_0.Items.Add("Asteroidalna kopalnia (400 KG)");
                                    }
                                }
                                else if (_planet.AsteoridMine == 1 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 1 -> poz. 2 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 2 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 2 -> poz. 3 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 3 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 3 -> poz. 4 (400 KG)");
                                }
                                else if (_planet.AsteoridMine == 4 && game.Players[game.CurrentPlayer].CanPay(400))
                                {
                                    ComboBox_1_1_1.Items.Add("Asteroidalna kopalnia: poz. 4 -> poz. 5 (400 KG)");
                                }

                                if (_planet.Shipyard == 0 && game.Players[game.CurrentPlayer].CanPay(500))
                                {
                                    if (_planet.Parent.CheckIfPlayerIsSystemOwner(_planet.Owner))
                                    {
                                        ComboBox_1_1_0.Items.Add("Stocznia galaktyczna (500 KG)");
                                    }
                                }
                                Button_1_1_2.Content = "Zastaw (" + ((int)(_planet.CalculatePlanetWorth() * 0.5)).ToString() + " KG)";
                                int x;
                                List<string> tmp = new List<string> { "x" };
                                if ((int)(_planet.CalculatePlanetWorth() * 1.5) > game.Players[game.CurrentPlayer].Money)
                                {
                                    tmp.Add("y");
                                }
                                switch (game.RandomPlanetChoice(tmp))
                                {
                                    case -1:
                                        x = game.RandomPlanetChoice(ComboBox_1_1_0.Items.Cast<string>().ToList());
                                        if (x == -1)
                                        {
                                            Label_1_2_1.Content = "Pominięto!";
                                        }
                                        else
                                        {
                                            ComboBox_1_1_0.SelectedIndex = x;
                                            Button_1_1_0_Click(null, null);
                                            Label_1_2_1.Content = "Dokonano transakcji!";
                                        }
                                        break;
                                    case 1:
                                        Button_1_1_2_Click(null, null);
                                        Label_1_2_1.Content = "Oddano pod zastaw!";
                                        break;
                                    default:
                                        x = game.RandomPlanetChoice(ComboBox_1_1_1.Items.Cast<string>().ToList());
                                        if (x == -1)
                                        {
                                            Label_1_2_1.Content = "Pominięto!";
                                        }
                                        else
                                        {
                                            ComboBox_1_1_1.SelectedIndex = x;
                                            Button_1_1_1_Click(null, null);
                                            Label_1_2_1.Content = "Dokonano transakcji!";
                                        }
                                        break;
                                }
                                if (ComboBox_1_1_0.Items.Count == 0)
                                {
                                    ComboBox_1_1_0.Items.Add("(brak)");
                                }
                                if (ComboBox_1_1_1.Items.Count == 0)
                                {
                                    ComboBox_1_1_1.Items.Add("(brak)");
                                }
                            }
                            else
                            {
                                Button_1_1_2.Content = "Odkup (" + ((int)(_planet.CalculatePlanetWorth() * 0.5)).ToString() + " KG)";
                                List<string> tmp = new List<string>();
                                if ((int)((_planet.CalculatePlanetWorth() * 0.5) * 1.5) < game.Players[game.CurrentPlayer].Money)
                                {
                                    tmp.Add("y");
                                }
                                switch (game.RandomPlanetChoice(tmp))
                                {
                                    case -1:
                                        Label_1_2_1.Content = "Pominięto!";
                                        break;
                                    default:
                                        Button_1_1_2_Click(null, null);
                                        Label_1_2_1.Content = "Wykupiono z zastawu!";
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (!_planet.Pledged)
                            {
                                Button_1_1_2_Click(null, null);
                                Label_1_2_1.Content = "Zapłacono za postój!";
                            }
                            else
                            {
                                Label_1_2_1.Content = "Pominięto!";
                            }
                        }
                    }
                    break;
                case 2:
                case 6:
                    Label_1_1_0.Content = "Kolej Galaktyczna";
                    Button_1_1_1.Content = "Podróż";
                    Button_1_1_1.Visibility = Visibility.Visible;
                    ComboBox_1_1_1.Visibility = Visibility.Visible;
                    if (game.Players[game.CurrentPlayer].Position == 2)
                    {
                        Label_1_1_1.Content = "Obecny przystanek: " + game.GalacticTrainStations[0].Name;
                    }
                    if (game.Players[game.CurrentPlayer].Position == 6)
                    {
                        Label_1_1_1.Content = "Obecny przystanek: " + game.GalacticTrainStations[1].Name;
                    }
                    Label_1_1_1.Visibility = Visibility.Visible;
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        if (game.Players[game.CurrentPlayer].HaveGalacticTicket())
                        {
                            Button_1_1_1.IsEnabled = true;
                            ComboBox_1_1_1.IsEnabled = true;
                            if (game.Players[game.CurrentPlayer].Position == 2)
                            {
                                ComboBox_1_1_1.Items.Add(game.GalacticTrainStations[1].Name);
                            }
                            if (game.Players[game.CurrentPlayer].Position == 6)
                            {
                                ComboBox_1_1_1.Items.Add(game.GalacticTrainStations[0].Name);
                            }
                            ComboBox_1_1_1.SelectedIndex = 0;
                        }
                        else
                        {
                            Label_1_2_1.Content = "Brak biletu!";
                        }
                    }
                    else
                    {
                        if (game.Players[game.CurrentPlayer].HaveGalacticTicket())
                        {
                            if (game.Players[game.CurrentPlayer].Position == 2)
                            {
                                ComboBox_1_1_1.Items.Add(game.GalacticTrainStations[1].Name);
                            }
                            if (game.Players[game.CurrentPlayer].Position == 6)
                            {
                                ComboBox_1_1_1.Items.Add(game.GalacticTrainStations[0].Name);
                            }
                            Label_1_2_1.Content = "Użyto biletu!";
                            switch (game.RandomGalacticTrainStationChoice())
                            {
                                case 0:
                                    ComboBox_1_1_1.SelectedIndex = 0;
                                    Button_1_1_1_Click(null, null);
                                    break;
                                case -1:
                                    Label_1_2_1.Content = "Pominięto!";
                                    break;
                            }
                        }
                        else
                        {
                            Label_1_2_1.Content = "Brak biletu!";
                        }
                    }
                    break;
                case 4:
                    Label_1_1_0.Content = "Szansa";
                    Button_1_1_0.Content = "Sprawdź kartę";
                    Button_1_1_0.Visibility = Visibility.Visible;
                    Button_1_1_2.Content = "OK";
                    Button_1_1_2.Visibility = Visibility.Visible;
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        Button_1_1_0.IsEnabled = true;
                    }
                    else
                    {
                        switch (game.RandomOpportunityChoice())
                        {
                            case 0:
                                Button_1_1_0_Click(null, null);
                                Label_1_2_1.Content = "Wylosowano szansę!";
                                break;
                            case -1:
                                Label_1_2_1.Content = "Pominięto!";
                                break;
                        }
                    }
                    break;
                case 8:
                    Label_1_1_0.Content = "Piraci";
                    Button_1_1_0.Content = "Użyj karty obrony";
                    Button_1_1_0.Visibility = Visibility.Visible;
                    Button_1_1_1.Content = "Okup (1000 KG)";
                    Button_1_1_1.Visibility = Visibility.Visible;
                    Button_1_1_2.Content = "Poddaj się (strata 2 kolejek)";
                    Button_1_1_2.Visibility = Visibility.Visible;
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        if (game.Players[game.CurrentPlayer].HavePiratesCard())
                        {
                            Button_1_1_0.IsEnabled = true;
                        }
                        if (game.Players[game.CurrentPlayer].CanPay(1000))
                        {
                            Button_1_1_1.IsEnabled = true;
                        }
                        Button_1_1_2.IsEnabled = true;
                    }
                    else
                    {
                        switch (game.RandomPiratesChoice())
                        {
                            case 2:
                                Button_1_1_0_Click(null, null);
                                Label_1_2_1.Content = "Użyto karty piratów!";
                                break;
                            case 1:
                                Button_1_1_1_Click(null, null);
                                Label_1_2_1.Content = "Zapłacono okup!";
                                break;
                            case 0:
                                Button_1_1_2_Click(null, null);
                                Label_1_2_1.Content = "Przyjęto blokadę!";
                                break;
                        }
                    }
                    break;
            }
            ComboBox_0_1_0.IsEnabled = true;
            foreach (string s in game.Players[0].GetBuildingsList())
            {
                ComboBox_0_1_0.Items.Add(s);
            }
            if (ComboBox_0_1_0.Items.Count == 0)
            {
                ComboBox_0_1_0.Items.Add("(brak)");
            }
            ComboBox_0_1_0.SelectedIndex = 0;
            ComboBox_0_1_1.IsEnabled = true;
            bool pirates = false;
            bool trains = false;
            foreach (string s in game.Players[0].GetCardsList())
            {
                if (s == "Karta obrony przed piratami!" && pirates == false)
                {
                    pirates = true;
                    ComboBox_0_1_1.Items.Add("Karta obrony przed piratami");
                }
                if (s == "Bilet galaktyczny!" && trains == false)
                {
                    trains = true;
                    ComboBox_0_1_1.Items.Add("Bilet galaktyczny");
                }
            }
            if (ComboBox_0_1_1.Items.Count == 0)
            {
                ComboBox_0_1_1.Items.Add("(brak)");
            }
            ComboBox_0_1_1.SelectedIndex = 0;
            ComboBox_0_1_2.IsEnabled = true;
            foreach (string s in game.Players[1].GetBuildingsList())
            {
                ComboBox_0_1_2.Items.Add(s);
            }
            if (ComboBox_0_1_2.Items.Count == 0)
            {
                ComboBox_0_1_2.Items.Add("(brak)");
            }
            ComboBox_0_1_2.SelectedIndex = 0;
            ComboBox_0_1_3.IsEnabled = true;
            pirates = false;
            trains = false;
            foreach (string s in game.Players[1].GetCardsList())
            {
                if (s == "Karta obrony przed piratami!" && pirates == false)
                {
                    pirates = true;
                    ComboBox_0_1_3.Items.Add("Karta obrony przed piratami");
                }
                if (s == "Bilet galaktyczny!" && trains == false)
                {
                    trains = true;
                    ComboBox_0_1_3.Items.Add("Bilet galaktyczny");
                }
            }
            if (ComboBox_0_1_3.Items.Count == 0)
            {
                ComboBox_0_1_3.Items.Add("(brak)");
            }
            ComboBox_0_1_3.SelectedIndex = 0;
            Label_0_1_2.Content = game.Players[0].Money.ToString() + " KG";
            Label_0_1_4.Content = game.Players[1].Money.ToString() + " KG";
            Label_0_2_1.Content = game.RoundCount.ToString();
            Label_1_0_1.Content = game.Players[game.CurrentPlayer].Name.ToString();
            if (!CheckIfMoreThan1ButtonIsEnabled())
            {
                Button_0_2_0.IsEnabled = true;
            }
            game.GameInfo = "";
        }

        private bool Opportunity()
        {
            switch (game.Players[game.CurrentPlayer].LastDiceResult2 - 1)
            {
                case 0:
                    game.Players[game.CurrentPlayer].AddCard(game.Cards[game.Players[game.CurrentPlayer].LastDiceResult2 - 1]);
                    break;
                case 1:
                    game.Players[game.CurrentPlayer].AddCard(game.Cards[game.Players[game.CurrentPlayer].LastDiceResult2 - 1]);
                    break;
                case 2:
                    game.Players[game.CurrentPlayer].ChangeLocation(8);
                    RefreshWindow();
                    return false;
                case 3:
                    int worth = 0;
                    foreach (Planet planet in game.Players[game.CurrentPlayer].Planets)
                    {
                        if (!planet.Pledged)
                        {
                            worth += planet.CalculatePlanetWorth();
                        }
                    }
                    worth = (int)(worth * 0.1);
                    if (game.Players[game.CurrentPlayer].CanPay(worth))
                    {
                        game.Players[game.CurrentPlayer].Pay(worth);
                    }
                    else
                    {
                        game.Players[game.CurrentPlayer].ChangeStatus(-1);
                    }
                    break;
                case 4:
                    game.Players[game.CurrentPlayer].GiveMoney(100);
                    break;
                case 5:
                    if (game.Players[game.CurrentPlayer].CanPay(150))
                    {
                        game.Players[game.CurrentPlayer].Pay(150);
                    }
                    else
                    {
                        game.Players[game.CurrentPlayer].ChangeStatus(-1);
                    }
                    break;
                case 6:
                    if (game.Players[game.CurrentPlayer].CanPay(300))
                    {
                        game.Players[game.CurrentPlayer].Pay(300);
                    }
                    else
                    {
                        game.Players[game.CurrentPlayer].LoseShipyard();
                    }
                    break;
            }
            return true;
        }

        private void Button_0_0_0_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox_0_0_0.SelectedIndex == 0)
            {
                game = new GalacticBusinessGame();
            }
            else
            {
                game = new GalacticBusinessGame(true);
            }
            game.StartRound();
            RefreshWindow();
        }

        private void Button_0_2_0_Click(object sender, RoutedEventArgs e)
        {
            switch (game.Players[game.CurrentPlayer].Position)
            {
                case 1:
                    if (game.Systems[0].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Owner == game.Players[game.CurrentPlayer])
                    {
                        game.RoundNotSkipped();
                    }
                    break;
                case 3:
                    if (game.Systems[1].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Owner == game.Players[game.CurrentPlayer])
                    {
                        game.RoundNotSkipped();
                    }
                    break;
                case 5:
                    if (game.Systems[2].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Owner == game.Players[game.CurrentPlayer])
                    {
                        game.RoundNotSkipped();
                    }
                    break;
                case 7:
                    if (game.Systems[3].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Owner == game.Players[game.CurrentPlayer])
                    {
                        game.RoundNotSkipped();
                    }
                    break;
                case 9:
                    if (game.Systems[4].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Owner == game.Players[game.CurrentPlayer])
                    {
                        game.RoundNotSkipped();
                    }
                    break;
                default:
                    break;
            }
            game.RoundSkipped();
            game.StartRound();
            RefreshWindow();
        }

        private void Button_1_1_0_Click(object sender, RoutedEventArgs e)
        {
            switch (game.Players[game.CurrentPlayer].Position)
            {
                case 4:
                    Label_1_1_2.Content = game.Cards[game.Players[game.CurrentPlayer].LastDiceResult2 - 1].Description;
                    Label_1_1_2.Visibility = Visibility.Visible;
                    Button_1_1_0.IsEnabled = false;
                    Button_0_2_0.IsEnabled = false;
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        Button_1_1_2.IsEnabled = true;
                    }
                    else
                    {
                        Opportunity();
                    }
                    break;
                case 8:
                    game.Players[game.CurrentPlayer].UsePirateCard();
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Planet _planet;
                    switch (game.Players[game.CurrentPlayer].Position)
                    {
                        case 1:
                            _planet = game.Systems[0].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 3:
                            _planet = game.Systems[1].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 5:
                            _planet = game.Systems[2].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 7:
                            _planet = game.Systems[3].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        default:
                            _planet = game.Systems[4].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                    }
                    string txt = (string)ComboBox_1_1_0.SelectedItem;
                    string firstThreeChars = txt.Substring(0, Math.Min(txt.Length, 3));
                    switch (firstThreeChars)
                    {
                        case "Sto":
                            game.Players[game.CurrentPlayer].Pay(500);
                            foreach (Planet __planet in _planet.Parent.Planets)
                            {
                                __planet.Shipyard++;
                            }
                            break;
                        case "Ast":
                            game.Players[game.CurrentPlayer].Pay(400);
                            foreach (Planet __planet in _planet.Parent.Planets)
                            {
                                __planet.AsteoridMine++;
                            }
                            break;
                        case "Far":
                            game.Players[game.CurrentPlayer].Pay(300);
                            _planet.Farm++;
                            break;
                        case "Kop":
                            game.Players[game.CurrentPlayer].Pay(200);
                            _planet.Mine++;
                            break;
                        case "Pos":
                            game.Players[game.CurrentPlayer].Pay(100);
                            _planet.Residential++;
                            break;
                        default:
                            game.Players[game.CurrentPlayer].Pay(50);
                            _planet.Owner = game.Players[game.CurrentPlayer];
                            game.Players[game.CurrentPlayer].AddPlanet(_planet);
                            break;
                    }
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
            }
        }

        private void Button_1_1_1_Click(object sender, RoutedEventArgs e)
        {
            switch (game.Players[game.CurrentPlayer].Position)
            {
                case 2:
                case 6:
                    if (game.Players[game.CurrentPlayer].Position == 2)
                    {
                        game.Players[game.CurrentPlayer].ChangeLocation(6);
                    }
                    else if (game.Players[game.CurrentPlayer].Position == 6)
                    {
                        game.Players[game.CurrentPlayer].ChangeLocation(2);
                    }
                    game.Players[game.CurrentPlayer].UseGalacticTicket();
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
                case 8:
                    game.Players[game.CurrentPlayer].Pay(1000);
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Planet _planet;
                    switch (game.Players[game.CurrentPlayer].Position)
                    {
                        case 1:
                            _planet = game.Systems[0].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 3:
                            _planet = game.Systems[1].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 5:
                            _planet = game.Systems[2].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 7:
                            _planet = game.Systems[3].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        default:
                            _planet = game.Systems[4].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                    }
                    string txt = (string)ComboBox_1_1_1.SelectedItem;
                    string firstThreeChars = txt.Substring(0, Math.Min(txt.Length, 3));
                    switch (firstThreeChars)
                    {
                        case "Ast":
                            game.Players[game.CurrentPlayer].Pay(400);
                            foreach (Planet __planet in _planet.Parent.Planets)
                            {
                                __planet.AsteoridMine++;
                            }
                            break;
                        case "Far":
                            game.Players[game.CurrentPlayer].Pay(300);
                            _planet.Farm++;
                            break;
                        case "Kop":
                            game.Players[game.CurrentPlayer].Pay(200);
                            _planet.Mine++;
                            break;
                        default:
                            game.Players[game.CurrentPlayer].Pay(100);
                            _planet.Residential++;
                            break;
                    }
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
            }
        }

        private void Button_1_1_2_Click(object sender, RoutedEventArgs e)
        {
            switch (game.Players[game.CurrentPlayer].Position)
            {
                case 4:
                    if (Opportunity())
                    {
                        game.RoundNotSkipped();
                        if (game.Players[game.CurrentPlayer].RealPlayer)
                        {
                            game.StartRound();
                            RefreshWindow();
                        }
                    }
                    break;
                case 8:
                    game.Players[game.CurrentPlayer].LoseRound(2);
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Planet _planet;
                    switch (game.Players[game.CurrentPlayer].Position)
                    {
                        case 1:
                            _planet = game.Systems[0].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 3:
                            _planet = game.Systems[1].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 5:
                            _planet = game.Systems[2].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        case 7:
                            _planet = game.Systems[3].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                        default:
                            _planet = game.Systems[4].Planets[game.Players[game.CurrentPlayer].LastDiceResult2 - 1];
                            break;
                    }
                    if (!_planet.Pledged)
                    {
                        if (_planet.Owner != game.Players[game.CurrentPlayer])
                        {
                            int tax = ((int)(25 + (_planet.CalculatePlanetWorth() * 0.1)));
                            if (game.Players[game.CurrentPlayer].CanPay(tax))
                            {
                                game.Players[game.CurrentPlayer].Pay(tax);
                                _planet.Owner.GiveMoney(tax);
                            }
                            else
                            {
                                game.Players[game.CurrentPlayer].ChangeStatus(-1);
                            }
                        }
                        else
                        {
                            game.Players[game.CurrentPlayer].GiveMoney(((int)(_planet.CalculatePlanetWorth() * 0.5))); 
                            _planet.Pledged = true;
                        }
                    }
                    else
                    {
                        if (_planet.Owner == game.Players[game.CurrentPlayer])
                        {
                            if (game.Players[game.CurrentPlayer].CanPay(((int)(_planet.CalculatePlanetWorth() * 0.5))))
                            {
                                game.Players[game.CurrentPlayer].Pay(((int)(_planet.CalculatePlanetWorth() * 0.5)));
                                _planet.Pledged = false;
                            }
                        }
                    }
                    game.RoundNotSkipped();
                    if (game.Players[game.CurrentPlayer].RealPlayer)
                    {
                        game.StartRound();
                        RefreshWindow();
                    }
                    break;
            }
        }
    }
}
