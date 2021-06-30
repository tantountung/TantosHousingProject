using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Repo
{
    public interface IGenericRepo <ModelType>
    {
        ModelType Create(ModelType create);

        ModelType Read(int id);
        List<ModelType> Read();
        ModelType Update(ModelType model);

        bool Delete(int id);
    }
}
