using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.modle
{ /// <summary>  
  /// 用来给数据库表中元素做映射的类  
  /// </summary>  
    class mapzheng:ClassMap<zheng>
    {
        public mapzheng()
        {
            Id(x => x.Id).Column("id");//主键映射主键  
            //其他元素我们使用Map来映射  
            Map(x => x.Name).Column("name");
            Map(x => x.Age).Column("age");
            //表明是哪个表  
            Table("stu");
        }
    }
}
