namespace Core.Specifications;

public class ProductsSpecParams
{
    private const int MaxPageSize = 50;
    public int PageIndex { get; set; } = 1;
private int _pageSize;
public int PageSize
{
    get => _pageSize = 6;
    set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
}

     private List<string> _brands = [];
     public List<string> brands
     {
        get => _brands; // types = boards, gloves
        set
        {
            _brands = value.SelectMany(x => x.Split(',',
                StringSplitOptions.RemoveEmptyEntries)).ToList();
        }
     }
     
     private List<string> _types = [];
     public List<string> types
     {
        get => _types; // types = boards, gloves
        set
        {
            _types = value.SelectMany(x => x.Split(',',
                StringSplitOptions.RemoveEmptyEntries)).ToList();
        }
     }

     public string? Sort { get; set; }

     private string? _search;
     public string Search
     {
        get => _search ?? "";
        set => _search = value.ToLower();
     }
}
