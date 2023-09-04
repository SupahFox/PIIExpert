using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Cargo pacientes
            Patient patient1 = new Patient("Steven Jhonson", 986782342, 38, "5555-555-555");
            Patient patient2 = new Patient("Ralf Manson", 423423453, 24, "5555-555-555");

            //Cargo doctores
            Doctor doctor1 = new Doctor("Armand", "Fernandez", 32, "Nutricionista");
            Doctor doctor2 = new Doctor("Ralf", "Manson", 32, "Nutricionista");
            
            //Creo turnos
            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
