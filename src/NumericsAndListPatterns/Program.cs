var result = AddAll(new[] { 1, .2, 3, 4, 5 }.AsSpan());
WriteLine(result);

T AddAll<T>(Span<T> values) where T : INumber<T> => values switch
{
    [] => T.Zero,
    [var first, .. var rest] => first + AddAll(rest),
};