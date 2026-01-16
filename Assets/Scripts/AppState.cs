namespace dev.xrlab.core
{
    public class AppState
    {
        public AppStateId Id { get; }
        private readonly dev.xrlab.ui.UIView view;

        public AppState(AppStateId id, dev.xrlab.ui.UIView view)
        {
            Id = id;
            this.view = view;
        }

        public void Enter() => view.Show();
        public void Exit() => view.Hide();
    }
}