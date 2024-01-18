using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dbz_power_levels_to_yugioh_attack_and_defense_converter_2
{
    public class CharacterOrMonster
    {
    public double ATKPoints { get; set; }
    public double DEFPoints { get; set; }
    public string Name { get; set; }
    public double PowerLevel { get; set; }
    public bool IsTheStrongestCharacterInHisDeck { get; set; }
    public bool IsTheWeakestCharacterInHisDeck { get; set; }
    public Deck TheDeckThisGuyBelongsTo { get; set; }

        public CharacterOrMonster()
        {
            ATKPoints = 0.1;
            DEFPoints = 0.1;
            Name = "";
            PowerLevel = 0;
            IsTheStrongestCharacterInHisDeck = false;
            IsTheWeakestCharacterInHisDeck = false;
        }

    }
}
