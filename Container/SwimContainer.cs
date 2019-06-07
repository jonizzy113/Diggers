using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class SwimContainer {
        public List<ISwimInWater> SwimBox {get; set; } = new List<ISwimInWater> ();
    }
}