using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
namespace FrameworkQZ
{
    public interface IProvedor
    {
        IDbConnection Con { get; set; }
        IDbCommand Cmd { get; set; }
        IDbDataAdapter Adp { get; set; }
        IProvedor(IEntidade Ent);
        DataTable Select(string strSelect, string Where);
        IEntidade SelectEnt(string Where);
        List<IEntidade> SelectEntCollection(string Where);
        void GerarParametros();
        void AtualizarParametros();
        int Insert(string campos, string valores);
        int Update(string sets, string where);
        int Delete(string where);
        int ExecuteNonQuery(string strCmd);


    }
}
