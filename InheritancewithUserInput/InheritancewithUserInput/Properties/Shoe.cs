using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritancewithUserInput.Properties
{
    class Shoe
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        
        public void ShoeInfo()
        {
            Console.WriteLine(Brand + " " + Color);
        }
    }
    class LowTopSneaker : Shoe
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public void SneakerInfo()
        {
            ShoeInfo();
            Console.WriteLine(Type + " " + Size);
        }
    }
    class HighTop : Shoe
    {
        public string AnkleSupport { get; set; }
        public string Material { get; set; }
        public void HighTopInfo()
        {
            ShoeInfo();
            Console.WriteLine(AnkleSupport + " " + Material);
        }
    }
}
