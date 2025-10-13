using System.Threading.Channels;

namespace ControlPoint2
{
    static class GameSettings
    {
        public static int MaxLevel { get; set; } = 100;

        public static bool IsLevelValid(int level)
        {
            return level > 0 && level <= MaxLevel;
        }
    }
}