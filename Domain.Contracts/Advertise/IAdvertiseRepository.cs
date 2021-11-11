using Domain.Contracts.Commons;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IAdvertiseRepository : IBaseRepository<Advertise>
    {
        IEnumerable<AdvertiseDo> SelectAllWithInsta();
    }
}
