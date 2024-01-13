using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
    public  interface IAcountSitting
    {
        Task<User> UpdateUserinfo(UserUpdateDTO userUpdateDTO);
        Task <User> UpdateRole(UserRoleDTO roleDTO);
        Task<User> ChangePassword(ChangePasswordDTO changePasswordDTO);
        Task<User> ChageEmail(ChangeEmailDTO dTO);

    }
}
