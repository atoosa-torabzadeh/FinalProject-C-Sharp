using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Services
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;
        public PersonApplicationService(){
            _personServiceModel=new PersonServiceModel();
        }
        #region GetAll()
        public List<GetPersonDto> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var getpersonDto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(getpersonDto);
            }
            return getPersonDtos;
        }
        #endregion

        #region post()
        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName
            };

            _personServiceModel.Insert(person);
           
        }
        #endregion

        #region Update()
        public void Update(UpdatePersonDto updatePersonDto)
        {
            var person = new Person
            {
                Id = updatePersonDto.Id,
                FirstName = updatePersonDto.FirstName,
                LastName = updatePersonDto.LastName,
                
            };
            _personServiceModel.Update(person);
        }
        #endregion

        #region Delete()
        public void Delete(DeletePersonDto deletePersonDto)
        {
            var person = new Person()
            {
                Id = deletePersonDto.Id
            };
            _personServiceModel.Delete(person);
        } 
        #endregion
    }
}
