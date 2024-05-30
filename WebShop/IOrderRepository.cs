using Webshop.Models;

namespace Webshop
{
    public interface IOrderRepository
    {
        void Add(Cart Cart);
    }
}
