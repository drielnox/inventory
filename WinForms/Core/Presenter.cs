namespace SmartInventorySystem.WinForms.Core
{
    abstract class Presenter<TView>
        where TView : IView
    {
        protected TView View { get; private set; }

        public Presenter(TView view)
        {
            View = view;
        }
    }
}
