using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public enum PriorityCriteria
    {
        BrokenPromise, HasAssets, WaitingReturn, CurrentlyMailReturn, HasPhone,
        HasEmployment, CollectionAttempted, HasMadePayment, NewInSystem, InSystemOver10Days,
        InSystenOver30Days, InSystemOver60Days, InSystemOver90Days, InSystemLessThan10Days,
        InSystemLessThan30Days, InSystemLessThan60Days, InSystemLessThan90Days, NotWorked,
        GoodAddress, KeptPromise, BrokeSomePromises, Balance2, Balance4, Balance8, Score2, Score4,
        Score8, StatusIs, Eastern
    }

    public class Priority
    {
    }
}
