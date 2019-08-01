using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModels;

namespace HospitalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHospitalServices" in both code and config file together.
    [ServiceContract]
    public interface IHospitalServices
    {
        [OperationContract]
        List<Hospital> GetAllHospitals();

        [OperationContract]
        List<Hospital> GetHospitals(int userid);

        [OperationContract]
        Hospital GetHospitalDetails(int userid, int hospitalid);

        [OperationContract]
        int AddHospital(Hospital hospital);

        [OperationContract]
        int UpdateHospital(Hospital hospital);

        [OperationContract]
        int DeleteHospital(int userid, int hospitalid);
    }
}
