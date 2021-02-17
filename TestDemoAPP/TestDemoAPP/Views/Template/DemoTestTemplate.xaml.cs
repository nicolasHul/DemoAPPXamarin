using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDemoAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoTestTemplate : ContentView
    {
        private bool _toggler;

        public static BindableProperty CommandParameterProperty =
         BindableProperty.Create(
         nameof(CommandParameter),
         typeof(object),
         typeof(DemoTestTemplate));

        public static BindableProperty CommandProperty =
           BindableProperty.Create(
           nameof(Command),
           typeof(ICommand),
           typeof(DemoTestTemplate),
           default(ICommand));

        public static readonly BindableProperty ColorProperty = BindableProperty.Create(
            nameof(Color),
            typeof(Color),
            typeof(DemoTestTemplate),
            Color.Blue);


        public DemoTestTemplate()
        {
            InitializeComponent();
            Content.BindingContext = this;
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Color = _toggler ? Color.Red : Color.Purple;
            _toggler = !_toggler;

            if (Command != null && Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }

    }
}