namespace Cyberpunk_RPG_game.Items
{
    public class CyberneticsList
    {
        public static Cybernetic GetRavenFullBody()
        {
            Cybernetic RavenFullBody = new Cybernetic(EnumCybernetics.FULLBODY, "Raven R.M.C. Gemini", 100000, 1, 1, 1, 2, 30);

            return RavenFullBody;
        }
        public static Cybernetic GetNovelTechFullBody()
        {
            Cybernetic NovelTechFullBody = new Cybernetic(EnumCybernetics.FULLBODY, "NovelTech Samson", 150000, 2, 2, 1, -1, 40);

            return NovelTechFullBody;
        }
        public static Cybernetic GetIECFullBody()
        {
            Cybernetic IECFullBody = new Cybernetic(EnumCybernetics.FULLBODY, "IEC Dragoon", 200000, 5, 5, 2, -3, 70);

            return IECFullBody;
        }
    }
}
