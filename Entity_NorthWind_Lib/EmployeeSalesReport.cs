using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entity_NorthWind_Lib
{
    internal class EmployeeSalesReport
    {
        public static void SalesReport()
        {
            using (var db = new NorthwindEntities())
            {
                var salesReport = db.EmployeeSalesReport()

                foreach (var item in result1)
                {
                    Console.WriteLine($"{item.userId}\t\t{item.FirstName}\t\t{item.LastName}");
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("======Group======");

                Group g = new Group();
                g.Name = "D";
                db.Groups.Add(g);
                db.SaveChanges();
                var result3 = db.Groups.ToList();

                foreach (Group item in result3)
                {
                    Console.WriteLine(item.Id + "\t\t" + item.Name);
                }

            }
            Console.ReadLine();
        }
    }
}
