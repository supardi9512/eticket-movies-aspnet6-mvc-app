using eTickets.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        //GET ALL DATA
        Task<IEnumerable<Actor>> GetAll();

        //GET BY ID
        Actor GetById(int id);

        //CREATE DATA
        void Add(Actor actor);

        //UPDATE DATA
        Actor Update(int id, Actor newActor);

        //DELETE DATA
        void Delete(int id);
    }
}
