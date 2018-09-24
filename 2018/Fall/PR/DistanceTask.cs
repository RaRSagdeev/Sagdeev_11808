using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            double distDA = Math.Sqrt(Math.Pow(x - ax,2) + Math.Pow(y - ay,2));
            double distDB = Math.Sqrt(Math.Pow(x - bx,2) + Math.Pow(y - by,2));
            double distAB = Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay - by,2));

            //скалярное произведение векторов
            double scalarABandAD = (x - ax) * (bx - ax) + (y - ay) * (by - ay);
            double scalarABandBD = (x - bx) * (-bx + ax) + (y - by) * (-by + ay);

            if (distAB == 0) return distDA;// на случай, когда B и A имеют одинаковые координаты
            // Если скалярное произведение >= 0, то угол острый или прямой
            if (scalarABandAD >= 0 && scalarABandBD >= 0)
            {
                //находим площадь треугольника через полупериметр
                double halfP = (distDA + distDB + distAB) / 2.0;
                double areaOfTrian = Math.Sqrt(Math.Abs((halfP * (halfP - distDA) * (halfP - distDB) * (halfP - distAB))));
                return (2.0 * areaOfTrian) / distAB;
                //пытался найти площадь через стороны, не получилось, выдавало ошибку :(
            }
            // если скалярные произведения меньше нуля, то нам нужно взять меньшее расстояние до одной из точек
            else if (scalarABandAD < 0 || scalarABandBD < 0)
            //Скалярное произведение < 0  когда cosAlfa<0, то есть угол тупой
            {
                return Math.Min(distDA, distDB);
            }
            else return 0;//выполняется, если точка находится в отрезке AB
        }
    }
}