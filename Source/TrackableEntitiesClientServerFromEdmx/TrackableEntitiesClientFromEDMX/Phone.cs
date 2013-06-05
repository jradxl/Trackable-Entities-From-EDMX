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
    public partial class Phone : ModelBase<Phone>
    {
        public Phone()
        {
        }//ctor

        [DataMember]
        public int PhoneID
        { 
            get { return _PhoneID; }
            set
            {
                if (value == _PhoneID) return;
                _PhoneID = value;
                NotifyPropertyChanged(m => m.PhoneID);
            }
        }
        private int _PhoneID;

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
        public string PhoneNumber
        { 
            get { return _PhoneNumber; }
            set
            {
                if (value == _PhoneNumber) return;
                _PhoneNumber = value;
                NotifyPropertyChanged(m => m.PhoneNumber);
            }
        }
        private string _PhoneNumber;

        [DataMember]
        public Person Person
        {
            get { return _Person; }
            set
            {
                if (value == _Person) return;
                _Person = value;
                NotifyPropertyChanged(m => m.Person);
            }
        }
        private Person _Person;


    } //Class
} //Namespace
