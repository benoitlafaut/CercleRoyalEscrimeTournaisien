namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestToAjouterUneLeçonACeTireur
    {
        public string GuidTireur { get; set; }
        public string ArmeSelected { get; set; }
        public int NombreDeLeconsDejaRecues { get; set; }
    }
}