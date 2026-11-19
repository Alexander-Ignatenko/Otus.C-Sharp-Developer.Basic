
namespace HomeFitBot
{
    public class Program
    {
        // Константа с версией программы. Значение подставляется в вызывающий код на этапе компиляции.
        const string Version = "1.0.0";

        // Константа с названием бота. Значение подставляется в вызывающий код на этапе компиляции.
        const string BotName = "HomeFitBot";

        // Статическое поле дата создания программы. Значение задаётся один раз при инициализации типа.
        static readonly DateTime CreatedAt = new DateTime(2026, 10, 03);

        // Статическое поле с текущим именем пользователя.
        static string _userName;
    }
}