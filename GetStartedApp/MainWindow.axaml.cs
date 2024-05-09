// Импорт необходимых пространств имён из Avalonia для работы с элементами UI и загрузки XAML
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _33_4 {
    // Определение класса MainWindow, наследующего от класса Window
    public partial class MainWindow : Window  // Добавлен модификатор partial
    {
        // Конструктор для MainWindow
        public MainWindow()
        {
            // Вызов метода InitializeComponent, который загружает XAML-разметку и связывает её с этим окном
            InitializeComponent();

            // Условная компиляция; блок кода внутри будет выполнен только если проект собран в режиме DEBUG
    #if DEBUG
            // Метод AttachDevTools позволяет открыть инструменты разработчика в Avalonia приложении
            this.AttachDevTools();
    #endif
        }

        // Метод InitializeComponent, используемый для загрузки и применения XAML-разметки к окну
        private void InitializeComponent()
        {
            // AvaloniaXamlLoader.Load(this) загружает XAML, ассоциированный с текущим окном,
            // что позволяет использовать размеченные элементы в коде.
            AvaloniaXamlLoader.Load(this);
        }
    }
}