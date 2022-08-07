using BankSystemCore.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.Helpers
{
    public class JsonOperation : IJsonOperation 
    {
        private readonly string dir = Path.Combine(Environment.CurrentDirectory, "db");
       public string _data { get; set; } = String.Empty;
        public async Task<bool> WriteJson<T>(T model, string jsonFile)
        {
            List<T> allUsers = new List<T>(); 
            try
            {
                var path = Path.Combine(dir, jsonFile);
                if (File.Exists(path))
                {
                    //get all json data and add to list of users
                    var readtext = File.ReadAllText(path);
                    var existingUsers = JsonConvert.DeserializeObject<List<T>>(readtext);
                    if (existingUsers != null)
                    {
                        allUsers.AddRange(existingUsers);
                    }
                    //add incoming users to allusers and serialize object
                    allUsers.Add(model);
                    _data = JsonConvert.SerializeObject(allUsers);
                    await File.WriteAllTextAsync(path, _data);
                    return true;
                }
                else
                {            
                    allUsers.Add(model);
                    _data = JsonConvert.SerializeObject(allUsers);
                    await File.AppendAllTextAsync(path, _data);
                    return true;
                }
            }
            catch (Exception) 
            {
                throw;
            }
        }
        //Reading from a json file
        public async Task<List<T>> ReadJson<T>(string jsonFile)
        {
            var path = Path.Combine(dir, jsonFile);
            var readtext = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<T>>(readtext);
            return await Task.FromResult(data!);
        }
    }
}
