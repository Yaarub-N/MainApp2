using MainApp2.Interface;
using MainApp2.Models;
using Moq;

namespace MainApp2.Test
{
    public class ContactServic_Test
    {
        private readonly Mock<IContactService<Contact, Contact>> _mockContactService = new();
        [Fact]
        public void Creat__ShoudReturnSuccessResult__WhenContactIsCreated()
        {
            var contact = new Contact { FirstName = "Yaarub", LastName = "Nassr", Email = "Yaarub.nasser@yahoo.com" };
            var exptedRespons = new ResultResponse<Contact> { Success = true, Result = contact };

            _mockContactService.Setup(contactService => contactService.Create(contact)).Returns(exptedRespons);

            var contactService = _mockContactService.Object;


            //act
            var result = contactService.Create(contact);


            //assert
            Assert.True(result.Success);
            Assert.Equal(contact, result.Result);

        }

        [Fact]
        public void GetAll__ShoudReturnSuccessResult__WhenContactIsCreated()
        {
            var contact = new Contact { FirstName = "Yaarub", LastName = "Nassr", Email = "Yaarub.nasser@yahoo.com" };
            var contacts = new List<Contact> { contact };
            var exptedRespons = new ResultResponse<IEnumerable<Contact>> { Success = true, Result = contacts };

            _mockContactService.Setup(contactService => contactService.GetAll()).Returns(exptedRespons);

            var contactService = _mockContactService.Object;

            //act
            var responce = contactService.GetAll();

            //Assert
            Assert.True(responce.Success);
            Assert.Equal(contacts, responce.Result);

        }


        [Fact]
        public void GetOne__ShoudReturnSuccessResult__WhenContactIsCreated()
        {
         

            // Arrange
            var id = Guid.NewGuid().ToString();
            var contact = new Contact { Id = id, FirstName = "Yaarub", LastName = "Nassr", Email = "Yaarub.nasser@yahoo.com" };
            var expectedResponse = new ResultResponse<Contact>
            {
                Success = true,
                Result = contact
            };

            _mockContactService.Setup(contactService => contactService.GetOne(id)).Returns(expectedResponse);

            var contactService = _mockContactService.Object;


            //act
            var response = contactService.GetOne(id);

            //Assert
        
            Assert.True(response.Success);
            Assert.NotNull(response.Result);
            Assert.Equal(contact, response.Result);


        }
    }
}