using BTECanada.Models;

namespace BTECanada.Data
{
    public class SampleData
    {
        public static List<BuilderResourcesCategory> categories = new()
        {
            new()
            {
                Id = 1,
                Name = "Mods",
                BuilderResources = new()
                {
                    new()
                    {
                        Id = 1,
                        Title = "Optifine",
                        Content = "https://optifine.net/adloadx?f=OptiFine_1.12.2_HD_U_G5.jar&x=0ff3\r\nClassic mod that makes things look better and perform faster. IMPORTANT: you must download this version (G5). The version with F5 is incompatible with BTE mods."
                    },
                    new()
                    {
                        Id = 2,
                        Title = "Schematica",
                        Content = "https://www.curseforge.com/minecraft/mc-mods/schematica REQUIRES THIS MOD TOO: https://www.curseforge.com/minecraft/mc-mods/lunatriuscore/download\r\nMod that lets you save and load schematics from your pc onto the server. Confused? Here's a tutorial: https://www.youtube.com/watch?v=kqZMGM_orN4"
                    }
                }
            },
            new()
            {
                Id = 2,
                Name = "World Edit",
                BuilderResources = new()
                {
                    new()
                    {
                        Id = 3,
                        Title = "Line",
                        Content = "Lines are helpful"
                    }
                }
            }
        };
    }
}
