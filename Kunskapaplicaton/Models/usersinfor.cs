using System;
namespace Kunskapaplicaton.Models
{
    public class usersinfor
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string title { get; set; }
        // vi flyttade från uaddress till här för att det är lättare och alla skulle vara i en class
    
        public string street_address { get; set; }
        public int postalcode { get; set; }
    }
}
