namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            // Буду делать через остатки от 100 и 10
            // При остатке 10 от деления на 100 всегда будет Рублей
            // 11 рублей, 111 рублей, 15 рублей, 115 рублей и т.д.
		    if (count % 100 <= 20 && count % 100 >= 10)
            {
                return "рублей";
            } else //Иначе зависит от остатка от деления на 10
            {
                int tensRemainder = count % 10;
                if (tensRemainder > 1 && tensRemainder < 5) // 4 рубля,3 рубля,но 5 рублей
                    return "рубля";
                else if (tensRemainder == 1)// рубль,просто рубль
                    return "рубль";
                else return "рублей";// в других случаях всегда будет рублей
            }
		}
	}
}