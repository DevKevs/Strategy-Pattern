using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using stategy_hw.Entities;

namespace stategy_hw.Services
{
    public class TXTSaving : ISaveService
    {
        public void Guardar(string data)
        {
            string name = "ESTUDENTSTXT";
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + $"{name}.txt";
            using (StreamWriter output = new StreamWriter(pathfile))
            {
                output.WriteLine(data);
            }
        }
    }
}