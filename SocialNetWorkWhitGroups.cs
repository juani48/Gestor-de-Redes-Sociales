using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CshaprSocialNetWorkManager.Models;

namespace CshaprSocialNetWorkManager.Models
{
    class SocialNetWorkWhitGroups : SocialNetWork
    {
        public List<string> Groups { get; set; }

        public List<string> getGroups()
        {
            return this.Groups;
        }
        public void setGroups(List<string> groups)
        {
            this.Groups = groups;
        }
    }
}
