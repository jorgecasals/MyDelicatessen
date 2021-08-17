namespace MyDelicatessen.RecursiveProblems
{
	public class ReverseStringAlgorithm
	{
		//Recursion: Specially inneficient
		public string ReverseStringRecursive(string text)
		{
			if (text.Length <= 1)
				return text;

			else return text[text.Length - 1] + ReverseStringRecursive(text.Substring(text.Length - 1));
		}
	}
}