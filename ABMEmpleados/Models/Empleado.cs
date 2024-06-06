using System;
using System.Collections.Generic;

namespace ABMEmpleados.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Clave { get; set; }
}
