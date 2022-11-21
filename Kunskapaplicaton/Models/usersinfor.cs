using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kunskapaplicaton.Models
{
    [Table("usersinfor")]
    public class usersinfor
    {
        [Column ("id")]
        
        public int id { get; set; }
        [Column("first_name")]
        public string first_name { get; set; }
        [Column("last_name")]
        public string last_name { get; set; }
        [Column("title")]
        public string title { get; set; }
        // vi flyttade från uaddress till här för att det är lättare och alla skulle vara i en class
    
        public string street_address { get; set; }
        public int postalcode { get; set; }
    }
}
