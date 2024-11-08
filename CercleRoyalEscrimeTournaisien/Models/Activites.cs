using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    public class Activites
    {
        public Activites()
        {
            //ListeDesActivites = @"<p class=""cssFormatDatePostage"">Posté le 01 mars 2019</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Dimanche passé, Antoine (Lemaire) participait à sa première compétition à l'épée à Ath." ;
            //ListeDesActivites += @"" + "Sans se décomposer ni montrer de stress, sauf un petit peu en demi finale et finale, il gagne tous ses matchs et termine 1er de la compétition." ;
            //ListeDesActivites += @"" + "";
            //ListeDesActivites += @"" + "Bravo Antoine, continue comme ça!!!" ;
            //ListeDesActivites += @"" + "";
            //ListeDesActivites += @"" + "A quand la prochaine? pour que tu nous remontres ton envie de gagner et ton (non) stress .." + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 01 septembre 2018</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Aujourd'hui, nous déménageons à l'école de Don Bosco." ;
            //ListeDesActivites += @"" + "";
            //ListeDesActivites += @"" + "Vous êtes les bienvenus les lundis et mercredis pour les enfants et les mercredis et dimanches pour les adultes." + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 05 novembre 2017</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Ce 25 octobre 2017, Antoine et Fabrice se battent ensemble. C'était un beau duel.." + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 04 novembre 2017</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Ce 21 octobre 2017, à la compétition de Lessines, Thomas et Victor se battent ensemble." + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 29 octobre 2017</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Ce 21 octobre 2017, Thomas et Victor ont commencé leur début en compétitions." ;
            //ListeDesActivites += @"" + "En effet, lors d'une compétition Pupilles mixte à Lessines, ils ont terminé 8ème (pour Victor) et 10ème (pour Thomas) sur 11." ;
            //ListeDesActivites += @"" + "C'est un bon début en matière surtout que c'était leur première compétition." ;
            //ListeDesActivites += @"" + "Les photos de la compét sont mises en ligne." + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 02 août 2017</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Le cercle reprendra ses cours après deux mois de congé le 4 septembre 2017 au hall sportif de l'école de Saint-André." ;
            //ListeDesActivites += @"" + "Adresse :" ;
            //ListeDesActivites += @"" + "  57, Chaussée de Tournai" ;
            //ListeDesActivites += @"" + "  7520 Ramegnies-Chin" + "</P>";
            //ListeDesActivites += @"" + @"<p class=""cssFormatDatePostage"">Posté le 28 avril 2017</p>";
            //ListeDesActivites += @"" + @"<P class=""cssCadrePostage"">" + "Le CRE de Tournai mis à l'honneur par Mati Pouilly.";
            //ListeDesActivites += @"" + "Avec un début difficile, Mati se bat dans une compétition relevée." ;
            //ListeDesActivites += @"" + "En changeant de catégorie, cette saison, il s'est rendu compte que c'était moins évident..." ;
            //ListeDesActivites += @"" + "Du coup, après 2 victoires et 1 presque victoire sur 6, il se classe 6 sur 7 au premier tour." ;
            //ListeDesActivites += @"" + "Il finit la compét à la 6ème place sur 7." ;
            //ListeDesActivites += @"" + "Le voici dans la catégorie pupille... Mais il n'a pas démérité!" + "</P>";
        }
        public List<ClassActivite> ActivitesList
        {
            get 
            {
                return new List<ClassActivite>() 
                { 
                    new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 01 mars 2019"
                    },
                    new ClassActivite()
                    {
                        IsTitre=false, Content = "Dimanche passé, Antoine (Lemaire) participait à sa première compétition à l'épée à Ath. Sans se décomposer ni montrer de stress, sauf un petit peu en demi finale et finale, il gagne tous ses matchs et termine 1er de la compétition. Bravo Antoine, continue comme ça!!! A quand la prochaine? pour que tu nous remontres ton envie de gagner et ton (non) stress .."
                    },
                    new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 01 septembre 2018"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Aujourd'hui, nous déménageons à l'école de Don Bosco. Vous êtes les bienvenus les lundis et mercredis pour les enfants et les mercredis et dimanches pour les adultes."
                    },
                      new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 05 novembre 2017"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Ce 25 octobre 2017, Antoine et Fabrice se battent ensemble. C'était un beau duel"
                    },
                       new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 04 novembre 2017"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Ce 21 octobre 2017, à la compétition de Lessines, Thomas et Victor se battent ensemble."
                    },     
                    new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 29 octobre 2017"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Ce 21 octobre 2017, Thomas et Victor ont commencé leur début en compétitions. En effet, lors d'une compétition Pupilles mixte à Lessines, ils ont terminé 8ème (pour Victor) et 10ème (pour Thomas) sur 11. C'est un bon début en matière surtout que c'était leur première compétition. Les photos de la compét sont mises en ligne."
                    },
                      new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 02 août 2017"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Le cercle reprendra ses cours après deux mois de congé le 4 septembre 2017 au hall sportif de l'école de Saint-André. Adresse : 57, Chaussée de Tournai 7520 Ramegnies-Chin"
                    },
                       new ClassActivite()
                    {
                        IsTitre=true, Content = "Posté le 28 avril 2017"
                    },
                     new ClassActivite()
                    {
                        IsTitre=false, Content = "Le CRE de Tournai mis à l'honneur par Mati Pouilly. Avec un début difficile, Mati se bat dans une compétition relevée. En changeant de catégorie, cette saison, il s'est rendu compte que c'était moins évident... Du coup, après 2 victoires et 1 presque victoire sur 6, il se classe 6 sur 7 au premier tour. Il finit la compét à la 6ème place sur 7. Le voici dans la catégorie pupille... Mais il n'a pas démérité!"
                    },
                };
            }
        }
    }

    public class ClassActivite
    {
        public bool IsTitre { get; set; }
        public string Content { get; set; }
        public ClassActivite()
        {
            IsTitre = false;
            Content = string.Empty;
        }
    }
}