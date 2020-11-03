using DatabaseModule;
using Models;

namespace ORProcessor
{
    public class GetInformationByToken : IGetInformationByToken
    {
        private readonly IGetTokenModelByToken getTokenModelByToken;

        public GetInformationByToken(IGetTokenModelByToken getTokenModelByToken)
        {
            this.getTokenModelByToken = getTokenModelByToken;
        }

        public ShopWebAccountTokensModel Get(string token)
        {
            return getTokenModelByToken.Get(token);
        }
    }
}
