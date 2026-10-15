namespace Tyuiu.AndrianovSA.Sprint2.Review.V11.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Уравнения трех окружностей с вашего графика:
            // 1. Большая основная окружность
            bool inMainCircle = (Math.Pow(x - 1.2, 2) + Math.Pow(y + 1, 2) <= Math.Pow(1.8, 2));

            // 2. Верхняя фиолетовая окружность
            bool inTopPurple = (Math.Pow(x - 0.9, 2) + Math.Pow(y - 1, 2) <= Math.Pow(0.7, 2));

            // 3. Нижняя/правая вырезаемая окружность (по формуле с графика)
            bool inBottomCircle = (Math.Pow(x - 1.3, 2) + Math.Pow(y - (-1.3), 2) <= Math.Pow(1.3, 2));

            // Итоговое условие для заштрихованной области (внутри главной и вне вырезов)
            bool res = inMainCircle && !inTopPurple && !inBottomCircle;

            return res;
        }
    }
}