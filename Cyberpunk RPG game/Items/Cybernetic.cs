namespace Cyberpunk_RPG_game.Items
{
    public class Cybernetic
    {
        public EnumCybernetics CyberType;
        public string FullName;
        public int Cost, StatBoostStr, StatBoostRef, StatBoostNet, StatBoostChr, CyberPsycho;

        public Cybernetic(Cybernetic cybernetic)
        {
            CyberType = cybernetic.CyberType;
            FullName = cybernetic.FullName;
            Cost = cybernetic.Cost;
            StatBoostStr = cybernetic.StatBoostStr;
            StatBoostRef = cybernetic.StatBoostRef;
            StatBoostNet = cybernetic.StatBoostNet;
            StatBoostChr = cybernetic.StatBoostChr;
            CyberPsycho = cybernetic.CyberPsycho;
        }
        public Cybernetic(EnumCybernetics cyberType, string fullName, int cost, int statBoostStr, int statBoostRef, int statBoostNet, int statBoostChr, int cyberPsycho)
        {
            CyberType = cyberType;
            FullName = fullName;
            Cost = cost;
            StatBoostStr = statBoostStr;
            StatBoostRef = statBoostRef; 
            StatBoostNet = statBoostNet;
            StatBoostChr = statBoostChr;
            CyberPsycho = cyberPsycho;
        }
    }
}
