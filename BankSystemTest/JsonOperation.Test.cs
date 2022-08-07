using BankSystemCore.Helpers;
using BankSystemCore.Models;

namespace BankSystemTest
{
    public class JsonOperationTest
    {
        private readonly JsonOperation _jsonOperation;
        private readonly string jsonFile = "Users.Json";
        public JsonOperationTest()
        {
            _jsonOperation = new JsonOperation();
        }
        [Fact]
        public async void writeToJson_check_If_Object_write_to_json()
        {
            //Arrange
            bool flag = false;
            User user = new()
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test@gmail.com",
            };     
            //Act
            flag =  await _jsonOperation.WriteJson(user, jsonFile);
            //Assert
            Assert.True(flag);          
        }
        [Fact]
        public async Task writeToJson_if_file_NotExist_throwException()
        {

            User user = null;
            //Assert
            Assert.ThrowsAsync<Exception>( () =>  _jsonOperation.WriteJson(user, "wrongfile.json"));
        }
        [Fact]
        public async void readToJson_check_If_Object_read_from_json()
        {
            //Arrange
            List<User> data;
            //Act
             data = await _jsonOperation.ReadJson<User>(jsonFile);
            //Assert
            Assert.NotNull(data);
        }
    }
}
