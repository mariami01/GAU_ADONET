using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Request<T>
    {
        public T Object { get; set; }
    }
}
