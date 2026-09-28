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
    }
}
