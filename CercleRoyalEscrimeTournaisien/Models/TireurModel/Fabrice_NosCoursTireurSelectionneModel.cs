﻿using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Fabrice_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Fabrice_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2024, 9, 22),
                        Arme = TypeArme.Fleuret,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    PointNégatif="Au fleuret, quand tu fais un batté, tu accentues l'attaque. là je vois 3 battés sans attaque. Du coup tu peux aller directement chercher la touche. pas besoin de laisser venir le tireur, c'est toi qui as l'avantage. Et on voit que tu sautes aussi avec les deux pieds en l'air en faisant la riposte à la fin de la vidéo.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice.avi"
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    PointNégatif="Je vois (à nouveau) que tu sautes aussi avec les deux pieds en l'air lors d'une attaque",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_2.avi",
                                    Frequency =3
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    PointNégatif="Utilise la flexibilité de la lame pour toucher avec le pouce à 3h, c'est mieux. Utilise le coupé horizontal pour toucher au lieu de toucher linéairement.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_3.avi"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositif="Le trompé est bien exécuté. la finalité n'est à mon avis qu'un détail de la gestion du fleuret. le fleuret est plus flexible que l'épée. du coup tu peux utiliser la flexibilité de la lame pour toucher de manière horizontale.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_3.avi"
                                },
                            }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 20),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    PointNégatif="une belle passe avant. non sanctionnée.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Fabrice.avi",
                                    Frequency = 2
                                },
                                 new RemarqueData()
                                {
                                  //  HasPointPositif=false,
                                    PointNégatif="une parade suivie d'une riposte. et pas de point? bizarre...",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Fabrice_2.avi",
                                },
                            }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}