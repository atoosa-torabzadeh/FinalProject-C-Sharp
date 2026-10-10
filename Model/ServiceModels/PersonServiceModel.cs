using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region selectAll()
        public List<Person> SelectAll()
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {

                }

            }
        }
        #endregion
        #region insert()
        public void insert(Person person)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    //context.Person.Add(person);
                    context.Add(person);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {

                }

            }
        }
        #endregion
        #region Update()
        public void Update(Person person)
        {
            using (var context = new ProjectDbContext()) {
                try
            {
                var currentPerson = context.Person.Find(person.Id);
                    if(currentPerson != null)
                    {
                        currentPerson.FirstName=person.FirstName;
                        currentPerson.LastName=person.LastName;
                        context.SaveChanges();
                    }
            }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {

                }

            }
        } 
        #endregion
    }
}
