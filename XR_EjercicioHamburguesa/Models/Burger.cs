using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XR_EjercicioHamburguesa.Models
{
    [Table("burger")]
    public class Burger
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string XRName { get; set; }
        public string XRDescription { get; set; }
        public bool XRWithExtraCheese { get; set; }
    }
}
