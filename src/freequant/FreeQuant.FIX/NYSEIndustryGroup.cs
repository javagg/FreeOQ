using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class NYSEIndustryGroup : FIXStringField
  {
    public const string Aerospace = "102";
    public const string BusinessSuppliesAndServices = "104";
    public const string Chemicals = "106";
    public const string ComputersAndDataProcessing = "108";
    public const string Construction = "110";
    public const string ElectricalEquipment = "112";
    public const string Electronics = "114";
    public const string EnvironmentalControl = "116";
    public const string FoodsBeverages = "118";
    public const string HealthAndBeautyProducts = "120";
    public const string HealthCareServices = "122";
    public const string HouseholdGoods = "124";
    public const string IndustrialMachineryAndEquipment = "126";
    public const string LodgingRestaurants = "128";
    public const string MiningRefiningFabricating = "130";
    public const string MotorVehicles = "132";
    public const string OilAndGas = "134";
    public const string Packaging = "136";
    public const string PaperProduction = "138";
    public const string Pharmaceuticals = "140";
    public const string Publishing = "142";
    public const string RecreationServicesAndProducts = "144";
    public const string RetailTrade = "146";
    public const string TextilesApparel = "148";
    public const string TiresRubber = "150";
    public const string Tobacco = "152";
    public const string WholesalersDistributors = "154";
    public const string MultiIndustry = "170";
    public const string Other = "180";
    public const string Air = "202";
    public const string Rail = "204";
    public const string Trucking = "206";
    public const string OtherTransportationServices = "208";
    public const string ElectricServices = "302";
    public const string GasServices = "304";
    public const string Telecommunications = "306";
    public const string WaterSupplyCompanies = "308";
    public const string MultiServiceCompanies = "310";
    public const string Banks = "402";
    public const string BrokerageServices = "404";
    public const string ClosedEndInvestmentCompanies = "406";
    public const string FinanceCompanies = "408";
    public const string Insurance = "410";
    public const string Trusts = "412";
    public const string RealEstate = "414";
    public const string DiversifiedFinancialServices = "416";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NYSEIndustryGroup(string val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(10102, val);
    }
  }
}
