using KashkeshetClient.ServersHandler;
using MenuBuilder.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashkeshetClient.MenuHandler.Options
{
    public class GroupChatCreatorOption : IOptions
    {
        private ServerHandler _serverHandler { get; set; }
        public GroupChatCreatorOption(ServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
