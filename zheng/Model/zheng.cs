using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.modle
{
    /// <summary>  
    /// 这个类是用来存储数据库表中元素的  
    /// </summary>  
    class zheng
    {
        /*注意下面的写法是固定的*/
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
    }
}
