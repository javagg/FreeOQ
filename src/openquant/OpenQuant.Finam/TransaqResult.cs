namespace OpenQuant.Finam
{
  public sealed class TransaqResult
  {
    public bool Success { get; private set; }

    public string TransactionId { get; private set; }

    public string Message { get; private set; }

    public string Error { get; private set; }

    public TransaqResult()
    {
    }

    public TransaqResult(string data)
    {
      this.TransactionId = this.Message = this.Error = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length)
      {
        switch (strArray[index])
        {
          case "success":
            this.Success = bool.Parse(strArray[index + 1]);
            break;
          case "transactionid":
            this.TransactionId = strArray[index + 1];
            break;
          case "message":
            this.Message = strArray[index + 1];
            break;
          case "error":
            this.Error = strArray[index + 1];
            break;
        }
        index += 2;
      }
    }
  }
}
