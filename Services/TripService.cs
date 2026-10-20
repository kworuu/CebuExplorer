namespace MidtermProj.Services;

public class TripService
{
    private readonly List<string> _ids = new();
    public IReadOnlyList<string> Ids => _ids;
    public int Count => _ids.Count;
    public event Action? OnChange;

    public bool Has(string id) => _ids.Contains(id);

    public void Toggle(string id)
    {
        if (!_ids.Remove(id)) _ids.Add(id);
        OnChange?.Invoke();
    }

    public void Clear() { _ids.Clear(); OnChange?.Invoke(); }
}