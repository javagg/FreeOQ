namespace OpenQuant.Finam
{
  public sealed class TransaqMarket
  {
    public int Id { get; private set; }

    public string Name { get; private set; }

    public TransaqMarket(string data)
    {
      this.Name = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "market":
            this.Name = strArray[index + 1];
            break;
          case "id":
            this.Id = int.Parse(strArray[index + 1]);
            break;
        }
      }
    }
  }
}
