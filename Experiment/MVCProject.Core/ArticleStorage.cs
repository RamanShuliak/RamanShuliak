using MVCProject.Core.DataTransferObject;

namespace MVCProject.Core
{
    public class ArticleStorage
    {
        public readonly List<ArticleDto> ArticlesList;

        public ArticleStorage()
        {
            ArticlesList = new()
            {
                 new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now
            }
            };
        }   
    }
}
