// Type: SmartQuant.Shared.Data.Import.CSV.Separator
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Runtime.CompilerServices;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class Separator
  {
    private const string vsgg0EX2xr = "Tab";
    private const string h90gp9VGfP = "Comma";
    private const string dLRgNu9LA4 = "Semicolon";
    private const string JvMgtFm7o4 = "Space";
    public static readonly Separator Tab;
    public static readonly Separator Comma;
    public static readonly Separator Semicolon;
    public static readonly Separator Space;
    private string OW8gEJp9GL;
    private char aCugQ6nqnh;

    public string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OW8gEJp9GL;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Separator()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      Separator.Tab = new Separator(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30662), '\t');
      Separator.Comma = new Separator(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30672), ',');
      Separator.Semicolon = new Separator(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30686), ';');
      Separator.Space = new Separator(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30708), ' ');
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Separator(string displayName, char value)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OW8gEJp9GL = displayName;
      this.aCugQ6nqnh = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator char[](Separator separator)
    {
      return new char[1]
      {
        separator.aCugQ6nqnh
      };
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Separator Parse(string displayName)
    {
      string str;
      if ((str = displayName) != null)
      {
        if (str == RNaihRhYEl0wUmAftnB.aYu7exFQKN(30558))
          return Separator.Tab;
        if (str == RNaihRhYEl0wUmAftnB.aYu7exFQKN(30568))
          return Separator.Comma;
        if (str == RNaihRhYEl0wUmAftnB.aYu7exFQKN(30582))
          return Separator.Semicolon;
        if (str == RNaihRhYEl0wUmAftnB.aYu7exFQKN(30604))
          return Separator.Space;
      }
      throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30618) + displayName);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.OW8gEJp9GL;
    }
  }
}
