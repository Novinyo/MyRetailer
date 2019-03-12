using System.Threading.Tasks;
using NRMWPFUI.Models;

namespace NRMWPFUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}