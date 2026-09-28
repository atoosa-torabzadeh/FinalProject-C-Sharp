using ApplicationService.Dtos;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Services
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;
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
    }
}
