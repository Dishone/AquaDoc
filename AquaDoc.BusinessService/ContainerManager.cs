using AquaDoc.DataInterface;
using AquaDoc.DataProvider;
using Unity;

namespace AquaDoc.BusinessService
{
    public static class ContainerManager<TEntiy> where TEntiy : class
    {
        public static IUnityContainer GetContainer()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRepository<TEntiy>, Repository<TEntiy>>();
            return container;
        }

        /// 根据容器解析公共接口
        public static IRepository<TEntiy> GetResolve()
        {
            return GetContainer().Resolve<IRepository<TEntiy>>();
        }
    }
}
