using ConsoleApp1;

int pageCount = 6;
bool showStar = false;
var Radius = 2;
int currentPage = Convert.ToInt32((Console.ReadLine()));
if (currentPage > pageCount)
{
    currentPage = pageCount;
}
Console.WriteLine("**************************************");
Console.WriteLine("\n");


List<int> result = new List<int>();
for (int i = 1; i < pageCount; i++)
{
    result.Add(i);
}

if (pageCount < 6)
{
    result.ForEach(x =>
    {
        if (x == currentPage)
        {
            Console.WriteLine("PC:" + x);
        }
        else
        {
            Console.WriteLine(x);
        }
    });
}
else
{
    var res = new List<string>();
    foreach (var itemm in result)
    {
        if (res.Count == 5)
        {
            res.Add("***");
            break;
        }
        else
        {
            int target = (currentPage - 2);
            if (itemm < target)
            {

            }
            else if (itemm >= currentPage + 2)
            {
                res.Add(itemm == currentPage ? "PC:" + itemm : itemm.ToString());

            }
            else
            {
                res.Add(itemm == currentPage ? "PC:" + itemm : itemm.ToString());
            }
        }
    }

    if (res.Contains("***") == false && res.Count == 5)
    {
        res.Add("***");
    }


    if (res.Count <= 4 && pageCount - currentPage < 3)
    {
        var sub = 4 - res.Count;


        int first = res.First().GetNumbers();
        res.Reverse();
        for (int i = 0; i < sub; i++)
        {
            first -= 1;
            res.Add(first.ToString());
        }

        res.Reverse();
    }
    res.ForEach(Console.WriteLine);
}

Console.WriteLine(pageCount == currentPage ? "PC:" + pageCount : pageCount);

Console.ReadKey();

