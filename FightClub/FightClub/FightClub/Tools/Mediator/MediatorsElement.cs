using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class MediatorsElement
    {
        IMediator Mediator;
        public MediatorsElement(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
