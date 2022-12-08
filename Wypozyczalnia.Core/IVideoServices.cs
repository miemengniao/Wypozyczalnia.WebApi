using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Core
{
    public  interface IVideoServices
    {
        List<Video> GetVideos();

    }
}
