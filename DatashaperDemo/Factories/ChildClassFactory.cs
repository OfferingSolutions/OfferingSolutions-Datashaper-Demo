using DatashaperDemo.Models;

namespace DatashaperDemo.Factories
{
    class ChildClassFactory : FactoryBase
    {
        public ChildClass CreateChildClass(ParentClass parentClass)
        {
            return new ChildClass()
            {
                Id = GetRandomNumber(),
                Description = GetRandomString(),
                IsModified = false,
                //ParentClass = parentClass,
                ParentClassId = parentClass.Id
            };
        }
    }
}
