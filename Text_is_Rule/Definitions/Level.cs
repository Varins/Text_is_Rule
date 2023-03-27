using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Text_is_Rule.Definitions
{
    public class Level
    {
        public string Name { get; set; }
        public Vector2 gridDimensions { get; set; }
        public List<Object> gameObjects { get; set; }
        // add background color, picture or sth

        public Level() { }

    }
}
