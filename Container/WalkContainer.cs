using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class WalkContainer {
        public List<IMoveOnGround> WalkBox { get; set; } = new List<IMoveOnGround>();
    }
}