using WebApplication2.Models;

namespace WebApplication2.Services
{
    public static class EventLogger
    {
        public static Action<Event> OnEventCreated = e =>
        {
            Console.WriteLine($"Evento criado: {e.Title} em {e.Date.ToShortDateString()} no local {e.Location}");
        };
    }
}
