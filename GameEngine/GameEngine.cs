using System;
using System.Collections.Generic;
using System.Linq;

namespace GameEngine
{
    public class Player
    {
        public string Name { get; set; }
        public bool RealPlayer { get; set; }
        public int Money { get; set; }
        public int Status { get; set; }
        public int MyRoundCount { get; set; }
        public int SkipCount { get; set; }
        public int Position { get; set; }
        public int LastDiceResult1 { get; set; }
        public int LastDiceResult2 { get; set; }
        public List<Planet> Planets { get; set; }
        public List<Card> Cards { get; set; }

        public Player(string _name, bool _realPlayer = false)
        {
            Name = _name;
            RealPlayer = _realPlayer;
            Clear(350);
        }

        public void Clear(int _money = 0)
        {
            Money = _money;
            Status = 0;
            MyRoundCount = 0;
            SkipCount = 0;
            Position = 0;
            LastDiceResult1 = 0;
            LastDiceResult2 = 0;
            Planets = new List<Planet>();
            Cards = new List<Card>();
        }

        public void AddPlanet(Planet _planet)
        {
            bool p = false;
            foreach (Planet planet in Planets)
            {
                if (planet == _planet)
                {
                    p = true;
                    break;
                }
            }
            if (!p)
            {
                Planets.Add(_planet);
            }
        }

        public void AddCard(Card _card)
        {
            bool c = false;
            foreach (Card card in Cards)
            {
                if (card == _card)
                {
                    c = true;
                    break;
                }
            }
            if (!c)
            {
                Cards.Add(_card);
            }
        }

        public bool HavePiratesCard()
        {
            bool p = false;
            foreach (Card card in Cards)
            {
                if (card.Description == "Karta obrony przed piratami!")
                {
                    p = true;
                    break;
                }
            }
            return p;
        }

        public void UsePirateCard()
        {
            Cards.RemoveAll(obj => obj.Description == "Karta obrony przed piratami!");
        }

        public bool HaveGalacticTicket()
        {
            bool c = false;
            foreach (Card card in Cards)
            {
                if (card.Description == "Bilet galaktyczny!")
                {
                    c = true;
                    break;
                }
            }
            return c;
        }

        public void UseGalacticTicket()
        {
            Cards.RemoveAll(obj => obj.Description == "Bilet galaktyczny!");
        }

        public bool CanSkip()
        {
            if (SkipCount > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CanPay(int money)
        {
            if (Money >= money)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Pay(int money)
        {
            Money -= money;
        }

        public void GiveMoney(int money)
        {
            Money += money;
        }

        public void LoseRound(int amount)
        {
            MyRoundCount -= amount;
        }

        public void ChangeLocation(int i)
        {
            Position = i;
        }

        public void ChangeStatus(int i)
        {
            Status = i;
        }

        public void LoseShipyard()
        {
            foreach (Planet planet in Planets)
            {
                if (planet.Shipyard > 0)
                {
                    foreach (Planet _planet in planet.Parent.Planets)
                    {
                        _planet.Shipyard = 0;
                    }
                    break;
                }
            }
        }

        public List<string> GetBuildingsList()
        {
            List<string> Buildings = new List<string>();
            foreach (Planet planet in Planets)
            {
                string p = "";
                if (planet.Pledged)
                {
                    p = "ZASTAWIONE - ";
                }
                Buildings.Add(p + planet.Parent.Name + " - " + planet.Name + " - " + "Port kosmiczny (50 KG)");
                string s = p + planet.Parent.Name + " - " + planet.Name + " - ";
                switch (planet.Residential)
                {
                    case 1:
                        s += "Posterunek (100 KG)";
                        Buildings.Add(s);
                        break;
                    case 2:
                        s += "Habitat mieszkalny (200 KG)";
                        Buildings.Add(s);
                        break;
                    case 3:
                        s += "Kolonia (300 KG)";
                        Buildings.Add(s);
                        break;
                    case 4:
                        s += "Hotel galaktyczny (400 KG)";
                        Buildings.Add(s);
                        break;
                    case 5:
                        s += "Sieć hoteli galaktycznych (500 KG)";
                        Buildings.Add(s);
                        break;
                }
                s = p + planet.Parent.Name + " - " + planet.Name + " - ";
                switch (planet.Mine)
                {
                    case 1:
                        s += "Kopalnia (poz. 1) (200 KG)";
                        Buildings.Add(s);
                        break;
                    case 2:
                        s += "Kopalnia (poz. 2) (400 KG)";
                        Buildings.Add(s);
                        break;
                    case 3:
                        s += "Kopalnia (poz. 3) (600 KG)";
                        Buildings.Add(s);
                        break;
                }
                s = p + planet.Parent.Name + " - " + planet.Name + " - ";
                switch (planet.Farm)
                {
                    case 1:
                        s += "Farma żywności (poz. 1) (300 KG)";
                        Buildings.Add(s);
                        break;
                    case 2:
                        s += "Farma żywności (poz. 2) (600 KG)";
                        Buildings.Add(s);
                        break;
                    case 3:
                        s += "Farma żywności (poz. 3) (900 KG)";
                        Buildings.Add(s);
                        break;
                    case 4:
                        s += "Farma żywności (poz. 4) (1200 KG)";
                        Buildings.Add(s);
                        break;
                    case 5:
                        s += "Farma żywności (poz. 5) (1500 KG)";
                        Buildings.Add(s);
                        break;
                }
                s = p + planet.Parent.Name + " - " + planet.Name + " - ";
                switch (planet.AsteoridMine)
                {
                    case 1:
                        s += "Asteroidalna kopalnia (poz. 1) (400 KG)";
                        Buildings.Add(s);
                        break;
                    case 2:
                        s += "Asteroidalna kopalnia (poz. 2) (800 KG)";
                        Buildings.Add(s);
                        break;
                    case 3:
                        s += "Asteroidalna kopalnia (poz. 3) (1200 KG)";
                        Buildings.Add(s);
                        break;
                    case 4:
                        s += "Asteroidalna kopalnia (poz. 4) (1600 KG)";
                        Buildings.Add(s);
                        break;
                    case 5:
                        s += "Asteroidalna kopalnia (poz. 5) (2000 KG)";
                        Buildings.Add(s);
                        break;
                }
                s = p + planet.Parent.Name + " - " + planet.Name + " - ";
                switch (planet.Shipyard)
                {
                    case 1:
                        s += "Stocznia galaktyczna (500 KG)";
                        Buildings.Add(s);
                        break;
                }
            }
            return Buildings;
        }

        public List<string> GetCardsList()
        {
            List<string> _Cards = new List<string>();
            foreach (Card card in Cards)
            {
                _Cards.Add(card.Description);
            }
            return _Cards;
        }
    }

    public class Card
    {
        public string Description { get; set; }

        public Card(string _description)
        {
            Description = _description;
        }
    }

    public class GalacticTrainStation
    {
        public string Name { get; set; }

        public GalacticTrainStation(string _name)
        {
            Name = _name;
        }
    }

    public class Planet
    {
        public string Name { get; set; }
        public Player Owner { get; set; }
        public System Parent { get; set; }
        public bool Pledged { get; set; }
        public int Residential { get; set; }
        public int Mine { get; set; }
        public int Farm { get; set; }
        public int AsteoridMine { get; set; }
        public int Shipyard { get; set; }

        public Planet(string _name, System parent)
        {
            Name = _name;
            Owner = null;
            Parent = parent;
            Pledged = false;
            Residential = 0;
            Mine = 0;
            Farm = 0;
            AsteoridMine = 0;
            Shipyard = 0;
        }

        public int CalculatePlanetWorth()
        {
            int worth = 0;
            if (Owner != null)
            {
                worth += 50;
            }
            worth += Residential * 100;
            worth += Mine * 200;
            worth += Farm * 300;
            worth += AsteoridMine * 400;
            worth += Shipyard * 500;
            return worth;
        }

        public void Clear(string _name, System parent)
        {
            Name = _name;
            Owner = null;
            Parent = parent;
            Pledged = false;
            Residential = 0;
            Mine = 0;
            Farm = 0;
            AsteoridMine = 0;
            Shipyard = 0;
        }
    }

    public class System
    {
        public string Name { get; set; }
        public List<Planet> Planets { get; set; }

        public System(string _name)
        {
            Name = _name;
            Planets = new List<Planet>();
        }

        public void CreateNewPlanet(string _name)
        {
            Planets.Add(new Planet(_name, this));
        }

        public bool CheckIfPlayerIsSystemOwner(Player _player)
        {
            int p = 0;
            foreach (Planet planet in Planets)
            {
                if (planet.Owner == _player)
                {
                    p++;
                }
            }
            if (p == Planets.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class GalacticBusinessGame
    {
        public int RoundCount { get; set; }
        public int CurrentPlayer { get; set; }
        public string GameInfo { get; set; }
        public List<Player> Players { get; set; }
        public List<System> Systems { get; set; }
        public List<Card> Cards { get; set; }
        public List<GalacticTrainStation> GalacticTrainStations { get; set; }
        private readonly Random Rand;

        public GalacticBusinessGame(bool withComputer = false)
        {
            RoundCount = 0;
            CurrentPlayer = -1;
            GameInfo = "";
            Players = new List<Player>();
            Systems = new List<System>();
            Cards = new List<Card>();
            GalacticTrainStations = new List<GalacticTrainStation>();
            Rand = new Random();

            Players.Add(new Player("Gracz 1", true));
            if (withComputer)
            {
                Players.Add(new Player("Gracz 2"));
            }
            else
            {
                Players.Add(new Player("Gracz 2", true));
            }
            Systems.Add(new System("Słoneczny"));
            Systems[0].CreateNewPlanet("Ziemia");
            Systems[0].CreateNewPlanet("Mars");
            Systems.Add(new System("Księżycowy"));
            Systems[1].CreateNewPlanet("Wenus");
            Systems[1].CreateNewPlanet("Merkury");
            Systems.Add(new System("Gwiezdny"));
            Systems[2].CreateNewPlanet("Jowisz");
            Systems[2].CreateNewPlanet("Saturn");
            Systems.Add(new System("Głębinowy"));
            Systems[3].CreateNewPlanet("Uran");
            Systems[3].CreateNewPlanet("Neptun");
            Systems.Add(new System("Mglisty"));
            Systems[4].CreateNewPlanet("Pluton");
            Systems[4].CreateNewPlanet("Charon");
            Cards.Add(new Card("Karta obrony przed piratami!"));
            Cards.Add(new Card("Bilet galaktyczny!"));
            Cards.Add(new Card("Atak piratów!"));
            Cards.Add(new Card("Podatek od nieruchomości (20%)!"));
            Cards.Add(new Card("Wygrana w loterii (100 KG)!"));
            Cards.Add(new Card("Awaria silnika statku (150 KG)!"));
            Cards.Add(new Card("Awaria w stoczni (300 KG)!"));
            GalacticTrainStations.Add(new GalacticTrainStation("Dworzec Orbitalny"));
            GalacticTrainStations.Add(new GalacticTrainStation("Dworzec Świetlny"));
        }

        public void StartRound()
        {
            if (CurrentPlayer + 1 >= Players.Count || CurrentPlayer == -1)
            {
                RoundCount++;
                if (RoundCount % 5 == 0)
                {
                    foreach (Player player in Players)
                    {
                        int worth = 0;
                        foreach (Planet planet in player.Planets)
                        {
                            if (!planet.Pledged)
                            {
                                worth += planet.CalculatePlanetWorth();
                            }
                        }
                        player.Money += 100;
                        player.Money += (int)(worth * 0.1);
                    }
                    GameInfo = "Wpłynął przelew!";
                }
                CurrentPlayer = 0;
                PlayerRound(Players[CurrentPlayer]);
            }
            else
            {
                CurrentPlayer++;
                PlayerRound(Players[CurrentPlayer]);
                return;
            }
        }

        public void PlayerRound(Player player)
        {
            if (player.MyRoundCount != RoundCount && player.Status >= 0)
            {
                player.MyRoundCount++;
                if (player.MyRoundCount < RoundCount)
                {
                    player.MyRoundCount++;
                    StartRound();
                    return;
                }
                player.LastDiceResult1 = RollDice();
                player.Position += player.LastDiceResult1;
                if (player.Position > 9)
                {
                    player.Position -= 9;
                }
                switch (player.Position)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                        player.LastDiceResult2 = RollDice(2);
                        break;
                    case 4:
                        bool s = false;
                        foreach (Planet planet in player.Planets)
                        {
                            if (planet.Shipyard > 0)
                            {
                                s = true;
                                break;
                            }
                        }
                        if (s)
                        {
                            player.LastDiceResult2 = RollDice(Cards.Count);
                        }
                        else
                        {
                            player.LastDiceResult2 = RollDice(Cards.Count - 1);
                        }
                        break;
                    default:
                        player.LastDiceResult2 = 0;
                        break;
                }
            }
        }

        public void RoundNotSkipped()
        {
            Players[CurrentPlayer].SkipCount = 0;
        }

        public void RoundSkipped()
        {
            Players[CurrentPlayer].SkipCount++;
        }

        public int RollDice(int max = 3)
        {
            return Rand.Next(1, max + 1);
        }

        public bool CheckIfPlayerHasHalfPossibleWealth(Player player)
        {
            int max_worth = 0;
            foreach (System system in Systems)
            {
                foreach (Planet planet in system.Planets)
                {
                    max_worth += 1*50;
                    max_worth += 5*100;
                    max_worth += 3*200;
                    max_worth += 5*300;
                    max_worth += 1*400;
                    max_worth += 5*500;
                }
            }
            int worth = 0;
            foreach (Planet planet in player.Planets)
            {
                worth += planet.CalculatePlanetWorth();
            }
            worth += player.Money;
            if (worth > max_worth/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RandomPiratesChoice()
        {
            List<int> L = new List<int> { 0 };
            if (Players[CurrentPlayer].CanPay(1000))
            {
                L.Add(1);
            }
            if (Players[CurrentPlayer].HavePiratesCard())
            {
                L.Add(2);
            }
            return L[Rand.Next(0, L.Count)];
        }

        public int RandomPlanetChoice(List<string> L)
        {
            if (L.Count > 0)
            {
                switch (Rand.Next(0, 3))
                {
                    case 0:
                        return -1;
                    default:
                        return Rand.Next(0, L.Count);
                }
            }
            else
            {
                return -1;
            }
        }

        public int RandomGalacticTrainStationChoice()
        {
            List<int> L = new List<int> { -1, 0 };
            return L[Rand.Next(0, L.Count)];
        }

        public int RandomOpportunityChoice()
        {
            List<int> L = new List<int> { 0 };
            if (Players[CurrentPlayer].CanSkip())
            {
                L.Add(-1);
            }
            return L[Rand.Next(0, L.Count)];
        }

        public void RandomGame()
        {
            RoundCount = 0;
            CurrentPlayer = -1;
            foreach (Player player in Players)
            {
                player.Clear(Rand.Next(1, 2346));
            }
            foreach (System system in Systems)
            {
                foreach (Planet planet in system.Planets)
                {
                    planet.Clear(planet.Name, planet.Parent);
                }
            }
            foreach (System system in Systems)
            {
                foreach (Planet planet in system.Planets)
                {
                    switch (Rand.Next(0, 3))
                    {
                        case 0:
                            planet.Owner = Players[0];
                            Players[0].AddPlanet(planet);
                            break;
                        case 1:
                            planet.Owner = Players[1];
                            Players[1].AddPlanet(planet);
                            break;
                        default:
                            continue;
                    }
                }
            }
            foreach (System system in Systems)
            {
                bool r = false;
                int a = 0;
                bool s = false;
                foreach (Planet planet in system.Planets)
                {
                    if (planet.Owner == null)
                    {
                        continue;
                    }
                    int add = 0;
                    if (system.CheckIfPlayerIsSystemOwner(planet.Owner))
                    {
                        add++;
                    }
                    planet.Residential = Rand.Next(0, 5 + add);
                    if (planet.Residential == 5)
                    {
                        r = true;
                    }
                    planet.Mine = Rand.Next(0, 4);
                    planet.Farm = Rand.Next(0, 6);
                    planet.AsteoridMine = Rand.Next(0, 0 + add * 5);
                    if (planet.AsteoridMine > 0)
                    {
                        a = planet.AsteoridMine;
                    }
                    planet.Shipyard = Rand.Next(0, 0 + add);
                    if (planet.Shipyard == 5)
                    {
                        s = true;
                    }
                }
                if (r)
                {
                    foreach (Planet planet in system.Planets)
                    {
                        planet.Residential = 5;
                    }
                }
                if (a > 0)
                {
                    foreach (Planet planet in system.Planets)
                    {
                        planet.AsteoridMine = a;
                    }
                }
                if (s)
                {
                    foreach (Planet planet in system.Planets)
                    {
                        planet.Shipyard = 1;
                    }
                }
            }
            foreach (Player player in Players)
            {
                switch (Rand.Next(0, 4))
                {
                    case 0:
                        player.AddCard(Cards[0]);
                        break;
                    default:
                        break;
                }
                switch (Rand.Next(0, 4))
                {
                    case 0:
                        player.AddCard(Cards[1]);
                        break;
                    default:
                        break;
                }
            }
            StartRound();
        }
    }
}
