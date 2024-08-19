using BlazorTestes.Models;

namespace BlazorTestes.Repository
{
    public interface ImedicoRepository
    {
        Task<List<Medico>> GetAll();
    }
}
