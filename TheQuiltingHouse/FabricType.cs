using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiltingHouse.Enums
{
    public class FabricType
    {
        private List<FabricType> _fabricType;

        public FabricType()
        {
            _fabricType.Add(new Fabric { Type = "Cotton" });
            _fabricType.Add(new Fabric { Type = "Cotton Poly Blend" });
            _fabricType.Add(new Fabric { Type = "Flannel" });
            _fabricType.Add(new Fabric { Type = "Fleece" });
            _fabricType.Add(new Fabric { Type = "Minky" });
            _fabricType.Add(new Fabric { Type = "Silk" });
        }
    }
}