using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Contratos
{
    public interface IPerfil
    {
        //Sección para administración de datos del usuario(nombre y apellido, nombre de usuario, contraseña, foto de perfil).
        //Aplicable a los dos roles de usuario del sistema
        void CrearPerfil();
        void ModificarPerfil();
        void EliminarPerfil();
    }
}
