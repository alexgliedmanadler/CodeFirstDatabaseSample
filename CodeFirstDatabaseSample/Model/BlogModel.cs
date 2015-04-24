using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDatabaseSample.Model
{
    class BlogModel
    {
        public int BlogModelId { get; set; }
        public string Name { get; set; }

        public virtual List<PostModel> Posts { get; set; }
    }
}
