using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using sinter_ia.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinter_ia.Infra
{
    public class FirebaseConfiguration
    {

        public async Task<Art> GetById(string id)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                //AuthSecret = "your_firebase_secret",
                BasePath = "https://sinterremote.firebaseio.com/"
            };

            IFirebaseClient client = new FirebaseClient(config);

            FirebaseResponse response = await client.GetAsync("Artes/" + id);
            var todo = response.ResultAs<Art>();
            return todo;
        }
    }
}
