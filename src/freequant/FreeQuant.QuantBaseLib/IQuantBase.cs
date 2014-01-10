namespace FreeQuant.QuantBaseLib
{
	public interface IQuantBase
	{
		IQuantBaseConnection OpenConnection(LogonInfo logon);
	}
}
