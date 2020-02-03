namespace AdProvider.Model
{
    public interface IRule
    {
        bool ShouldShowAd(Context context);
    }
}
