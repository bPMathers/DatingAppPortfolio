namespace DatingApp.API.Helpers
{
  public class MessageParams
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
    public string MessageContainer { get; set; } = "Unread";
  }
}