using System.Collections.Generic;

namespace Logic
{
    public static class MocksGenerator
    {
        public static List<string> getFakeArtists()
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

        public static Dictionary<string, int> getFakeFriends()
        {
            return new Dictionary<string, int>()
                       {
                           { "Daniel", 1 },
                           { "Omer", 2 },
                           { "Noam", 100 },
                           { "Eden", 77 },
                           { "Yuval", 1502 }
                       };
        }

        public static List<string> getFakeEvents()
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

        public static string getFakePost(ref int io_MaxLikedPost, ref string io_FriendName)
        {
            io_MaxLikedPost = 712;
            io_FriendName = "Daniel";

            return "Design Patterns are cool";
        }

        public static List<string> getFakeBirthdays()
        {
            return new List<string>
                       {
                           "Daniel - 6/9/95",
                           "Omer - 16/6/96",
                           "Eden - 10/3/96",
                           "Noam - 10/3/96",
                           "Yuval - 29/3/95"
                       };
        }
    }
}