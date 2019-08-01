using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;

namespace DataAccess
{
    public class DataAccessClass
    {
        public List<Hospital> GetAllHospitalsFromDB()
        {
            using (var context = new assignmentEntities())
            {
                return context.hospitals.Select(x => new Hospital()
                {
                    HospitalId = x.hospitalid,
                    UserId = x.userid,
                    Address = x.address,
                    Email = x.email,
                    HospitalName = x.hospitalname,
                    Phone1 = x.phone1,
                    Phone2 = x.phone2,
                    IsPrimary = x.isprimary
                }).ToList();
            }
        }
        public List<Hospital> GetHospitalsFromDB(int userid)
        {
            using (var context = new assignmentEntities())
            {
                return context.hospitals.Where(x => x.userid == userid).Select(x => new Hospital()
                {
                    HospitalId = x.hospitalid,
                    UserId = x.userid,
                    Address = x.address,
                    Email = x.email,
                    HospitalName = x.hospitalname,
                    Phone1 = x.phone1,
                    Phone2 = x.phone2,
                    IsPrimary = x.isprimary
                }).ToList();
            }
        }

        public Hospital GetHospitalDetailsFromDB(int userid, int hospitalid)
        {
            using (var context = new assignmentEntities())
            {
                hospitals h = context.hospitals.FirstOrDefault(x => x.userid == userid && x.hospitalid == hospitalid);
                if (h != null)
                {
                    return new Hospital()
                    {
                        status = 1,
                        HospitalId = h.hospitalid,
                        UserId = h.userid,
                        Address = h.address,
                        Email = h.email,
                        HospitalName = h.hospitalname,
                        Phone1 = h.phone1,
                        Phone2 = h.phone2,
                        IsPrimary = h.isprimary
                    };
                }
                else
                {
                    return new Hospital()
                    {
                        status = -1
                    };
                }
            }
        }
        public int AddHospitalToDB(Hospital hospital)
        {
            using (var context = new assignmentEntities())
            {
                context.hospitals.Add(new hospitals()
                {
                    userid = hospital.UserId,
                    address = hospital.Address,
                    email = hospital.Email,
                    hospitalname = hospital.HospitalName,
                    phone1 = hospital.Phone1,
                    phone2 = hospital.Phone2,
                    isprimary = hospital.IsPrimary
                });
                return context.SaveChanges();
            }
        }
        public int UpdateHospitalToDB(Hospital hospital)
        {
            using (var context = new assignmentEntities())
            {
                var updatedHospital = context.hospitals.FirstOrDefault(x => x.userid == hospital.UserId && x.hospitalid == hospital.HospitalId);
                if (updatedHospital != null)
                {
                    updatedHospital.address = hospital.Address;
                    updatedHospital.email = hospital.Email;
                    updatedHospital.hospitalname = hospital.HospitalName;
                    updatedHospital.phone1 = hospital.Phone1;
                    updatedHospital.phone2 = hospital.Phone2;
                    updatedHospital.isprimary = hospital.IsPrimary;
                    return context.SaveChanges();
                }
                else
                {
                    return -1;
                }
            }
        }
        public int DeleteHospitalFromDB(int userid, int hospitalid)
        {
            using (var context = new assignmentEntities())
            {
                var deletedHospital = context.hospitals.FirstOrDefault(x => x.userid == userid && x.hospitalid == hospitalid);
                if (deletedHospital != null)
                {
                    context.hospitals.Remove(deletedHospital);
                    return context.SaveChanges();
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
