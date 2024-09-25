using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orixa.Domain.Models;

public class Usuario
{

    public int Id { get; set; }
    public string Name { get; set; }
    public char Genere { get; set; }

    public DateTime BirthDay {  get; set; }

}
