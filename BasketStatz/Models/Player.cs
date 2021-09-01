using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketStatz.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Team { get; set; }
        public string Height { get; set; }
        public int Age { get; set; }
        public int PTS { get; set; }
        public int FGM { get; set; }
        public int FGA { get; set; }
        public double FGP { get; set; }
        public int FTM { get; set; }
        public int FTA { get; set; }
        public double FTP { get; set; }
        public int ThreeFGM { get; set; }
        public int ThreeFGA { get; set; }
        public double ThreeFGP { get; set; }
        public int REB { get; set; }
        public int OREB { get; set; }
        public int DREB { get; set; }
        public int AST { get; set; }
        public int STL { get; set; }
        public int BLK { get; set; }
        public int TO { get; set; }
        public int PF { get; set; }



    }
}
