using System;
using System.IO;
using System.Net;
using System.Text;

class HttpServer
{
    static void Main(string[] args)
    {
        // Step 1: Create an HttpListener instance
        HttpListener listener = new HttpListener();

        // Step 2: Add prefixes to listen on (e.g., "http://localhost:9090/")
        listener.Prefixes.Add("http://192.168.19.223:80/");
        Console.WriteLine("Starting the server...");

        try
        {
            // Step 3: Start the listener
            listener.Start();
            Console.WriteLine("Server started. Press 'q' to stop the server.");

            while (true)
            {
                // Graceful exit condition
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Stopping the server...");
                    break;
                }

                // Step 4: Wait for an incoming request
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                Console.WriteLine($"Received request for {request.Url}");

                // Step 5: Read the HTML file dynamically
                string filePath = "index.html";
                string responseString;

                if (File.Exists(filePath))
                {
                    responseString = File.ReadAllText(filePath);
                }
                else
                {
                    // If file not found, send an error message
                    responseString = "<html><body><h1>404 - File Not Found</h1></body></html>";
                    response.StatusCode = 404;
                }

                // Step 6: Write the response
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);

                // Close the response
                response.OutputStream.Close();
            }
        }
        catch (HttpListenerException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Step 7: Stop the listener
            listener.Stop();
            Console.WriteLine("Server stopped.");
        }
    }
}