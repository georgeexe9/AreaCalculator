
using AreaCalculator.Trapezoids;
using System.Text;

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
            trapesz();
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
                    Shape square = new Square(side);

                    //Извикваме CalculateArea без да ни интересува как подяволите работи,
                    //защриховаме към променлива от същия типаж
                    double squareArea = square.CalculateArea();
                    double squarePerimeter = square.CalculatePerimeter();
                    string info = square.GetSummary();
                    //визуализираме резултата в лейбъл
                    SquareAreaResult.Text = $"Лице/Площ - {squareArea}, Периметър - {squarePerimeter}";
                    MessageBox.Show(info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SideA.Clear();
                    SquareAreaResult.Text = "";
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
                    Shape rectangle = new Rectangle(sideA, sideB);
                    double rectangleArea = rectangle.CalculateArea();
                    double rectanglePerimeter = rectangle.CalculatePerimeter();
                    string infoRectangle = rectangle.GetSummary();
                    RectangleAreaResult.Text = $"Лице/Площ - {rectangleArea}, Периметър - {rectanglePerimeter}";
                    MessageBox.Show(infoRectangle, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SideARectangle.Clear();
                    SideBRectangle.Clear();
                    RectangleAreaResult.Text = "";
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
                    double sideB = double.Parse(sideBTriangle.Text.Trim());
                    double sideC = double.Parse(sideCTriangle.Text.Trim());
                    double height = double.Parse(heightTriangle.Text.Trim());
                    Shape triangle = new Triangle(sideA, sideB, sideC, height);
                    double triangleArea = triangle.CalculateArea();
                    double trianglePerimeter = triangle.CalculatePerimeter();
                    AreaTriangle.Text = $"Лице/Площ: {triangleArea}, Периметър: {trianglePerimeter}";
                    string info = triangle.GetSummary();
                    MessageBox.Show(info, "Информация за фигурата:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sideATriangle.Clear();
                    sideBTriangle.Clear();
                    sideCTriangle.Clear();
                    heightTriangle.Clear();
                    AreaTriangle.Text = "";
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
                double sidec = double.Parse(SideCBox.Text.Trim());
                double sided = double.Parse(SideDBox.Text.Trim());
                double height = double.Parse(HeightBox.Text.Trim());
                Shape trapezoid = new Trapezoid(sidea, sideb,sidec,sided, height);
                double resultArea = trapezoid.CalculateArea();
                double resultPerimeter = trapezoid.CalculatePerimeter();
                string infoTrapezoid = trapezoid.GetSummary();
                TrapezoidLabelInfo.Text = $"Лице/Площ - {resultArea}, Периметър - {resultPerimeter}";
                MessageBox.Show(infoTrapezoid, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SideABox.Clear();
                SideBbox.Clear();
                SideCBox.Clear();
                SideDBox.Clear();
                HeightBox.Clear();
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


        private void SumParellelogram_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SideAParallelogram.Text) && !string.IsNullOrWhiteSpace(SideBParallelogram.Text) && !string.IsNullOrWhiteSpace(HeightParallelogram.Text))
            {
                try
                {
                    double side = double.Parse(SideAParallelogram.Text.Trim());
                    double sideb = double.Parse(SideBParallelogram.Text.Trim());
                    double height = double.Parse(HeightParallelogram.Text.Trim());


                    Shape parallelogram = new Parallelogram(side, sideb, height);
                    double result = parallelogram.CalculateArea();
                    double resultPerimeter = parallelogram.CalculatePerimeter();
                    ResultParallelogram.Text = $"Лицето е {result}";
                    ResultParallelogramPerimeter.Text = $"Периметъра е {resultPerimeter}";
                    string getinfo = parallelogram.GetSummary();
                    MessageBox.Show(getinfo, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SideAParallelogram.Clear();
                    SideBParallelogram.Clear();
                    HeightParallelogram.Clear();
                    ResultParallelogram.Text = "";
                    ResultParallelogramPerimeter.Text = "";

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
            else
            {
                MessageBox.Show("Моля въведете страната а, страната b и височината на успоредника!");
            }

        }
        public void trapesz()
        {
            try
            {
                double SideA = 10;
                double SideB = 6;
                double sideC = 5;
                double sideD = 5;
                double height = 4;

                IsoscelesTrapezoid tr = new IsoscelesTrapezoid(SideA, SideB, sideC, sideD, height);
                double area = tr.CalculateArea();

                double perimeter = tr.CalculatePerimeter();
                StringBuilder sbs = new StringBuilder();
                sbs.AppendLine($"Площ/Лице - {area}, Периметър - {perimeter}");

                MessageBox.Show(sbs.ToString(), "title");
            }
            
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message, "ЧАООООООООО");
            }
            
           

        }


    }
}

