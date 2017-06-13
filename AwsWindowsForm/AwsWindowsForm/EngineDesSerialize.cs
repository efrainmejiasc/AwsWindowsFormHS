using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsWindowsForm
{
    public class EngineDesSerialize
    {
        public class ListaAwsProfileSearch
        {
            public List<AwsProfileSearch> responseArray { get; set; }

        }

        public class AwsProfileSearch
        {
            public string asin { get; set; }
            public string productUrl { get; set; }
            public string productImgUrl { get; set; }
            public string price { get; set; }
            public string title { get; set; }
            public string offersUrl { get; set; }

        }

    }
}
