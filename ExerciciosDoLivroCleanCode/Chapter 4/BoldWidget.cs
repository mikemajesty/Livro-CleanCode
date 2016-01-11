namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    internal class BoldWidgets
    {
        private MockWidgetRoot mockWidgetRoot;
        private string v;

        public BoldWidgets()
        {
        }

        public BoldWidgets(MockWidgetRoot mockWidgetRoot, string v)
        {
            this.mockWidgetRoot = mockWidgetRoot;
            this.v = v;
        }
    }
}