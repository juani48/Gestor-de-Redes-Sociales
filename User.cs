using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CshaprSocialNetWorkManager.Utilities;

namespace CshaprSocialNetWorkManager.Models
{
    class User
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private short Age { get; set; }
        private bool isActive { get; set; }
        private DateTime DateCreated { get; set; }

        #region Geters
        public string getName()
        {
            return Name;
        }
        public string getEmail()
        {
            return Email;
        }
        public short getAge()
        {
            return this.Age;
        }
        public bool getActive()
        {
            return this.isActive;
        }
        public DateTime getDateCreated()
        {
            return this.DateCreated;
        }
        #endregion
        #region Seters
        private void setName(string name)
        {
            this.Name = name;
        }
        private void setEmail(string email)
        {
            this.Email = email;
        }
        private void setAge(short age)
        {
            this.Age = age;
        }
        private void setActive(bool active)
        {
            this.isActive = active;
        }
        private void setDateTime()
        {
            this.DateCreated = new DateTime();
            this.DateCreated = DateTime.Now;
        }
        #endregion
        private bool isValid(string name, string email, short age)
        {
            if ((HelperValidator.validString(name, email)) &&
                    (HelperValidator.validEmail(email)) &&
                    (HelperValidator.validAge(age)))
                return true;
            else
                return false;
        }
        public User(string name, string email, short age) //constructor 
        {
            if (isValid(name, email, age))
            {
                this.setName(name);
                this.setEmail(email);
                this.setAge(age);
                this.setActive(true);
                this.setDateTime();
                Console.WriteLine($"Los datos se guardaron correctamente:\n" +
                    $"-Nombre: {name}.\n" +
                    $"-Email: {email}.\n" +
                    $"-Edad: {age}.");
            }
            else
            {
                Console.WriteLine("Los datos ingresados son incorrectos");
            }
        }

    }
}
