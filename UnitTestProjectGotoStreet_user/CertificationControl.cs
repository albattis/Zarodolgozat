using System;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace GotoStreet_1._0_Company
{
    class CertificationControl
    {
        private int Id;
        private bool IdControl { get; set; }
        private bool Insertcontrol { get; set; }
        public bool IdsControl { get { return IdControl; } set { IdControl = value; } }
        public bool InsContr { get { return Insertcontrol; } set { Insertcontrol = value; } }

        public CertificationControl() { }

        public void CertificationControlId(int ids)
        {
            Id = ids;
            IdControl = false;
            ControlId();

        }

        private void ControlId()
        {
            var context = new gotoStreetEntities();
            foreach (var item in context.Authenticated_user)
            {
                if (Id.Equals(item.userid)) { IdsControl = true; }
            }
        }

        public void InsertControl(int compid)
        {
            Insertcontrol = false;

            Emlpoye_Certificate emlpoye_Certificate = new Emlpoye_Certificate
            {
                userid = Id,
                Companyid = compid,
                date = DateTime.Today
            };
            Emlpoye_Certificate cc;
            cc = emlpoye_Certificate;
            using (var context = new Company_registerEntities1())
            {
                foreach (var item in context.Emlpoye_Certificate)
                {
                    if (!item.userid.Equals(Id))
                    {
                        Insertcontrol = true;
                    }
                }
                if (Insertcontrol)
                {
                    try
                    {
                        context.Emlpoye_Certificate.Add(cc);
                        context.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        Insertcontrol = false;
                    }
                }
            }
        }

        public bool Delete_Certification()
        {
            try
            {
                using (var context = new Company_registerEntities1())
                {
                    Emlpoye_Certificate Em = context.Emlpoye_Certificate.Where(x => x.userid == Id).Single<Emlpoye_Certificate>();
                    context.Emlpoye_Certificate.Remove(Em);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (DbUpdateException) { return false; }
        }

    }
}
