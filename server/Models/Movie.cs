using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    // [Table("Movie")]
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
    }
}

// http://www.entityframeworktutorial.net/code-first/table-dataannotations-attribute-in-code-first.aspx
// https://code-maze.com/net-core-web-development-part4/
// https://code-maze.com/net-core-web-development-part9/#angularRepository