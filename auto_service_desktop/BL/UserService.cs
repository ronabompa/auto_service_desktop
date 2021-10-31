using System.Net.Http;


namespace ServiceAutoDESKTOP.BL
{
    public interface IUserService
    {
        bool getUser(string username, string password);
    }

    public class UserService : IUserService
    {

        string uri = "https://localhost:44384/APIUsers/LoginGet?username=";

        public bool getUser(string username, string password)
        {
            bool isValid = false;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(uri + username + "&password=" + password).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    
                    // by calling .Result you are synchronously reading the result
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    //Console.WriteLine(responseString);
                    if(responseString.Equals("true"))
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }
    }
}
