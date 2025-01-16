using System.Net.Sockets;

TcpListener myListener;
int port = 5000; 

System.Net.IPAddress local = System.Net.IPAddress.Parse();

string webServerPath = @"WebServer";


myListener = new TcpListener("127.0.0.1");

