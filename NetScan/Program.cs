using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;

class Program
{
    //Verifica gli host di rete raggiungibile nella rete designata dall'utente, recupera il nome (se possibile) e verifica (tra quelli attivi) quali porte (tra quelle presenti nella lista di controllo) sono aperte
    static async Task Main()
    {
        String baseIpAddress = GetBaseIpAddress();

        String publicIpAddress = await GetPublicIpAddress();

        List<int> ports = GetPortsToScan();

        IP[] network = new IP[256];
        for (int i = 0; i < network.Length; i++)
        {
            network[i] = new IP();
        }

        List<Task> tasks = new List<Task>();

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Scansione in corso...");
        Console.ResetColor();

        //Aggiunge alla lista dei Task le verifiche dei vari host
        for (int i = 1; i <= 255; i++)
        {
            tasks.Add(VerifyHost(baseIpAddress, i, network, ports));
        }

        //Verifica lo stato di avanzamento della scansione (aggiorna ogni 100ms)
        while (!Task.WhenAll(tasks).IsCompleted)
        {
            Console.Write("\r[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(GetProgressBar(TaskProgress(tasks), 50));
            Console.ResetColor();
            Console.Write($"] {TaskProgress(tasks):P0}");
            await Task.Delay(100);
        }

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Scansione della rete " + baseIpAddress + "0 completata.");
        Console.WriteLine("IP publico della rete " + publicIpAddress);
        Console.ResetColor();

        Print(network, baseIpAddress);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPremi un qualsiasi tasto per chiudere il programma...");
        Console.ResetColor();
        Console.ReadLine();
    }

    //Recupera l'indirizzo publico della rete in cui sei coneesso con la macchina che sta eseguendo questo programma
    private static async Task<String> GetPublicIpAddress()
    {
        String result = "NON trovato";

        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://ipapi.co/ip/");

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Errore nella richiesta all'API. Codice di stato: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Si è verificato un errore: " + ex.Message);
            }
        }

        return result;
    }

    //Restituisce l'indirizzo IP inserito dall'utente (solamente se della forma 'x.y.z.', altrimenti chiude il programma)
    private static String GetBaseIpAddress()
    {
        String result = "192.168.1.";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Inserisci l'indirizzo IP di base senza l'ultima cifra (es. 192.168.1.): ");
        Console.ResetColor();

        String input = Console.ReadLine();
        String pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.$";

        if (Regex.IsMatch(input, pattern))
        {
            result = input;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Formato indirizzo IP inserito non valido.");
            Environment.Exit(0);
        }

        return result;
    }

    //Restituisce la lista delle Porte che l'utente ha inserito e vuole verificare
    private static List<int> GetPortsToScan()
    {
        List<int> result = new List<int> { 20, 21, 22, 23, 80, 443 };

        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Attualmente verranno controllate le seguenti porte: ");
            Console.WriteLine("\t|");
            foreach (int port in result)
            {
                Console.WriteLine("\t|- " + port);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nInserisci una porta che vuoi controllare (o 'q' per uscire): ");
            Console.ResetColor();
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break; // Esci dal ciclo se l'utente inserisce 'q'
            }

            if (int.TryParse(input, out int number))
            {
                result.Add(number); // Aggiungi il numero alla lista
            }
        }

        return result;
    }

    //Verifica se l'host (passato alla funzione) è raggiungibile (se raggiungibile verifica anche le porte aperte tra quelle da verificare)
    private static async Task VerifyHost(String bIP, int host, IP[] n, List<int> p)
    {
        using (Ping ping = new Ping())
        {
            try
            {
                PingReply reply = await ping.SendPingAsync(bIP + host);
                if (reply.Status == IPStatus.Success)
                {
                    List<int> ports = new List<int>();
                    n[host].status = true;

                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(bIP + host);
                        n[host].name = hostEntry.HostName;
                    }
                    catch
                    {
                        //TODO - non fare nulla
                    }

                    foreach (int port in p)
                    {
                        if (VerifyPort(bIP + host, port))
                        {
                            ports.Add(port);
                        }
                    }
                    n[host].ports = ports;
                }
            }
            catch (PingException)
            {
                Console.WriteLine($"Errore durante il ping: {bIP + host}");
            }
        }
    }

    //Verifica se la porta dell'host (passata alla funzione) è aperta
    private static Boolean VerifyPort(String bIP, int p)
    {
        try
        {
            using (TcpClient client = new TcpClient())
            {
                client.Connect(bIP, p);
                return true;
            }
        }
        catch (SocketException)
        {
            return false;
        }
    }

    //Stampa il risultato della scansione (evidenziando in rosso gli host di cui non è stato possibile reperire il nome)
    private static void Print(IP[] n, String bIP)
    {
        for (int i = 1; i <= 255; i++)
        {
            if (n[i].status)
            {
                Console.WriteLine("\t|");
                Console.WriteLine("\t|");

                var name = n[i].name;

                if (name.Equals("nome NON trovato"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine("\t|--" + bIP + i);

                Console.WriteLine("\t|  " + n[i].name);
                foreach (int port in n[i].ports)
                {
                    Console.WriteLine("\t|\t|----" + port);
                }

                Console.ResetColor();
            }
        }
    }

    //Animazione della barra di avanzamento
    private static Double TaskProgress(List<Task> tasks)
    {
        int completedTasks = 0;
        foreach (var task in tasks)
        {
            if (task != null && task.IsCompleted)
            {
                completedTasks++;
            }
        }
        return (Double)completedTasks / tasks.Count;
    }
    private static String GetProgressBar(Double percent, int length)
    {
        int progressBarLength = (int)(length * percent);
        return new String('█', progressBarLength) + new String(' ', length - progressBarLength);
    }
}

public class IP
{
    public Boolean status = false;
    public String name = "nome NON trovato";
    public List<int> ports = new List<int>();
}
