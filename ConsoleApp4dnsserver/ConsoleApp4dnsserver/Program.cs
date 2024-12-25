using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using DnsClient;

class DnsServer
{
    static void Main()
    {
        int port = 5050; // Port to listen on
        TcpListener server = new TcpListener(IPAddress.Any, port);

        Console.WriteLine("DNS Server starting...");
        server.Start();

        while (true)
        {
            Console.WriteLine("Waiting for a client connection...");

            using (TcpClient client = server.AcceptTcpClient())
            using (NetworkStream stream = client.GetStream())
            {
                Console.WriteLine("Client connected!");

                // Receive query from client
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string query = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received query: {query}");

                string[] queryParts = query.Split(':');
                if (queryParts.Length != 2)
                {
                    byte[] errorResponse = Encoding.UTF8.GetBytes("Error: Invalid query format");
                    stream.Write(errorResponse, 0, errorResponse.Length);
                    continue;
                }

                string queryType = queryParts[0].ToUpper();
                string queryValue = queryParts[1];
                string response;

                try
                {
                    switch (queryType)
                    {
                        case "A":
                            response = GetARecords(queryValue);
                            break;

                        case "MX":
                            response = GetMXRecords(queryValue);
                            break;

                        case "CNAME":
                            response = GetCNAMERecord(queryValue);
                            break;

                        case "PTR":
                            response = GetPTRRecord(queryValue);
                            break;

                        default:
                            response = $"Unknown query type: {queryType}";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    response = $"Error resolving {queryType} record: {ex.Message}";
                }

                Console.WriteLine($"Resolved response: {response}");

                // Send response back to client
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
                Console.WriteLine("Response sent to client.");
            }
        }
    }

    private static string GetARecords(string domain)
    {
        try
        {
            var lookup = new LookupClient();
            var result = lookup.Query(domain, QueryType.A);

            var addresses = result.Answers.ARecords()
                .Select(record => record.Address.ToString())
                .ToList();

            return addresses.Count > 0
                ? string.Join(", ", addresses)
                : "No A records found.";
        }
        catch (Exception ex)
        {
            return $"Error retrieving A records: {ex.Message}";
        }
    }

    private static string GetMXRecords(string domain)
    {
        try
        {
            var lookup = new LookupClient();
            var result = lookup.Query(domain, QueryType.MX);

            var mxRecords = result.Answers.MxRecords()
                .Select(record => $"{record.Exchange} (Priority {record.Preference})")
                .ToList();

            return mxRecords.Count > 0
                ? string.Join(", ", mxRecords)
                : "No MX records found.";
        }
        catch (Exception ex)
        {
            return $"Error retrieving MX records: {ex.Message}";
        }
    }

    private static string GetCNAMERecord(string domain)
    {
        try
        {
            var lookup = new LookupClient();
            var result = lookup.Query(domain, QueryType.CNAME);

            var cnameRecords = result.Answers.CnameRecords()
                .Select(record => record.CanonicalName.ToString())
                .ToList();

            return cnameRecords.Count > 0
                ? string.Join(", ", cnameRecords)
                : "No CNAME record found.";
        }
        catch (Exception ex)
        {
            return $"Error retrieving CNAME records: {ex.Message}";
        }
    }

    private static string GetPTRRecord(string ipAddress)
    {
        try
        {
            var lookup = new LookupClient();
            var result = lookup.QueryReverse(IPAddress.Parse(ipAddress));

            var ptrRecords = result.Answers.PtrRecords()
                .Select(record => record.PtrDomainName.ToString())
                .ToList();

            return ptrRecords.Count > 0
                ? string.Join(", ", ptrRecords)
                : "No PTR records found.";
        }
        catch (Exception ex)
        {
            return $"Error retrieving PTR records: {ex.Message}";
        }
    }
}
