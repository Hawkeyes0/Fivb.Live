using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivbLive.Models
{
    public class MatchComparer : IEqualityComparer<Match>
    {
        public bool Equals(Match x, Match y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode(Match obj)
        {
            return obj.Id;
        }
    }
}
