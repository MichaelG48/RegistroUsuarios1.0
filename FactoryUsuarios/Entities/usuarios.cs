using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUsuarios.Entities
{
    public class usuarios
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidoP_usuario { get; set; }
        public string apellidoM_usuario { get; set; }
        public int edad_usuario { get; set; }
        public string clv_elec_usuario { get; set; }
        public string curp_usuario { get; set; }
        public int anio_reg_usuario { get; set; }
        public string estado_usuario { get; set; }
        public string municipio_usuario { get; set; }
        public int seccion_usuario { get; set; }
        public string localidad_usuario { get; set; }
        public int emicion_usuario { get; set; }
        public int vigencia_usuario { get; set; }
        public string perfil_usuario { get; set; }
    }
}
