using System.Collections.Generic;

namespace Logic
{
    public static class MocksGenerator
    {
        public static List<string> GetFakeArtists()
        {
            return new List<string>
                     {
                         "Cat Stevens",
                         "Cheetah Girls",
                         "Cat Power",
                         "One Day As A Lion",
                         "Def Leopard",
                         "Stray Cats",
                         "Lady Gaga",
                         "Nirvana",
                         "Radiohead",
                         "Pink Floyd",
                     };
        }

        public static Dictionary<string, int> GetFakeFriends()
        {
            return new Dictionary<string, int>()
                       {
                           { "Daniel Dolev", 1 },
                           { "Omer Gery", 2 },
                           { "Noam Bracha", 100 },
                           { "Eden Shalev", 77 },
                           { "Yuval Houri", 152 },
                           { "Ido Rot", 1216 }
                       };
        }

        public static List<string> GetFakeEvents()
        {
            return new List<string>
                       {
                           "Fetival - 7",
                           "Pool Party - 124",
                           "X Day Music - 1367",
                           "Local Concert - 135",
                           "Football match - 13524",
                           "BBQ in the park - 12",
                           "Proteset - 75"
                       };
        }

        public static string GetFakePost(out int o_MaxLikedPost, out string o_FriendName)
        {
            o_MaxLikedPost = 712;
            o_FriendName = "Daniel Dolev";
            return "Design Patterns are cool";
        }

        public static List<string> GetFakeBirthdays()
        {
            return new List<string>
                       {
                           "Daniel Dolev - 6/9/95",
                           "Omer Gery - 16/6/96",
                           "Eden Shalev - 10/3/96",
                           "Noam Bracha - 10/3/96",
                           "Yuval Houri - 29/3/95",
                           "Ido Rot - 6/8/97"
                       };
        }
    }
}