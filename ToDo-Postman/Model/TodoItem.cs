using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_Postman.Model
{
    public class TodoItem
    {
        public long id { get; set; }

        public string Nome { get; set; }

        public bool EstaCompleto { get; set; }
    }
}
