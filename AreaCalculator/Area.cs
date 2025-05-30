﻿
namespace AreaCalculator
{

    public partial class CalculatorMainFrom : Form
    {
        /// <summary>
        /// ========================= AREA CALCULATOR C# .NET APPLICATION ;)=============================
        /// The purpose of this project is to demonstrate how object-oriented abstraction works.
        /// I have used a public abstract class named 'Shape', which is inherited by other non-sealed classes,
        /// in order to hide their internal implementation from the user and expose only the final result (e.g., area). 
        ///
        /// 
        ///
        /// ABSTRACT SHAPE
        /// ----> INHERITED BY INTERNAL CIRCLE, ELLIPSE, SQUARE, RECTANGLE, TRIANGLE, TRAPEZOID.
        /// 
        /// </summary>

        public CalculatorMainFrom()
        {
            InitializeComponent();
        }

        private void CalculatorMainFrom_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SideA.Text))
            {
                try
                {
                    //животът на променливата е кратък като моя!
                    double side = double.Parse(SideA.Text.Trim());

                    //създаваме нова инстанция Квадрат от абстрактен тип Форма
                    //присвояваме променливата side в абстрактия клас Форма
                    Shape shape = new Square(side);

                    //Извикваме CalculateArea без да ни интересува как подяволите работи,
                    //защриховаме към променлива от същия типаж
                    double squareArea = shape.CalculateArea();
                    //визуализираме резултата в лейбъл
                    SquareAreaResult.Text = $"Лицето е {squareArea}";
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Моля въведете числа, а не буквички!\n Чупите ми кода!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля въведете стойност за страната на квадрата!");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SideARectangle.Text) && !string.IsNullOrWhiteSpace(SideBRectangle.Text))
            {
                //try was expected to welp me here
                try
                {
                    double sideA = double.Parse(SideARectangle.Text.Trim());
                    double sideB = double.Parse(SideBRectangle.Text.Trim());
                    Shape shape = new Rectangle(sideA, sideB);
                    double rectangleArea = shape.CalculateArea();
                    RectangleAreaResult.Text = $"Лицето е {rectangleArea}";
                    SideARectangle.Clear();
                    SideBRectangle.Clear();
                }
                //хвърля грешка за неправилно въведени стойности
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //хвърля грешка за неправилно подаден тип данни
                catch (FormatException)
                {
                    MessageBox.Show("Моля въведете числа, а не буквички! Чупите ми кода!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля въведете стойности за страната а и страната b на правоъгълника");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sideATriangle.Text) && !string.IsNullOrWhiteSpace(heightTriangle.Text))
            {
                try
                {
                    double sideA = double.Parse(sideATriangle.Text.Trim());
                    double height = double.Parse(heightTriangle.Text.Trim());
                    Shape shape = new Triangle(sideA, height);
                    double triangleArea = shape.CalculateArea();
                    AreaTriangle.Text = $"Лицето е {triangleArea}";
                }
                //catch 
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                catch (FormatException)
                {
                    MessageBox.Show("Моля въведете валидни числа", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля въведете страната и височината на триъгълника");
            }




        }

        private void изчистиПолетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(SideA, sideATriangle, SideBRectangle, SideARectangle, heightTriangle);
        }
        public static void ClearAllTextBoxes(params TextBox[] TextBox)
        {
            foreach (var box in TextBox)
            {
                box.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double sidea = double.Parse(SideABox.Text.Trim());
                double sideb = double.Parse(SideBbox.Text.Trim());
                double height = double.Parse(HeightBox.Text.Trim());
                Shape shape = new Trapezoid(sidea, sideb, height);
                double result = shape.CalculateArea();
                TrapezoidLabelInfo.Text = $"Лицето е:{result}";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля, въведете числа! Чупите ми програма!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
