using System;
using Shared;

namespace AddDataApplication.ViewModel
{
    public class PersonVm
    {
        #region Properties

        public string Name
        {
            get { return person.Name; }
            set { person.Name = value; }
        }

        public Guid Id
        {
            get { return person.ID; }
            set { person.ID = value; }
        }
        public decimal Salary
        {
            get { return person.Salary; }
            set { person.Salary = value; }
        }

        public bool Ownskey
        {
            get { return person.Ownskey; }
            set { person.Ownskey = value; }
        }
        
        public int Type
        {
            get { return person.Type; }
            set { person.Type = value; }
        }


        #endregion

        private Person person;

        public PersonVm(string name, Guid id, int type, decimal salary, bool ownskey)
        {
            person = new Person(name, id, type, salary, ownskey);
        }
    }
}