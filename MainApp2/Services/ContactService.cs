using MainApp2.Interface;
using MainApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp2.Services
{

    public class ContactService : IContactService<Contact, Contact>
    {
        public ResultResponse<Contact> Create(Contact contact)
        {
            throw new NotImplementedException();
        }

        public ResultResponse<Contact> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ResultResponse<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResultResponse<Contact> GetOne(string id)
        {
            throw new NotImplementedException();
        }

        public ResultResponse<Contact> Update(string id, Contact updateContact)
        {
            throw new NotImplementedException();
        }
    }
}
