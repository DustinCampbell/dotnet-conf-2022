var result = AddAll(new[] { 1, 2, 3, 4, 5 });
WriteLine(result);

int AddAll(int[] values)
{
    int result = 0;
    foreach (var value in values)
    {
        result += value;
    }
    return result;
}
