using COMMON.DTO;
using System.Threading.Tasks;

namespace COMMON.Contracts
{
    public interface IBLContract
    {
        Task<DTOResponse> Create(DTORequest request);
    }
}
