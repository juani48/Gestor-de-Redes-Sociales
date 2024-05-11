using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshaprSocialNetWorkManager.Models
{
    class SocialNetWork
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private List<User> Users { get; set; } = new List<User>();
        public DateTime DateCreated { get; set; }

        #region Geters
        public string getName()
        {
            return this.Name;
        }
        public string getDescrption()
        {
            return this.Description;
        }
        public List<User> getUsers()
        {
            return this.Users;
        }
        public DateTime getDateTime()
        {
            return this.DateCreated;
        }
        #endregion

        #region Seters
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setDescriptio(string description)
        {
            this.Description = description;
        }
        public void setUsers(List<User> users)
        {
            this.Users = users;
        }
        public void setDateTime(DateTime dateTime)
        {
            this.DateCreated = dateTime;
        }
        #endregion
        //public SocialNetWork(string Name, string description, DateTime dateTime)
        //{
        //    this.setName(Name);
        //    this.setDescriptio(description);
        //    List<User> users = new List<User>();
        //    this.setUsers(users);
        //    this.setDateTime(dateTime);
        //}
    }
}
