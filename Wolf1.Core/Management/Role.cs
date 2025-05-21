using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public class Role
    {
    }

    /// <summary>
    /// Users with the AdministratorRole have administrative privileges on the 
    /// system. Administrative users can create new non-administrative users and
    /// new clients; can change the run-states of non-privileged queues; can 
    /// create new accounts; and can move accounts between queues and between
    /// collectors.
    /// </summary>
    public class AdministratorRole : Role
    {

    }
    public class ClericalRole : Role
    {

    }
    public class CollectorRole : Role
    {

    }
    public class ComplianceOfficerRole : Role
    {

    }
    public class DataEntryClerkRole : Role
    {

    }
    public class ExecutiveRole : Role
    {

    }
    public class LetterManagerRole : Role
    {

    }
    public class ManagerRole : Role
    {

    }
    public class NewBusinessEntryClerkRole : Role
    {

    }
    public class NewBusinessManagerRole : Role
    {

    }
    public class PaymentOriginatorRole : Role
    {

    }
    public class PaymentApproverRole : Role
    {

    }
    public class QueueManagerRole : Role
    {

    }
    public class DocumentScannerRole : Role
    {
        
    }
    public class SkipTracerRole : Role
    {

    }
    public class SupervisorRole : Role
    {

    }
    public class SystemManagerRole : Role
    {

    }
    public class ClientRole : Role
    {

    }
    public class ClientAdministratorRole : Role
    {

    }
    public class ClientNewbusinessUploaderRole : Role
    {

    }
    public class ClientInquiryResponderRole : Role
    {

    }
    public class AttorneyRepresentativeRole : Role
    {

    }
    public class AttorneyDocumentReceiverRole : Role
    {

    }
    public class AttorneyDocumentSourceRole : Role
    {

    }
    public class VendorRole : Role
    {

    }
    public class VendorAccountReceiverRole : Role
    {

    }
    public class VendorAccountSourceRole : Role
    {

    }
    public class PayrollProcessorRole : Role
    {

    }
    public class AccountingRole : Role
    {

    }
    public class BoardRole : Role
    {

    }
    public class ChairmanRole : Role
    {

    }
    public class ContractOriginatorRole : Role
    {

    }
    public class ContractSignerRole : Role
    {
        
    }
}
