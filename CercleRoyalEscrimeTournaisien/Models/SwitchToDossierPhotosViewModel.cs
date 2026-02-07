using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class SwitchToDossierPhotosViewModel
    {
        public SwitchToDossierPhotosViewModel() 
        {
        }       
   
        public Guid SwitchToDossierPhotosGuid { get; set; }

        public List<string> ImagesPath
        {
            get
            {
                string pathDossier = HttpContext.Current.Server.MapPath(GetDossierWithGuid());
                var urls = Directory.GetFiles(pathDossier).Select(f => GetDossierWithGuid() + "/" + Path.GetFileName(f)).ToList();
                return urls.ToList();
            }
        }
        public List<string> ImagesWithoutDossierPath
        {
            get
            {
                string pathDossier = HttpContext.Current.Server.MapPath(GetDossierWithGuid());
                var urls = Directory.GetFiles(pathDossier).Select(f => Path.GetFileName(f)).ToList();
                return urls.ToList();
            }
        }
        private string GetDossierWithGuid()
        {
            switch (SwitchToDossierPhotosGuid)
            {
                case var g when g == GuidConstantesImages.GuidRonseFévrier2026:
                    return "/home/photos/RonseFévrier2026";
                default:
                    return string.Empty;
            }
        }
    }  
}