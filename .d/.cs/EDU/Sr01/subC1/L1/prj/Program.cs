using Gtk;
using static System.Net.Mime.MediaTypeNames;
// Gio.Application.FlagsNone
var app = Application.New("com.metanit.hello",Gio.Application.FlagsNone);

app.OnActivate += (sender, args) =>
{
    Window window = new Window();  // Создаем новое окно
    window.Title = "METANIT.COM";  // Устанавливаем заголовок окна
 
    window.DefaultWidth = 250;      // Устанавливаем начальную ширину окна
    window.DefaultHeight = 200;     // Устанавливаем начальную высоту окна
 
    // Свойство Application окна указывает на текущий объект приложения
    window.Application = (Application) sender;
 
    window.Show();    // Отображаем окно на экране
};
 
// запускаем приложение
return app.RunWithSynchronizationContext(null);