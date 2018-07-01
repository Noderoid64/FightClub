﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IModelMenu : IMVCElement
    {
        void ShowLogWindow();
        void ShowPlayersWindow();
        void CreateNewPlayers();
    }
}