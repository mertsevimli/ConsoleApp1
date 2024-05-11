using System.Globalization;

namespace Konu12KalitimInheritance;

internal class Kategori : OrtakOzellikler
{
public String? Resim { get; set; }
public String? Acıklamasi { get; set;}
public bool UstMenudeGoster { get; set; }
public bool YanMenudeGoster { get; set; }
}
