using System;
using Top.Banking.Domain.Enums;

namespace Top.Banking.Domain
{
    public class Owner
    {
        public Guid OwnerID { get; set; }
        
        public Status Status { get; set; }
        // активен, заблокирован, на верификации
    }
}
