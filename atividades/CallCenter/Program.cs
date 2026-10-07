Random random = new Random();
CallCenter center = new CallCenter();

// Clientes ligando para o Call Center
center.Call(1234);
center.Call(5678);
center.Call(1468);
center.Call(9641);

// As chamadas são atendidas na ordem em que chegaram (FIFO)
while (center.AreWaitingCalls())
{
    IncomingCall? call = center.Answer("Gabriel");

    if (call == null)
    {
        continue;
    }

    Log($"Chamada #{call.Id} do cliente {call.ClientId} foi atendida por {call.Consultant}.");

    // Simula o tempo de atendimento da chamada
    Thread.Sleep(random.Next(1000, 3000));

    center.End(call);
    Log($"Chamada #{call.Id} do cliente {call.ClientId} foi encerrada por {call.Consultant}.");
}

static void Log(string text)
{
    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {text}");
}
