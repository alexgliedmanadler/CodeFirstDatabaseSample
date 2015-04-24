using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDatabaseSample.Model
{
    class PostModel
    {
        public int PostModelId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogModelId { get; set; }
        public virtual BlogModel Blog { get; set; }
    }
}
