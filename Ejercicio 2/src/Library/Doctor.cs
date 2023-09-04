using System;
using System.Text;

namespace Library{
    public class Doctor{
        //Cargo características de los doctores
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Specialty { get; set; }

        //Constructor
        public Doctor(string name, string lastName, int age, string specialty){
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Specialty = specialty;
        }

        //Método para chequear si los datos están completos
        public bool DataCheck(){
            if (string.IsNullOrEmpty(this.Name) ||
               (string.IsNullOrEmpty(this.LastName) ||
               (this.Age < 0) ||
               (string.IsNullOrEmpty(this.Specialty))))
               {
                return false;
            }
            return true;
        }
    }
}