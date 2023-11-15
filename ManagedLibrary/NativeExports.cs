using System.Runtime.InteropServices;

namespace ManagedLibrary
{
  public static unsafe class NativeExports
  {
    [UnmanagedCallersOnly(EntryPoint = nameof(MyEqual))]
    public static unsafe bool MyEqual(int a, int b)
    {
      return EqualityComparer<int>.Default.Equals(a, b);
    }
  }
}