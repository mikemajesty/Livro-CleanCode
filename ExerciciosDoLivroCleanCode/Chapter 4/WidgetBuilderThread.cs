namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    internal class WidgetBuilderThread
    {
        private AtomicBoolean failFlag;
        private ParentWidget parent;
        private string text;
        private WidgetBuilder widgetBuilder;

        public WidgetBuilderThread(WidgetBuilder widgetBuilder, string text, ParentWidget parent, AtomicBoolean failFlag)
        {
            this.widgetBuilder = widgetBuilder;
            this.text = text;
            this.parent = parent;
            this.failFlag = failFlag;
        }
    }
}