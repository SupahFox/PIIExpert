using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            Boolean isValidDoctor = true;
            Boolean isValidPatient = true;

            //Checkeo si algún valor falta. SI DATA CHECK ES FALSE SIGNIFICA QUE PASÓ LA PRUEBA
            if (doctor.DataCheck() == false)
            {
                stringBuilder.Append("Unable to schedule appointment, doctor data is required\n");
                isValidDoctor = false;
            }

            //Checkeo si algún valor falta. SI DATA CHECK ES FALSE SIGNIFICA QUE PASÓ LA PRUEBA
            if (patient.DataCheck() == false)
            {
                stringBuilder.Append("Unable to schedule appointment, patient data is required\n");
                isValidPatient = false;
            }

            //Checkeo si algún valor falta. SI DATA CHECK ES FALSE SIGNIFICA QUE PASÓ LA PRUEBA
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            //ESTO ES PARA NO DEVOLVER 3 VECES EL Appointment scheduled
            //Le corregí la falta de ortografía también
            if (isValid == true && isValidDoctor == true && isValidPatient == true)
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
