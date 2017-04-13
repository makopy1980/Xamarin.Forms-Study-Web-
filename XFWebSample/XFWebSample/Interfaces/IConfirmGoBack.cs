using System;
using System.Threading.Tasks;

namespace XFWebSample.Interfaces
{
    public interface IConfirmGoBack
    {
        Task<bool> CanGoBackAsync();
    }
}
