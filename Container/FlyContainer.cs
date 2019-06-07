using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class FlyContainer {
        public List<IFly> FlyBox { get; set; } = new List<IFly> ();
    }
}