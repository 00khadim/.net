using System;
using System.Collections.Generic;

namespace BookStoreAPI.Entities

{
    public class Equipe
    {
        // ceci est une property
        public int Id { get; set; }
        public string nomEquipe { get; set; } = default!;
        //liste pilote equipe
        public List<string> Pilote {get;set;} = new List<string>(); 
       //nationaly Team
        public string Nationality { get; set; }= default!;
    }
}