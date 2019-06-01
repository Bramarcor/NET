using System;
using System.Collections.Generic;
using System.Text;

namespace OOP5
{
    class Empleado
    {
        protected string nombreEmpleado;
        protected double sueldoDepositado;

        public Empleado(string nombre, double deposito)
        {
            this.nombreEmpleado = nombre;
            this.sueldoDepositado = deposito;
        }

        public double obtenerSueldo()
        {
            return this.sueldoDepositado;
        }

        }
    }
}
