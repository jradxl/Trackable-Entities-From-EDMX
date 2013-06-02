// <autogenerated>
//   This file was generated by T4 code generator TrackableEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

namespace TrackableEntitiesDTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using TrackableEntities.Client;

    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class PersonInfo : ModelBase<PersonInfo>
    {
        public PersonInfo()
        {
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
        public string Data1
        { 
            get { return _Data1; }
            set
            {
                if (value == _Data1) return;
                _Data1 = value;
                NotifyPropertyChanged(m => m.Data1);
            }
        }
        private string _Data1;

        [DataMember]
        public string Data2
        { 
            get { return _Data2; }
            set
            {
                if (value == _Data2) return;
                _Data2 = value;
                NotifyPropertyChanged(m => m.Data2);
            }
        }
        private string _Data2;

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
