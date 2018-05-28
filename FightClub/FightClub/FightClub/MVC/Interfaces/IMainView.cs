using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IMainView : IMVCComponent
    {       
        void Log(string message);
        void SetLeftMaxLife(int i);
        void SetRightMaxLife(int i);
        void SetLeftLife(int i);
        void SetRightLife(int i);
        void SetLeftName(string name);
        void SetRightName(string name);
        void SetPhaseDefence();
        void SetPhaseAttack();

        void PickOutRightPlayer();
        void PickOutLeftPlayer();

        void CleanLog();

        
    }
}
