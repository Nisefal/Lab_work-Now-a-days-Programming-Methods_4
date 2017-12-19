using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4_bogdanenko
{
    class Program
    {
        /**
         * characteristics of Computing Equipment:
         * price
         * name
         * users
         */
        static void Main(string[] args)
        {
            #region
            int r = 1;
            Console.WriteLine(r.MultipleTwice());
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => -g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
            Console.Clear();
            #endregion
            Console.WriteLine("\t\tALL MACHINES");

            List<Computing_eguipment> mach = EquipmentStore.GetAllMachines();
            foreach (var m in mach)
                Console.WriteLine(m.ToString());

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\t\tSHOW MACHINE INFO + USERS OF MACHINE #3");
            Console.WriteLine(EquipmentStore.GetMachineById(3).ToString());
            Console.WriteLine("Users of {0}", EquipmentStore.GetMachineById(3).name);
            List<CE_user> list = EquipmentStore.GetUsers(3);
            foreach (var u in list)
                Console.WriteLine(u.ToString());

            Console.ReadLine();
            Console.Clear();
        }
    }
}
