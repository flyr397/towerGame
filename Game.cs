using System;
using static System.Console;

namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            #region Exception Handling 
            try
            {
                Path path = new Path(
                    new[] {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    }
                );
                #region Commented Out 

                //Invader invader = new Invader();
                //MapLocation location = new MapLocation(0, 0, map);

                //invader.Location = location;

                //location = invader.Location;

                //MapLocation location = path.GetLocationAt(8);

                //if(location != null)
                //    WriteLine(location.X + "," + location.Y);
                #endregion

                IInvader[] invaders =
                {
                    new SheildedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new SheildedInvader(path),
                    new BasicInvader(path),
                    new ResurectingInvader(path)
                };

                Tower[] towers =
                {
                   new Tower(new MapLocation(2, 4, map)),
                   new Tower(new MapLocation(2, 3, map)),
                   new PowerTower(new MapLocation(3, 3, map)),
                   new SniperTower(new MapLocation(5, 3, map)),
                   new FastTower(new MapLocation(6, 3, map))
                };

                Level level = new Level(invaders);

                level.Towers = towers;

                bool playerWon = level.Play();

                WriteLine("Player" + (playerWon ? " won" : " lost"));


            }
            catch (OutOfBoundsException ex)
            {
                WriteLine(ex.Message);
            }
            catch (DefenseException)
            {
                WriteLine(" Unhandled DefenseException ");
            }
            catch (Exception ex)
            {
                WriteLine("Unhandled Exception: " + ex);
            }
            #endregion
        }
    }
}