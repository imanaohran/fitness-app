using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aptus.Data;
using SQLite;
using System.IO;

namespace Aptus.Models;

[Table("exercises")]
public class Exercise
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public double Weight { get; set; }
    public string MuscleGroup { get; set; }



}
