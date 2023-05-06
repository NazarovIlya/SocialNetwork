using BusinessDomain.Model;
using Persistance;

namespace BusinessDomain.ExperimentalData
{
	public class TestDataProvider
	{
		public static async Task Provider(DataContex contex, int count = 20)
		{
			if (contex.Activities.Any()) return;

			List<Activeness> activities = new List<Activeness>();

			for (int i = 1; i < count; i++)
			{
				int month = Random.Shared.Next(0, 12);
				int category = Random.Shared.Next(0, 10);
				int city = Random.Shared.Next(0, 10);
				int location = Random.Shared.Next(0, 10);


				activities.Add(new Activeness
				{
					Title = $"Тестовая активность #{i}",
					PointTime = DateTime.SpecifyKind(DateTime.Now.AddMonths(month), DateTimeKind.Utc),
					Description = $"Описание #{month}",
					Category = $" Категория {category}",
					City = $"Город #{city}",
					Location = $"Место проведения #{location}",
				});
			}
		}
	}
}
