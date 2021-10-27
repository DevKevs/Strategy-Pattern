using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using stategy_hw.Entities;
using stategy_hw.Models;

namespace stategy_hw.Services
{
    public class JSONsaving : ISaveService
    {
        public void Guardar(string data)
        {
            string name = "ESTUDENTSJSON";
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + $"{name}.json";

            using (StreamWriter output = new StreamWriter(pathfile))
            {
                output.WriteLine(data);
            }
        }
        public static string Serializar(Estudent student)
        {
            return JsonConvert.SerializeObject(student);
        }
    }
}