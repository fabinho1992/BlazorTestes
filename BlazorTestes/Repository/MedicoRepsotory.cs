using BlazorTestes.Models;

namespace BlazorTestes.Repository
{
    public class MedicoRepsotory : ImedicoRepository
    {
        public async Task<List<Medico>> GetAll()
        {
            return new List<Medico>
            {
                new Medico { Id = 1, Nome = "Rafael", Crm = "aq2h232 "},
                new Medico { Id = 2, Nome = "Miguel", Crm = "3b21hbc"},
                new Medico {Id = 3, Nome = "João", Crm = "jkweb33"}

            };
        }
    }
}
