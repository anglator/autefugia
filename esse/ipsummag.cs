public static async Task PublishMessage(NatsConnection connection, string subject, string message)
{
    await connection.PublishAsync(subject, message);
    Console.WriteLine($"Published message '{message}' to subject '{subject}'");
}
