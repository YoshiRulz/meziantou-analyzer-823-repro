// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public readonly ref struct TestStruct(int n) //: IEquatable<TestStruct>
{
	public readonly int N
		=> n;

	public readonly override bool Equals(object? other)
		=> false;

	public readonly bool Equals(TestStruct other)
		=> n == other.N;

	public readonly override int GetHashCode()
		=> n;
}
