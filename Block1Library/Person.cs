namespace Block1Library
{
    //The abstract keyword denotes this class is, in a sense, incomplete.
    //We don't intend to make Person objects, but instead will make more
    //specific types of objects which inherit from Person.
    public abstract class Person
    {
        //FIELDS
        //Variables used to store data about this type of object.
        //Only necessary when we have custom business rules.
        //Naming Convention: _camelCase
        //Access: Always private

        private string _firstName;
        private string _lastName;
        private readonly DateTime _dob;

        //PROPERTIES
        //Publicly availble "gatekeepers" for the object's fields
        //Define the rules for getting or setting values related to a field.
        //Naming Convention: PascalCase version of the Field (no underscore)
        //Access: Always public

        public string FirstName
        {
            //Getter - The rule for how to retrieve values from the field
            get { return _firstName; }

            //Setter - The rue for how to assign values to the field
            set 
            {
                if (value.Count() > 1)
                {
                    //Name provided is longer than one character -- we can use it.
                    _firstName = value;
                }//end if
                else
                {
                    //No characters given or only one character was given -- use a default value.
                    _firstName = "Not Given";
                }//end else
            }//end setter

        }//end FirstName prop

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime DOB
        {
            get { return _dob; }
            //set { _dob = value; } - No setter for ReadOnly
        }


        //CONSTRUCTORS
        //Special method(s) used to create objects of this type.
        //Naming Convention: PascalCase, match the class name
        //Access: Always public

        public Person(string firstName, string lastName, DateTime dob) //Fully-Qualified
        {
            //Assignment - Use the provided values (parameters) to set the properties
            //Property = parameter
            //PascalCase = camelCase

            FirstName = firstName;
            LastName = lastName;
            _dob = dob; //Read-Only, so we assign to the field directly.
            //This ensures you are only able to give DOB a value using the Fully-Qualified Constructor.

        }

        //METHODS
        //Provide additional functionality related to objects of this type.
        //*** METHOD SIGNATURE ***
        //[Access Modifier] [Keywords (Optional)] [Return Type] [MethodName]([Parmeters (Optional)])

        //ToString() : String representation of the object that can be formatted.
        //ToString() already exists for ALL objects, so we need to override the default behavior.

        //Default Behavior:
        //public override string ToString()
        //{
        //    //Parent definition of ToString() is returned.
        //    //In this case, Object's ToString() - Namespace.ClassName
        //    return base.ToString();
        //}

        //Basic Concatonation - Better, but a bit bulky and has lots of room for mistakes.
        //public override string ToString()
        //{
        //    //return base.ToString();

        //    return "Name: " + FirstName + " " + LastName + "\nDate of Birth: " + DOB;

        //}

        //String Format - Even better, still error-prone by forgetting/misnumbering a placeholder
        //public override string ToString()
        //{
        //    //return base.ToString();

        //    return string.Format("Name: {0} {1}\nDate of Birth: {2:d}", FirstName, LastName, DOB);

        //}

        //String Interpolation - Little room for error
        public override string ToString()
        {
            //return base.ToString();

            return string.Format($"Name: {FirstName} {LastName}\nDate of Birth: {DOB:d}");
        }

    }
}