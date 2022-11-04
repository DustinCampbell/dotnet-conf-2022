var result = AddAll(new[] { 1, .2, 3, 4, 5 });
WriteLine(result);

T AddAll<T>(T[] values) where T : INumber<T> => values switch
{
    [] => T.Zero,
    [var first] => first,
    [var first, var second] => first + second,
};