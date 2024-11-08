using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Elodie_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Elodie_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(new List<RemarqueParDate>()
                {
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 9, 20),
                        Arme = TypeArme.Fleuret,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                                {
                                    new RemarqueData()
                                    {
                                        //HasPointPositif=false,
                                        PointNégatif="Deux petites choses dans la vidéo. la première c'est décrire ce que tu vois en tant qu'arbitre (je sais c'est dur) mais ici je vois une parade de Rémi et la riposte non valable. et pour la dernière action, c'est attaque d'Arthur car Rémi ne bouge pas. C'est Arthur qui attaque. Du coup on ne regarde pas celui qui allonge le bras en premier mais celui qui est à l'attaque. Ici Rémi est statique et Arthur va chercher la touche en marchés fente. c'est lui qui attaque.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-09-2024_Elodie.avi"
                                    },
                                }
                    }
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}