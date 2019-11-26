using ReactiveUI;

using Splat;

namespace BugReactiveUIViewModelViewHost
{
    public partial class View1 : ReactiveUserControl<ViewModel1>, IEnableLogger
    {
        public View1()
        {
            this.InitializeComponent();
            this.Log().Info("Creating the view 1");
        }
    }
}
