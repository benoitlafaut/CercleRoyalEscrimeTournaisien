using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public  class Paiements_2023_2024
    {
        public  JoursDePrésence ChargerPresences()
        {
            JoursDePrésence joursDePrésence = new JoursDePrésence()
            {
                JourDePrésence = new List<JourDePrésence>()
                {
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,6,3),
                        EscrimeurId = new List<Guid>()
                        {

                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMartinSiu,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,6,2),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRaedwaldVercouter,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,31),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidMaybelleCarlier,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRaedwaldVercouter,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMartinSiu,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,27),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidMartinSiu,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,26),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidMaybelleCarlier,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,24),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidFabriceRazanajao,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,17),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidEvaDufrasne,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,5,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,26),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,14),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,12),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,10),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,7),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,4,5),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,27),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,25),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,24),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMaybelleCarlier,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,18),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,17),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,3,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidLeanderCle ,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,23),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,21),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux ,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,19),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,18),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,16),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,14),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,12),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,9),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,7),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,5),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,2,2),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidJordanMestdagh,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,31),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,26),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidFabriceRazanajao,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,24),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,21),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidRémiSoyez,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,19),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,14),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,12),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,10),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,1,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,17),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,15),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,10),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidArthurCouturiaux
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,8),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidRémiSoyez
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,3),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,12,1),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidRémiSoyez
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,26),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidFabriceRazanajao,
                              GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,24),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,20),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,19),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidEvaDufrasne,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,17),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,

                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,12),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,

                            GuidConstantes.GuidFabriceRazanajao,                            
                            GuidConstantes.GuidEvaDufrasne,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,10),
                        EscrimeurId = new List<Guid>()
                        {
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidArthurCouturiaux,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,11,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidArthurCouturiaux,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,10),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,17),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidMaybelleCarlier,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,18),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,20),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidLisaWaeselynck
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,24),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,25),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMargauxCourret,
                            GuidConstantes.GuidLeanderCle
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,9,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFabriceRazanajao,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,1),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidRémiSoyez,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,2),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,9),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle,
                            GuidConstantes.GuidMargauxCourret
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidMargauxCourret,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidLisaWaeselynck,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidRémiSoyez
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,16),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLeanderCle
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,18),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidCyrilLeclercq,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAbelMotte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2023,10,20),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                           GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidRémiSoyez,

                        }
                    },
                }
            };

            return joursDePrésence;
        }
        public  void Add_Paiements_Leclercq_Cyril(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Motte_Baptiste(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Motte_Abel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,6),
                        new DateTime(2023,9,8)
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Courret_Margaux(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,6),
                        new DateTime(2023,9,8)
                    },
                    IsMatérielLoue = true
                };
        }
     

        public  void Add_Paiements_Razanajao_Fabrice(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Dufrasne_Eva(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,10),
                        new DateTime(2023,9,8)
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Carlier_Maybelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Deblocq_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre=true,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Deblocq_Judith(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Barbery_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId ==GuidConstantes.GuidArthurBarbery && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId ==GuidConstantes.GuidArthurBarbery && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre =true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Waeselynck_Lisa(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
     
        public  void Add_Paiements_Soyez_Rémi(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                     IsLocationMatérielEnOrdre= true,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }
       
        public  void Add_Paiements_Cle_Leander(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsLocationMatérielEnOrdre = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    
                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,18),
                        new DateTime(2023,9,17),
                    },
                    IsMatérielLoue = true
                };
        }
       
      
       
       
        
        public  void Add_Paiements_Couturiaux_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,11,6),
                        new DateTime(2023,11,8),
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Mestdagh_Jordan(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,2,2),
                        new DateTime(2024,2,4),
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Siu_Martin(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,27),
                        new DateTime(2024,5,29),
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Vercouter_Raedwald(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2023_2024,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,31),
                        new DateTime(2024,6,2),
                    },
                    IsMatérielLoue = true
                };
        }  
    }
}