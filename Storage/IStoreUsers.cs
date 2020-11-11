using System;

namespace ComitTracer.Storage
{
    public interface IStoreUsers
    {
        void Save(User newUser);

        User GetById(Guid id);
    }
}