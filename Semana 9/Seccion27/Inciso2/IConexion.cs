using System;
namespace Inciso2
{
    public interface IConexion
    {
        public  List<Cita> ConsultaCita (string query);
        public  List<Contacto> ConsultaContacto(string query);
        public  void AgregarCita(Cita info);
        public  void AgregarContacto(Contacto info);

    }
}

