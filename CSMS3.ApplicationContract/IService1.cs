using CSMS3.Application.DTO;
using CSMS3.Infrastructure;
using System.ServiceModel;
using CSMS3.Infrastructure.Caching;

namespace CSMS3.ApplicationContract
{
    [ServiceContract]
    public interface IService1 : IApplicationServiceContract
    {
        [OperationContract]
        [FaultContract(typeof(FaultData))]
        [Caching(CachingMethod.Get)]
        YongHuXXDTO GetYongHuXXByCID(string cid);

        [OperationContract]
        bool AddYongHuXX(YongHuXXDTO dto);
        /// <summary>
        ///  123
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        string GetData(int value);
    }
}
