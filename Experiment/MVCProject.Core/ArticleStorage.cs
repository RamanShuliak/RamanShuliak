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
                PublicationDate = DateTime.Now,
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat a est in pulvinar. Ut rhoncus dignissim lacus vel maximus. Maecenas faucibus enim cursus nisi dignissim, id euismod libero dapibus. Etiam id mattis ante, id hendrerit lacus. Proin scelerisque mattis ligula in luctus. Aenean sed eros eu dolor fermentum semper ut et turpis. Morbi pretium mi nec arcu molestie, vel rhoncus purus vestibulum. Aliquam quis hendrerit nisi. Curabitur leo nisl, aliquet vitae erat nec, aliquam gravida nibh. Vivamus imperdiet, nibh vitae sollicitudin congue, urna nunc convallis nisi, id fringilla ante ipsum non mauris. Proin tortor arcu, elementum ac arcu sollicitudin, egestas scelerisque dui. Donec vel purus et sapien iaculis cursus. Vestibulum in odio a ipsum faucibus ullamcorper. Donec in consectetur tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nPellentesque lacinia molestie aliquam. Maecenas varius ornare enim, quis mattis nulla congue non. Nullam hendrerit ac nunc a suscipit. Phasellus in nisi risus. In hac habitasse platea dictumst. Aenean tincidunt nisi elementum nisi vulputate, vel commodo sem pharetra. In rutrum nisl metus, eu vehicula nunc efficitur facilisis. Nullam eget pulvinar mi.\r\n\r\nFusce iaculis ultrices sodales. Integer eu varius orci. Ut at mollis arcu. Sed pretium malesuada eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc fringilla enim sed tincidunt gravida. Ut justo massa, hendrerit id imperdiet sit amet, porta at ex. Nam rutrum velit iaculis, tempor lectus sed, pulvinar felis. Quisque commodo euismod ex sollicitudin faucibus. Phasellus ac libero dui. In lobortis, lacus ut laoreet dignissim, velit dui cursus quam, a volutpat elit erat id sapien. Aliquam vulputate tincidunt metus quis imperdiet. Proin vitae magna elementum, viverra felis ut, iaculis massa. Morbi luctus massa massa, at accumsan nisi condimentum vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin sed erat eu velit tristique feugiat vitae sit amet nunc. "
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now,
                Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat a est in pulvinar. Ut rhoncus dignissim lacus vel maximus. Maecenas faucibus enim cursus nisi dignissim, id euismod libero dapibus. Etiam id mattis ante, id hendrerit lacus. Proin scelerisque mattis ligula in luctus. Aenean sed eros eu dolor fermentum semper ut et turpis. Morbi pretium mi nec arcu molestie, vel rhoncus purus vestibulum. Aliquam quis hendrerit nisi. Curabitur leo nisl, aliquet vitae erat nec, aliquam gravida nibh. Vivamus imperdiet, nibh vitae sollicitudin congue, urna nunc convallis nisi, id fringilla ante ipsum non mauris. Proin tortor arcu, elementum ac arcu sollicitudin, egestas scelerisque dui. Donec vel purus et sapien iaculis cursus. Vestibulum in odio a ipsum faucibus ullamcorper. Donec in consectetur tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nPellentesque lacinia molestie aliquam. Maecenas varius ornare enim, quis mattis nulla congue non. Nullam hendrerit ac nunc a suscipit. Phasellus in nisi risus. In hac habitasse platea dictumst. Aenean tincidunt nisi elementum nisi vulputate, vel commodo sem pharetra. In rutrum nisl metus, eu vehicula nunc efficitur facilisis. Nullam eget pulvinar mi.\r\n\r\nFusce iaculis ultrices sodales. Integer eu varius orci. Ut at mollis arcu. Sed pretium malesuada eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc fringilla enim sed tincidunt gravida. Ut justo massa, hendrerit id imperdiet sit amet, porta at ex. Nam rutrum velit iaculis, tempor lectus sed, pulvinar felis. Quisque commodo euismod ex sollicitudin faucibus. Phasellus ac libero dui. In lobortis, lacus ut laoreet dignissim, velit dui cursus quam, a volutpat elit erat id sapien. Aliquam vulputate tincidunt metus quis imperdiet. Proin vitae magna elementum, viverra felis ut, iaculis massa. Morbi luctus massa massa, at accumsan nisi condimentum vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin sed erat eu velit tristique feugiat vitae sit amet nunc. "
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now,
                Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat a est in pulvinar. Ut rhoncus dignissim lacus vel maximus. Maecenas faucibus enim cursus nisi dignissim, id euismod libero dapibus. Etiam id mattis ante, id hendrerit lacus. Proin scelerisque mattis ligula in luctus. Aenean sed eros eu dolor fermentum semper ut et turpis. Morbi pretium mi nec arcu molestie, vel rhoncus purus vestibulum. Aliquam quis hendrerit nisi. Curabitur leo nisl, aliquet vitae erat nec, aliquam gravida nibh. Vivamus imperdiet, nibh vitae sollicitudin congue, urna nunc convallis nisi, id fringilla ante ipsum non mauris. Proin tortor arcu, elementum ac arcu sollicitudin, egestas scelerisque dui. Donec vel purus et sapien iaculis cursus. Vestibulum in odio a ipsum faucibus ullamcorper. Donec in consectetur tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nPellentesque lacinia molestie aliquam. Maecenas varius ornare enim, quis mattis nulla congue non. Nullam hendrerit ac nunc a suscipit. Phasellus in nisi risus. In hac habitasse platea dictumst. Aenean tincidunt nisi elementum nisi vulputate, vel commodo sem pharetra. In rutrum nisl metus, eu vehicula nunc efficitur facilisis. Nullam eget pulvinar mi.\r\n\r\nFusce iaculis ultrices sodales. Integer eu varius orci. Ut at mollis arcu. Sed pretium malesuada eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc fringilla enim sed tincidunt gravida. Ut justo massa, hendrerit id imperdiet sit amet, porta at ex. Nam rutrum velit iaculis, tempor lectus sed, pulvinar felis. Quisque commodo euismod ex sollicitudin faucibus. Phasellus ac libero dui. In lobortis, lacus ut laoreet dignissim, velit dui cursus quam, a volutpat elit erat id sapien. Aliquam vulputate tincidunt metus quis imperdiet. Proin vitae magna elementum, viverra felis ut, iaculis massa. Morbi luctus massa massa, at accumsan nisi condimentum vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin sed erat eu velit tristique feugiat vitae sit amet nunc. "
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now,
                Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat a est in pulvinar. Ut rhoncus dignissim lacus vel maximus. Maecenas faucibus enim cursus nisi dignissim, id euismod libero dapibus. Etiam id mattis ante, id hendrerit lacus. Proin scelerisque mattis ligula in luctus. Aenean sed eros eu dolor fermentum semper ut et turpis. Morbi pretium mi nec arcu molestie, vel rhoncus purus vestibulum. Aliquam quis hendrerit nisi. Curabitur leo nisl, aliquet vitae erat nec, aliquam gravida nibh. Vivamus imperdiet, nibh vitae sollicitudin congue, urna nunc convallis nisi, id fringilla ante ipsum non mauris. Proin tortor arcu, elementum ac arcu sollicitudin, egestas scelerisque dui. Donec vel purus et sapien iaculis cursus. Vestibulum in odio a ipsum faucibus ullamcorper. Donec in consectetur tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nPellentesque lacinia molestie aliquam. Maecenas varius ornare enim, quis mattis nulla congue non. Nullam hendrerit ac nunc a suscipit. Phasellus in nisi risus. In hac habitasse platea dictumst. Aenean tincidunt nisi elementum nisi vulputate, vel commodo sem pharetra. In rutrum nisl metus, eu vehicula nunc efficitur facilisis. Nullam eget pulvinar mi.\r\n\r\nFusce iaculis ultrices sodales. Integer eu varius orci. Ut at mollis arcu. Sed pretium malesuada eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc fringilla enim sed tincidunt gravida. Ut justo massa, hendrerit id imperdiet sit amet, porta at ex. Nam rutrum velit iaculis, tempor lectus sed, pulvinar felis. Quisque commodo euismod ex sollicitudin faucibus. Phasellus ac libero dui. In lobortis, lacus ut laoreet dignissim, velit dui cursus quam, a volutpat elit erat id sapien. Aliquam vulputate tincidunt metus quis imperdiet. Proin vitae magna elementum, viverra felis ut, iaculis massa. Morbi luctus massa massa, at accumsan nisi condimentum vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin sed erat eu velit tristique feugiat vitae sit amet nunc. "
            },
            new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum",
                Category = "Text",
                ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec malesuada augue ac nulla gravida placerat. Nulla non volutpat mi. Morbi mollis gravida mauris in rhoncus. Curabitur porta, augue at aliquet tempus, orci mauris convallis nisi, at egestas ex massa a metus. Cras scelerisque sagittis efficitur. Quisque nisl tortor, congue sit amet lacinia at, semper vitae risus. Nunc bibendum lectus eu risus fermentum, et lobortis arcu eleifend. Pellentesque et purus sit amet orci posuere ullamcorper quis et libero. Sed tincidunt elementum arcu, eget varius tortor. Nam scelerisque placerat mollis. ",
                PublicationDate = DateTime.Now,
                Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat a est in pulvinar. Ut rhoncus dignissim lacus vel maximus. Maecenas faucibus enim cursus nisi dignissim, id euismod libero dapibus. Etiam id mattis ante, id hendrerit lacus. Proin scelerisque mattis ligula in luctus. Aenean sed eros eu dolor fermentum semper ut et turpis. Morbi pretium mi nec arcu molestie, vel rhoncus purus vestibulum. Aliquam quis hendrerit nisi. Curabitur leo nisl, aliquet vitae erat nec, aliquam gravida nibh. Vivamus imperdiet, nibh vitae sollicitudin congue, urna nunc convallis nisi, id fringilla ante ipsum non mauris. Proin tortor arcu, elementum ac arcu sollicitudin, egestas scelerisque dui. Donec vel purus et sapien iaculis cursus. Vestibulum in odio a ipsum faucibus ullamcorper. Donec in consectetur tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\r\n\r\nPellentesque lacinia molestie aliquam. Maecenas varius ornare enim, quis mattis nulla congue non. Nullam hendrerit ac nunc a suscipit. Phasellus in nisi risus. In hac habitasse platea dictumst. Aenean tincidunt nisi elementum nisi vulputate, vel commodo sem pharetra. In rutrum nisl metus, eu vehicula nunc efficitur facilisis. Nullam eget pulvinar mi.\r\n\r\nFusce iaculis ultrices sodales. Integer eu varius orci. Ut at mollis arcu. Sed pretium malesuada eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc fringilla enim sed tincidunt gravida. Ut justo massa, hendrerit id imperdiet sit amet, porta at ex. Nam rutrum velit iaculis, tempor lectus sed, pulvinar felis. Quisque commodo euismod ex sollicitudin faucibus. Phasellus ac libero dui. In lobortis, lacus ut laoreet dignissim, velit dui cursus quam, a volutpat elit erat id sapien. Aliquam vulputate tincidunt metus quis imperdiet. Proin vitae magna elementum, viverra felis ut, iaculis massa. Morbi luctus massa massa, at accumsan nisi condimentum vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin sed erat eu velit tristique feugiat vitae sit amet nunc. "
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
