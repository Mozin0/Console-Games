using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Player : Entity
    {

        public Player(string name) : base(name) { }

        public static Player CreatePlayer(string name)
        {
            return Random.Shared.Next(0, 3) switch
            {
                0 => new Archer($"{nameof(Archer)} {name}"),
                1 => new Warrior($"{nameof(Warrior)} {name}"),
                _ => new Mage($"{nameof(Mage)} {name}")
            };
            
        }

        public void ShowStatus(string name)
        {
            var status = this switch
            {
                Archer => $"{nameof(Archer)} | {name} | {Health} Hp",
                Warrior => $"{nameof(Warrior)} | {name} | {Health} Hp",
                _ => $"{nameof(Mage)} | {name} | {Health} Hp"
            };

            Console.WriteLine(status);
        }

        public override string ToString() => $"{Name}";

        public int Hit(Player player)
        {
            var damage = Random.Shared.Next(40, 46);
            
            player.Health = Math.Clamp(player.Health - damage, 0, 100);
            Console.WriteLine($"{this} hits {player} {damage} damage.");
            return damage;
        }

        public void Fight(Player player)
        {
            while(true)
            {
                if(Health > 0 || player.Health > 0)
                {
                    
                Console.WriteLine("Press A to attack   Press D to dodge");
                var fight = Console.ReadKey(true).Key;
                ClearLastLineWrittenByConsole();

                if (fight == ConsoleKey.A)
                {
                        string clashed = $"You have clahed with the enemy";
                        string pierced = $"You have pierced the enemy";
                        var battle = Random.Shared.Next(0, 2);
                        if (battle == 0)
                        {
                            Console.WriteLine(clashed);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(pierced);
                            Hit(player);
                            player.ShowStatus(player.Name);
                            player.Hit(this);
                            this.ShowStatus(this.Name);

                            continue;
                        }
                }
                
                else if (fight == ConsoleKey.D)
                {
                    Console.WriteLine($"{player} hits {this}");
                    var random = Random.Shared.Next(0, 3);
                    var dodgeMessages = random switch
                    {
                        0 => $"You have dodged the enemy attack",
                        1 => $"Dodge failed",
                        _ => $"You have dodged the enemy attack"
                    };

                        if (random == 1)
                        {
                            Console.WriteLine(dodgeMessages);
                            player.Hit(this);

                            ShowStatus(this.Name);
                            if (Health <= 0 || player.Health <= 0)
                            {
                                Console.WriteLine(Health > player.Health ? $"{this} wins." : $"{player} wins.");

                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(dodgeMessages);
                        }

                    continue;
                }
                else if (fight is not ConsoleKey.A && fight is not ConsoleKey.D)
                {
                    continue;
                }
                }
                else if (Health <= 0 || player.Health <= 0)
                {
                    Console.WriteLine(Health > player.Health ? $"{this} wins." : $"{player} wins.");

                    break;
                }
            }
        }

        public void EnemyFight(Player player)
        {
            while (Health > 0 || player.Health > 0)
            {
                if (Health == 0 || player.Health == 0)
                {
                    break;
                }

                player.Hit(this);
                return;                
            }
           // Console.WriteLine(Health > player.Health ? $"{this} wins." : $"{player} wins.");
        }


        static void ClearLastLineWrittenByConsole()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.Write(new string(' ', Console.BufferWidth));

            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }

    internal class Archer : Player
        {
            public Archer(string name) : base(name) { }
        }

        internal class Warrior : Player
        {
            public Warrior(string name) : base(name) { }
        }

        internal class Mage : Player
        {
            public Mage(string name) : base(name) { }
        }

    }

