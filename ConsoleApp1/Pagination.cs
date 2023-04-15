namespace ConsoleApp1;
public static class CollectionExtension
{
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
        => self.Select((item, index) => (item, index));
  public  static int GetNumbers(this string input)
    {
        return Convert.ToInt32(new string(input.Where(c => char.IsDigit(c)).ToArray()));
    }
}