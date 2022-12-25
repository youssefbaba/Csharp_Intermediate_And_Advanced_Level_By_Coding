
using System.Windows.Markup;

namespace Object_Initializer_Test3
{
    public class BaseBallTeam
    {
        /*
         - BaseballTeam class that uses an indexer to get and set players at different positions.
         - The initializer can assign players, based on the abbreviation for the position, or the number used for each position baseball scorecards ( 1 --> 9 ) 
         */

        // Fields
        private string[] _players = new string[9];
        private readonly List<string> _positionAbbreviations = new List<string>
        {
            "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
        };

        // Indexers
        public string this[int positionNumber]
        {
            get
            {
                return _players[positionNumber - 1];
            }
            set
            {
                _players[positionNumber - 1] = value;
            }
        }
        public string this[string positionAbbreviation]
        {
            get
            {
                return _players[_positionAbbreviations.IndexOf(positionAbbreviation)];
            }
            set
            {
                _players[_positionAbbreviations.IndexOf(positionAbbreviation)] = value;
            }
        }
    }
}
