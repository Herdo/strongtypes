namespace Herdo.StrongTypes.DotNetFramework
{
    using System;
    using StrongTypes;

    internal class Consumer
    {
        private readonly UserID _creatorID;
        private readonly CustomerID _customerID;
        private readonly Year _added;
        private readonly Years _membershipDuration;

        internal Consumer()
        {
            _creatorID = (UserID) 189;
            _customerID = (CustomerID) 4140;
            _added = (Year) 2010;
            _membershipDuration = (Years) (DateTime.Today.Year - (short) _added);
        }

        internal string GetMembershipDetails()
        {
            return $"Customer {_customerID} was added {_membershipDuration} years ago ({_added}) by user {_creatorID}.";
        }
    }
}