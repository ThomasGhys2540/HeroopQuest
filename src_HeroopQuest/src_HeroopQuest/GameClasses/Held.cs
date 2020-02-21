using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public Held HeldType (HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case GameClasses.HeldType.Barbaar:
                    AanvalsDobbelstenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case GameClasses.HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case GameClasses.HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case GameClasses.HeldType.Tovenaar:
                    AanvalsDobbelstenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            Huidigintelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }
        public string Naam { get; set; }
        public HeldType HeldType { get; set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get; private set; }
        public int Huidigintelligentie { get; set; }
        public int MaxLichaam { get; private set; }
        public int HuidigLichaam { get; set; }
        public int AanvalsDobbelstenen { get; private set; } = 2;
        public int VerdedigingsDobbelstenen { get; private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;

    }
}
