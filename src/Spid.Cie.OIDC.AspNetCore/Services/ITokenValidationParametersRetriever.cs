using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;

namespace Spid.Cie.OIDC.AspNetCore.Services;

public interface ITokenValidationParametersRetriever
{
    Task<TokenValidationParameters> RetrieveTokenValidationParameter();
}
