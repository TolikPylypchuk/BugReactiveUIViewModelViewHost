using System.Reactive;

using ReactiveUI;

using Splat;

namespace BugReactiveUIViewModelViewHost
{
    public class MainViewModel : ReactiveObject, IEnableLogger
    {
        private ReactiveObject content = new ViewModel1();

        public MainViewModel()
        {
            this.SwitchView = ReactiveCommand.Create(() =>
            {
                this.Log().Info("Switching the view.");
                this.Content = this.Content is ViewModel1 ? (ReactiveObject)new ViewModel2() : new ViewModel1();
            });
        }

        public ReactiveCommand<Unit, Unit> SwitchView { get; }

        public ReactiveObject Content
        {
            get => this.content;
            set => this.RaiseAndSetIfChanged(ref this.content, value);
        }
    }
}
