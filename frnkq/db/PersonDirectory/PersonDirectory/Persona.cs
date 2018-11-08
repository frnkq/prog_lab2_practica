using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDirectory
{
    public class Persona
    {
        private string id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string personType;

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public Persona()
        {

        }
        public Persona(string id, string firstName, string middleName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public Persona(string id, string firstName, string middleName, string lastName, string personType)
            :this(id, firstName, middleName, lastName)
        {
            this.personType = personType;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.middleName + " " + this.lastName;
        }
    }
}
