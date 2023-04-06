using Nikora.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikora.Core.Repositories
{
    public interface IRepository<Model>
    {
        void Add(Model userModel);
        void Update(Model userModel);
        void Delete(int userID);
        IEnumerable<Model> GetAll();
        IEnumerable<Model> GetByValue();
    }
}
