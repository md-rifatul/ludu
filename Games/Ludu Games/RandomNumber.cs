using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludu_Games
{
    public class RandomNumber
    {
        public string Genarate()
        {
            return new Random().Next(1,6).ToString();
        }
    }
}
