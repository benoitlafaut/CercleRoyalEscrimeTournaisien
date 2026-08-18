using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class ClassPoule
    {
        public string Poule { get; set; }
        public string DescriptionDeLaPoule { get; set; }
        public bool Selected { get; set; }
    }
    public class ClassTireur
    {
        public string Tireur { get; set; }
        public string JourDeLaPoule { get; set; }
        public string PouleAttribuee { get; set; }
        public string DateDeNaissance { get; set; }
        public bool IsSelected { get; set; }
    }
    public class ClassAge
    {
        public string Tireur { get; set; }
        public int Age { get; set; }
    }
    public class ClassDatesPourToutesLesPoules
    {
        public string DateDeLaPoule { get; set; }
        public string Arme { get; set; }
    }
    public class ClassPoulesDuJour
    {
        public Guid TireurGuid { get; set; }
        public string Poule { get; set; }
        public string Tireur { get; set; }
        public string DateDeLaPoule { get; set; }
    }
    public class ClassStatistiqueTireur
    {
        public ClassStatistiqueTireur()
        {
            Matchs = new List<StatistiqueMatch>() { };
        }
        public Guid TireurGuid { get; set; }
        public string Tireur { get; set; }
        public string DateDeLaPoule { get; set; }
        public string ArmePratiquee { get; set; }
        public List<StatistiqueMatch> Matchs { get; set; }
    }
    public class StatistiqueMatch
    {
        public string Poule { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string TireurAdversaire { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
    }
    public class ClassScore
    {
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Poule { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
        public int QuestionMeneOuNon { get; set; }
    }
    public class ClassScoreEliminationsDirectes
    {
        public string DateDeLaPoule { get; set; }
        public string PouleSelected { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Round { get; set; }
        public string IndexTireur1 { get; set; }
        public string IndexTireur2 { get; set; }
        public string Tireur1Name { get; set; }
        public string Tireur2Name { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
        public bool ScoreDejaIntroduit { get; set; }
    }
    public class ClassRound
    {
        public string DateDuJourWithoutDay { get; set; }
        public string PouleSelected { get; set; }
        public string Round { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Tireur1Name { get; set; }
        public string Tireur2Name { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
        public int IndexTireur1 { get; set; }
        public int IndexTireur2 { get; set; }
    }
    public class MatchFencer
    {
        public int Round { get; set; }
        public int Seed1 { get; set; }
        public int Seed2 { get; set; }
    }
}
