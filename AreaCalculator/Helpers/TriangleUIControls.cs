namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Defines the UI controls used in the TriangleControl class.
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

        public TriangleUIControls(TextBox sideABox, TextBox sideBBox, TextBox sideCBox, TextBox heightBox,
            Label sideALabel, Label sideBLabel, Label sideCLabel, Label heightLabel)
        {
            SideABox = sideABox;
            SideBBox = sideBBox;
            SideCBox = sideCBox;
            HeightBox = heightBox;
            SideALabel = sideALabel;
            SideBLabel = sideBLabel;
            SideCLabel = sideCLabel;
            HeightLabel = heightLabel;
        }   
    }
}
