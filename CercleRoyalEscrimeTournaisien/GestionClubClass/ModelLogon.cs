using System;

namespace WebApplication1.Models
{
    [Serializable]
    
    public class ModelLogon
    {
        public string UserName { get; set; }
        public string Password { get; set; }       
    }
}