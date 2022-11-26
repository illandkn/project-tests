using Application.Models;
using Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services.User
{
    public interface IUserService
    {
        Task Create(UserRequestModel request);
        Task Delete(Guid id);
        Task<UserResponseModel> GetById(Guid id);
        Task<IList<UserResponseModel>> GetAll();
        Task Update(Guid id, UserRequestModel request);
        Task<ActionResult<dynamic>> Authenticate(UserLoginModelBase request);
    }
}
