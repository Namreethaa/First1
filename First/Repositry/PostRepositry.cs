using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Models.Repositry;

namespace First.Models.Repositry
{
    public class PostRepositry : IPostRepositry
    {
        public List<PostView> GetPosts()
        {
            var posts = new List<PostView> { new PostView()
            {
                PostId= 101,Title="DevOps",Description="Devops demo",Author="Rajat"
            },
            new PostView()
            {
                PostId= 102,Title="DevOps",Description="Devops demo",Author="Rajat"
            },
            new PostView()
            {
                PostId= 103,Title="DevOps",Description="Devops demo",Author="Rajat"
            },
            }
            ;
            return posts;
        }

    }
}
