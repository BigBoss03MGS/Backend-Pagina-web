namespace Gimnasio.Models
{
    public class Usuario
    {
            public int Id { get; set; }
            public string NombreUsuario { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public int Edad { get; set; }
            public string Correo { get; set; }
            public string Contraseña { get; set; }
            public double Peso { get; set; }
            public double Altura { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public DateTime ExpiracionMembresia { get; set; }

            
        
    }
}
