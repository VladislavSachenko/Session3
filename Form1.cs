using Microsoft.EntityFrameworkCore;
using Session3.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Session3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitDataComp();
            SubscribeAll();
            LoadTable(null, null);
            EFTutor();
        }

        private void InitDataComp()
        {
            fromCB.ValueMember = "ID";
            fromCB.DisplayMember = "IATACode";
            toCB.ValueMember = "ID";
            toCB.DisplayMember = "IATACode";
            cabinTypeCB.ValueMember = "ID";
            cabinTypeCB.DisplayMember = "Name";
        }

        private void SubscribeAll()
        {
            db.OnSave += LoadTable;
        }

        FlyContext db = new Models.FlyContext();

        private void RefreshGrid()
        {
            var resourseOutbound = db.Tickets
                .Include(u => u.Schedule)
                .ThenInclude(u => u.Route)
                .Where(u =>
                u.Schedule.Route.ArrivalAirportID == (int)fromCB.SelectedValue &&
                u.Schedule.Route.DepartureAirportID == (int)toCB.SelectedValue &&
                u.CabinTypeID == (int)cabinTypeCB.SelectedValue &&
                DateTime.Parse(outBoundDate.Text ?? DateTime.Now.ToString()) == u.Schedule.Date)
                .ToList();
            if (returnRB.Checked)
            {
                var resourseReturn = db.Tickets
                    .Include(u => u.Schedule)
                    .ThenInclude(u => u.Route)
                    .Where(u =>
                    u.Schedule.Route.ArrivalAirportID == (int)toCB.SelectedValue &&
                    u.Schedule.Route.DepartureAirportID == (int)fromCB.SelectedValue &&
                    u.CabinTypeID == (int)cabinTypeCB.SelectedValue &&
                    DateTime.Parse(returnDate.Text ?? DateTime.Now.ToString()) == u.Schedule.Date)
                    .ToList();
                dataGridView2.DataSource = resourseReturn;
            }
            dataGridView1.DataSource = resourseOutbound;
            
        }

        private void LoadTable(object obj, EventArgs args)
        { 
            fromCB.DataSource = db.Airports.ToList(); ;
            toCB.DataSource = db.Airports.ToList();
            cabinTypeCB.DataSource = db.CabinTypes.ToList();
            RefreshGrid();
        }


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

        private void apply_Click(object sender, EventArgs e)
        {
            LoadTable(sender, e);
        }
    }
}
