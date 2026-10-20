//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.OutputEncoding = Encoding.UTF8;

// Task 1
//string hostName = Dns.GetHostName();

//IPAddress[] addresses = Dns.GetHostAddresses(hostName);

//List<IPAddress> ipv4List = new List<IPAddress>();
//List<IPAddress> ipv6List = new List<IPAddress>();

//foreach (IPAddress address in addresses)
//{
//    if (address.AddressFamily == AddressFamily.InterNetwork)
//        ipv4List.Add(address);
//    else if (address.AddressFamily == AddressFamily.InterNetworkV6)
//        ipv6List.Add(address);
//}

//Console.WriteLine("Информация о компьютере");
//Console.WriteLine($"Имя компьютера: {hostName}");
//Console.WriteLine($"Всего адресов:  {addresses.Length}");
//Console.WriteLine();

//Console.WriteLine($"IPv4 адреса ({ipv4List.Count})");
//foreach (IPAddress ip in ipv4List)
//    Console.WriteLine($"{ip} Семейство: {ip.AddressFamily}");
//Console.WriteLine();

//Console.WriteLine($"IPv6 адреса ({ipv6List.Count})");
//foreach (IPAddress ip in ipv6List)
//    Console.WriteLine($"{ip} Семейство: {ip.AddressFamily}");


// Task 2
//Console.Write("Введите доменное имя (например, google.com): ");
//string name = Console.ReadLine();

//if (string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("Ошибка: имя не введено.");
//    return;
//}

//try
//{
//    IPHostEntry entry = Dns.GetHostEntry(name);

//    Console.WriteLine($"Домен:  {name}");
//    Console.WriteLine($"Имя хоста: {entry.HostName}");
//    Console.WriteLine($"Найдено IP-адресов: {entry.AddressList.Length}");
//    Console.WriteLine();

//    foreach (IPAddress ip in entry.AddressList)
//    {
//        if (ip.AddressFamily == AddressFamily.InterNetwork)
//        {
//            Console.WriteLine($"{ip.AddressFamily}: {ip}");
//        }
//        else if (ip.AddressFamily == AddressFamily.InterNetworkV6)
//        {
//            Console.WriteLine($"{ip.AddressFamily}: {ip}");
//        }
//    }
//}
//catch (SocketException ex)
//{
//    Console.WriteLine($"Не удалось найти домен: {ex.Message}");
//}