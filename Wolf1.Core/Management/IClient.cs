using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Statistics;

namespace Wolf1.Core.Management
{
    public interface IClient : ICompany
    {
        String ClientID { get; set; }
        ICompany Company { get; set; }
        IOffice ClientOffice { get; set; }
        List<IServices> ActiveServices { get; set; }
        List<IOffice> ClientOffices { get; set; }
        Boolean DirectDeposit { get; set; }
        Dictionary<DateTime, IContract> Contracts { get; set; }
        DateTime RenewalAgreementRequested { get; set; }
        DateTime UploadedNewbiz { get; set; }
        IFeeSchedule FeeSchedule { get; set; }
        Dictionary<String,IStatistics> ClientStatistics { get; set; }
        List<IUser> Users { get; set; }
    }
}
