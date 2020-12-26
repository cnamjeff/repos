using System;

namespace TestJeffDataConnexion.Models
{
    public class LoginLock
    {

        public string LockType { get; set; }
        public string LockedValue { get; set; }
        public DateTime LockExpiration { get; set; }

        public LoginLock(string LockType, string LockedValue, DateTime LockExpiration)
        {

            this.LockType = LockType;
            this.LockedValue = LockedValue;
            this.LockExpiration = LockExpiration;
        }

    }
}