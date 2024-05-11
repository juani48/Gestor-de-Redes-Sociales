using CshaprSocialNetWorkManager.Utilities.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshaprSocialNetWorkManager.Models
{
    class AppManager
    {
        private string AppTitle { get; set; } = "Administrados de redes sociales";
        private List<SocialNetWork> SNW { get; set; }
        private List<SocialNetWorkWhitGroups> SNWwG { get; set; }

        public ILog<string> log { get; set; }

        public List<SocialNetWork> getSNW()
        {
            return this.SNW;
        }
        public List<SocialNetWorkWhitGroups> getSNWwG()
        {
            return this.SNWwG;
        }
        private void InitializeSNW()
        {
            string name = "Twitter";
            string descripotion = "Red social para intercambio de mensajes cortos";
            DateTime dateTime = new DateTime(2008, 1, 20);
            SNW.Add(new SocialNetWork()
            {
                Name = name,
                Description = descripotion,
                DateCreated = dateTime
            });

            name = "Instagram";
            descripotion = "Red social para intercambio de fotos y videos";
            dateTime = new DateTime(2010, 4, 12);
            SNW.Add(new SocialNetWork()
            {
                Name = name,
                Description = descripotion,
                DateCreated = dateTime
            });
            log.SaveLog("InitializeSNW");
        }
        private void InitializeSNWwG()
        {
            string name = "FaceBook";
            string description = "Red social para intercambio de mensajes, fotos y videos";
            DateTime dateTime = new DateTime(2000, 12, 1);
            SNWwG.Add(new SocialNetWorkWhitGroups()
            {
                Name = name,
                Description = description,
                DateCreated = dateTime,
                Groups = new List<string> { "Grupo 1", "Grupo 2", "Grupo 3" }
            });
            log.SaveLog("InitializeSNWwG");
        }
        public string getAppTitle()
        {
            return AppTitle;

        }

        public string getInfomratioSNW<T>(T SNW)
        {
            var SNWobject = SNW as SocialNetWork;

            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {SNWobject.getName()} \n");
            sb.Append($"Descripcion: {SNWobject.getDescrption()} \n");
            sb.Append($"Fecha creacion: {SNWobject.getDateTime().Year}\n");

            if (SNWobject is SocialNetWorkWhitGroups)
            {
                var SNWwGobject = SNW as SocialNetWorkWhitGroups;
                sb.Append($"Grupos: {string.Join(",", SNWwGobject.getGroups())}");
            }
            log.SaveLog("getInfomratioSNW");
            return sb.ToString();
        }
        public string getStackSNW<T>(T SNW)
        {
            var SNWobject = SNW as SocialNetWork;

            StringBuilder sb = new StringBuilder();
            if (SNWobject.getUsers().Count == 0)
            {
                sb.Append("No hay ningun usuario cargado \n");
            }
            else
            {
                sb.Append($"Cantidad de usuarios: {SNWobject.getUsers().Count} \n");
                sb.Append($"Promedio de edad: {SNWobject.getUsers().Average(p => p.getAge())} \n");
                sb.Append($"Uusario con mas edad: {SNWobject.getUsers().Max(p => p.getAge())}\n");

                if (SNWobject is SocialNetWorkWhitGroups)
                {
                    var SNWwGobject = SNW as SocialNetWorkWhitGroups;
                    sb.Append($"Cantidad de grupos: {SNWwGobject.getGroups().Count}");
                }
            }
            log.SaveLog("getStackSNW");
            return sb.ToString();
        }
        public AppManager(ILog<string> logger)
        {
            log = logger;
            this.SNW = new List<SocialNetWork>();
            this.SNWwG = new List<SocialNetWorkWhitGroups>();
            this.InitializeSNW();
            this.InitializeSNWwG();
        }
    }
}
