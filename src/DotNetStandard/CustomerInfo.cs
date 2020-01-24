namespace Herdo.StrongTypes.DotNetStandard
{
    using System;
    using StrongTypes;

    public class CustomerInfo
    {
        public UserID CreatorID { get; set; }
        public UserID? LastEditByUserID { get; set; }
        public CustomerID CustomerID { get; set; }
        public Year Added { get; set; }
        public Years MembershipDuration { get; set; }

        public CustomerInfo()
        {
            CreatorID = (UserID) 189;
            LastEditByUserID = null;
            CustomerID = (CustomerID) 4140;
            Added = (Year) 2010;
            MembershipDuration = (Years) (DateTime.Today.Year - (short) Added);
        }

        public string GetMembershipDetails()
        {
            return $"Customer {CustomerID} was added {MembershipDuration} years ago ({Added}) by user {CreatorID}.";
        }
    }
}