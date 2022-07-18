using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		/* 
		 * Для борьбы с пиксельным шумом, подобным тому, что на изображении,
		 * обычно применяют медианный фильтр, в котором цвет каждого пикселя, 
		 * заменяется на медиану всех цветов в некоторой окрестности пикселя.
		 * https://en.wikipedia.org/wiki/Median_filter
		 * 
		 * Используйте окно размером 3х3 для не граничных пикселей,
		 * Окно размером 2х2 для угловых и 3х2 или 2х3 для граничных.
		 */
		public static double[,] MedianFilter(double[,] original)
		{
			return original;
		}

		public static double [,] AngleSorter(double[,]original)
        {
			var height = original.GetLength(0);
			var width = original.GetLength(1);
			var buf = new double[2, 2];
			var i = 0;
			var j = 0;
            for (var x = 0; x < height; x += height - 1)
            {
				for (var y = 0; y < width; y += width - 1)
                {
					buf[i,j]=
					j++;
                }
				i++;
            }
			return original;
        }

		public static double[,] EdgeSorter(double[,] original)
		{

			return original;
		}
		public static double[,] CentralSorter(double[,] original)
		{

			return original;
		}
	}
}