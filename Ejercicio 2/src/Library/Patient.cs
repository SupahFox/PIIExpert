using System;
using System.Text;

namespace Library{
    public class Patient{

        //Cargo características de los pacientes
        public string Name { get; set; }
        public int id { get; set; }
        public int Age { get; set; }
        public string phoneNumber { get; set; }

        //Constructor
        public Patient(string name, int id, int age, string phoneNumber){
            this.Name = name;
            this.id = id;
            this.Age = Age;
            this.phoneNumber = phoneNumber;
        }

        //Método para chequear si los datos están completos
        public bool DataCheck(){
            if (string.IsNullOrEmpty(this.Name) ||
               (this.id < 0) ||
               (this.Age < 0) ||
               (string.IsNullOrEmpty(this.phoneNumber)))
               {
                return false;
            }
            return true;
        }

    }
}