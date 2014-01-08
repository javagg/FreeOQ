using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRule80A : FIXCharField
  {
    public const char AgencySingleOrder = 'A';
    public const char ShortExemptTransactionAType = 'B';
    public const char ProgramOrderNonIndexArbForMemberFirm = 'C';
    public const char ProgramOrderIndexArbForMemberFirm = 'D';
    public const char ShortExemptTransactionForPrincipal = 'E';
    public const char ShortExemptTransactionWType = 'F';
    public const char ShortExemptTransactionIType = 'H';
    public const char IndividualInvestorSingleOrder = 'I';
    public const char ProgramOrderIndexArbForIndividualCustomer = 'J';
    public const char ProgramOrderNonIndexArbForIndividualCustomer = 'K';
    public const char ShortExemptTransactionForMemberCompetingMarketMakerAffiliatedWithTheFirmCleraingTheTrade = 'L';
    public const char ProgramOrderIndexArbForOtherMember = 'M';
    public const char ProgramOrderNonIndexArbForOtherMember = 'N';
    public const char ProprietaryTransactionsForCompetingMarketMakerThatIsAffiliatedWithTheClearingMember = 'O';
    public const char Principal = 'P';
    public const char TransactionsForTheAccountOfANonMemberCompetingMarketMaker = 'R';
    public const char SpecialistTrades = 'S';
    public const char TransactionsForTheAccountofAnUnaffiliatedMembersCompetingMarketMaker = 'T';
    public const char ProgramOrderIndexArbForOtherAgency = 'U';
    public const char AllOtherOrdersAsAgentForOtherMember = 'W';
    public const char ShortExemptTransactionForMemberCompetingMarketMakerNotAffiliatedWithTheFirmClearingTheTrade = 'X';
    public const char ProgramOrderNonIndexArbForOtherAgency = 'Y';
    public const char ShortExemptTransactionForNonMemberCompetingMarketMakerAAndRTypes = 'Z';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRule80A(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(47, val);
    }
  }
}
