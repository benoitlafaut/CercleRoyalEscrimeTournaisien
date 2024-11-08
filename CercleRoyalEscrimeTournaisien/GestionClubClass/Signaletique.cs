using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum Categorie
    {
        U11, U13, U15, U17, U20, U23, Senior, Vétéran_40, Vétéran_50, Vétéran_60, Vétéran_70, Inconnu
    }
    public enum Groupe
    {
        [Description("I")]
        One = 1,
        [Description("II")]
        Two = 2
    }

    
    public class Signaletique
    {
        public Guid EscrimeurId { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public Categorie Categorie { get; set; }
        public List<string> Telephone { get; set; }
        public List<string> Email { get; set; }
        public string NomMaman { get; set; }
        public string NomPapa { get; set; }
        public string FicheSignaletiqueUrl { get; set; }
        public List<string> Groupe { get; set; }
    }    
}