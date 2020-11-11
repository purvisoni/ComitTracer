using System;
using System.Collections.Generic;
using System.Linq;

namespace ComitTracer.Storage
{
    public class UserStorageList : IStoreUsers
    {
        private List<User> _userList;

        public UserStorageList() {
            _userList = new List<User>();
        }

        public void Save(User newUser) {
            _userList.Add(newUser);
        }

        public User GetById(Guid userId) {
            return _userList.Find(x => x.Id == userId);
        }
    }
}