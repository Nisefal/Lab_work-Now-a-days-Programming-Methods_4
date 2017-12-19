using System.Collections.Generic;
using System.Linq;

namespace lab4_bogdanenko
{
    static class EquipmentStore
    {
        public static List<Computing_eguipment> equipmentlist;
        public static List<CE_user> userlist;
        public static List<Link_User_Comp> links;

        static EquipmentStore()
        {
            equipmentlist = GetEqList();
            userlist = GetUsList();
            links = GetLinks();
        }
        


        private static List<Computing_eguipment> GetEqList()
        {
            List<Computing_eguipment> b = new List<Computing_eguipment>();
            b.Add(new Computing_eguipment() { Id = 1, name = "Comp1", computing_power = 120, price = 2000 });
            b.Add(new Computing_eguipment() { Id = 2, name = "Comp2", computing_power = 80, price = 1400 });
            b.Add(new Computing_eguipment() { Id = 3, name = "Golden Trone", computing_power = 40000, price = 100500 });
            return b;
        }

        private static List<CE_user> GetUsList()
        {
            List<CE_user> b = new List<CE_user>();

            b.Add(new CE_user() { name = "Evgen", surname = "Kravchenko", Id = 1, position = "admin"});
            b.Add(new CE_user() { Id = 3, name = "Martin", surname = "Luter King", position = "fullstack developer"});
            b.Add(new CE_user() { Id = 4, name = "Emperor", position = "Emperor of Mankind"});
            b.Add(new CE_user() { Id = 5, name = "Kama", surname = "Puliya", position = "Philosopher"});

            return b;
        }

        private static List<Link_User_Comp> GetLinks()
        {
            List<Link_User_Comp> l = new List<Link_User_Comp>();
            l.Add(new Link_User_Comp(1, 1));
            l.Add(new Link_User_Comp(1, 2));
            l.Add(new Link_User_Comp(2, 1));
            l.Add(new Link_User_Comp(2, 3));
            l.Add(new Link_User_Comp(3, 4));
            return l;
        }

        public static List<CE_user> GetUsers(int cmpid)
        {
            var usrs = from _u in userlist
                       from _ce in equipmentlist
                       from _cusers in links
                       where (_ce.Id == cmpid)
                       && (_u.Id == _cusers.usr_id)
                       && (_ce.Id == _cusers.comp_id)
                       select _u;
            List<CE_user> l = new List<CE_user>();
            foreach (var user in usrs) { l.Add((CE_user)user); };
            return l;
        }


        public static List<CE_user> GetAllUsers()
        {
            return userlist;
        }

        public static List<Computing_eguipment> GetAllMachines()
        {
            return equipmentlist;
        }

        public static Computing_eguipment GetMachineById(int id)
        {
            var ce = from _ce in equipmentlist
                    where (_ce.Id == id)
                    select _ce;

            Computing_eguipment machine = ce.ElementAt(0);

            return machine;
        }
    }
}
