using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkQZ
{
    public interface IEntidade
    {
        string Tbl { get; set; }
        string[] GetParametrosNomes();
        
    }
}
