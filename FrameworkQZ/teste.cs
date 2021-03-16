using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkQZ
{
    class teste : IProvedor
    {
        public teste()
        {
           
        }
        public System.Data.IDbConnection Con
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Data.IDbCommand Cmd
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Data.IDbDataAdapter Adp
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Data.DataTable Select(string strSelect, string Where)
        {
            throw new NotImplementedException();
        }

        public IEntidade SelectEnt(string Where)
        {
            throw new NotImplementedException();
        }

        public List<IEntidade> SelectEntCollection(string Where)
        {
            throw new NotImplementedException();
        }

        public void GerarParametros()
        {
            throw new NotImplementedException();
        }

        public void AtualizarParametros()
        {
            throw new NotImplementedException();
        }

        public int Insert(string campos, string valores)
        {
            throw new NotImplementedException();
        }

        public int Update(string sets, string where)
        {
            throw new NotImplementedException();
        }

        public int Delete(string where)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(string strCmd)
        {
            throw new NotImplementedException();
        }
    }
}
