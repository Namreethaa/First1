using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Models;

namespace First.Models.Repositry
{
    public interface IPostRepositry
    {
        List<PostView> GetPosts();

    }
}
