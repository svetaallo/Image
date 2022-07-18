﻿namespace Recognizer
{
	public static class GrayscaleTask
	{
		/* 
		 * Переведите изображение в серую гамму.
		 * 
		 * original[x, y] - массив пикселей с координатами x, y. 
		 * Каждый канал R,G,B лежит в диапазоне от 0 до 255.
		 * 
		 * Получившийся массив должен иметь те же размеры, 
		 * grayscale[x, y] - яркость пикселя (x,y) в диапазоне от 0.0 до 1.0
		 *
		 * Используйте формулу:
		 * Яркость = (0.299*R + 0.587*G + 0.114*B) / 255
		 * 
		 * Почему формула именно такая — читайте в википедии 
		 * http://ru.wikipedia.org/wiki/Оттенки_серого
		 */

		public static double[,] ToGrayscale(Pixel[,] original)
		{
			var grayPic = new double[original.GetLength(0), original.GetLength(1)];
			var height = original.GetLength(0);
			var width = original.GetLength(1);
			for (var x = 0; x < height; x++)
				for (var y = 0; y < width; y++)
					grayPic[x,y] = (original[x, y].R * 0.299 + original[x, y].G * 0.587 + original[x, y].B * 0.114) / 255;
			return grayPic;
		}
	}
}