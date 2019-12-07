namespace DatingApp.API.Helpers
{
  // Used when querying for a PagedList<T>
  public class UserParams
  {
    private const int MaxPageSize = 50;
    public int PageNumber { get; set; } = 1;
    private int defaultPageSize = 10;
    public int PageSize
    {
      get { return defaultPageSize; }
      set { defaultPageSize = (value > MaxPageSize) ? MaxPageSize : value; }
    }

    public int UserId { get; set; }
    public string Gender { get; set; }
    public int MinAge { get; set; } = 18;
    public int MaxAge { get; set; } = 99;
    public string OrderBy { get; set; }

  }
}