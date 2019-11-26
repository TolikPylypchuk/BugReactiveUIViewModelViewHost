using ReactiveUI;

using Splat;

namespace BugReactiveUIViewModelViewHost
{
    public partial class View2 : ReactiveUserControl<ViewModel2>, IEnableLogger
    {
        public View2()
        {
            this.InitializeComponent();
            this.Log().Info("Creating the view 2");
        }
    }
}
