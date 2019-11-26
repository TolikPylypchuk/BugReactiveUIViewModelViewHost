using System.Reactive.Disposables;

using ReactiveUI;

namespace BugReactiveUIViewModelViewHost
{
    public partial class MainWindow : ReactiveWindow<MainViewModel>
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.ViewModel = new MainViewModel();

            this.WhenActivated(disposables =>
            {
                this.BindCommand(this.ViewModel, vm => vm.SwitchView, v => v.SwitchViewButton)
                    .DisposeWith(disposables);

                this.OneWayBind(this.ViewModel, vm => vm.Content, v => v.Host.ViewModel)
                    .DisposeWith(disposables);
            });
        }
    }
}
