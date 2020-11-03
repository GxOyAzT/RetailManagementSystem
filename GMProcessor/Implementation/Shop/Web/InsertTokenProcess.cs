using DatabaseModule;
using Models;
using System;

namespace GMProcessor
{
    public class InsertTokenProcess : IInsertTokenProcess
    {
        private readonly IGenerateToken generateToken;
        private readonly IInsertToken insertToken;

        public InsertTokenProcess(IGenerateToken generateToken, IInsertToken insertToken)
        {
            this.generateToken = generateToken;
            this.insertToken = insertToken;
        }

        public string Insert(Guid shopId)
        {
            var model = new ShopWebAccountTokensModel()
            {
                Id = Guid.NewGuid(),
                ShopId = shopId,
                Token = generateToken.Generate(),
                DateTm = DateTime.Now
            };

            insertToken.Insert(model);

            return model.Token;
        }
    }
}
