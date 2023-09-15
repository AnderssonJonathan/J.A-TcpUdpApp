# TCP & UDP Application

## About

The main goal with this application is to simulate how TCP and UDP connections behaves differently. This is done by enable a user to send a message by either TCP or UDP.

In order to simulate this process the application needs to be started simustainously via two terminals. One will work as a server where TCP and UDP connections can be established. The other one will then work as a client which main purpose is to send TCP or UDP messages. 

## Main Features 
- Start a TCP Server
- Start a UDP Server
- Send a TCP message
- Send a UDP message

## Set Up
Make sure to follow all the steps below in order to set up and controll the program as intended...

1. **Clone Repo**\
Clone the repository using the command git clone https://github.com/OrchardCMS/OrchardCore.git and checkout the main branch.

2. **SDK**\
Make sure to install the latest version of the .NET SDK from this page https://dotnet.microsoft.com/download

3. **Run Program x3**\
    **A)** Start prefered terminal and navigate to the program folder.\
    **B)** Start the application by calling `dotnet run`.\
    **C)** Repeat **A** + **B** two more times.\
    *It is prefeered to run this application in three terminals but it can also work in two terminals.

    You will now have three applications that are simustainously running the program.

4. **Controll the program**\
You can now control the program via the three terminals. In each terminal there is a menu and you run the commands by enter the number from 1-6 and hit enter as an input.

    **Establish TCP/ UDP connection**
    - Two terminals will act as two seperatly servers. You start a TCP connection on one of these and on the other you then start an UDP connecion. You establish a TCP/ UDP connections with input 1 or 2, shown in the menu.
    
    - When a connection have been established the user will reciev a confirmation of this in the terminal:\
    "TCP Server started. Waiting for connections...

     **Sending TCP/ UDP messages**
    - Now pretend that the third terminal is a client. On this one you can send TCP or UDP messages with input 3 or 4, shown in the menu.
    - **Response - Client**\
    When a message have been sent this message will appear in the terminal of the client:\
    "TCP Message sent: Testing TCP"
    - **Response - Server**\
    In the terminal of the server this message will appear when e.g. a TCP message has been sent:\
    "TCP Client connected.\
    TCP Message received: Testing TCP".

5. **Refresh/ Exit**
At any given time you can refresh the terminal by input 5 and the menu will be displayed again. Rember that a started server will continue to run.

Enter 6 as input in order to exit the application.

6. **User scenarios**

    - **Message not sent TCP**\
    If trying to send a TCP message before a TCP Server has been established the aplication is expected to crash and the user will have to start it up again in order to continue.

    - **Message not sent UDP**\
    If trying to send a UDP message before a UDP Server has been established the aplication is expected to continue without sending the message. There is no message informing the user of this. 
