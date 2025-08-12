using System.Text;

namespace AreaCalculator
{
    /// <summary>
    ///A Shape abstract class defines the blueprint for all specific shapes.
    ///It says: “Any real shape must tell me how to compute area and perimeter.”
    ///Use me like a template
    /// </summary>
    public abstract class Shape
    {

        //изчислява лице/площ
        public abstract double CalculateArea();

        //връща пълна информация за фигурата
        //not required for now
        public virtual string GetShapeInfo() 
        {
            throw new NotSupportedException("не днес, не си познал!");
        }
        

        //STANDBY METHOD ;) 
        [Obsolete("THROW OUT OF THE WINDOWWW!, Use GetShapeInfo instead dear")]
        public virtual string GetShapeName()
        {
            throw new NotSupportedException("Overrides in other classes");
        }
        
        public abstract double CalculatePerimeter();
        
       
        public virtual double CalculateDiagonal()
        {
            throw new NotSupportedException("Only in rectangle and parallelogram");
        }
        public virtual List<string> GetSummary()
        {
            return new List<string>()
            {
                //will return this if the getsummary is not yeat implemented
                "Няма информация"
            };
           
        }


    }

}
