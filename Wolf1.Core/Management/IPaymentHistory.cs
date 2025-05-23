﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IPaymentHistory
    {
        List<IPayment> Payments { get; set; }

        Boolean AddPayment(IPayment payment);
        Boolean VoidPayment(IPayment payment);

        Boolean PostPayments();
        Boolean InvoicePayments();
    }
}
