using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Lab_Joey_Dias.Repository
{
    interface IRepository
    {
        void save(Data.Entities.entity e);
        void delete(Data.Entities.entity e);
        void edit(Data.Entities.entity e);
        Data.Entities.entity find(int id, realRepository.type toFind);
        IEnumerable<Data.Entities.entity> getAll(realRepository.type theType, int id = -1);
    }
}
