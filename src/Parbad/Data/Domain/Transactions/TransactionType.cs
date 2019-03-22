// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

namespace Parbad.Data.Domain.Transactions
{
    public enum TransactionType : byte
    {
        Request = 0,
        Verify = 1,
        Refund = 2
    }
}
