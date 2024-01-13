using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
	public interface IUserRepo : IBaseRepo<User>
	{
		Task<User> UpdateUser( UserUpdateDTO user );
		Task<User> ChangePassword( ChangePasswordDTO changePasswordDTO );
		Task<User> ChageEmail( ChangeEmailDTO dTO );
		Task<IEnumerable<User>> GetAllUsers();
		Task<AuthModel> ChangRole( UserRoleDTO userRoleDTO );
		Task<User> GetUser( string id );
		Task<IEnumerable<string>> GetUserRoles( User user );
	}
}
