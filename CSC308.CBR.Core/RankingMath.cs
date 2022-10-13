namespace CSC308.CBR.Core;

public class RankingMath
{
    public static double WinChance(double ratingA, double ratingB)
    {
        var raisedTo = (ratingA - ratingB) / 400;
        var power = Math.Pow(10, raisedTo);
        var result = 1 / (1 + power);
        return result;
    }

    public static double WinnerNewRating(double chance, double rating)
    {
        return rating + (32 * (1 - chance));
    }

    public static double LoserNewRating(double chance, double rating)
    {
        return rating + (32 * (0 - chance));
    }
}