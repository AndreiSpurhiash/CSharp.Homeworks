using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class Engineer : IEngineer
    {
        public Guid id;
        protected string _firstName;
        protected string _lastName;
        protected DateTime? _dayOfBirth;
        protected int _experience;
        protected string _responsibilities;
        protected string _technologies;
        protected string _gitHubAccount;
        protected int salary = 500;

        public void Enginer(Guid Id, string firstName, string lastName, DateTime dayofBirth,
            int experience, string responsibilities, string technologies, string gitHubAccount)
        { 
            id = Id;
            _firstName = firstName;
            _lastName = lastName;
            _dayOfBirth = dayofBirth;
            _experience = experience;
            _responsibilities = responsibilities;
            _technologies = technologies;
            _gitHubAccount = gitHubAccount;
        }

        public  virtual void Salary()
        {
            salary = 500;
            Console.WriteLine(salary);
        }

        private static List<Engineer> _collection = new List<Engineer>();

        public void CreateEngineer(Engineer engineer)
        {
            _collection.Add(engineer);
        }

        public void DeleteEngineer(Guid id)
        {
            foreach (var item in _collection)
            {
                if (item.id == id)
                    _collection.Remove(item);
            }

        }

        public List<Engineer> GetAll()
        {
            return _collection;
        }

        public Engineer Update(Engineer engineer)
        {
            return engineer;
        }
    }
}
