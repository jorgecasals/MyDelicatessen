using System.Text;

namespace MyDelicatessen.StringProblems
{
	public class StringReversal
	{
		//Reverse an string
		//The cost in memory is O(N) and the performance is O(N)
		public string Reverse(string textToReverse)
		{
			if (string.IsNullOrWhiteSpace(textToReverse))
			{
				return textToReverse;
			}

			StringBuilder stringBuilder = new StringBuilder(textToReverse.Length);

			for (int i = textToReverse.Length - 1; i >= 0; i++)
			{
				stringBuilder.Append(textToReverse[i]);
			}

			return stringBuilder.ToString();
		}
	}
}