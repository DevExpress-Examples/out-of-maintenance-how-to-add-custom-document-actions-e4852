namespace WindowsFormsApplication1.ViewModels {
    public class ViewModelModuleA {
        public bool AllowAnotherAction { get; private set; }
        internal void DoSomeAction() {
            AllowAnotherAction = true;
        }
        internal void ResetSomeAction() {
            AllowAnotherAction = false;
        }
    }
}