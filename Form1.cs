using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session3.Models;

namespace Session3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EFTutor();
        }

        FlyContext db = new Models.FlyContext();

        private void EFTutor()
        {
            //аналогично select * from user
            var res1 = db.Users.ToList();
            //аналогично select * from user inner join role on role.ID = user.RoleID
            var res2 = from i in db.Users
                       where i.Role.Name.ToLower() == "admim"
                       select i;
            //то же самое
            var res3 = db.Users.Where(i => i.Role.Name.ToLower() == "admin");
            //и так далее...
            //select top 1 * from office inner join user office.ID = user.officeID 
            var res4 = db.Offices.FirstOrDefault().Users.ToList();

            //после любого удаления/удаления/добавления НУЖНО сохранить изменения с помощью db.SaveChanges();
            //удаление первого пользователя
            var user = db.Users.FirstOrDefault();
            db.Users.Remove(user);
            //для того, что бы он удалился писать db.SaveChanges()
            //добавление
            db.Users.Add(user);
            //изменение первого пользователя
            var fUser = db.Users.FirstOrDefault();
            fUser.LastName = "Lisyakov";
            //для сохранения любых изменений писать db.SaveChanges()

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
