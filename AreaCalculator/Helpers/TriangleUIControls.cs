namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Defines the UI controls used in the TriangleControl - Helper - HelperTriangles classes.
    /// </summary>
    public class TriangleUIControls
    {
        public TextBox SideABox { get; }
        public TextBox SideBBox { get; }
        public TextBox SideCBox { get; }
        public TextBox HeightBox { get; }
        public Label SideALabel { get; }
        public Label SideBLabel { get; }
        public Label SideCLabel { get; }
        public Label HeightLabel { get; }
        public Label TriangleNameType { get; }
        public Label FormulaLabel { get; }
        public Label FunFactLabel { get; }

        public TriangleUIControls(TextBox sideABox, TextBox sideBBox, TextBox sideCBox, TextBox heightBox,
            Label sideALabel, Label sideBLabel, Label sideCLabel, Label heightLabel, Label triangleNameType, Label formulaLabel, Label funFactLabel)
        {
            SideABox = sideABox;
            SideBBox = sideBBox;
            SideCBox = sideCBox;
            HeightBox = heightBox;
            SideALabel = sideALabel;
            SideBLabel = sideBLabel;
            SideCLabel = sideCLabel;
            HeightLabel = heightLabel;
            TriangleNameType = triangleNameType;
            FormulaLabel = formulaLabel;
            FunFactLabel = funFactLabel;
        }


    }
}
