using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new() {
                    Title = "Youth Picnic",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activities start at 11:00.",
                    Category = "Youth Ministry",
					Organizer = "Israel Jones",
                    City = "Lenoir City",
                    Venue = "Lenoir City Park",
                },
                new() {
                    Title = "Area-Wide Singing",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "An area-wide singing usually in July each year",
                    Category = "Area Meetings/Singing",
					Organizer = "Daniel Howell",
                    City = "Gatlinburg",
                    Venue = "Convention Center",
                },
                new() {
                    Title = "Bi Monthly Leadership Meeting",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Periodic meetings to discuss congregational projects",
                    Category = "Leadership Activities",
					Organizer = "Don Brown",
					City = "Lenoir City",
                    Venue = "Shoneys",
                },
                new() {
                    Title = "Skating Party",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "This is listed as a youth activity but everybody is encourages to participate.",
                    Category = "Youth Ministry",
					Organizer = "Israel Jones",
                    City = "Farragut",
                    Venue = "Ice Rink",
                },
                new() {
                    Title = "Ladies Monthly Meeting",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "A periodic meeting, usually monthly, to discuss ongoing and planned projects.",
                    Category = "Ladies Ministry",
					Organizer = "Libby Brown",
                    City = "Lenoir City",
                    Venue = "Church Building",
                },
                new() {
                    Title = "2024 Gospel Meeting",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "This year our gospel meeting will consist of a Summer Series with various preachers.",
                    Category = "Congregational Meetings",
					Organizer = "Jesse Nelsen",
                    City = "Lenoir City",
                    Venue = "Church Building",
                },
                new() {
                    Title = "VBS - 2024",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Annual VBS. Theme: Who are the Prophets?",
                    Category = "VBS",
					Organizer = "Israel Jones",
                    City = "Lenoir City",
                    Venue = "Church Building",
                },
                new() {
                    Title = "Clean out the shed - again!",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "We are trying to get rid of things we aren't using and probably never will.",
                    Category = "Work Day",
                    Organizer = "Joe McCameron",
					City = "Lenoir City",
                    Venue = "Storage Shed",
                },
                new() {
                    Title = "Monthly Breakfast at Shoneys",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Food and Fellowship - 9:00 a.m.",
                    Category = "Young at Heart Ministry",
					Organizer = "Don Chandler",
                    City = "Lenoir City",
                    Venue = "Shoneys",
                },
                new() {
                    Title = "Monthly Fellowship Meal",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "A monthly get together at area restaurants",
                    Category = "College Ministry",
					Organizer = "Jesse Nelsen",
                    City = "Lenoir City",
                    Venue = "Calhouns",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}