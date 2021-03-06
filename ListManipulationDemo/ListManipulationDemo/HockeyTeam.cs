using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationDemo
{
    public class HockeyTeam
    {
        public string TeamName { get; set; }
        public List<HockeyPlayer> Players { get; set;}
        public HockeyTeam(string teamName)
        {
            TeamName = teamName;
            Players = new List<HockeyPlayer>
            {
                new HockeyPlayer {PlayerName="Leon Draisatil", GamesPlayed=46, Goals=33, Assists=32 },
                new HockeyPlayer {PlayerName="Connor McDavid", GamesPlayed=45, Goals=24, Assists=40 },
                new HockeyPlayer {PlayerName="Ryan Nugent-Hopkins", GamesPlayed=39, Goals=6, Assists=28 },
                new HockeyPlayer {PlayerName="Zach Hyman", GamesPlayed=40, Goals=14, Assists=13 },
                new HockeyPlayer {PlayerName="Jesse Puljujarvi", GamesPlayed=44, Goals=11, Assists=15 },
                new HockeyPlayer {PlayerName="Evan Bouchard", GamesPlayed=46, Goals=9, Assists=17 },
                new HockeyPlayer {PlayerName="Darnell Nurse", GamesPlayed=39, Goals=5, Assists=15 },
                new HockeyPlayer {PlayerName="Tyson Barrie", GamesPlayed=40, Goals=3, Assists=14 },
            };
        }
        public List<HockeyPlayer> RemovePlayersAt(int startIndex)
        {
            List<HockeyPlayer> splitttedPlayers = new();
            for (int index = startIndex; index < Players.Count; index++)
            {
                splitttedPlayers.Add(Players[index]);
            }
            Players.RemoveRange(startIndex, Players.Count - startIndex);
            return splitttedPlayers;
        }

        public List<HockeyPlayer> RemovePlayersByName(string playerName)
        {
            int indexofPlayerName = 0;
            for (int index = 0; index < Players.Count; ++index)
            {
                if (Players[index].PlayerName == playerName)
                {
                    indexofPlayerName = index;
                    index = Players.Count;
                }
            }
            return RemovePlayersAt(indexofPlayerName);
        }

    }
}
