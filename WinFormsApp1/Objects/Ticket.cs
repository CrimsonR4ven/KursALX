namespace Lotto.Objects
{
	public class Ticket
	{
		public string Username;
		public List<int> Numbers;

		public Ticket(string username, List<int> numbers)
		{
			Username = username;
			Numbers = numbers;
		}
	}
}
