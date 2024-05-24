namespace API.Extensions;

public static class DateTimeExtensions
{
    //this method is not accurate for leap year (29 of February), but for every other day - it's fine
    public static int CalculateAge(this DateOnly dob)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);

        var age = today.Year - dob.Year;

        if (dob > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }
}
