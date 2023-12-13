using System;
using System.Collections.Generic;

namespace BookStoreAPI.Entities

{
    public class Formula1Team
    {

      
        // ceci est une property
         public int Id { get; set; }
        public string nomEquipe { get; set; }= default!;
        public List<string> Pilote { get; set; } = new List<string>(); // Liste des pilotes de l'équipe
        

    }
}