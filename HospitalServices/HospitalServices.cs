using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModels;
using BusinessLayer;

namespace HospitalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalServices" in both code and config file together.
    public class HospitalServices : IHospitalServices
    {
        public List<Hospital> GetAllHospitals()
        {
            return new BusinessClass().GetAllHospitals();
        }
        public List<Hospital> GetHospitals(int userid)
        {
            return new BusinessClass().GetHospitals(userid);
        }
        public Hospital GetHospitalDetails(int userid, int hospitalid)
        {
            return new BusinessClass().GetHospitalDetails(userid, hospitalid);
        }
        public int AddHospital(Hospital hospital)
        {
            return new BusinessClass().AddHospital(hospital);
        }
        public int UpdateHospital(Hospital hospital)
        {
            return new BusinessClass().UpdateHospital(hospital);
        }
        public int DeleteHospital(int userid, int hospitalid)
        {
            return new BusinessClass().DeleteHospital(userid, hospitalid);
        }
    }
}
