# Project: DNS-LOOKUP
This project consists of three main components: a DNS server, a DNS client (a Windows Forms application), and an HTTP server. The purpose of this project is to implement a simple DNS resolution system where users can query various types of DNS records, and an HTTP server serves a basic HTML page when requested.

1. DNS Server (DnsServer)

The DNS server listens on port 5050 and allows clients to query for DNS records. It handles several types of DNS queries:

- **A records (Address Record)**: Resolves a domain name to its corresponding IP address.
- **MX records (Mail Exchange Record)**: Resolves the domain to its mail server.
- **CNAME records (Canonical Name Record)**: Resolves a domain name to its canonical alias.
- **PTR records (Pointer Record)**: Resolves an IP address to a domain name (reverse DNS lookup).

The server operates over TCP and listens for incoming connections from DNS clients. It then reads the query from the client, processes the query by calling methods that interact with a DNS lookup library (DnsClient), and responds with the appropriate DNS records.

**How it works:**
- The server accepts TCP connections and reads queries sent by the client.
- It parses the query (in the format `QueryType:Domain`) and determines the DNS record type (`A`, `MX`, `CNAME`, or `PTR`).
- Based on the query type, the server fetches the DNS records using the `LookupClient` from the `DnsClient` library and sends the response back to the client.

The following helper methods perform the actual DNS queries:
- `GetARecords()`: Resolves A records for the given domain.
- `GetMXRecords()`: Resolves MX records for the given domain.
- `GetCNAMERecord()`: Resolves CNAME records for the given domain.
- `GetPTRRecord()`: Resolves PTR records for the given IP address.

**2. DNS Client (Windows Forms Application)**

The DNS client is a Windows Forms application that provides a simple graphical interface for users to query DNS records. The interface consists of:
- A **ComboBox** to select the query type (A, MX, CNAME, PTR).
- A **TextBox** to enter the domain or IP address.
- A **ListBox** to display the DNS query results.
- A **Button** to initiate the query.
- An optional **"Open Website" button** to open the domain in a web browser if it resolves successfully.

**How it works:**
- The user enters a domain name or IP address in the `TextBox`.
- The user selects the DNS query type from the `ComboBox`.
- Upon clicking the **"Lookup"** button, the application connects to the DNS server (which is running locally on port 5050) via TCP.
- The application sends the formatted query (`QueryType:Domain`) to the DNS server.
- After receiving the response, the application displays the result in the `ListBox`.
- If the response contains a valid domain, the **"Open Website"** button becomes enabled, allowing the user to open the domain in their default browser.

**3. HTTP Server (HttpServer)**

The HTTP server is a basic web server that listens on `http://192.168.19.223:80/`. When it receives an incoming HTTP request, it attempts to serve the `index.html` file. If the file does not exist, it responds with a 404 error message.

**How it works:**
- The server starts by listening for incoming HTTP requests on the specified IP address and port.
- Upon receiving a request, it checks if the `index.html` file exists.
  - If the file exists, it reads the file and sends its contents as the response.
  - If the file does not exist, it sends a 404 error message in the response.
- The server runs in a loop until the user presses 'q' to stop the server.

**Key Features:**

- **DNS Server:**
  - Resolves various types of DNS records: A, MX, CNAME, PTR.
  - Provides a simple TCP interface to communicate with the client.
  - Handles DNS queries and sends appropriate responses back to the client.

- **DNS Client (Windows Forms):**
  - User-friendly interface for querying DNS records.
  - Supports A, MX, CNAME, and PTR queries.
  - Displays DNS query results and provides an option to open a website in the browser if the domain resolves to a valid address.

- **HTTP Server:**
  - A basic web server that serves an HTML file (`index.html`).
  - Handles HTTP requests on the local network.

**Detailed Workflow:**

1. **DNS Query Process:**
   - The user opens the DNS client (Windows Forms app).
   - The user enters a domain name or IP address and selects a query type (A, MX, CNAME, or PTR).
   - The DNS client sends the query to the DNS server using TCP.
   - The DNS server processes the query and returns the relevant DNS records (or an error message if something goes wrong).
   - The client displays the response in the GUI.

2. **HTTP Server Interaction:**
   - The HTTP server is running separately, waiting for HTTP requests.
   - When a request is received, it either serves the `index.html` file or returns a 404 error if the file is missing.

**Conclusion:**

This project demonstrates the ability to create a DNS server and client using C# and .NET, as well as a basic HTTP server for serving web content. The DNS server resolves various types of DNS queries, while the DNS client provides a user-friendly interface to interact with the server. The HTTP server demonstrates serving static content over HTTP. The combination of these three components forms the foundation of a basic DNS lookup service with the added ability to serve web pages.
