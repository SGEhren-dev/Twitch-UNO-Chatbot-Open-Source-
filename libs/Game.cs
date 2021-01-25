using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchUNO.libs
{ 
    enum GameState
    {
        PREGAME,
        STARTING,
        PLAYING,
        ENDING,
        REWARDING
    }

    class Game
    {

        GameState __currState;
        bool __doGame = false;

        List<TwitchUser> __usersInGame = new List<TwitchUser>();

        public Game()
        {
            this.__currState = GameState.PREGAME;                           //Start the game and place it into the pre-game state

            while(__doGame)                                                 //While do game is true
            {

            }
        }

        GameState GetCurrentState() { return __currState; }

        /// <summary>
        /// Force closes the game in case something were to happen i.e. Fatal Error or player has to leave
        /// </summary>
        /// <returns>0 for success, -1 if not successful</returns>
        int ForceGameClose()
        {
            this.__doGame = false;
            ShutdownGame();

            if (!__doGame)                                                  //Properly debug if the game was closed or not
                return 0;
            else
                return -1;
        }

        void AddPlayerToGameLobby(TwitchUser user)
        {
            this.__usersInGame.Add(user);
        }

        void RemovePlayerFromGame(TwitchUser user)
        {
            this.__usersInGame.Remove(user);
        }

        void ShutdownGame()
        {
            this.__currState = GameState.ENDING;
        }

        void GameCommand()
        {

        }
    }
}
