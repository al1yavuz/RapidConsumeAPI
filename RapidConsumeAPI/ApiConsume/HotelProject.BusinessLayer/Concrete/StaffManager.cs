using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _IStaffDal;

        public StaffManager(IStaffDal ıstaffDal)
        {
            _IStaffDal = ıstaffDal;
        }

        public void TDelete(Staff t)
        {
            _IStaffDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _IStaffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _IStaffDal.GetList();
        }

        public void TInsert(Staff t)
        {
            _IStaffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _IStaffDal.Update(t);
        }
    }
}
