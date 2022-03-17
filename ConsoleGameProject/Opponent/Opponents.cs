using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject.Opponent
{
    public interface IOpponent
    {
       string Name { get; }
       string Attack();

       
    }
}
