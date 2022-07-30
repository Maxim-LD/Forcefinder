using ForceFinder.Model;

namespace ForceFinder
{
    public class GetForceService
    {
        public double AverageForce(ForceViewModel model)
        {
            double result = model.Mass * model.Acceleration;
            return result;
        }
    }
}
