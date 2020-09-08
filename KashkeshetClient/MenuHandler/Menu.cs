using KashkeshetClient.MenuHandler.Options;
using KashkeshetClient.ServersHandler;
using MenuBuilder;
using MenuBuilder.IO.Input;
using MenuBuilder.Menus;
using MenuBuilder.Menus.NumberMenu;
using MenuBuilder.output;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace KashkeshetClient.MenuHandler
{
    public class Menu
    {
        public void Run(string name,TcpClient client)
        {
            IOutputSystem outputSystem = new ConsoleOutput();
            ISystemInput systemInput = new SystemInput();

            //IMenuBuilder launcRocket = new TextMenuBuilder("Launch Menu : ", outputSystem, systemInput);

            ServerHandler serverHandler = new ServerHandler(name,client);
            IMenu numberMenuBuilder = new NumberMenuBuilder("Chat options : ", outputSystem, systemInput).
                AddOptions("Get All Chats", new GetAllChatOption(serverHandler)).
                AddOptions("Create Private Chat", new PrivateChatCreatorOption(name,serverHandler)).
                AddOptions("Create Group Chat", new GroupChatCreatorOption(name,serverHandler)).
                AddOptions("Go into chat", new InsertToChatOption(serverHandler))
                .Build();

            //launcRocket.AddOptions("MoveBack", new NavigateMenu(numberMenuBuilder))


            numberMenuBuilder.Run();
        }
    }
}
