using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace TestApp
{

    public class Class1
    {

        public int CalculateRawMaterial(int count, float width, float length, int productType, int materialType)
        {
            if (count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }

            double area = width * length;
            double coefficient = GetProductTypeCoefficient(productType);
            double rejectedPercentage = GetMaterialTypeRejectedPercentage(materialType);

            if (coefficient == -1 || rejectedPercentage == -1)
            {
                return -1;
            }

            double rawMaterialPerUnit = area * coefficient;
            double totalRawMaterial = rawMaterialPerUnit * count / (1 - rejectedPercentage / 100);

            return (int)Math.Ceiling(totalRawMaterial);
        }

        private double GetProductTypeCoefficient(int productType)
        {
            switch (productType)
            {
                case 1:
                    return 1.1;
                case 2:
                    return 2.5;
                case 3:
                    return 8.43;
                default:
                    return -1;
            }
        }

        private double GetMaterialTypeRejectedPercentage(int materialType)
        {
            switch (materialType)
            {
                case 1:
                    return 0.3;
                case 2:
                    return 0.12;
                default:
                    return -1;
            }
        }

    }
}

