using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContact
{
    interface IContacstRepository
    {
        DataTable SelectAll();

        DataTable SelcetRow(int contactId);

        DataTable Search(string Parameter);
        bool Insert(string name, string family, string mobile, string email, int age, string adders);

        bool Update(int ContactID, string name, string family, string mobile, string email, int age, string adders);

        bool Delete(int ContactID);
    }
}
