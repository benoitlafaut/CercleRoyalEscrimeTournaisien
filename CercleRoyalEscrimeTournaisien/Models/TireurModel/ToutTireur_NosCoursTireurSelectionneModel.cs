using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ToutTireur_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public ToutTireur_NosCoursTireurSelectionneModel() : base()
        {
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
                        DateRemarque = new DateTime(2025,11,7),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Voici quelques questions à se poser après chaque match... " + "<br/>" +"<br/>" +
                                         "Je ne vous oblige pas à vous les poser systématiquement mais à vous faire réfléchir, à vous faire progresser." + "<br/>" +"<br/>" +
                                         "Que faut-il retenir de mon match/assaut ?" + "<br/>" +"<br/>" +
                                         "" + "<br/>" +"<br/>" +
                                         "Est-ce que j’ai utilisé mes 3 minutes ou 9 minutes judicieusement, de manière intelligente ?" + "<br/>" +"<br/>" +
                                         "Où ai-je été touché ?" + "<br/>" +"<br/>" +
                                         "  Combien de fois par endroit ?" + "<br/>" +"<br/>" +
                                         "  Etais-je en attaque ou en défense ?" + "<br/>" +"<br/>" +
                                         "  Est-ce que j’étais bien en garde ?" + "<br/>" +"<br/>" +
                                         "  Est-ce que ma main armée était à la même hauteur que mon épaule quand j’allongeais mon bras?" + "<br/>" +"<br/>" +
                                         "Est-ce que je fais souvent la même action ?" + "<br/>" +"<br/>" +
                                         "Est-ce que mon adversaire essaie de toucher au même endroit plusieurs fois d’affilée ?" + "<br/>" +"<br/>" +
                                         "Est-ce que je tombe toujours trop court ? Il manque 10 cm trop court pour la touche." + "<br/>" +"<br/>" +
                                         "Est-ce que je vais plus lentement que mon adversaire ?" + "<br/>" +"<br/>" +
                                         "Est-ce que je casse le rythme ? tantôt je vais lentement tantôt rapidement ?" + "<br/>" +"<br/>" +
                                         "Est-ce que j’attaque quand je mène de 2 3 touches ?" + "<br/>" +"<br/>" +
                                         "Est-ce que j’utilise ce qui me permets de gagner très souvent ?" + "<br/>" +"<br/>" +
                                         "Est-ce que je note dans mon cahier mes résultats, mes réponses aux questions ci-dessus pour le futur ?" + "<br/>" +"<br/>" +
                                         "Quel est mon point fort, mon point faible ?" + "<br/>" +"<br/>" +
                                         "  Quel est son point fort, son point faible ?" + "<br/>" +"<br/>" 
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,10,11),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quelques points d'attention à mettre en avant: " + "<br/>" +"<br/>" +
                                         "Quand vous tirez avec un adversaire plus faible ou moins expérimenté, c'est là que vous pouvez vous permettre de vous mettre des défis:" + "<br/>" +"<br/>" +
                                         "Par exemple, toucher aux avancées (manchette, saignée)." + "<br/>" +"<br/>" +
                                         "Ou prendre le temps de faire un match en 3 minutes" + "<br/>" +"<br/>" +
                                         "Ou de vous mettre en mode défenseur si vous êtes plus attaquant ou l'inverse en mode attaquant si vous êtes plus défenseur." + "<br/>" +"<br/>" +
                                         "Utilisez toute la piste, elle fait 14 mètres. Laissez venir votre adversaire en reculant." + "<br/>" +"<br/>" +
                                         "N'ayez pas peur d'écrire dans vos cahiers tout enseignement que l'on vous dit. tout score aussi, toute constatation faite par vous ou qqn d'autre." + "<br/>" +"<br/>" +
                                         "Quand vous restez bloquer dans le fer adverse, ne restez pas dans cette position trop longtemps ou anticipez ce blocage par un dégagement. Généralement quand on reste bloquer ainsi, c'est celui qui sera plus fort ou plus rapide qui aura le point." + "<br/>" +"<br/>" +
                                         "A l'escrime, on bouge mais on prend aussi des initiatives. j'en vois régulièrement qui attendent que l'autre fasse le premier pas. Non, osez attaquer en premier! Prenez l'initiative de l'attaque quand l'autre ne s'y attend pas."
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,10,11),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quelques règles de sécurité à lire ou relire: " + "<br/>" +"<br/>" +
                                         "La pointe est toujours dirigée vers le bas lorsqu'on ne tire pas." + "<br/>" +"<br/>" +
                                         "Un tireur tire avec un masque." + "<br/>" +"<br/>" +
                                         "On ne touche pas son fils de corps/câble, son arme ou son masque quand on tire." + "<br/>" +"<br/>" +
                                         "L'arme est déposée complètement sur le sol quand elle n'est pas utilisée." + "<br/>" +"<br/>" +
                                         "On salue son adversaire ainsi que l'arbitre avant et après chaque assaut, en même temps. Et on lui serre la main." + "<br/>" +"<br/>" ,
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,9,5),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous voulez participer à une compétition ?" + "<br/>" +"<br/>" +
                                         "Fabrice a créé un document pour vous." +   "<br/>" +"<br/>" +
                                         "Voici son contenu :" +   "<br/>" +"<br/>" +
                                         "Infos pratiques" +   "<br/>" +   "<br/>" +
                                         "Dans chaque compétition, il y a des vestiaires avec des douches et des WC. L’idéale sera de regrouper les affaires de notre club au même endroit dans la salle." +   "<br/>" +
                                         "Pour nos supporters (parents, amis, etc.), Il y a généralement une buvette et de quoi acheter à manger et à boire." + "<br/>" +
                                         "Durant la matinée, on fait les phases de poules (match en 4 touches ou en 5 touches selon la catégorie)" + "<br/>" +
                                         "Après la pause du midi, on fait les matchs éliminatoires (en 10 touches ou en 15 touches )." + "<br/>" +
                                         "Si on tire toutes les places, alors cela peut prendre quasi toute l’après-midi. Cela dépend également du nombre d’inscrits." + "<br/>" +
                                         "Durant la compétition, il y a un vendeur de matériel mais pas systématiquement." +   "<br/>"  + "<br/>" +
                                         "Les affaires" +   "<br/>" +   "<br/>" +
                                         "Evidement, votre tenue d’escrime : protège-poitrine, pantalon, veste, sous-veste, gant, fils de corps, t-shirts, chaussures et chaussettes hautes. Prenez un petit essuie et de quoi vous préparer si vous le voulez (baume pour les muscles, pansement, etc). Il y a des douches dans les vestiaires, prenez vos affaires pour vous laver si vous voulez." +   "<br/>" +
                                         "Libre à vous de prendre de quoi manger et boire. L’idéale est d’avoir un biscuit, un fruit ou une boisson entre les matchs mais faites attention à ne pas trop manger. Sinon, vous sentirez votre estomac en tirant." +   "<br/>" +"<br/>" +
                                         "Présence" +   "<br/>" +   "<br/>" +
                                         "En entrant dans le bâtiment, présentez-vous à la table d’appel. Donnez votre nom, votre catégorie et l’arme. Il y a une contribution monétaire pour les compétiteurs de 15 à 20€ (dépendant de la compétition) en liquide. Essayez d’arriver 30 minutes avant le dernier appel (l’horaire de la compétition est sur le groupe WhatsApp ou distribué à chacun des compétiteurs). Un accompagnant sera dans la salle avec le reste de votre matériel."+   "<br/>"  +   "<br/>" +
                                         "Echauffement" +   "<br/>" +   "<br/>" +
                                         "Vous pouvez le faire seul avec votre masque ou en groupe. En général, on fait des aller-retour le long d’une piste. Vous faites un échauffement classique (talons aux fesses, les bras, flexions, etc); Insistez  bien sur le poignet, les chevilles et les adducteurs. Ensuite, le long d’une piste et sans l’arme, faites des marchés/rompés avec des marché-fentes. Le but n’est pas d’être le plus rapide, vous devez être capable de parler normalement durant l’échauffement. L’idéale serait de finir 5 minutes avant le début. Si vous voulez, vous pouvez faire des matchs d’échauffement entre vous. Il est important aussi de s'échauffer avant la reprise des assauts après chaque longue période d'arrêt." +   "<br/>" +"<br/>" +
                                         "Phase de poules" +   "<br/>" +   "<br/>" +
                                         "Il y aura des affiches avec tous les groupes, à vous de trouver votre nom et la piste. Pour les grands, vous vous auto-arbitrez comme à l’entrainement selon la compétition. Quand tous les tireurs d’une poule sont présents sur la piste, la poule est lancée. Selon la formule utilisée par l'organisateur de la compétition, on peut avoir une ou deux phases de poule. La première est totalement aléatoire et la seconde dépend du résultat de la première. Attention à la deuxième, généralement on vous aura vu tirer lors de la première poule et on saura comment vous réagissez." +   "<br/>" +"<br/>" +
                                         "Match de poule" +   "<br/>" +   "<br/>" +
                                         "Pour les plus grands, Il y a des chances pour que vous soyez l’arbitre. Dans ce cas, faites les choses proprement (gestuelles, mots et notations des points). Arbitre ou tireur, faites attention à la vérification du matériel. Vous devez avoir votre gourde, essuie, fils de corps de secours et deux armes." + "<br/>" +"<br/>" +
                                         "Comment vérifier l'arme ?" +   "<br/>" +"<br/>" +
                                         "Présence des deux petites vis"+   "<br/>" +"<br/>" +
                                         "Poids sur la pointe : appuyez et la lumière doit rester éteinte après qu'elle se soit allumée"+   "<br/>" +"<br/>" +
                                         "Grande jauge : doit passer partout sous la pointe"+   "<br/>" +"<br/>" +
                                         "Petite jauge : appuyez et ça ne doit pas s’allumer"+   "<br/>" +"<br/>" +
                                         "Si cela arrive, l'arbitre mettra l’arme ou le câble de côté et dites-le à l'encadrant. Votre matériel a un problème dès le début d'un assaut, il y a carton jaune. Entre vos matchs, vous avez l’occasion d’observer les autres. Essayez de trouver leurs points faibles et leurs points forts, c’est un grand avantage pour vous. "+   "<br/>" +"<br/>" +
                                         "Fin de la poule" +   "<br/>" +   "<br/>" +
                                         "Après le dernier match, il faut signer la feuille de poule. Regardez bien qu’il n’y ait pas d’erreur dans vos points (généralement on le fait régulièrement pour intervenir quand c'est encore frais dans la tête de l'arbitre). C’est à ce moment qu’on fait la pause du midi pour manger mais restez attentif aux diverses annonces." +   "<br/>" +"<br/>" +
                                         "Phase éliminatoire" +   "<br/>" +   "<br/>" +
                                         "Soit on tire toutes les places, soit c’est élimination directe. C’est en 10 ou 15 touches avec trois fois * trois minutes. Lorsqu’il n'y a aucune touche pendant 1 minute, on passe au tiers temps suivant. Comme pour la poule, les matchs seront affichés sur un mur. Trouvez le votre et la piste. Il est intéressant de regarder les performances de votre adversaire durant la poule. L’idéal est de faire un petit échauffement pour se remettre dans le bain à la reprise." + "<br/>" +"<br/>" +
                                         "Conseil pour les matchs" +   "<br/>" +   "<br/>" +
                                         "Pour les spectateurs" +   "<br/>" +   "<br/>" +
                                         "Vous pouvez venir en bout de piste sans déranger les autres. Un match d’escrime, c’est comme un match de tennis. Les encouragements et le coaching se font après les touches ou pendant les pauses. Evitez tous mouvements pouvant déconcentrer l’adversaire et les flashs. Ce serait bien de filmer les tireurs afin qu’il puisse comprendre leur escrime et voir les avantages et les défauts."+   "<br/>" +
                                         "Pour les tireurs" +   "<br/>" +   "<br/>" +
                                         "Appliquer les conseils du maître Lafaut. Ne pas partir défaitiste, rester calme et réfléchir. Ne râlez pas, réfléchissez sur ce qui s’est passé : comment il a eu le point, comment il réagit, il est rapide ou il fonce sans réfléchir, ... Exprimez vos émotions, célébrez quand vous avez mis un beau point et évitez de crier un gros mots en français même si c’est contre vous. N’oubliez pas les bonnes manières. On salue l’adversaire et l’arbitre et on serre la main peu importe ce qui s’est passé. C’est aussi l’occasion de faire des rencontres et des amis, les plus expérimentés vous donneront un feedback avec plaisir. Soyez sûr d’avoir un message de maître Lafaut, il demandera surement comment ça s’est passé et ce que vous avez appris. Venez avec un objectif, il y aura tous les niveaux. " + "<br/>" 
                                         + "Voici quelques exemples :"+   "<br/>" +
                                         "Découvrir les compétitions d’escrime" +   "<br/>" +
                                         "S’amuser, se défouler" +   "<br/>" +
                                         "S’améliorer, apprendre des autres et mieux se connaître" +   "<br/>" +
                                         "Donner le maximum de soi" +   "<br/>" +
                                         "Gagner (c’est très amical donc disons que c’est un objectif secondaire)" +   "<br/>" +"<br/>" +
                                         "Fin de la compétition" +   "<br/>" +   "<br/>" +
                                         "A la fin, nous serons invités à assister à la grande finale suivie d’une remise des prix. Il y en aura une pour chaque catégorie selon la compétition. Selon le nombre de participants, les filles peuvent être amenées à tirer contre les garçons. Dans ce cas, il y aura une remise de prix filles et garçons." +   "<br/>" +"<br/>" +
                                         "Conclusion" +   "<br/>" +   "<br/>" +
                                         "Concernant les matchs, il y aura surtout des appareils avec uniquement les lumières OU les lumières et le score. Il existe des applications pour avoir un tableau de score avec chrono. Respecter le matériel ! On ne lâche pas le câble, on ne redresse pas son arme sur la piste et on ne tape pas les appareils. Quand je tire avec des gens que je connais, ils ont un style de jeu bien différent qu’à l’entrainement. Même si c’est amical ou votre première fois, c’est l’occasion de cultiver votre esprit de compétitions. Bien qu’il n’y ait pas d’entrainement, ce sera bien de faire un peu de sport (attention aux courbatures). Libre à vous de chercher des vidéos youtube sur l’escrime pour voir des techniques, des conseils ou ressentir l’atmosphère d’une compétition. Il y a ce genre de vidéos sur le site du club. Lisez les remarques vous concernant sur le site. En cas de questions, Rémy, Fabrice et maître Lafaut restont à votre disposition. Bon courage pour la compétition !"
                                ,
                            },
                        }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,8,20),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Après avoir regardé quelques fois les assauts des tireurs lors du championnat du Hainaut, j'ai plusieurs constatations à émettre:" + "<br/>" + "<br/>" +
                                "Certains font des battés avant de toucher. A l'épée, le batté sert surtout à ouvrir la ligne lors de l'attaque. Si vous êtes assez proche de votre adversaire, les jambes avec le bras allongé suffisent. pas besoin de faire un batté.<br/>" +
                                "Le bras est la première chose à bouger lors d'une attaque mais aussi la dernière chose à bouger lors d'une retraite. Si vous êtes trop proche de votre adversaire, utilisez d'abord vos jambes pour vous remettre à bonne distance de lui et puis fléchissez le bras armé.<br/>" +
                                "<br/>" + "Comment savoir si l'on est trop près de son adversaire à l'épée?"  + "<br/>" +
                                "Lorsque votre pointe dépasse de 10 cm sa pointe, vous êtes trop proche. Soit vous vous remettez à bonne distance, soit vous attaquez en mettant la touche." + "<br/>" + "<br/>" +
                                "Durant l'année passée, sur les coups au sol (une fois ou deux fois), je vous demandais de faire un marché avant la fente ou une première fente suivie d'une deuxième fente (redoublement). Tout cà dans le but de faire ce premier déplacement très important." + "<br/>"  +
                                "Je vois sur les vidéos, que vous essayez de faire juste la fente pour toucher. Utilisez ce premier déplacement (marché ou 1ère fente) pour vous rapprocher de votre adversaire." + "<br/>" +  "<br/>" + 
                                "Comment casser la distance? j'entends par là, vous rapprocher de votre adversaire sans qu'il s'en aperçoive ??" + "<br/>" + "<br/>" +
                                "Un des exemples tactiques qu'on apprend c'est tout simple faites deux déplacements chez vous : une petite retraite suivie d'un marché plus long et vous venez de casser la distance..." + "<br/>" +
                                "Cela marche aussi pour la petite passe arrière suivie d'une passe avant plus grande." + "<br/>" + "<br/>" +
                                "Bien sûr ce genre de manoeuvre doit être fait très discrètement, pas souvent, de façon à endormir votre adversaire. je suis sûr que si vous prenez la peine et le temps de le faire chez vous régulièrement, cà deviendra une habitude." + "<br/>" +
                                "petite retraite, grand marché, suivi d'un marché-fente avec le bras qui s'allonge avant le marché ou même (pour les plus expérimentés) pendant le marché. " + "<br/>" +
                                "c'est un exercice qui une fois assimilé, on le fait de manière naturelle. Beaucoup de déplacements, s'ils sont faits souvent, deviennent naturellement effectués." + "<br/>" + "<br/>" +
                                "Pour résumer sur ce que j'ai vu, les victoires ne sont jamais acquises. On peut être fort étonné de nos exploits. Il faut croire en vous. Prenez le temps de tirer. 3 minutes c'est très long." + "<br/>" + "C'est à la salle que vous pourrez gérer votre patience à attendre le bon moment et à gagner avec le temps. " + "<br/>" + "Ouvrez les yeux à la salle comme à la compétition. Beaucoup de touches simples sont faites par les autres, il faut juste reprendre leur stratégie à votre avantage."
                                ,
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,6,28),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Petits points d'attention...</br>Vous tirez contre qqn de plus grand? fléchissez vos jambes, descendez votre pointe pour partir avec une pointe basse, laissez le venir et touchez aux avancées (la manchette).</br>Mon adversaire est plus rapide que moi..!! Prenez le fer adverse pour qu'il ne me vise pas et attaquez le premier.</br>Je mène de deux touches et mon adversaire n'a pas l'air d'attaquer? Laissez le temps défiler, je prends de la distance. je fais de temps en temps des battés pour dire ehh je suis encore là. La piste fait 14 mètres de long, servez-vous en.<br/>N'oubliez pas le petit marché avant la fente. Le bras qui s'allonge est à faire avant la fin du marché.</br>Ne fléchissez pas le bras lors de l'attaque.</br>Ne regardez pas l'appareil lors de l'assaut. Vos oreilles sont là pour entendre les haltes de l'arbitre.</br>Quand vous attaquez, allez jusqu'à la touche sans s'arrêter. Et si par erreur vous stoppez l'attaque, reculez pour reprendre de la distance par rapport à votre adversaire.",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,6,28),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Hello hello,</br>La veille d'une compétition ou d'un assaut, je répète souvent les mêmes observations.</br>Prenez votre temps lors de chaque assaut.</br>Vous avez 3 minutes en poule et 3 x 3 minutes en assaut après les poules pour gagner.</br>Une victoire 3-1 est tout autant une victoire que 15-14.</br>Quand vous avez une stratégie qui marche, faites la régulièrement mais pas trop souvent.</br>Prenez le temps d'observer et d'avoir une stratégie pour gagner.</br>C'est en regardant les autres tirer qu'on peut savoir leurs défauts.</br>Quand vous êtes appelé(e) sur la piste ou à chaque reprise d'assaut, vous devez avoir deux fils de corps et deux armes opérationnels.</br>Si vous avez un doute sur la qualité de l'arme pendant un match (arme défectueuse ou autre), n'hésitez pas à changer d'arme rapidement.</br>Vous n'êtes pas obligé(e) d'attendre la fin du match pour changer d'arme.</br>Dans chaque compétition, il y a un espace où la liste des inscrits et la liste des résultats sont affichés.</br>Ces listes peuvent être format papier ou support écran selon la compétition.</br>N'attaquez pas comme un taureau et ne baissez pas les bras avant la fin de l'assaut.</br>Chaque assaut se finit au halte de l'arbitre.</br>Vérifiez chaque score à la fin de chaque assaut et surtout en signant la feuille de poule auprès de l'arbitre à la fin de tous les assauts d'une poule.</br></br>Amusez-vous... et ayez confiance en vous..",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les attaques simples et composées au sabre : <a class='divUnderline' target='_blank' href='https://youtu.be/QxGMfZA2-Ak?si=u0P0CNRu-jZ4PXQZ'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les attaques simples au fleuret : <a class='divUnderline' target='_blank' href='https://youtu.be/CbeKK_atvQY?si=-uCgz2wm5rsjaLBs'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les positions de main au fleuret et au sabre, en passant par l'explication sur la pronation et supination : <a class='divUnderline' target='_blank' href='https://youtu.be/mFYFQ8clY80?si=RPqvkcx_5I_zaEvE'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,3,30),
                        Arme = TypeArme.Sabre,                        
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur l'arbitrage au sabre du Maître Poizat du club du sabre noir (club liégeois) : <a class='divUnderline' target='_blank' href='https://youtu.be/0oKOLPpB8bg?si=sx0bkd0458HfpI1i'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,9,1),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Si vous menez, utilisez le chrono à votre avantage. Laissez le défiler en prenant vos distances.",
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Ayant remarqué cela plusieurs fois et récemment (en décembre), je rappelle à tout le monde que vous êtes protégés de la tête au pied. Du coup, évitez de mettre votre main non armée devant votre corps. Je parle surtout pour celles qui ont peur de recevoir un coup d'épée (Héloïse, Anaëlle, Mathilde, Maé, ...).",
                                Frequency = 7
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="A l'épée, oubliez les combats de capes et d'épées à la Zorro ou les mousquetaires. L'arme est toujours dirigée vers la manchette ou la saignée avec la coquille qui protège votre avant-bras. Et l'arme n'est pas pointée ni vers les étoiles ni vers les mouettes ni même vers les fourmis par terre. Passez en dessous de la coquille quand il y a tentative de prendre votre fer par votre adversaire. Je passe en dessous de la coquille et j'allonge un peu le bras vers la manchette/saignée."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="A l'épée, lorsque vous attaquez, allongez le bras et laissez le allonger. Mais en défense, quand vous subissez une attaque, fléchissez votre bras; une fois le fer adverse écarté d'une surface valable, attaquez en allongeant le bras progressivement vers une surface valable."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Lorsque vous attaquez à l'épée, c'est votre bras armé votre point fort. Si vous le fléchissez lors de l'attaque, vous perdez un avantage. laissez-le allonger jusqu'à la touche."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="A chaque touche et point accordé, exclamez-vous par un yes ou 'come on à la Kim clijsters tenniswoman belge' pour vous donner du peps, ou déstabiliser votre adversaire. Cà vous aidera à prendre confiance en vous et à vous motiver pour remonter le score une touche à la fois si vous êtes en train de perdre."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Au début d'un assaut et à la fin d'un assaut, on salue son adversaire ainsi que l'arbitre en position préparatoire avec son arme. On lui serre la main à la fin de l'assaut. Quand il s'agit de rencontre entre 2 équipes, on se salue au début mais aussi à la fin et tous les tireurs de chaque équipe se mettent sur leur ligne de mise en garde et se saluent en même temps de la position préparatoire. Après les tireurs serrent la main de tous leurs adversaires de l'autre équipe."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Quand on tire, on ne regarde pas l'appareil. L'arbitre est là pour arrêter le match si il y a eu touche."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quand l'arbitre suit l'assaut, il doit se trouver entre les deux tireurs. Et ne pas rester devant l'appareil. Il suit le match de telle sorte qu'il voit les deux tireurs ainsi que l'appareil en même temps."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="En fente, les deux pieds sont sur le sol. et même quand on essaie de toucher en fente, les deux pieds restent sur le sol."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quand nous avons un doute sur notre arme ou fil de corps ou tout autre matériel, du genre mais j'ai touché mais l'appareil n'a pas sonné. Il faut lever la main non armée, attendre que l'arbitre arrête l'assaut, présenter la pointe de l'arme à l'arbitre. S'il y a problème de matériel, fil de corps défectueux ou arme qui ne fonctionne plus, le tireur doit changer d'arme ou de fil de corps, la touche qui était douteuse (si il y en a une) est annulée et l'assaut reprend là où il y a eu arrêt du combat. Le contrôle de la coquille doit se refaire sur l'arme qui a été changée à l'épée. Même chose pour les plastrons fleuret ou sabre, si un fil de corps a été changé, le test des plastrons est à refaire."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Parfois en regardant une vidéo, il se peut que l'image ne soit pas droite. Du coup, vous devez tourner la tête pour regarder la vidéo. Pour ma part, j'utilise le programme vlc. C'est, pour ceux qui ne le connaissent pas, un lecteur de vidéo; et dans vlc nous pouvons remettre l'image droite. En allant dans Outils puis Effets et filtres, puis dans le popup dans Effets Vidéos/Géométrie et puis sélectionner Transformation. Désolé d'avance pour ce chipotage-là."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque ="Beaucoup de tireurs font des marchés ou rompés ou tout autre déplacement excepté la fente en rapprochant leurs pieds l'un de l'autre. Exercez-vous chez vous à garder la même distance entre les pieds après chaque déplacement. Sur la vidéo ci-jointe, on voit l'erreur chez les deux tireurs.",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/Probleme de distance entre les pieds.avi",
                                UrlYoutubeVideo = "AJLi3Z6aaro"
                            },
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }

    }
}