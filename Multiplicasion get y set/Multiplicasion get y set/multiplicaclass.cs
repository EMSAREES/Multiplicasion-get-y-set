﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicasion_get_y_set
{
    internal class multiplicaclass
    {
        //se ponen en privado los tipos de datos
        private int N1;
        private int N2;

        //nos permite proteger o crear límites de acceso a las variables y métodos de una clase,
        //controlando con ello el comportamiento fuera y dentro de la misma clase
        public int N11 { get => N1; set => N1 = value; }
        public int N21 { get => N2; set => N2 = value; }

        //metodo, accion, lo que hace.
        public int multiplica()
        {
            return (N1 * N2);
        }
    }
}
