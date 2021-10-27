using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stategy_hw.Entities
{
    public class Context
    {
        private ISaveService strategy;
        public void SetStrategy(ISaveService strategy)
        {
            this.strategy = strategy;
        }
        public void Ejecutar(string data)
        {
            this.strategy.Guardar(data);
        }
    }
}