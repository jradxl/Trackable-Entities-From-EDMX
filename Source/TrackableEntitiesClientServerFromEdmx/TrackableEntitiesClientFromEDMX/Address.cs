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
    public partial class Address : ModelBase<Address>
    {
        public Address()
        {
            this.People = new ChangeTrackingCollection<Person>();
        }//ctor

        [DataMember]
        public int AddressID
        { 
            get { return _AddressID; }
            set
            {
                if (value == _AddressID) return;
                _AddressID = value;
                NotifyPropertyChanged(m => m.AddressID);
            }
        }
        private int _AddressID;

        [DataMember]
        public string Address1
        { 
            get { return _Address1; }
            set
            {
                if (value == _Address1) return;
                _Address1 = value;
                NotifyPropertyChanged(m => m.Address1);
            }
        }
        private string _Address1;

        [DataMember]
        public string Address2
        { 
            get { return _Address2; }
            set
            {
                if (value == _Address2) return;
                _Address2 = value;
                NotifyPropertyChanged(m => m.Address2);
            }
        }
        private string _Address2;

        [DataMember]
        public string Address3
        { 
            get { return _Address3; }
            set
            {
                if (value == _Address3) return;
                _Address3 = value;
                NotifyPropertyChanged(m => m.Address3);
            }
        }
        private string _Address3;

        [DataMember]
        public string City
        { 
            get { return _City; }
            set
            {
                if (value == _City) return;
                _City = value;
                NotifyPropertyChanged(m => m.City);
            }
        }
        private string _City;

        [DataMember]
        public string Country
        { 
            get { return _Country; }
            set
            {
                if (value == _Country) return;
                _Country = value;
                NotifyPropertyChanged(m => m.Country);
            }
        }
        private string _Country;

        [DataMember]
        public string Postcode
        { 
            get { return _Postcode; }
            set
            {
                if (value == _Postcode) return;
                _Postcode = value;
                NotifyPropertyChanged(m => m.Postcode);
            }
        }
        private string _Postcode;

        [DataMember]
        public ChangeTrackingCollection<Person> People
        {
            get { return _People; }
            set
            {
                if (Equals(value, _People)) return;
                _People = value;
                NotifyPropertyChanged(m => m.People);
            }
        }
        private ChangeTrackingCollection<Person> _People;


    } //Class
} //Namespace
