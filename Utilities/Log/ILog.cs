using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshaprSocialNetWorkManager.Utilities.Log
{
    public interface ILog<T>
    {
        void SaveLog(T action);
    }
}
