using System.Net.Sockets;

if (args.Length < 2)
{
    Console.WriteLine("Использование: program.exe <host> <port>");
    Console.WriteLine("Или: program.exe <host> <startPort> <endPort>");
    return;
}

var scanner = new PortScan(args[0]);

if (args.Length == 2)
{
    await scanner.ScanPortAsync(Convert.ToInt32(args[1]));
}
else if (args.Length == 3)
{
    await scanner.ScanPortRangeAsync(
        Convert.ToInt32(args[1]),
        Convert.ToInt32(args[2])
    );
}

public class PortScan
{
    private string targetHost;
    private int timeout;

    public PortScan(string host, int timeoutMs = 1000)
    {
        targetHost = host;
        timeout = timeoutMs;
    }

    public async Task<bool> ScanPortAsync(int port)
    {
        using (var client = new TcpClient())
        using (var cts = new CancellationTokenSource(timeout))
        {
            try
            {
                await client.ConnectAsync(targetHost, port, cts.Token);
                Console.WriteLine($"Порт {port} открыт");
                return true;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"Порт {port} закрыт (таймаут)");
            }
            catch (SocketException)
            {
                Console.WriteLine($"Порт {port} закрыт");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Порт {port} ошибка: {ex.Message}");
            }
            return false;
        }
    }

    public async Task ScanPortRangeAsync(int startPort, int endPort, int maxThreads = 10)
    {
        var semaphore = new SemaphoreSlim(maxThreads);
        var tasks = new List<Task>();

        for (int port = startPort; port <= endPort; port++)
        {
            await semaphore.WaitAsync();

            var task = Task.Run(async () =>
            {
                try
                {
                    await ScanPortAsync(port);
                }
                finally
                {
                    semaphore.Release();
                }
            });

            tasks.Add(task);
        }

        await Task.WhenAll(tasks);
    }
}
