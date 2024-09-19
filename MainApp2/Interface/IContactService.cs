

using MainApp2.Models;

namespace MainApp2.Interface
{
    public interface IContactService<T, TResult> where T : class where TResult : class
    {
        ResultResponse<Contact> Create(Contact contact);
        ResultResponse<IEnumerable<Contact>> GetAll();
        ResultResponse<Contact> GetOne(string id);
        ResultResponse<Contact> Update(string id, Contact updateContact);
        ResultResponse<Contact> Delete(string id);
    }
}
