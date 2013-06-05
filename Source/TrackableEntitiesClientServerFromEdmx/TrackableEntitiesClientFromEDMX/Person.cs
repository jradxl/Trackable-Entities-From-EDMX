// <autogenerated>
//   This file was generated by T4 code generator TrackableEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

namespace TrackableEntitiesDTO.ClientEntities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using TrackableEntities.Client;

    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Person : ModelBase<Person>
    {
        public Person()
        {
            this.Phones = new ChangeTrackingCollection<Phone>();
            this.Addresses = new ChangeTrackingCollection<Address>();
        }//ctor

        [DataMember]
        public int PersonID
        { 
            get { return _PersonID; }
            set
            {
                if (value == _PersonID) return;
                _PersonID = value;
                NotifyPropertyChanged(m => m.PersonID);
            }
        }
        private int _PersonID;

        [DataMember]
        public string Firstname
        { 
            get { return _Firstname; }
            set
            {
                if (value == _Firstname) return;
                _Firstname = value;
                NotifyPropertyChanged(m => m.Firstname);
            }
        }
        private string _Firstname;

        [DataMember]
        public string Lastname
        { 
            get { return _Lastname; }
            set
            {
                if (value == _Lastname) return;
                _Lastname = value;
                NotifyPropertyChanged(m => m.Lastname);
            }
        }
        private string _Lastname;

        [DataMember]
        public ChangeTrackingCollection<Phone> Phones
        {
            get { return _Phones; }
            set
            {
                if (Equals(value, _Phones)) return;
                _Phones = value;
                NotifyPropertyChanged(m => m.Phones);
            }
        }
        private ChangeTrackingCollection<Phone> _Phones;

        [DataMember]
        public PersonInfo PersonInfoes
        {
            get { return _PersonInfoes; }
            set
            {
                if (value == _PersonInfoes) return;
                _PersonInfoes = value;
                NotifyPropertyChanged(m => m.PersonInfoes);
            }
        }
        private PersonInfo _PersonInfoes;

        [DataMember]
        public ChangeTrackingCollection<Address> Addresses
        {
            get { return _Addresses; }
            set
            {
                if (Equals(value, _Addresses)) return;
                _Addresses = value;
                NotifyPropertyChanged(m => m.Addresses);
            }
        }
        private ChangeTrackingCollection<Address> _Addresses;


    } //Class
} //Namespace
