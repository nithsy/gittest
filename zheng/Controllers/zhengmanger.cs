using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.modle;
using test;
using zheng.Dao;


namespace test.manger
{
    class zhengmanger//:IUserDao
    {
        //public int putUserAge(int age)
     //   {
     //   }
        public IList<test.modle.zheng> GetAllData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transcation = session.BeginTransaction())
                {
                    //使用session查询vivian  
                    var userList = session.QueryOver<test.modle.zheng>();
                    return userList.List();//返回查询后的结果  
                }
            }
        }
        static void Main(string[] args)
        {
            zhengmanger pc = new zhengmanger();
            IList<test.modle.zheng> apc = pc.GetAllData();            
            Console.WriteLine("开始测试查询功能!!");
            foreach (test.modle.zheng cp in apc)
            {
                Console.WriteLine(cp.Name);//输出查询到的所有表中元素的名字  
            }

            Console.ReadKey();
        }
    }
}