using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.Enums
{
    public enum HotPotNameEnum
    {
        Kimuchi,
        Sukiyaki,
        Mizutaki
    }

    public static class EnumExtend
    {
        public static string GetJapaneseName(this HotPotNameEnum param)
        {
            switch (param)
            {
                case HotPotNameEnum.Kimuchi:
                    return "キムチ";
                case HotPotNameEnum.Sukiyaki:
                    return "すき焼き";
                case HotPotNameEnum.Mizutaki:
                    return "水炊き";
                default:
                    return "";
            }
        }

        public static Factory GetFactory (this HotPotNameEnum param)
        {
            return new MizutakiFactory();
        }
    }
}
