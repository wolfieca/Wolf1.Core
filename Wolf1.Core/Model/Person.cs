using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Formatters;
using Wolf1.Core.Letters;
using Wolf1.Core.Management;

namespace Wolf1.Core.Model
{
    public class Name : IComparable<Name>
    {
        public String LastName { get; }
        public String MiddleName { get; }
        public String FirstName { get; }
        public String Title { get; }
        public String Generation { get; }

        public override string ToString()
        {
            return Title != "" ? Title + " " : "" + FirstName != "" ? FirstName + " " : "" + MiddleName != "" ? MiddleName + " " : "" +
            LastName != "" ? LastName + " " : "" + Generation != "" ? ", " + Generation : "";
        }

        public String ToSortableForm()
        {
            return LastName != "" ? LastName + ", " : "" + FirstName != "" ? FirstName + " " : "" + MiddleName != "" ? MiddleName + " " : ""
             + Generation != "" ? Generation : "";
        }

        public int CompareTo(Name other)
        {
            return (LastName + FirstName + MiddleName).CompareTo(other.LastName + other.FirstName + other.MiddleName);
        }
    }

    public class Person 
    {
        public Name Name {get; }
        public Address HomeAddress {get; }
        public SocialSecurityNumber SocialSecurityNumber {get; }
        public DateTime DateOfBirth {get; }
        public PhoneNumber HomeNumber {get; }
        public PhoneNumber CellNumber {get; }
        public PhoneNumber WorkNumber {get; }
        public PhoneNumber FaxNumber { get; }
        public Person Spouse { get; }
        public Company Employer { get; }
        public Demographics Demographics { get; }
        public LetterHistory LettersSent {get; }
    }

    public class LetterHistory
    {
        public Dictionary<DateTime, Letter> LettersSent {get; }
    }
}
